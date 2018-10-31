using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetryparse
{

    class Program
    {       
            public static int Main()
            {
            // int i = 0;
            
            string name = Console.ReadLine();
            string[] arr = name.Split(' ');
             string[] j;
                for ( int i = 0; i < arr.Length; i++)
                {
                // Console.WriteLine(arr[i]);
                //Console.WriteLine(arr[i].Length);
                do
                {
                    if (name[i] == ' ')
                    {
                        return i;

                    }
                    else
                        return 0;
                }while(name[i]=='\0');
            }
            Console.WriteLine("Added tis line for the git);
            return 0;
            }


       

        }
    
}
