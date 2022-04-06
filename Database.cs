using System;
using System.Collections.Generic;
namespace Do_an_OOP
{
    public class Database
    {
        private List<Employee> data;
        private Dictionary<string, string> adminAccounts = new Dictionary<string, string>();

        public List<Employee> Data { get { return data; } set { data = value; } }

        public Database()
        {
            data = new List<Employee>();
            data.Add(new Experience("01", "A", new DateTime(2002, 5, 18), "09xxx", "@", 0, 5, "C#"));
            data.Add(new Experience("02", "B", new DateTime(2002, 5, 18), "09xxx", "@", 0, 5, "C#"));
            data.Add(new Intern("03", "B", new DateTime(2002, 5, 18), "09xxx", "@", 1, "IT", 4, "UEH"));
            data.Add(new Fresher("04", "B", new DateTime(2002, 5, 18), "09xxx", "@", 2, new DateTime(2022, 5, 23), 3, "UEH"));
            adminAccounts.Add("admin", "123");
            adminAccounts.Add("user1", "123");
            adminAccounts.Add("user2", "456");
        }

        public bool query4Login(string username, string password) {
            foreach(KeyValuePair<string, string> entry in adminAccounts) {
                if(username.Equals((string)entry.Key) && password.Equals((string)entry.Value)) {
                    return true;
                }
            }
            return false;
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
        public void Remove(string id) {
            System.Console.WriteLine("Xóa thành công");
            data.RemoveAll(item => item.Id.Contains(id));
        }

        public void Edit(string id) {
            int count = 0;
            foreach(Employee item in Data) {
                if(item as Experience != null) {
                    Experience tempEmp = (Experience)item;
                    if (tempEmp.Id == id)
                    {
                        count++;
                        System.Console.WriteLine("Thông tin nhân viên hiện tại: " + tempEmp);
                        this.EditInfoBasic();
                        System.Console.WriteLine("6. Năm kinh nghiệm");
                        System.Console.WriteLine("7. Kỹ năng chuyên môn");
                        System.Console.Write("Nhập lựa chọn của bạn: ");
                        int chooseNumber = int.Parse(Console.ReadLine());
                        System.Console.WriteLine();
                        this.ChooseInfo(chooseNumber, tempEmp);
                        switch(chooseNumber) {
                            case 6: 
                                System.Console.Write("Nhập vào năm kinh nghiệm mới: ");
                                int yearOfExp = int.Parse(Console.ReadLine());
                                tempEmp.YearOfExp = yearOfExp;
                                break;
                            case 7:
                                System.Console.Write("Nhập vào kĩ năng chuyên môn mới: ");
                                string proSkills = Console.ReadLine();
                                tempEmp.ProSkills = proSkills;
                                break;
                            default:
                                break;
                        }
                        System.Console.WriteLine("Cập nhật thành công");
                        System.Console.WriteLine("Sau khi cập nhật, thông tin nhân viên mới là: " + tempEmp);
                    }
                }else if(item as Intern != null) {
                    Intern tempEmp = (Intern)item;
                    if (tempEmp.Id == id)
                    {
                        count++;
                        System.Console.WriteLine("Thông tin nhân viên hiện tại: " + tempEmp);
                        this.EditInfoBasic();
                        System.Console.WriteLine("6. Chuyên ngành");
                        System.Console.WriteLine("7. Học kỳ");
                        System.Console.WriteLine("8. Trường đại học");
                        System.Console.Write("Nhập lựa chọn của bạn: ");
                        int chooseNumber = int.Parse(Console.ReadLine());
                        System.Console.WriteLine();
                        this.ChooseInfo(chooseNumber, tempEmp);
                        switch(chooseNumber) {
                            case 6: 
                                System.Console.Write("Nhập vào chuyên ngành mới: ");
                                string majors = Console.ReadLine();
                                tempEmp.Majors = majors;
                                break;
                            case 7:
                                System.Console.Write("Nhập vào học kì mới: ");
                                int semester = int.Parse(Console.ReadLine());
                                tempEmp.Semester = semester;
                                break;
                            case 8:
                                System.Console.Write("Nhập vào trường đại học mới: ");
                                string university = Console.ReadLine();
                                tempEmp.University = university;
                                break;
                            default:
                                break;
                        }
                    }
                }else if(item as Fresher != null) {
                    Fresher tempEmp = (Fresher)item;
                    if (tempEmp.Id == id)
                    {
                        count++;
                        System.Console.WriteLine("Thông tin nhân viên hiện tại: " + tempEmp);
                        this.EditInfoBasic();
                        System.Console.WriteLine("6. Thời gian tốt nghiệp");
                        System.Console.WriteLine("7. Hạng tốt nghiệp");
                        System.Console.WriteLine("8. Trường tốt nghiệp");
                        System.Console.Write("Nhập lựa chọn của bạn: ");
                        int chooseNumber = int.Parse(Console.ReadLine());
                        System.Console.WriteLine();
                        this.ChooseInfo(chooseNumber, tempEmp);
                        switch(chooseNumber) {
                            case 6: 
                                System.Console.Write("Nhập vào ngày tốt nghiệp mới");
                                int dayGra = int.Parse(Console.ReadLine());
                                System.Console.Write("Nhập vào tháng tốt nghiệp mới: ");
                                int monthGra = int.Parse(Console.ReadLine());
                                System.Console.Write("Nhập vào năm tốt nghiệp mới: ");
                                int yearGra = int.Parse(Console.ReadLine());
                                tempEmp.GraDate = new DateTime(yearGra, monthGra, dayGra);
                                break;
                            case 7:
                                System.Console.Write("Nhập hạng tốt nghiệp mới: ");
                                byte graRank = byte.Parse(Console.ReadLine());
                                tempEmp.GraRank = graRank;
                                switch (graRank)
                                {
                                    case 0:
                                        tempEmp.GraRankName = "Trung Bình";
                                        break;
                                    case 1:
                                        tempEmp.GraRankName = "Khá";
                                        break;
                                    case 2:
                                        tempEmp.GraRankName = "Giỏi";
                                        break;
                                    case 3:
                                        tempEmp.GraRankName = "Xuất sắc";
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 8:
                                System.Console.Write("Nhập vào trường tốt nghiệp mới: ");
                                string graUni = Console.ReadLine();
                                tempEmp.GraUni = graUni;
                                break;
                            default:
                                break;
                        }
                    }
                }
                System.Console.WriteLine("Chỉnh sửa thành công");
            }
            if(count == 0) {
                System.Console.WriteLine("Người dùng không tồn tại trong hệ thống. Vui lòng thử lại");
            }
        }
        public void ShowAllEmp() {
            foreach(var item in Data) {
                System.Console.WriteLine(item);
            }
        }

        public void EditInfoBasic() {
            System.Console.WriteLine("Bạn muốn chỉnh sửa:");
            System.Console.WriteLine("1. Họ tên");
            System.Console.WriteLine("2. Ngày sinh");
            System.Console.WriteLine("3. Số điện thoại");
            System.Console.WriteLine("4. Email");
            System.Console.WriteLine("5. Loại nhân viên");
        }
        public void ChooseInfo(int chooseNumber, Employee tempEmp) {
            switch(chooseNumber) {
                case 1: 
                    System.Console.Write("Nhập vào họ tên mới: ");
                    string fullname = Console.ReadLine();
                    tempEmp.Fullname = fullname;
                    break;
                case 2: 
                    System.Console.Write("Nhập vào ngày sinh mới: ");
                    int day = int.Parse(Console.ReadLine());
                    System.Console.Write("Nhập vào tháng sinh mới: ");
                    int month = int.Parse(Console.ReadLine());
                    System.Console.Write("Nhập vào năm sinh mới: ");
                    int year = int.Parse(Console.ReadLine());
                    tempEmp.Birthday = new DateTime(year, month, day);
                    break;
                case 3: 
                    System.Console.Write("Nhập vào số điện thoại mới: ");
                    string phone = Console.ReadLine();
                    tempEmp.Phone = phone;
                    break;
                case 4: 
                    System.Console.Write("Nhập vào email mới: ");
                    string email = Console.ReadLine();
                    tempEmp.Email = email;
                    this.AddEmail(email);
                    this.CheckEmail(email);
                    break;
                case 5: 
                    System.Console.Write("Nhập vào loại nhân viên mới: ");
                    byte employee_type = byte.Parse(Console.ReadLine());
                    tempEmp.Employee_type = employee_type;
                    break;
            }
        }
        public void AddEmail(string email)
        {
            if (!email.Contains('@')) 
            {
                Exception e = new EmailException();
                throw e;
            }
            else System.Console.WriteLine("Email hợp lệ");
        }
        public void CheckEmail(string email) {
            try
            {
                AddEmail(email);
            }
            catch (EmailException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}