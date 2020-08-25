using System;
using System.Collections.Generic;
using System.Text;

namespace Console_app4
{
    class Student: Person
    {
        private string student_id;

        public Student(string student_id, string name, string email):base(name, email)
        {
            this.student_id = student_id;
        }

        public Student()
        {
            student_id = "";
        }

        public string Student_id
        {
            get { return student_id; }
            set { student_id = value; }
        }

        public override string ToString()
        {
            return "Studen ID: " +student_id+",Name: "+Name+",Email: "+Email;
        }
    }
}
