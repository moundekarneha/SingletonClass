using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClass
{
    internal class Program
    {
        
       internal sealed class SingletonClass //to protect from inheritance - even in multithreaded enviornment - use lock to prevent
        {
            private static SingletonClass obj;
            private static Object obj1;
            private SingletonClass()
            {

            }

            public static SingletonClass GetObj()
            {
                lock (obj1)
                {
                    if (obj == null)
                    {
                        obj = new SingletonClass();
                    }
                }
                
                return obj;
            }
        }

        
        static void Main(string[] args)
        {
            SingletonClass obj = SingletonClass.GetObj();
            Test(obj);

            void Test(SingletonClass obj1)
            {
                Console.WriteLine("We can use singleton class object as parameter to method");
            }
        }
       
    }

}
