namespace API_TEST
{
    class User
    {
        public int id;
        public string name;
        public string username;
        public string email;
        public Address adress;
        public string phone;
        public string website;
        public Company company;

        // A read-write 'Company' property
        public Company COMPANY
        {
            get { return company; }
            set { company = value; }
        }

        // A read-write 'WEB site' property
        public string WEBSITE
        {
            get { return website; }
            set { website = value; }
        }

        // A read-write 'Phone' property
        public string PHONE
        {
            get { return phone; }
            set { phone = value; }
        }

        // A read-write 'Address' property
        public Address ADDRESS
        {
            get { return adress; }
            set { adress = value; }
        }

        // A read-write 'Email' property
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        // A read-write 'Username' property
        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }

        // A read-write 'Name' property
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        // A read-write 'ID' property
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
