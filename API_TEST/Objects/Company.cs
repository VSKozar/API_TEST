namespace API_TEST
{
    class Company
    {
        public string name;
        public string catchPrase;
        public string bs;

        // A read-write 'business description' property
        public string BS
        {
            get { return bs; }
            set { bs = value; }
        }

        // A read-write 'catchphrase' property
        public string CatchPrase
        {
            get { return catchPrase; }
            set { catchPrase = value; }
        }

        // A read-write 'company name' property
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
    }
}
