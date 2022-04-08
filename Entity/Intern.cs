using System;
using System.Collections.Generic;

namespace Do_an_OOP
{
    public class Intern : Employee
    {
        private string majors;
        private int semester;
        private string university;
        public string Majors { get { return majors; } set { majors = value; } }
        public int Semester { get { return semester; } set { semester = value; } }
        public string University { get { return university; } set { university = value; } }

        public Intern(string id, string fullname, DateTime birthday, string phone, string email, byte employee_type, string majors, int semester, string university)
        {
            base.id = id;
            base.fullname = fullname;
            base.birthday = birthday;
            base.phone = phone;
            base.email = email;
            base.employee_type = employee_type;
            this.majors = majors;
            this.semester = semester;
            this.university = university;
        }
        public override string ToString()
        {
            return base.ToString().Insert(7, "\t") + $", Majors: {majors}, Semester: {semester}, University: {university}";
        }
    }
}