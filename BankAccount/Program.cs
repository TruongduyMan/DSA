using System;
using System.Collections.Generic;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("3657356728", "NGUYEN VAN TEO", 43246);
            Console.WriteLine(acc);
           
        }
       
    }

    class Account
    {
        private string id;
        private string name;
        private int so_tien;

        public Account()
        {
            id = Name = "";
            so_tien = 0;
        }

        public Account(string id, string name, int so_tien)
        {
            ID = id;
            Name = name;
            this.so_tien = so_tien;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int So_tien
        {
            get { return so_tien; }
            set
            {
                so_tien = value > 0 ? value : so_tien;
            }
        }

        public override string ToString()
        {
            return "Id: " + id + ", Name: " + Name + ",So tien: " + so_tien;
        }

    }
}
