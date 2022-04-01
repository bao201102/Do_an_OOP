using System;
using System.Text;

namespace Do_an_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Console.SetWindowSize(180, 40);
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Database db = new Database();
            string username = "admin1";
            string password = "123";
            if (db.query4Login(username, password))
            {
                System.Console.WriteLine("Đăng nhập thành công");
                ManageEmployee manageEmployee = new ManageEmployee();
                // manageEmployee.ShowAllEmp();
                manageEmployee.ShowEmpSalary(manageEmployee.FindByType(2));
                manageEmployee.ShowEmpSalary(manageEmployee.FindByType(0));
                manageEmployee.ShowEmpSalary(manageEmployee.FindByType(1));
            }
            else
            {
                System.Console.WriteLine("Đăng nhập không thành công");
            }
        }
    }
}
