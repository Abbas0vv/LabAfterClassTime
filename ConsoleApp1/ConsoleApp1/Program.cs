namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            //int number = 143;
            //int checkBox = 0;
            //int sum = 1;
            //int copyNumber = number;

            //while (copyNumber > 0)
            //{
            //    copyNumber = copyNumber / 10;
            //    checkBox++;
            //}


            //for (int i = 0; i < checkBox; i++)
            //{
            //    sum *= number % 10;
            //    number = number / 10;
            //}

            //Console.WriteLine(sum);
            #endregion

            #region task 2
            //int number = 15;
            //int checkBox = 0;
            //for (int i = 1; i < number; i++)
            //{
            //    if ((number % i) == 0)
            //    {
            //        checkBox++;
            //    }
            //}

            //if (checkBox > 2)
            //    Console.WriteLine("Murekkebdir");
            //else Console.WriteLine("Sadedir");

            #endregion

            #region task 3
            //string[] words = { "Car", "Table", "Mouse" };

            //for (int i = words.Length - 1; i >= 0 ; i--)
            //{
            //    Console.WriteLine(words[i]);
            //}
            #endregion

            #region task 4
            //int[] numbers = { 1, 2, 3 };
            //Console.Write("Eded daxil edin : ");
            //int inputNumber = int.Parse(Console.ReadLine());


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (inputNumber > numbers[i])
            //    {
            //        Console.WriteLine(true);
            //        break;
            //    }
            //}
            #endregion

            #region task 5

            //string[] words = { "Car", "Table", "Mouse", "Table" };
            //for (int i = 0; i < words.Length; i++)
            //{
            //    for (int j = i; j < words.Length; j++)
            //    {
            //        if (words[i] == words[j] && i != j)
            //        {
            //            Console.WriteLine($"Birinci ({words[i]}) dayanmisdir {i} indexinde ikincisi ise {j}");
            //        }
            //    }
            //}
            #endregion

            #region task 6

            int number = 156;
            int start = 0;
            int checkBox = 1;

            while (start < number)
            {
                Console.WriteLine(start);
                start += checkBox;

                if (start <= number)
                {
                    Console.WriteLine(checkBox);
                    checkBox = checkBox + start;
                }
            }

            #endregion
        }
    }
}
