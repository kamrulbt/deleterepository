using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("change by saddam 1111111111 ");
            int upto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n you gave {0}  ",upto);
            int check = 1,output=1;
            for (int i = 1; i <= upto;i++ )
            {
                check = 1;
                for (int j = 1; j <= 10;j++ )
                {
                    if(check == 1){
                        Console.WriteLine(i+ "  namata\n");
                        check = 0;
                    }
                    output = i * j;
                    Console.WriteLine("{0} * {1} = {2}",i,j,output);
                }
            }
            Console.ReadKey();
            
        }
    }
}
