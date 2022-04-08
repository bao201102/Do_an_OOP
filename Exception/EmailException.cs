using System;
namespace Do_an_OOP
{
    public class EmailException : Exception
    {
        const string errorEmail = "Email không hợp lệ";
        public EmailException() : base(errorEmail)
        {

        }
        /*public static void EmailEx(string s)
        {
            if (!s.Contains('@')) 
            {
                Exception e = new EmailException();
                throw e;
            }
        } */
    }
}