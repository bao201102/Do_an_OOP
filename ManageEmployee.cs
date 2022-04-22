using System;
using System.Collections.Generic;

namespace Do_an_OOP
{
    public class ManageEmployee
    {
        private Database db;

        public ManageEmployee()
        {
            db = new Database();
        }

        public Employee FindById(string id)
        {
            Employee emp = new Employee();
            foreach (Employee item in db.Data)
            {
                if (item.Id.Equals(id))
                {
                    emp = item;
                }
            }
            return emp;
        }

        public List<Employee> FindByType(byte type)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
            {
                if (item.Employee_type == type)
                {
                    listEmp.Add(item);
                }
            }
            return listEmp;
        }

        public List<Employee> FindByExp(int yearOfExp)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
            {
                if (item as Experience != null)
                {
                    Experience tempEmp = (Experience)item;
                    if (tempEmp.YearOfExp == yearOfExp)
                    {
                        listEmp.Add(item);
                    }
                }
            }
            return listEmp;
        }

        public List<Employee> FindBySkills(string proSkill)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
            {
                if (item as Experience != null)
                {
                    Experience tempEmp = (Experience)item;
                    if (tempEmp.ProSkills.Contains(proSkill))
                    {
                        listEmp.Add(item);
                    }
                }
            }
            return listEmp;
        }

        public List<Employee> FindByGraRank(byte graRank)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
            {
                if (item as Fresher != null)
                {
                    Fresher tempEmp = (Fresher)item;
                    if (tempEmp.GraRank == graRank)
                    {
                        listEmp.Add(item);
                    }
                }
            }
            return listEmp;
        }

        public List<Employee> FindByMajor(string major)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
            {
                if (item as Intern != null)
                {
                    Intern tempEmp = (Intern)item;
                    if (tempEmp.Majors == major)
                    {
                        listEmp.Add(item);
                    }
                }
            }
            return listEmp;
        }

        public void ShowEmpSalary()
        {
            foreach (Employee item in db.Data)
            {
                Console.WriteLine(item.ShowSalary());
            }
        }

        public void Add(Employee emp)
        {
            db.Add(emp);
        }

        public void Delete(string id)
        {
            db.Delete(id);
        }

        public void ShowAllEmp()
        {
            foreach (Employee item in db.Data)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowEmp(List<Employee> listemp)
        {
            if (listemp.Count < 1)
            {
                Console.WriteLine("Không tìm thấy nhân viên thỏa yêu cầu");
            }
            else
            {
                foreach (Employee item in listemp)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public bool QueryForLogin(string username, string password)
        {
            return db.QueryForLogin(username, password);
        }
    }
}