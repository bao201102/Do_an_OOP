using System;

namespace Do_an_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello World!");
            
            ManageEmployee manageEmployee = new ManageEmployee();
            Database db= new Database();
            foreach (var item in db.Data)
            {
                manageEmployee.Add(item);
            }
            manageEmployee.findbyExp(5);
            
        }
    }
}
