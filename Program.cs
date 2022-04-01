using System;
using System.Text;

namespace Do_an_OOP
{
    class Program
    {
        static void Add(string email)
        {
            if (!email.Contains('@')) 
            {
                Exception e = new EmailException();
                throw e;
            }
            else System.Console.WriteLine("Email hợp lệ");
        }
        static void Main(string[] args)
        {
            Console.Clear();
<<<<<<< HEAD
            /*Console.SetWindowSize(180, 40);
=======
            // Console.SetWindowSize(180, 40);
>>>>>>> 5bac65e5c0e056f18a39867570bb5cf11bed4a69
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
            }*/
            string email = "abcadada";
            try
            {
                Add(email);
            }
<<<<<<< HEAD
            catch (EmailException e)
            {
                System.Console.WriteLine(e.Message);
            }
    } }
=======
        }
    }
>>>>>>> 5bac65e5c0e056f18a39867570bb5cf11bed4a69
}
