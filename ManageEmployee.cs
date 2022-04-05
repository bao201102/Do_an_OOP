using System;
using System.Collections.Generic;

namespace Do_an_OOP
{
    public class ManageEmployee
    {
        Database db = new Database();

        public ManageEmployee()
        {

        }

        // public void Add(int empType)
        // {
        //     this.InputInfoBasic();
        //     if(empType == 0) {
        //         System.Console.WriteLine("Nhập vào năm kinh nghiệm: ");
        //         int yearOfExp = int.Parse(Console.ReadLine());
        //     }else if(empType == 1) {
        //         System.Console.WriteLine("Nhập vào chuyên ngành: ");
        //         string majors = Console.ReadLine();
        //         System.Console.WriteLine("Nhập vào học kì: ");
        //         string semester = Console.ReadLine();

        //     }
        // }
        public void Add(Employee e) {
            db.Add(e);
        }
        public void ShowAllEmp()
        {
            foreach (Employee item in db.Data)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowEmpInfo(List<Employee> listEmp)
        {
            foreach (Employee item in listEmp)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowEmpSalary(List<Employee> listEmp)
        {
            foreach (Employee item in listEmp)
            {
                Console.WriteLine(item.ShowSalary());
            }
        }
        public List<Employee> FindId(string id)
        {
            List<Employee> listEmp = new List<Employee>();
            foreach (Employee item in db.Data)
            {
                if (item.Id.Contains(id))
                {
                    listEmp.Add(item);
                }
            }
            return listEmp;
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
        public void MajorsSearch(string majors, List<Intern> list)
        {
            foreach (Intern i in list)
            {
                if (i.Majors == majors)
                {
                    System.Console.WriteLine("Chuyên ngành: {0} Học kỳ: {1} Trường: {2}", i.Majors, i.Semester, i.University);
                    break;
                }
            }
        }
        public void Edit() {
            System.Console.Write("Nhập vào id của nhân viên cần chỉnh sửa: ");
            string id = Console.ReadLine();
            Database db = new Database();
            foreach(Employee item in db.Data) {
                if(item as Experience != null) {
                    Experience tempEmp = (Experience)item;
                    if (tempEmp.Id == id)
                    {
                        System.Console.WriteLine("Thông tin nhân viên hiện tại: " + tempEmp);
                        System.Console.WriteLine("Bạn muốn chỉnh sửa:");
                        System.Console.WriteLine("1. Họ tên");
                        System.Console.WriteLine("2. Ngày sinh");
                        System.Console.WriteLine("3. Số điện thoại");
                        System.Console.WriteLine("4. Email");
                        System.Console.WriteLine("5. Loại nhân viên");
                        System.Console.WriteLine("6. Năm kinh nghiệm");
                        System.Console.WriteLine("7. Kỹ năng chuyên môn");
                        System.Console.Write("Nhập lựa chọn của bạn: ");
                        int chooseNumber = int.Parse(Console.ReadLine());
                        System.Console.WriteLine();
                        switch(chooseNumber) {
                            case 1: 
                                System.Console.WriteLine("Nhập vào họ tên mới: ");
                                string fullname = Console.ReadLine();
                                tempEmp.Fullname = fullname;
                                break;
                            case 2: 
                                System.Console.WriteLine("Nhập vào ngày sinh mới: ");
                                DateTime birthday = DateTime.Parse(Console.ReadLine());
                                tempEmp.Birthday = birthday;
                                break;
                            case 3: 
                                System.Console.WriteLine("Nhập vào số điện thoại mới: ");
                                string phone = Console.ReadLine();
                                tempEmp.Phone = phone;
                                break;
                            case 4: 
                                System.Console.WriteLine("Nhập vào email mới: ");
                                string email = Console.ReadLine();
                                tempEmp.Email = email;
                                break;
                            case 5: 
                                System.Console.WriteLine("Nhập vào loại nhân viên mới: ");
                                byte employee_type = byte.Parse(Console.ReadLine());
                                tempEmp.Employee_type = employee_type;
                                break;
                            case 6: 
                                System.Console.WriteLine("Nhập vào năm kinh nghiệm mới: ");
                                int yearOfExp = int.Parse(Console.ReadLine());
                                tempEmp.YearOfExp = yearOfExp;
                                break;
                            default:
                                break;
                        }
                        System.Console.WriteLine("Sau khi nhập, thông tin nhân viên mới là: " + tempEmp);
                    }else {
                        System.Console.WriteLine("Người dùng không tồn tại trong hệ thống. Vui lòng thử lại");
                    }
                }
            }
        }
        
    }
}