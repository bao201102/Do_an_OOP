
using System;
using System.Collections.Generic;
namespace Do_an_OOP
{
    public class Experience : Employee, IEmployee

    {
        private int yearOfExp;
        private string proSkills;

        public int YearOfExp { get { return yearOfExp; } set { yearOfExp = value; } }
        public string ProSkills { get { return proSkills; } set { proSkills = value; } }


        public Experience()
        {

        }

        public Experience(string id, string fullname, DateTime birthday, string phone, string email, byte employee_type, int yearOfExp, string proSkills)
        {
            base.id = id;
            this.fullname = fullname;
            this.birthday = birthday;
            this.phone = phone;
            this.email = email;
            this.employee_type = employee_type;
            this.yearOfExp = yearOfExp;
            this.proSkills = proSkills;
        }

        public override string ToString()
        {
            return base.ToString() + $", Year of experience: {yearOfExp}, Pro skills: {proSkills}";
        }

        public double CalcSalary()
        {
            return 15000000 + yearOfExp * 100000;
        }

        public override string ShowSalary()
        {
            return GetType().ToString().Remove(0, 10) + $"\tId: {id}, Fullname: {fullname}, Year of experience: {yearOfExp}, Salary: {String.Format("{0:0,0 vnđ}", CalcSalary())}";
        }
    }
}