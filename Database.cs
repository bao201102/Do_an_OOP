using System;
using System.Collections.Generic;
namespace Do_an_OOP
{
    public class Database
    {
        private List<Employee> data;
        private Dictionary<string, string> admin;

        public List<Employee> Data { get { return data; } set { data = value; } }

        public Database()
        {
            data = new List<Employee>();
            admin = new Dictionary<string, string>();
            data.Add(new Experience("01", "A", new DateTime(2002, 5, 18), "09xxx", "@", 0, 5, "C#"));
            data.Add(new Experience("02", "B", new DateTime(2002, 5, 18), "09xxx", "@", 0, 5, "C#"));
            data.Add(new Intern("03", "B", new DateTime(2002, 5, 18), "09xxx", "@", 1, "IT", 4, "UEH"));
            data.Add(new Fresher("04", "B", new DateTime(2002, 5, 18), "09xxx", "@", 2, new DateTime(2022, 5, 23), 3, "UEH"));
            admin.Add("admin", "123");
            admin.Add("user1", "123");
            admin.Add("user2", "456");
        }

        public bool QueryForLogin(string username, string password)
        {
            foreach (KeyValuePair<string, string> entry in admin)
            {
                if (username.Equals((string)entry.Key) && password.Equals((string)entry.Value))
                {
                    return true;
                }
            }
            return false;
        }

        public void Add(Employee emp)
        {
            foreach (Employee item in data)
            {
                if (item.Id.Equals(emp.Id))
                {
                    Console.WriteLine("ID này đã tồn tại trong dữ liệu!");
                    return;
                }
            }
            data.Add(emp);
        }

        public void Delete(string id)
        {
            foreach (Employee item in data)
            {
                if (item.Id.Equals(id))
                {
                    data.Remove(item);
                    return;
                }
            }
            Console.WriteLine("ID này không tồn tại trong dữ liệu!");
        }
    }
}