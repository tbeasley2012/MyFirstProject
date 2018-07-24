using System;

namespace FirstCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
         //   float AtBats = 4000;
         //   int Hits = 1250;
         //   float BattingAverage = Hits/AtBats;
         //   Console.WriteLine($"{BattingAverage}");


         /*   int i = 15;
            int j = 3;
            string name = "Tyler";
            bool isValid = false;
            Console.WriteLine("i = " + i);
            Console.WriteLine("j = {0}",j);
            Console.WriteLine($"{name}");
            Console.WriteLine($"Valid = {isValid}");*/
        

          /*  int i = 10;
            int j = 5;
            Console.WriteLine($"i = {i} , j = {j}");
            Swap(ref i, ref j);
            Console.WriteLine($"i = {i} , j = {j}");*/


            /*int [] numbers = new int []{10, 2, 5, 8 , 1};
            for(int a=0;a<5;a++)
            {
                Console.WriteLine($"Element {a} in the numbers array = {numbers[a]}");
            }*/


         /*   int [,] coords = new int[,] { {10,3}, {20,14}, {13,19} }; 
            Console.WriteLine($"{coords[0,0]},{coords[0,1]}");*/
            
            /*int[] numbers = new int[] {1,8,5,2,10};
            for(int a=0;a<5;a++)
            {
                Console.WriteLine($"Element {a} in the numbers array = {numbers[a]}");
            }
            
            for(int i=0;i<numbers.Length;i++)
            {
                for(int j=i+1;j<numbers.Length;j++)
                {
                    if(numbers[j]<numbers[i])
                    {
                        Swap(ref numbers[i],ref numbers[j]);
                    }
                }
            }

            for(int a=0;a<5;a++)
            {
                Console.WriteLine($"Element {a} in the numbers array = {numbers[a]}");
            }*/

            int Count=100;
            
            while(Count <= 150)
            {
                Console.Write($"{Count},");
                Count++;
            }
            Console.WriteLine();
            int x = 3;
            do 
            {
                Console.WriteLine($"x= {x}");
                x++;

            }while(x<10);




        }

       /*static void Swap(ref int x, ref int y)
        {
        
            int temp = x;
            x= y;
            y= temp;
        
        }*/

    }
}
