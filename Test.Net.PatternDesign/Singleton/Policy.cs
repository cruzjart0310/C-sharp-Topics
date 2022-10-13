namespace Test.Net.PatternDesign.Singleton
{
    public class Policy
    {
        private static Policy _instance;

        public Policy()
        {

        }

        public static Policy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Policy();
                }

                return _instance;
            }
        }
    }
}
