using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    { 
        static void palindrome()
        {
            int num, rem, sum = 0, temp;
            //clrscr();    
            Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
            Console.Write("\n Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10; //for getting remainder by dividing with 10    
                num = num / 10; //for getting quotient by dividing with 10    
                sum = sum * 10 + rem;
                /*multiplying the sum with 10 and adding  
                remainder*/
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            if (temp == sum) //checking whether the reversed number is equal to entered number    
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();
        }

        static public void merge()
        {

            int i = 0;
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            Console.WriteLine("Enter elements of ARR1: ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]:");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Arr1 Elements:");
            foreach (int ele in arr1)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("Enter the elements of ARR2:");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]:");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Arr2 Elements:");
            foreach (int ele in arr2)
            {
                Console.WriteLine(ele);
            }
            var arr3 = arr1.Union(arr2).ToArray();
            Console.WriteLine("Elements of Merged Array:");
            foreach (int ele in arr3)
            {
                Console.WriteLine(ele);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            palindrome();
            merge();

            Employee e1 = new Employee(45, "Shubham", 100000);
            e1.display();

            //program to handle exception

            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            Console.ReadLine();

        }
    }
}
