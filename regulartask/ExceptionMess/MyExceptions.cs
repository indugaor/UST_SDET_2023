using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMess
{
    internal class MyExceptions
    {
        /* public static List<string> exmesslist = new List<string>()
         {
             "Dont give 0 for Denom",
             "Index is out of Range",
             "Unknow Exception"
         };*/

        public static Dictionary<string, string> exmesslist =
            new Dictionary<string, string>()
            {
                {"NotHun","Age is less" },
                {"NotHun1" ,"Age is more"}
            };

      
    } 
    internal class Num1Exception : Exception
    {
        public Num1Exception(string message) : base(message)
        {

        }
    }
    internal class Num2Exception : Exception
    {
        public Num2Exception(string message) : base(message)
        {

        }
    }

}
