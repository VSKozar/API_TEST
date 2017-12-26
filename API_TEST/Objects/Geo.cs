namespace API_TEST
{
    class Geo
    {
        public float lat;
        public float lng;

        // A read-write 'Longitude' property
        public float LNG
        {
            get { return lng; }
            set { lng = value; }
        }

        // A read-write 'Latitude' property
        public float LAT
        {
            get { return lat; }
            set { lat = value; }
        }
    }
}
