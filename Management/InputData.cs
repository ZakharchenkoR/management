using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    class InputData
    {
        public static string EnterString()
        {
            try
            {
                string str = Console.ReadLine();
                return str;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public static int EnterNumber()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                return number;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
