using System;
using System.Collections.Generic;

namespace Bank_Account
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Account acc = new Account("43783457", "NGUYEN VAN TEO", 10000);
            
            Console.WriteLine(acc);
            
        }

        class Account
        {
            private string Id;
            private string Name;
            private int so_tien;

            public Account()
            {
                Id = "";
                Name = "";
                so_tien = 0;
            }

            public Account(string id, string name, int so_tien)
            {
                Id = id;
                Name = name;
                this.so_tien = so_tien;
            }


        }

        public string Id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int so_tien
        {
            get { return so_tien; }
            set
            {
                //if (so_tien >= 0)

                so_tien = value >= 0 ? value : so_tien;
            }
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name + ", so-tien: " + so_tien;

        }

    }

}
