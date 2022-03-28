using System;
using System.Diagnostics;
namespace Do_an_OOP
{
    public class Employee
    {
        protected string id;
        protected string fullname;
        protected string birthday;
        protected string phone;
        protected string email;
        protected byte employee_type;
        protected int employee_count;

        public Employee()
        {

        }
        public Employee(string id, string fullname, string birthday, string phone, string email, byte employee_type)
        {
            this.id = id;
            this.fullname = fullname;
            this.birthday = birthday;
            this.phone = phone;
            this.email = email;
            this.employee_type = employee_type;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public byte Employee_type
        {
            get { return employee_type; }
            set { employee_type = value; }
        }
        public virtual string showInfo()
        {
            return $"Id: {id}, Fullname: {fullname}, Birthday: {birthday}, Phone: {phone}, Email: {email}";
        }
    }
}