﻿using System;
using System.Text;
using System.Collections.Generic;
namespace Do_an_OOP
{
    class Program
    {
        static void AddEmail(string email)
        {
            if (!email.Contains('@')) 
            {
                Exception e = new EmailException();
                throw e;
            }
            else System.Console.WriteLine("Email hợp lệ");
        }
        public static void EmpType(byte s)
        {
            if (s < 0 || s > 2) 
            {
                Exception e = new EmployeeTypeException();
                throw e;
            }
        } 
        public static void GraRank(byte s)
        {
            if (s < 0 || s > 3) 
            {
                Exception e = new GraduateRankException();
                throw e;
            }
        } 
        public static void UserPhone(string s)
        {
            if (s.Length > 10) 
            {
                Exception e = new NumberException();
                throw e;
            }
        }
        static void Main(string[] args)
        {
            // ManageEmployee manageEmployee1 = new ManageEmployee();
            // Database db3 = new Database();
            // db3.ShowAllEmp();
            // db3.Add(new Experience("09", "J", new DateTime(2002, 8, 31), "0977xxx", "@", 0, 4, "PHP"));
            // db3.ShowAllEmp();
            // Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Console.Clear();
            // //Console.SetWindowSize(180, 40);
            // Console.OutputEncoding = Encoding.Unicode;
            // Console.InputEncoding = Encoding.Unicode;
            // Database db = new Database();
            // string username = "admin";
            // string password = "123";
            // if(db.query4Login(username, password)) {
            //     System.Console.WriteLine("Đăng nhập thành công");
            //     ManageEmployee manageEmployee = new ManageEmployee();
            //     manageEmployee.ShowAllEmp();
            //     manageEmployee.ShowEmpSalary(manageEmployee.FindByType(2));
            //     manageEmployee.ShowEmpSalary(manageEmployee.FindByType(0));
            //     manageEmployee.Edit();
            // }else {
            //     System.Console.WriteLine("Đăng nhập không thành công");
            // }
            /*string email = "abca@dada";
            try
            {
                AddEmail(email);
            }
            catch (EmailException e)
            {
                System.Console.WriteLine(e.Message);
            }*/
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            System.Console.WriteLine("================ĐỒ ÁN MÔN HỌC LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG===============");
            System.Console.WriteLine("                       ĐỀ TÀI: QUẢN LÍ NHÂN VIÊN ");
            System.Console.WriteLine("                 NHÓM THỰC HIỆN: ĐẠT, BẢO, DẬU, THIỆN");
            System.Console.WriteLine("                         ************************                   ");
            BEGIN:   
            System.Console.WriteLine("==========================ĐĂNG NHẬP VÀO HỆ THỐNG======================="); 
            System.Console.Write("Nhập vào tài khoản: ");
            string username = Console.ReadLine();
            System.Console.Write("Nhập vào mật khẩu: ");
            string password = Console.ReadLine();
            Database db = new Database();
            if(db.query4Login(username, password)) {
                Console.Clear();
                System.Console.WriteLine("Chào mừng trở lại, " + username);
                BEGIN2:
                ManageEmployee manageEmployee = new ManageEmployee();
                System.Console.WriteLine("----------------PHẦN MỀM QUẢN LÍ NHÂN VIÊN--------------");
                System.Console.WriteLine("Các chức năng: ");
                System.Console.WriteLine("0. Xem danh sách nhân viên");
                System.Console.WriteLine("1. Xem danh sách nhân viên theo loại");
                System.Console.WriteLine("2. Tìm nhân viên theo id");
                System.Console.WriteLine("3. Tìm thông tin nhân viên theo loại");
                System.Console.WriteLine("4. Thêm nhân viên");
                System.Console.WriteLine("5. Cập nhật thông tin nhân viên");
                System.Console.WriteLine("6. Xóa nhân viên theo Id");
                System.Console.Write("Nhập vào lựa chọn của bạn: ");
                int chooseNumber = int.Parse(Console.ReadLine());
                string id = ""; string fullname = ""; int day = 0; int month = 0; int year = 0; DateTime date = new DateTime();
                string phone = ""; string email = "";
                switch (chooseNumber) {
                    case 0:
                        Console.Clear();
                        System.Console.WriteLine("___________________DANH SÁCH NHÂN VIÊN__________________");
                        db.ShowAllEmp();
                        break;
                    case 1:
                        Console.Clear();
                        System.Console.WriteLine("===============CÁC LOẠI NHÂN VIÊN=============");
                        System.Console.WriteLine("0. Experience");
                        System.Console.WriteLine("1. Intern");
                        System.Console.WriteLine("2. Fresher");
                        System.Console.WriteLine("");
                        System.Console.Write("Nhập vào loại nhân viên muốn xem: ");
                        byte choose1 = byte.Parse(Console.ReadLine());
                        List<Employee> listEmp = new List<Employee>();
                        listEmp = manageEmployee.FindByType(choose1);
                        System.Console.WriteLine("Danh sách nhân viên thỏa mãn: ");
                        foreach(var item in listEmp) {
                            System.Console.WriteLine(item);
                        }
                        break;
                    case 2:
                        Console.Clear();
                        System.Console.Write("Nhập vào id của nhân viên bạn muốn tìm: ");
                        id = Console.ReadLine();
                        Employee emp = new Employee();
                        emp = manageEmployee.FindById(id);
                        if(emp.Id != null) {
                            System.Console.WriteLine("Nhân viên bạn cần tìm là: ");
                            System.Console.WriteLine(emp);
                        }else {
                            System.Console.WriteLine("Người dùng không tồn tại trong hệ thống");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        System.Console.WriteLine("===============CÁC LOẠI NHÂN VIÊN=============");
                        System.Console.WriteLine("0. Experience");
                        System.Console.WriteLine("1. Intern");
                        System.Console.WriteLine("2. Fresher");
                        System.Console.WriteLine("");
                        System.Console.Write("Nhập vào loại nhân viên muốn tìm: ");
                        int chooseNum = int.Parse(Console.ReadLine());
                        switch(chooseNum) {
                            case 0:
                                System.Console.WriteLine("1. Tìm theo số năm kinh nghiệm");
                                System.Console.WriteLine("2. Tìm theo kĩ năng chuyên môn");
                                System.Console.Write("Nhập lựa chọn của bạn: ");
                                int select = int.Parse(Console.ReadLine());
                                switch (select)
                                {
                                    case 1:
                                        System.Console.Write("Nhập vào số năm kinh nghiệm: ");
                                        int yearOfExp = int.Parse(Console.ReadLine());
                                        List<Employee> listExp = manageEmployee.FindByExp(yearOfExp);
                                        int count1 = 0;
                                        foreach(var item in listExp) {
                                            if(item != null) {
                                                count1++;
                                            }
                                        }
                                        if(count1 != 0) {
                                            System.Console.WriteLine("Danh sách nhân viên thỏa mãn: ");
                                            foreach(var item in listExp) {
                                                System.Console.WriteLine(item);
                                            }
                                        }else {
                                            System.Console.WriteLine("Không tìm thấy nhân viên thỏa mãn. Vui lòng thử lại");
                                        }
                                        break;
                                    case 2:
                                        System.Console.Write("Nhập vào kĩ năng chuyên môn: ");
                                        string proSkills = Console.ReadLine();
                                        List<Employee> listExp1 = manageEmployee.FindBySkills(proSkills);
                                        int count2 = 0;
                                        foreach(var item in listExp1) {
                                            if(item != null) {
                                                count2++;
                                            }
                                        }
                                        if(count2 != 0) {
                                            System.Console.WriteLine("Danh sách nhân viên thỏa mãn: ");
                                            foreach(var item in listExp1) {
                                                System.Console.WriteLine(item);
                                            }
                                        }else {
                                            System.Console.WriteLine("Không tìm thấy nhân viên thỏa mãn. Vui lòng thử lại");
                                        }
                                        break;
                                    default:
                                        System.Console.WriteLine("Vui lòng nhập lựa chọn từ 1 -> 2");
                                        break;
                                }
                                break;
                            case 1:
                                System.Console.Write("Nhập vào chuyên ngành: ");
                                string major = Console.ReadLine();
                                List<Employee> listIntern = manageEmployee.FindByMajor(major);
                                int count3 = 0;
                                foreach(var item in listIntern) {
                                    if(item != null) {
                                        count3++;
                                    }
                                }
                                if(count3 != 0) {
                                    System.Console.WriteLine("Danh sách nhân viên thỏa mãn: ");
                                    foreach(var item in listIntern) {
                                        System.Console.WriteLine(item);
                                    }
                                }else {
                                    System.Console.WriteLine("Không tìm thấy nhân viên thỏa mãn. Vui lòng thử lại");
                                }
                                break;
                            case 2:
                                System.Console.Write("Nhập vào hạng tốt nghiệp: ");
                                byte graRank = byte.Parse(Console.ReadLine());
                                 List<Employee> listFresher = manageEmployee.FindByGraRank(graRank);
                                int count4 = 0;
                                foreach(var item in listFresher) {
                                    if(item != null) {
                                        count4++;
                                    }
                                }
                                if(count4 != 0) {
                                    System.Console.WriteLine("Danh sách nhân viên thỏa mãn: ");
                                    foreach(var item in listFresher) {
                                        System.Console.WriteLine(item);
                                    }
                                }else {
                                    System.Console.WriteLine("Không tìm thấy nhân viên thỏa mãn. Vui lòng thử lại");
                                }
                                break;
                            default:
                                System.Console.WriteLine("Vui lòng nhập lựa chọn từ 0 -> 2");
                                break;
                        }
                        break;
                    case 4: 
                        Console.Clear();
                        System.Console.WriteLine("===============CÁC LOẠI NHÂN VIÊN=============");
                        System.Console.WriteLine("0. Experience");
                        System.Console.WriteLine("1. Intern");
                        System.Console.WriteLine("2. Fresher");
                        System.Console.WriteLine("");
                        System.Console.Write("Nhập vào loại nhân viên muốn thêm: ");
                        byte choose4 = byte.Parse(Console.ReadLine());
                        switch(choose4) {
                            case 0:
                                InputInfoBasic(ref id, ref fullname, ref day, ref month, ref year, ref date, ref phone, ref email);
                                System.Console.Write("Nhập vào năm kinh nghiệm: ");
                                int yearOfExp = int.Parse(Console.ReadLine());
                                System.Console.Write("Nhập vào kĩ năng: ");
                                string proSkills = Console.ReadLine();
                                Experience newExp = new Experience(id, fullname, date, phone, email, choose4, yearOfExp, proSkills);
                                db.Add(newExp);
                                break;
                            case 1:
                                InputInfoBasic(ref id, ref fullname, ref day, ref month, ref year, ref date, ref phone, ref email);
                                System.Console.Write("Nhập vào chuyên ngành: ");
                                string majors = Console.ReadLine();
                                System.Console.Write("Nhập vào học kì: ");
                                int semester = int.Parse(Console.ReadLine());
                                System.Console.Write("Nhập vào trường đại học: ");
                                string university = Console.ReadLine();
                                Intern newIntern = new Intern(id, fullname, date, phone, email, choose4, majors, semester, university);
                                manageEmployee.Add(newIntern);
                                break;
                            case 2:
                                InputInfoBasic(ref id, ref fullname, ref day, ref month, ref year, ref date, ref phone, ref email);
                                System.Console.Write("Nhập vào ngày tốt nghiệp: ");
                                int dayGra = int.Parse(Console.ReadLine());
                                System.Console.Write("Nhập vào tháng tốt nghiệp: ");
                                int monthGra = int.Parse(Console.ReadLine());
                                System.Console.Write("Nhập vào năm tốt nghiệp: ");
                                int yearGra = int.Parse(Console.ReadLine());
                                System.Console.Write("Nhập vào hạng tốt nghiệp: ");
                                byte graRank = byte.Parse(Console.ReadLine());
                                System.Console.Write("Nhập vào trường tốt nghiệp: ");
                                string graUni = Console.ReadLine();
                                DateTime graDate = new DateTime(yearGra, monthGra, dayGra);
                                Fresher newFresher = new Fresher(id, fullname, date, phone, email, choose4, graDate, graRank, graUni);
                                manageEmployee.Add(newFresher);
                                break;
                            default: 
                                System.Console.WriteLine("Vui lòng nhập lựa chọn từ 0 -> 2");
                                break;
                        }
                        break;
                    case 5:
                        Console.Clear();
                        System.Console.Write("Nhập vào id của nhân viên: ");
                        string id1 = Console.ReadLine();
                        db.Edit(id1);
                        break;
                    case 6:
                        System.Console.Write("Nhập vào id của nhân viên muốn xóa: ");
                        string idDel = Console.ReadLine();
                        db.Remove(idDel);
                        break;
                    default:
                        System.Console.WriteLine("Vui lòng nhập lựa chọn từ 0 -> 6");
                        goto BACK;
                }
                BACK:
                System.Console.WriteLine("Bạn có muốn quay lại màn hình chính");
                System.Console.WriteLine("1. Có");
                System.Console.WriteLine("2. Không");
                System.Console.Write("Nhập lựa chọn của bạn: ");
                int choose = int.Parse(Console.ReadLine());
                if(choose == 1) {
                    Console.Clear();
                    goto BEGIN2;
                }
                else {
                    Exit();
                    int chooseNum = int.Parse(Console.ReadLine());
                    switch (chooseNum)
                    {
                        case 2:
                            Console.Clear();
                            goto BEGIN2;
                        case 1:
                            System.Console.WriteLine("Thoát chương trình thành công");
                            break;
                        default:
                            break;
                    }
                }
                
            }else {
                System.Console.WriteLine("Tài khoản hoặc mật khẩu không đúng. Bạn có muốn tiếp tục?");
                System.Console.WriteLine("Yes (Ấn phím 1)");
                System.Console.WriteLine("No (Ấn phím 2)");
                System.Console.Write("Nhập lựa chọn của bạn: ");
                int chooseNumber = int.Parse(Console.ReadLine());
                switch (chooseNumber)
                {
                    case 1:
                        Console.Clear();
                        goto BEGIN;
                    case 2:
                        System.Console.WriteLine("Thoát chương trình thành công");
                        break;
                    default:
                        break;
                }
            }

        } 
        public static void InputInfoBasic(ref string id, ref string fullname, ref int day, ref int month, ref int year, ref DateTime date, ref string phone, ref string email) {
            System.Console.Write("Nhập vào id: ");
            id = Console.ReadLine();
            System.Console.Write("Nhập vào họ tên: ");
            fullname = Console.ReadLine();
            System.Console.Write("Nhập vào ngày sinh: ");
            day = int.Parse(Console.ReadLine());
            System.Console.Write("Nhập vào tháng sinh: ");
            month = int.Parse(Console.ReadLine());
            System.Console.Write("Nhập vào năm sinh: ");
            year = int.Parse(Console.ReadLine());
            date = new DateTime(year, month, day);
            System.Console.Write("Nhập vào số điện thoại: ");
            phone = Console.ReadLine();
            System.Console.Write("Nhập vào email: ");
            email = Console.ReadLine();
            Database db = new Database();
            db.AddEmail(email);
            db.CheckEmail(email);
        }
        public static void Exit() {
            Console.Clear();
            System.Console.WriteLine("Bạn có muốn thoát chương trình?");
            System.Console.WriteLine("1. Có");
            System.Console.WriteLine("2. Không");
            System.Console.Write("Nhập lựa chọn của bạn: ");
        }
    }
}

