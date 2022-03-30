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
        }
        public override string ToString()
        {
            return base.ToString() + ", Graduate Date: " + graDate.ToShortDateString() + ", Graduate Rank: " + graRank + ", Gradutate University: " + graUni;
        }
    }
}
