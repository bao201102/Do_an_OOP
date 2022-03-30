using System;
using System.Collections.Generic;
namespace Do_an_OOP
{
    public class Database
    {
        private List<Employee> data;

        public List<Employee> Data { get { return data; } set { data = value; } }

        public Database()
        {
            data = new List<Employee>();
            data.Add(new Experience("01", "A", new DateTime(2002, 5, 18), "09xxx", "@", 0, 5, "C#"));
            data.Add(new Experience("02", "B", new DateTime(2002, 5, 18), "09xxx", "@", 0, 5, "C#"));
            data.Add(new Intern("03", "B", new DateTime(2002, 5, 18), "09xxx", "@", 1, "gioi", 4, "UEH"));
            data.Add(new Fresher("02", "B", new DateTime(2002, 5, 18), "09xxx", "@",2,new DateTime(2022,5,23),4,"UEH"));
        }

        public void Add(Employee emp)
        {
            foreach (Employee item in data)
            {
                if (item.Id.ToLower().Contains(emp.Id.ToLower()))
                {
                    Console.WriteLine("ID này đã tồn tại trong dữ liệu!");
                    return;
                }
            }
            data.Add(emp);
        }
    }
}