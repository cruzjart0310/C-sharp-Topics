using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.Reflection
{
    public class CsvGenerator<T>
    {
        private readonly IEnumerable<T> _data;
        private readonly string _filaName;
        private readonly Type _type;

        public CsvGenerator(IEnumerable<T> data, string fileName)
        {
            _data = data;
            _filaName = fileName;
            _type = typeof(T);  
        }

        public void Generate()
        {
            var rows = new List<string>();

            rows.Add(CreateHeader());
            foreach (var item in _data)
                rows.Add(CreateRow(item));

            File.WriteAllLines($"{_filaName}.csv", rows, Encoding.UTF8);  
        }

        public string CreateHeader()
        {
            var propierties = _type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            var stb = new StringBuilder();

            foreach(var prop in propierties)
            {
                stb.Append(prop.Name).Append(",");
            }
            return stb.ToString();
        }

        private string CreateRow(T item)
        {
            var propierties = _type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            var stb = new StringBuilder();

            foreach (var prop in propierties) {
                stb.Append(CreateItem((dynamic)(prop.GetValue(item)))).Append(",");
            }

            return stb.ToString();
        }

        private string CreateItem(object item) => item.ToString();
        private string CreateItem(DateTime item) => item.ToShortDateString();    
    }
}
