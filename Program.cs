using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;
namespace Do_an_OOP
{
    class Program
    {
        static ManageEmployee manage = new ManageEmployee();

        public static void Add()
        {
            Console.WriteLine("------------NHẬP THÔNG TIN CHUNG CỦA NHÂN VIÊN------------");
            Console.Write("Nhập id: ");
            string id = Validation.InputId();
            Console.Write("Nhập họ tên: ");
            string fullname = Console.ReadLine();
            Console.Write("Nhập ngày: ");
            byte day = byte.Parse(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            byte month = byte.Parse(Console.ReadLine());
            Console.Write("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());
            DateTime birthday = new DateTime(year, month, day);
            Console.Write("Nhập số điện thoại: ");
            string phone = Validation.InputPhone();
            Console.Write("Nhập email: ");
            string email = Validation.InputEmail();
            Console.WriteLine("Nhập loại nhân viên (0-2):");
            Console.WriteLine("\tPhím 0: Experience");
            Console.WriteLine("\tPhím 1: Intern");
            Console.WriteLine("\tPhím 2: Fresher");
            Console.Write(">>: ");
            byte employee_type = Validation.InputEmpType();

            Console.WriteLine("------------NHẬP THÔNG TIN THEO LOẠI NHÂN VIÊN------------");
            switch (employee_type)
            {
                case 0:
                    Console.Write("Nhập năm kinh nghiệm: ");
                    int yearOfExp = int.Parse(Console.ReadLine());
                    Console.Write("Nhập kỹ năng: ");
                    string proSkills = Console.ReadLine();
                    manage.Add(new Experience(id, fullname, birthday, phone, email, employee_type, yearOfExp, proSkills));
                    break;
                case 1:
                    Console.Write("Nhập chuyên ngành: ");
                    string majors = Console.ReadLine();
                    Console.Write("Nhập học kỳ: ");
                    int semester = int.Parse(Console.ReadLine());
                    Console.Write("Nhập trường đại học: ");
                    string university = Console.ReadLine();
                    manage.Add(new Intern(id, fullname, birthday, phone, email, employee_type, majors, semester, university));
                    break;
                case 2:
                    Console.Write("Nhập ngày tốt nghiệp: ");
                    byte graDay = byte.Parse(Console.ReadLine());
                    Console.Write("Nhập tháng tốt nghiệp: ");
                    byte graMonth = byte.Parse(Console.ReadLine());
                    Console.Write("Nhập năm tốt nghiệp: ");
                    int graYear = int.Parse(Console.ReadLine());
                    DateTime graDate = new DateTime(graYear, graMonth, graDay);
                    Console.WriteLine("Nhập hạng tốt nghiệp (0 - 3): ");
                    Console.WriteLine("\tPhím 0: Trung bình");
                    Console.WriteLine("\tPhím 1: Khá");
                    Console.WriteLine("\tPhím 2: Giỏi");
                    Console.WriteLine("\tPhím 3: Xuất sắc");
                    Console.Write(">>: ");
                    byte graRank = Validation.InputGraRank();
                    Console.Write("Nhập trường tốt nghiệp: ");
                    string graUni = Console.ReadLine();
                    manage.Add(new Fresher(id, fullname, birthday, phone, email, employee_type, graDate, graRank, graUni));
                    break;
                default:
                    break;
            }
            Console.WriteLine("Bạn đã thêm nhân viên thành công");
        }

        public static void Edit(string id)
        {
            Console.WriteLine("Bạn đang chỉnh sửa thông tin của nhân viên:\n" + manage.FindById(id));
            Employee emp = manage.FindById(id);

            Console.WriteLine("Phím 0: Sửa thông tin chung của nhân viên");
            Console.WriteLine("Phím 1: Sửa thông tin theo loại nhân viên");
            Console.Write(">>: ");
            byte choose1 = byte.Parse(Console.ReadLine());
            switch (choose1)
            {
                case 0:
                    Console.WriteLine("------------SỬA THÔNG TIN CHUNG CỦA NHÂN VIÊN------------");
                    Console.WriteLine("Phím 0: Sửa họ tên");
                    Console.WriteLine("Phím 1: Sửa ngày, tháng, năm sinh");
                    Console.WriteLine("Phím 2: Sửa số điện thoại");
                    Console.WriteLine("Phím 3: Sửa email");
                    Console.Write(">>: ");
                    byte choose2 = byte.Parse(Console.ReadLine());
                    switch (choose2)
                    {
                        case 0:
                            Console.Write("Nhập họ tên mới: ");
                            emp.Fullname = Console.ReadLine();
                            break;
                        case 1:
                            Console.Write("Nhập ngày mới: ");
                            byte day = byte.Parse(Console.ReadLine());
                            Console.Write("Nhập tháng mới: ");
                            byte month = byte.Parse(Console.ReadLine());
                            Console.Write("Nhập năm mới: ");
                            int year = int.Parse(Console.ReadLine());
                            emp.Birthday = new DateTime(year, month, day);
                            break;
                        case 2:
                            Console.Write("Nhập số điện thoại mới: ");
                            emp.Phone = Validation.InputPhone();
                            break;
                        case 3:
                            Console.Write("Nhập email mới: ");
                            emp.Email = Validation.InputEmail();
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    Console.WriteLine("------------SỬA THÔNG TIN THEO LOẠI NHÂN VIÊN------------");
                    if (emp as Experience != null)
                    {
                        Experience tempEmp = (Experience)emp;
                        Console.Write("Nhập năm kinh nghiệm mới: ");
                        tempEmp.YearOfExp = int.Parse(Console.ReadLine());
                        Console.Write("Nhập kỹ năng mới: ");
                        tempEmp.ProSkills = Console.ReadLine();
                    }
                    else if (emp as Intern != null)
                    {
                        Intern tempEmp = (Intern)emp;
                        Console.Write("Nhập chuyên ngành mới: ");
                        tempEmp.Majors = Console.ReadLine();
                        Console.Write("Nhập học kỳ mới: ");
                        tempEmp.Semester = int.Parse(Console.ReadLine());
                        Console.Write("Nhập trường đại học mới: ");
                        tempEmp.University = Console.ReadLine();
                    }
                    else
                    {
                        Fresher tempEmp = (Fresher)emp;
                        Console.Write("Nhập ngày tốt nghiệp mới: ");
                        byte graDay = byte.Parse(Console.ReadLine());
                        Console.Write("Nhập tháng tốt nghiệp mới: ");
                        byte graMonth = byte.Parse(Console.ReadLine());
                        Console.Write("Nhập năm tốt nghiệp mới: ");
                        int graYear = int.Parse(Console.ReadLine());
                        tempEmp.GraDate = new DateTime(graYear, graMonth, graDay);
                        Console.WriteLine("Phím 0: Trung bình");
                        Console.WriteLine("Phím 1: Khá");
                        Console.WriteLine("Phím 2: Giỏi");
                        Console.WriteLine("Phím 3: Xuất sắc");
                        Console.Write("Nhập hạng tốt nghiệp mới (0 - 3): ");
                        tempEmp.GraRank = Validation.InputGraRank();
                        Console.Write("Nhập trường tốt nghiệp mới: ");
                        tempEmp.GraUni = Console.ReadLine();
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Bạn đã cập nhật thông tin nhân viên thành công");
        }

        public static void Delete(string id)
        {
            Console.WriteLine("Bạn đã xóa nhân viên thành công");
            manage.Delete(id);
        }

        public static void Login()
        {
            Console.Write("Nhập vào tài khoản: ");
            string username = Console.ReadLine();
            Console.Write("Nhập vào mật khẩu: ");
            string password = Console.ReadLine();
            if (!manage.QueryForLogin(username, password))
            {
                Console.WriteLine("Tài khoản hoặc mật khẩu sai vui lòng nhập lại");
                Login();
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.SetWindowSize(150, 50);

            Console.WriteLine("================ĐỒ ÁN MÔN HỌC LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG===============");
            Console.WriteLine("                       ĐỀ TÀI: QUẢN LÍ NHÂN VIÊN ");
            Console.WriteLine("                 NHÓM THỰC HIỆN: ĐẠT, BẢO, DẬU, THIỆN");
            Console.WriteLine("                         ************************                   ");
            Console.WriteLine("==========================ĐĂNG NHẬP VÀO HỆ THỐNG=======================");
            Login();

        BEGIN:
            Console.Clear();
            Console.WriteLine("----------------PHẦN MỀM QUẢN LÍ NHÂN VIÊN--------------");
            Console.WriteLine("\nDanh sách các chức năng: ");
            Console.WriteLine("Phím 0: Tìm nhân viên theo id để sửa/xóa thông tin");
            Console.WriteLine("Phím 1: Thêm mới nhân viên");
            Console.WriteLine("Phím 2: Xem danh sách tất cả nhân viên");
            Console.WriteLine("Phím 3: Xem danh sách nhân viên theo loại");
            Console.WriteLine("Phím 4: Xem danh sách nhân viên theo kinh nghiệm");
            Console.WriteLine("Phím 5: Xem danh sách nhân viên theo kỹ năng");
            Console.WriteLine("Phím 6: Xem danh sách nhân viên theo loại tốt nghiệp");
            Console.WriteLine("Phím 7: Xem danh sách nhân viên theo chuyên ngành");
            Console.WriteLine("Phím 8: Xem danh sách lương nhân viên");
            Console.Write(">>: ");
            byte choose = byte.Parse(Console.ReadLine());

            switch (choose)
            {
                case 0:
                    Console.Write("\nNhập id: ");
                    string id = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Nhân viên bạn cần tìm:\n" + manage.FindById(id));
                    manage.FindById(id);

                    Console.WriteLine("\nCác chức năng thao tác trên nhân viên: ");
                    Console.WriteLine("Phím 0: Cập nhật thông tin của nhân viên này");
                    Console.WriteLine("Phím 1: Xóa toàn bộ thông tin của nhân viên này");
                    Console.Write(">>: ");
                    byte choose2 = byte.Parse(Console.ReadLine());

                    switch (choose2)
                    {
                        case 0:
                            Edit(id);
                            break;
                        case 1:
                            Delete(id);
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    Console.Clear();
                    Add();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Danh sách các nhân viên trong bộ phận IT: ");
                    manage.ShowAllEmp();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Phím 0: Loại nhân viên Experience");
                    Console.WriteLine("Phím 1: Loại nhân viên Intern");
                    Console.WriteLine("Phím 2: Loại nhân viên Fresher");
                    Console.Write(">>: ");
                    byte choose_type = Validation.InputEmpType();
                    manage.ShowEmp(manage.FindByType(choose_type));
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Nhập số năm kinh nghiệm: ");
                    byte yearOfExp = byte.Parse(Console.ReadLine());
                    manage.ShowEmp(manage.FindByExp(yearOfExp));
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Nhập kỹ năng: ");
                    string skills = Console.ReadLine();
                    manage.ShowEmp(manage.FindBySkills(skills));
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Nhập loại tốt nghiệp (0 - 3):");
                    Console.WriteLine("\tPhím 0: Trung bình");
                    Console.WriteLine("\tPhím 1: Khá");
                    Console.WriteLine("\tPhím 2: Giỏi");
                    Console.WriteLine("\tPhím 3: Xuất sắc");
                    Console.Write(">>: ");
                    byte graRank = Validation.InputGraRank();
                    manage.ShowEmp(manage.FindByGraRank(graRank));
                    break;
                case 7:
                    Console.Clear();
                    Console.Write("Nhập chuyên ngành: ");
                    string majors = Console.ReadLine();
                    manage.ShowEmp(manage.FindByMajor(majors));
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("------------DANH SÁCH LƯƠNG CỦA NHÂN VIÊN------------");
                    manage.ShowEmpSalary();
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nPhím 0: Về lại màn hình chính và tiếp túc sử dụng chương trình");
            Console.WriteLine("Phím 1: Thoát khỏi chương trình");
            Console.Write(">>: ");
            byte continue_choose = byte.Parse(Console.ReadLine());
            switch (continue_choose)
            {
                case 0:
                    goto BEGIN;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

