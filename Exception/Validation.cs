using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_OOP
{
    public class Validation
    {
        public static void CheckNoneId(string id)
        {
            Database db = new Database();
            foreach (Employee item in db.Data)
            {
                if (item.Id.Equals(id))
                {
                    return;
                }
            }
            Exception e = new NoneIdException();
            throw e;
        }

        public static void CheckId(string id)
        {
            Database db = new Database();
            foreach (Employee item in db.Data)
            {
                if (item.Id.Equals(id))
                {
                    Exception e = new IdException();
                    throw e;
                }
            }
        }

        public static void CheckEmail(string email)
        {
            if (!email.Contains('@'))
            {
                Exception e = new EmailException();
                throw e;
            }
        }
        public static void CheckEmpType(byte s)
        {
            if (s < 0 || s > 2)
            {
                Exception e = new EmployeeTypeException();
                throw e;
            }
        }
        public static void CheckGraRank(byte s)
        {
            if (s < 0 || s > 3)
            {
                Exception e = new GraduateRankException();
                throw e;
            }
        }
        public static void CheckPhone(string s)
        {
            if (s.Length > 10)
            {
                Exception e = new NumberPhoneException();
                throw e;
            }
        }

        public static byte InputGraRank()
        {
            try
            {
                byte graRank;
                bool result = byte.TryParse(Console.ReadLine(), out graRank);
                if (!result)
                {
                    Console.WriteLine("Yêu cầu nhập số");
                    Console.Write(">>: ");
                    InputGraRank();
                }
                CheckGraRank(graRank);
                return graRank;
            }
            catch (GraduateRankException e)
            {
                Console.WriteLine(e.Message);
                Console.Write(">>: ");
                return InputGraRank();
            }
        }
        public static string InputPhone()
        {
            try
            {
                string phone = Console.ReadLine();
                CheckPhone(phone);
                return phone;
            }
            catch (NumberPhoneException e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Nhập số điện thoại: ");
                return InputPhone();
            }

        }
        public static string InputEmail()
        {
            try
            {
                string email = Console.ReadLine();
                CheckEmail(email);
                return email;
            }
            catch (EmailException e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Nhập email: ");
                return InputEmail();
            }
        }
        public static byte InputEmpType()
        {
            try
            {
                byte employee_type;
                bool result = byte.TryParse(Console.ReadLine(), out employee_type);
                if (!result)
                {
                    Console.WriteLine("Yêu cầu nhập số");
                    Console.Write(">>: ");
                    InputEmpType();
                }
                CheckEmpType(employee_type);
                return employee_type;
            }
            catch (EmployeeTypeException e)
            {
                Console.WriteLine(e.Message);
                Console.Write(">>: ");
                return InputEmpType();
            }
        }

        public static string InputId()
        {
            try
            {
                string id = Console.ReadLine();
                CheckId(id);
                return id;
            }
            catch (IdException e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Nhập id: ");
                return InputId();
            }
        }

        public static string InputNoneId()
        {
            try
            {
                string id = Console.ReadLine();
                CheckNoneId(id);
                return id;
            }
            catch (NoneIdException e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Nhập id: ");
                return InputNoneId();
            }
        }
    }
}
