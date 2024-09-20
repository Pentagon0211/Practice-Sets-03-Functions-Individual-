namespace Practice_Sets__03__Functions1;

class Program
{
    public static double triangle(double a, double b, double c)
    {
        //s
        double s = (a + b + c) / 2;
        //formula
        double Area = s *  (s - a ) * (s - b) * (s - c);
        //sqr
        double triangleArea = Math.Sqrt(Area);
        //return
        return  (double)triangleArea;
    }

    static void Main(string[] args)

    {
        while (true)
        {



            Program p = new Program();
            // input
            Console.WriteLine("Enter the length of the triangle to find the area. ");
            
            Console.Write("Enter lenght of A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter lenght of B :");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter lenght of C: ");
            double c = double.Parse(Console.ReadLine());
            //output
            double area = triangle(a, b, c);
            Console.WriteLine($"The area is {area}");

        }

    }
}