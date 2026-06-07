namespace Homework7
{
    class program
    {
        static void Main(string[] args)
        {
            // N1 - წრეწირზე ჩახაზული და შემოხაზული კვადრატების ფართობების სხვაობა
            Console.WriteLine("Enter radius:");
            var r = Convert.ToInt32(Console.ReadLine());
            var bigspace = 4 * r * r;
            var smallspace = 2 * r * r;
            var difference = bigspace - smallspace; // it is 2r^2
            Console.WriteLine($"Difference is {difference}");
            
            //
            // // N2 - ჯეკპოტი
            // Console.WriteLine("Enter the elements of the sequence");
            // var input = Console.ReadLine();
            // string str = "";
            // var length = 0;
            //
            // for (int i = 0; i < input.Length; i++)
            // {
            //     if (input[i] == ',' || input[i] == ' ')
            //     {
            //         break;
            //     }
            //     length++;
            // }
            //
            // for (int i = 0; i < input.Length; i++)
            // {
            //
            //     if (input[i] != ' ')
            //     {
            //         str += input[i];
            //     }
            // }
            //
            // if (str.Length == 0 || length == 0)
            // {
            //     Console.WriteLine("No");
            //     return;
            // }
            //
            // string element = str.Substring(0, length);
            // bool check = true;
            // for (int i = 0; i < str.Length; i = i + length + 1)
            // {
            //     if (i + length > str.Length)
            //     {
            //                     check = false;
            //                     break;
            //     }
            //     
            //     if (!element.Equals(str.Substring(i, length)))
            //     {
            //         check = false;
            //         break;
            //     } 
            //     
            // }
            //
            // if (check)
            // {
            //     Console.WriteLine("Yes");
            // }
            // else
            // {
            //     Console.WriteLine("No");
            // }
            //
            //
            //
            // //N3 -ფეხბურთის ქულები
            // var win = 3;
            // var draw = 1;
            // var lose = 0;
            // Console.WriteLine("Enter a number of wins: ");
            // int wins = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter a number of draws: ");
            // int draws = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter a number of losses: ");
            // int losses = int.Parse(Console.ReadLine());
            // Console.WriteLine(win * wins + draw * draws + lose * losses);
            //
            //
            //
            // //N4 - თანამშრომლის შემოსავალი
            // Console.WriteLine("Enter the hours");
            // string input = Console.ReadLine();
            // string[] splitInput = input.Split(',');
            // int[] array = new int[7];
            // int sum = 0;
            // int salaryinhour = 10;
            // int overtimesalary = 15;
            // int weekendsalary = 20;
            //
            //
            // for (int i = 0; i < 7; i++)
            // {
            //     array[i] = int.Parse(splitInput[i].Trim());
            //     if (i <= 4)
            //     {
            //         if (array[i] <= 8)
            //         {
            //             sum = sum + array[i] * salaryinhour;
            //         }
            //         else 
            //         {
            //             sum = sum + 8 * salaryinhour + overtimesalary * (array[i] - 8);
            //         }
            //     }
            //     else
            //     {
            //         sum = sum + array[i] * weekendsalary;
            //     }
            // }
            // Console.WriteLine(sum);
            //
            //
            //
            // // N5 - მარათონის პროგრესი
            //
            // Console.WriteLine("Enter the numbers");
            // string input = Console.ReadLine();
            // if (string.IsNullOrWhiteSpace(input))
            // {
            //     Console.WriteLine(0);
            //     return; 
            // }
            // string[] splitinput = input.Split(',');
            // int[] progressarray = new int[splitinput.Length];
            // int progress = 0;
            //
            // for (int i = 0; i < splitinput.Length; i++)
            // {
            //     progressarray[i] = int.Parse(splitinput[i].Trim());
            // }
            //
            // for (int i = 0; i < progressarray.Length - 1; i++)
            // {
            //     if (progressarray[i + 1] > progressarray[i])
            //     {
            //         progress = progress + 1;
            //     }
            // }
            //
            // Console.WriteLine(progress);
            //
            //
            // // N6 - N-ზე მეტი სიგრძის ელემენტები ინფუთიდან
            //
            // Console.WriteLine("Enter the strings: ");
            // string input = Console.ReadLine();
            //
            // Console.WriteLine("Enter N: ");
            // int n = int.Parse(Console.ReadLine());
            //
            // string[] words = input.Split(',').Select(x => x.Trim()).ToArray();
            // var result = words.Where(x => x.Length >= n).ToList();
            //
            // if (result.Count > 0)
            // {
            //     Console.WriteLine(string.Join(", ", result));
            // }else
            // {
            //     Console.WriteLine("No elements found");
            // }
            //
            //
            //
            
            
        }
    }
}
