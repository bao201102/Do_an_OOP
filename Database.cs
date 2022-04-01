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
<<<<<<< HEAD
            data.Add(new Experience("02", "B", new DateTime(2002, 5, 18), "09xxx", "@", 0, 5, "C#"));
            data.Add(new Intern("03", "B", new DateTime(2002, 5, 18), "09xxx", "@", 1, "IT", 4, "UEH"));
            data.Add(new Fresher("04", "B", new DateTime(2002, 5, 18), "09xxx", "@", 2, new DateTime(2022, 5, 23), 3, "UEH"));
=======
            data.Add(new Experience("02", "B", new DateTime(2002, 11, 20), "09xxx", "@", 0, 6, ".Net"));
            data.Add(new Intern("03", "B", new DateTime(2002, 5, 18), "09xxx", "@", 2, "IT", 4, "UEH"));
            data.Add(new Fresher("04", "B", new DateTime(2002, 5, 18), "09xxx", "@", 1, new DateTime(2022, 5, 23), 3, "UEH"));

            account.Add("admin1", "123");
            account.Add("admin2", "456");
            account.Add("admin3", "789");
>>>>>>> 5bac65e5c0e056f18a39867570bb5cf11bed4a69
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
<<<<<<< HEAD
=======
        public bool query4Login(string username, string password)
        {
            foreach (KeyValuePair<string, string> entry in account)
            {
                if (username.Equals((string)entry.Key) && password.Equals((string)entry.Value))
                {
                    return true;
                }
            }
            return false;
        }
>>>>>>> 5bac65e5c0e056f18a39867570bb5cf11bed4a69
    }
}