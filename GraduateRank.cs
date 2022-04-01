using System;
namespace Do_an_OOP
{
    public class GraduateRank : Exception
    {
        const string errorRank = "Trình độ nhân viên không hợp lệ";
        public GraduateRank() : base(errorRank)
        {

        }
        public static void GraRank(byte s)
        {
            if (s < 0 || s > 3) 
            {
                Exception e = new GraduateRank();
                throw e;
            }
        } 
    }
}