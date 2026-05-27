namespace  Homework5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // ნომერი 1 - 5ის ჯერადები
            Console.WriteLine("Enter a number: ");
            var f = 5;
            var input = Convert.ToInt32(Console.ReadLine());
            
            if (input % f == 0) {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }
            
            // N2 - ჯამი, სხვაობა, ნამრავლი, განაყოფი
            Console.WriteLine("Enter a 1st number: ");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a 2nd number: ");
            var y = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("sum is: " + (x + y));
            Console.WriteLine("mul is " + (x * y));
            if (x > y) {
                Console.WriteLine("sub is " + (x - y));
                if (y == 0)
                {
                    Console.WriteLine("Not Allowed To Divide By Zero");
                }
                else
                {
                    Console.WriteLine("div is " + Math.Round((x / y), 2));
                }
            }
            else
            {
                Console.WriteLine("sub is " + (y - x));
                if (x == 0)
                {
                    Console.WriteLine("Not Allowed To Divide By Zero");
                }
                else
                {
                    Console.WriteLine("div is " + Math.Round((y / x), 2));
                }
            
            }
            
            
            // N3 - გაცვლა
            Console.WriteLine("Enter a 1st number: ");
            int a = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter a 2nd number: ");
            int b = int.Parse(Console.ReadLine());
            
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("1st number bocame: " + a );
            Console.WriteLine("2nd number bocame: " + b);
            
            
            // N4 - გამრავალების ტაბულა
            
            Console.WriteLine("Enter a number: ");
            int m = int.Parse(Console.ReadLine());
            int nine = 9 + 1;
            
            for (int i = 1; i < nine; i++)
            {
                Console.WriteLine($" {m} * {i} = " + i * m);
            }
            
            
            
            // N5 - ლუწები n-მდე
            
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i * i);
                }
            }
            
        }
    }
}