namespace Homework6
{
    class program
    {
        static void Main(string[] args)
        {
            // #region N1 
            // // N1 - ლუწი და კენტი რიცხვების მასივი
            // Console.WriteLine("Enter a length of array");
            // var n = Convert.ToInt32(Console.ReadLine());
            // int[] array = new int[n];
            // int even = 0;
            // int odd = 0;
            //
            //
            // for (int i = 0; i < n; i++)
            // {
            //     array[i] = Convert.ToInt32(Console.ReadLine());
            //     if (array[i] % 2 == 0)
            //     {
            //         even++;
            //     }
            //     else
            //     {
            //         odd++;
            //     }
            //
            // }
            //
            // int[] evenarray = new int[even];
            // int[] oddarray = new int[odd];
            // int evenindex = 0;
            // int oddindex = 0;
            //
            // for (int i = 0; i < n; i++)
            // {
            //     if (array[i] % 2 == 0)
            //     {
            //         evenarray[evenindex] = array[i];
            //         evenindex++;
            //     }
            //     else
            //     {
            //         oddarray[oddindex] = array[i];
            //         oddindex++;
            //     }
            //
            // }
            //
            // Console.Write("Evens: ");
            // for (int i = 0; i < even; i++)
            // {
            //     Console.Write(evenarray[i] + " ");
            // }
            //
            // Console.WriteLine();
            //
            // Console.Write("Odds: ");
            // for (int i = 0; i < odd; i++)
            // {
            //     Console.Write(oddarray[i] + " ");
            // }
            //
            // Console.WriteLine();
            //
            // #endregion

            //
            // #region N3
            // // N3- მასივში ელემენტების დათვლა
            //
            // Console.WriteLine("Enter a length of array");
            // int n = Convert.ToInt32(Console.ReadLine());
            // int[] array = new int[n];
            //
            // for (int i = 0; i < n; i++)
            // {
            //     array[i] = Convert.ToInt32(Console.ReadLine());
            // }
            //
            // var grouped = array.GroupBy(x => x);
            // foreach (var group in grouped)
            // {
            //     int element = group.Key;     // რიცხვი (მაგ: 1, 2 ან 3)
            //     int count = group.Count();   // რამდენჯერ შეგვხვდა ეს რიცხვი
            //     int sum = group.Sum();       // ამ რიცხვების ჯამი (მაგ: 1 + 1 = 2)
            //
            //     Console.WriteLine($"{element} appears {count} times sum {sum}");
            // }
            // #endregion
            //
            
            #region N4
            // N4 - top n participants
            
            int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Enter N (how many top results you want to see):");
            int n = Convert.ToInt32(Console.ReadLine());


            var topResults = scores.OrderByDescending(x => x).Take(n).Reverse();

            Console.Write("Output: ");
            foreach (var score in topResults)
            {
                Console.Write(score + " ");
            }
            Console.WriteLine();
            #endregion
        }
    }
}