using System;
using System.Diagnostics;

namespace Do_an_OOP
{
    public class Employee
    {
        protected string id;
        protected string fullname;
        protected DateTime birthday;
        protected string phone;
        protected string email;
        protected byte employee_type;
        protected int employee_count;

        public string Id { get { return id; } set { id = value; } }

        public byte Employee_type { get { return employee_type; } set { employee_type = value; } }

        public Employee()
        {

        }

        public Employee(string id, string fullname, DateTime birthday, string phone, string email, byte employee_type)
        {
            this.id = id;
            this.fullname = fullname;
            this.birthday = birthday;
            this.phone = phone;
            this.email = email;
            this.employee_type = employee_type;
        }

        public override string ToString()
        {
            return GetType().ToString().Remove(0,10) + $"\tId: {id}, Fullname: {fullname}, Birthday: {birthday.ToShortDateString()}, Phone: {phone}, Email: {email}";
        }

    }
}