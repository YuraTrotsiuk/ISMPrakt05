using ArrayLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            int n,maxEvenElement,indexMaxElement,maxAbsElement, sumIndexPositiveElement, nUnpairedElement;
            long sumNegElement, dobElementEvenIndex;
            Console.Write("Введіть кількість елементів масиву:");
            bool isOk = int.TryParse(Console.ReadLine(), out n);
            if (isOk == true)
            {
                int[] arr = new int[n];
                ArrayLibrary.Array.FillArrayByRandomValue(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i],4}");
                    if ((i + 1) % 10 == 0)
                    {
                        Console.WriteLine("");
                    }
                }

                Console.WriteLine("");
                sumNegElement = ArrayLibrary.Array.SumNegElement(arr);
                Console.WriteLine($"Сума від'ємних елементів:{sumNegElement}");
                
                maxEvenElement = ArrayLibrary.Array.MaxEvenElement(arr);
                Console.WriteLine($"Максимальний серед парних елементів:{maxEvenElement}");
                
                dobElementEvenIndex = ArrayLibrary.Array.DobElementEvenIndex(arr);
                Console.WriteLine($"Добуток елементів масиву,що мають парні індекси:{dobElementEvenIndex}");
                
                indexMaxElement = ArrayLibrary.Array.IndexMaxElement(arr);              
                Console.WriteLine($"Індекс максимального елемента:{indexMaxElement}");
                
                maxAbsElement = ArrayLibrary.Array.MaxAbsElement(arr);               
                Console.WriteLine($"Максимальний за модулем елемент:{maxAbsElement}, його модуль:{Math.Abs(maxAbsElement)}");
                
                sumIndexPositiveElement = ArrayLibrary.Array.SumIndexPositiveElement(arr);
                Console.WriteLine($"Сума індексів додатних елементів:{sumIndexPositiveElement}");
                
                nUnpairedElement = ArrayLibrary.Array.NUnpairedElement(arr);
                Console.WriteLine($"Кількість непарних елементів:{nUnpairedElement}");

                Console.ReadKey();
            }
            else Console.Write("Помилка!");
                 Console.ReadKey();
        }
    }
}
