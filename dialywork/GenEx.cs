using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GenEx<T> where T : Exception
    {

        
        /*
        private T[] arr;
        public GenEx(T[] arr) {
            Arr = arr;
        }

        public T[] Arr { get=> arr;  set=>arr=value; }
        public void Disp()
        {
            foreach(var item in Arr)
            {
                Console.WriteLine(item);
            }
        }
        */
        
private T val1, val2;
public GenEx(T val1,T val2)
{
Val1 = val1;
Val2 = val2;
}
public T Val1 { get => Val1; set => val1 = value; }
public T Val2 { get => Val2; set => val2 = value; }

    }
}
