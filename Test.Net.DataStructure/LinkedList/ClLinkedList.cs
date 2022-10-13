using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.DataStructure.LinkedList
{
    public class ClLinkedList
    {
        private ClNode header;

        private ClNode job;

        private ClNode job2;

        public ClLinkedList()
        {
            header = new ClNode();
            header.Next = null;
        }

        //transverse the complete list
        public void Tranverse()
        {
            //start
            job = header;

            //run to get the eend
            while (job.Next != null)
            {
                //move job
                job = job.Next;

                //get data and show
                int value = job.Data;

                Console.Write($"{value} ");
            }

            Console.WriteLine();
        }

        public void add(int pData)
        {
            job = header;

            while (job.Next != null)
            {
                job = job.Next;
            }

            //new node
            ClNode temp = new ClNode();

            //insert node
            temp.Data = pData;

            //end
            temp.Next = null;

            //link the last node found whit the recently create
            job.Next = temp;
        }

        public void CleanList()
        {
            header.Next = null;
        }

        public bool IsEmpty()
        {
            return header.Next == null;
        }

        public ClNode Search(int pData)
        {
            if (IsEmpty())
                return null;

            job2 = header;

            while (job2.Next != null)
            {
                job2 = job2.Next;

                if (job2.Data == pData)
                    return job2;
            }
            return null;
        }


        public int SearchIndex(int pData)
        {
            int n = -1;

            job = header;

            while (job.Next != null)
            {
                job = job.Next;
                n++;

                if (job.Data == pData)
                    return n;
            }
            return -1;
        }

        public ClNode SearchPrevious(int pData)
        {
            job2 = header;

            while (job2.Next != null && job2.Next.Data != pData)
            {
               job2 = job2.Next;
            }
            return job2;
        }

        public void Delete(int pDato)
        {
            if (IsEmpty())
                return;

            var previous = SearchPrevious(pDato);
            var search = Search(pDato);

            if (search == null)
                return;

            previous.Next = search.Next;
            search.Next = null;
        }

        public void Insert(int where, int value )
        {
            if (where == 0)
            {
                ClNode temp1 = new ClNode();
                temp1.Data = value;

                temp1.Next = header.Next;
                header.Next = temp1;

                return;
            }
           
            job = Search(where);
            if (job == null)
                return;

            ClNode temp = new ClNode();
            temp.Data = value;

            temp.Next = job.Next;
            job.Next = temp;
        }
    }
}
