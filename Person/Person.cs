using System;
using System.Collections.Generic;
using System.Text;

namespace Console_app4
{
    class Person
    {
        
        private string name;
        private string email;
        public Person()
        {
            email = name = "";
        }

        public Person(string email, string name)
        {
            this.email = email;
            this.name = name;
        }

        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

}
