using System;
using System.Collections.Generic;
namespace Do_an_OOP
{
    public class Database
    {
        private List<Employee> data = new List<Employee>();

        public List<Employee> Data { get { return data; } set { data = value; } }

        public Database()
        {
            data.Add(new Experience("01", "A", new DateTime(2002, 5, 18), "09xxx", "@", 0, 5, "C#"));
            data.Add(new Experience("02", "B", new DateTime(2002, 5, 18), "09xxx", "@", 0, 5, "C#"));
            data.Add(new Intern("03", "B", new DateTime(2002, 5, 18), "09xxx", "@", 1, "gioi", 4, "UEH"));
        }
    }
}