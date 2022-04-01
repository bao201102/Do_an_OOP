using System;
namespace Do_an_OOP {
    public class Administrator : Employee {
        public Administrator(string id, string fullname, DateTime birthday, string phone, string email, byte employee_type)
        {
            base.id = id;
            this.fullname = fullname;
            this.birthday = birthday;
            this.phone = phone;
            this.email = email;
            this.employee_type = employee_type;
        }
    }
}