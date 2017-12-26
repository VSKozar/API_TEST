namespace API_TEST
{
    class Address
    {
        public string street;
        public string suite;
        public string city;
        public string zipcode;
        public Geo geo;

        // A read-write 'geolocation' property
        public Geo GEO
        {
            get { return geo; }
            set { geo = value; }
        }

        // A read-write 'ZIP code' property
        public string ZIPCODE
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        // A read-write 'City' property
        public string CITY
        {
            get { return city; }
            set { city = value; }
        }

        // A read-write 'Suite' property
        public string SUITE
        {
            get { return suite; }
            set { suite = value; }
        }

        // A read-write 'Street' property
        public string STREET
        {
            get { return street; }
            set { street = value; }
        }
    }
}
