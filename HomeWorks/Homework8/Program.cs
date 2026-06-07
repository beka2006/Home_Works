using System.Linq;
namespace Homework8
{
    class Program
    {
        static void Main(string[] args)       
        {
            // N1 - n-ური ხარისხის რიცხვები (ა, ბ) შუალედში
            Console.Write("Enter a (min): ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Enter b (max): ");
            double b = double.Parse(Console.ReadLine());
            
            Console.Write("Enter n (power): ");
            int n = int.Parse(Console.ReadLine());
            
            int result = CountNumbersInInterval(a, b, n);
            Console.WriteLine($"Output: {result}");
            
            
            // N2 
            Console.Write("Enter socks string: ");
            string input = Console.ReadLine();
            
            int pairCount = CountSockPairs(input);
            Console.WriteLine($"Output: {pairCount}");
            
            
            //N3 - სტრინგების  საერთო  suffix 
            
            Console.Write("Enter a string: ");
            string string1 = Console.ReadLine();
            
            Console.Write("Enter a string: ");
            string string2 = Console.ReadLine();
            
            string resultstring = GetLongestCommonSuffix(string1, string2);
            Console.WriteLine($"Output: {resultstring}");
            
            
            // N4 - ჯენერიკ ტიპის ლისტი - uppercase, sum, bool
            
            //  რიცხვების ლისტი
            List<int> intList = new List<int> { 5, 5 };
            ProcessList(intList); 
            
            Console.WriteLine();
            
            // სტრინგების ლისტი
            List<string> stringList = new List<string> { "test", "random", "programming", "word" };
            ProcessList(stringList); 
            
            Console.WriteLine();
            
            // ბულეანების ლისტი
            List<bool> boolList = new List<bool> { true, false, true, false, true, false, false };
            ProcessList(boolList); 
            
            
            
            // N5 - რეკურსია -  დაწერეთ ფუნქცია რომელიც დაბეჭდავს რიცხვში შემავალ ყოველ სიმბოლოს
            
            Console.Write("Enter a number: ");
            int anynumber = int.Parse(Console.ReadLine());
            
            PrintDigits(anynumber);
            Console.WriteLine(); 
            
            
            //N6 - შეიცავს თუ არა მასივი დუბლიკატებს
        
            int[] nums1 = { 1, 2, 3, 1 };
            Console.WriteLine($"Nums1 contains duplicates: {ContainsDuplicate(nums1)}"); 

            int[] nums2 = { 1, 2, 3, 4 };
            Console.WriteLine($"Nums2 contains duplicates: {ContainsDuplicate(nums2)}"); 
        }
        
        
        // N1-ის მეთოდი
        static int CountNumbersInInterval(double a, double b, int n)
        {
            int a1 = (int)Math.Ceiling(Math.Pow(a, 1.0 / n));
            int b1 = (int)Math.Floor(Math.Pow(b, 1.0 / n));

            if (a1 > b1)
            {
                return 0;
            }

            return b1 - a1 + 1;
        }
        
        // N2-ის მეთოდი
        static int CountSockPairs(string socks)
        {
            Dictionary<char, int> sockCounts = new Dictionary<char, int>();

            foreach (char s in socks)
            {
                if (sockCounts.ContainsKey(s))
                {
                    sockCounts[s]++;
                }
                else
                {
                    sockCounts[s] = 1;
                }
            }

            int totalPairs = 0;

            foreach (var count in sockCounts.Values)
            {
                totalPairs += count / 2; 
            }

            return totalPairs;
        }
        
        // N3-ის მეთოდი
        static string GetLongestCommonSuffix(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                return "No intersection found";
            }

            int i = str1.Length - 1;
            int j = str2.Length - 1;

            int suffixLength = 0;

            while (i >= 0 && j >= 0 && str1[i] == str2[j])
            {
                suffixLength++;
                i--;
                j--;
            }

            if (suffixLength == 0)
            {
                return "No intersection found";
            }

            return str1.Substring(str1.Length - suffixLength);
        }
        
        // N4- ის ოვერლოადინგ მეთოდები 
        
        // მეთოდი ინტების ლისტისთვის
        static void ProcessList(List<int> intList)
        {
            if (intList == null || intList.Count == 0) return;

            int sum = intList.Sum();
            Console.WriteLine($"Sum: {sum}");
        }

        // 2. მეთოდი სტრინგების ლისტისთვის 
        static void ProcessList(List<string> stringList)
        {
            if (stringList == null || stringList.Count == 0) return;

            foreach (var str in stringList)
            {
                Console.WriteLine(str.ToUpper());
            }
        }

        // 3. მეთოდი ბულეანების ლისტისთვის 
        static void ProcessList(List<bool> boolList)
        {
            if (boolList == null || boolList.Count == 0) return;

            bool first = boolList.First();
            bool last = boolList.Last();
        
            int middleIndex = boolList.Count / 2;
            bool middle = boolList[middleIndex];

            Console.WriteLine($"First Element is {first}");
            Console.WriteLine($"Last Element is {last}");
            Console.WriteLine($"Middle Element is {middle}");
        }
        
        // N5 -ის მეთოდი
        static void PrintDigits(int n)
        {
            if (n < 10)
            {
                Console.Write(n);
                return;
            }

            PrintDigits(n / 10);

            Console.Write(" - " + (n % 10));
        }
        
        //N6 -ის მეთოდი
        static bool ContainsDuplicate(int[] nums)
        {
            // თუ ორიგინალი მასივის სიგრძე არ უდრის უნიკალური ელემენტების სიგრძეს ესეიგი დუბლიკატი არსებობს 
            return nums.Length != nums.Distinct().Count();
        }
    }
}