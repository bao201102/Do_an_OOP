using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_OOP
{
    public class Fresher : Employee, IEmployee
    {
        private DateTime graDate;
        private byte graRank;
        private string graRankName;
        private string graUni;

        public byte GraRank { get { return graRank; } set { graRank = value; } }
        public DateTime GraDate { get { return graDate; } set { graDate = value; }}
        public string GraRankName { get { return graRankName; } set { graRankName = value; }}
        public string GraUni { get { return graUni; } set { graUni = value; }}

        public Fresher(string id, string fullname, DateTime birthday, string phone, string email, byte employee_type, DateTime graDate, byte graRank, string graUni)
        {
            this.id = id;
            this.fullname = fullname;
            this.birthday = birthday;
            this.phone = phone;
            this.email = email;
            this.employee_type = employee_type;
            this.graDate = graDate;
            this.graRank = graRank;
            this.graUni = graUni;

            switch (this.graRank)
            {
                case 0:
                    this.graRankName = "Trung Bình";
                    break;
                case 1:
                    this.graRankName = "Khá";
                    break;
                case 2:
                    this.graRankName = "Giỏi";
                    break;
                case 3:
                    this.graRankName = "Xuất sắc";
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            return base.ToString().Insert(8, "\t") + $", Graduate Date: {graDate.ToShortDateString()}, Rank: {graRankName}, University: {graUni}";
        }

        public double CalcSalary()
        {
            if (graRank > 0)
            {
                return 8000000 + 250000 * (graRank / 2);
            }
            return 800000;
        }
        public override string ShowSalary()
        {
            return GetType().ToString().Remove(0, 10) + $"\tId: {id}, Fullname: {fullname}, Rank: {graRankName}, Salary: {String.Format("{0:0,0 vnđ}", CalcSalary())}";
        }
    }
}
