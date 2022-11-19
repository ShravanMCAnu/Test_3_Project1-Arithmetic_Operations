
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3_Project1_Arithmetic_Operations
{

    public class ArithmeticExceptions
    {
        public static void Arithmetic1(int _number1, int _number2)
        {
            int  number3;
            number3 = _number1 / _number2;
            Console.WriteLine(number3);
        }
        
        public void Arithmetic2(int _number4)
        {
            int number5 = _number4 * _number4 * _number4;
            Console.WriteLine(number5);
        }

    }
    
}
