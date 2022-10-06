using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrays
{
    class Program
    {
        public int[] intNumbers = new int[3] {1 , 5 , 8};
        public float[] floatNumbers = new float[3] { 1.5f , 5.7f , 8.2f };
        public bool[] isCheck = new bool[3] { true , false , true };
        public string[] names = new string[3] {"youssef" , "omar" , "hassna"};
         public void Display()
        {
            for (int i = 0; i < intNumbers.Length ; i++)
            {
                Console.WriteLine($"Element {i} =  {intNumbers[i]}");
            }
            for (int i = 0; i < floatNumbers.Length; i++)
            {
                Console.WriteLine($"Element {i} =  {floatNumbers[i]}");
            }
            for (int i = 0; i < isCheck.Length; i++)
            {
                Console.WriteLine($"Element {i} =  {isCheck[i]}");
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Element {i} =  {names[i]}");
            }
        }
}
}
