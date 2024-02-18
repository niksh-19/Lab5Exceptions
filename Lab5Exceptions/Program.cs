namespace Lab5Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle1 = new Circle(5);
                Console.WriteLine(circle1.ToString());

                Circle circle2 = new Circle(-3);
                Console.WriteLine(circle2.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Circle circle3 = new Circle(0);
                Console.WriteLine(circle3.ToString());
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
