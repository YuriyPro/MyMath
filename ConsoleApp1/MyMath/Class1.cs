using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Class1
    {
        int[] array = { 1, 2, 3, 4, 5 };

        public void SerAr()
        {
            
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
                summ += array[i];
            int mid = summ / array.Length;
        }

        public void Max()
        {
           
            int maxValue = array.Max();

        }

        public void Sum()
        {
            
          int  sum = 0;
          int[] A = new int[5];
            // цикл обчислення суми
            for (int i = 0; i < array.Length; i++)
                sum = sum + A[i];
        }
    }
}
