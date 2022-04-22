using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_OOP
{
    public class NoneIdException : Exception
    {
        const string errorId = "Id không tồn tại trong hệ thống";
        public NoneIdException() : base(errorId)
        {

        }
    }
}
