using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_OOP
{
    public class Fresher : Employee
    {
        private DateTime graDate;
        private byte graRank;
        private string graRankName;
        private string graUni;

        public byte GraRank { get { return graRank; } set { graRank = value; } }

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
            return base.ToString().Insert(8, "\t") + ", Graduate Date: " + graDate.ToShortDateString() + ", Graduate Rank: " + graRankName + ", Gradutate University: " + graUni;
        }
    }
}
