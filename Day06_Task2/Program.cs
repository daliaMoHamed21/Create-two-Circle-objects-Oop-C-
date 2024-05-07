namespace Day06_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Circle objects 
            Circle circle1 = createCircle();
            Circle circle2 = createCircle();

            // Calculate and display the area and perimeter 

            printCircle(circle1);
            printCircle(circle2);
        }
        static Circle createCircle()
        {
            Console.Write("Enter the radius of the circle: \n");
            double radius = double.Parse(Console.ReadLine());


            return new Circle(radius);
        }

        static void printCircle(Circle circle)
        {
            Console.WriteLine($"Circle with radius : {circle.Radius}");
            Console.WriteLine($"The perimeter of circle : {circle.CalcPerimeter()}");
            Console.WriteLine($"The area of circle : {circle.CalcArea()}");


        }
    }
    class Circle
    {
        private double radius; // Private field for radius

        // property for reduis
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                    radius = value;

                else
                    Console.WriteLine("Radius cannot be negative.");
            }
        }

        // Property for PI 
        public double PI { get; } = Math.PI;

        // Param Constructor to intialize reduis
        public Circle(double radius)
        {
            Radius = radius;

        }


        // Method to calculate the perimeter 
        public double CalcPerimeter()
        {
            return 2 * PI * Radius;
        }

        // Method to calculate the area of the circle
        public double CalcArea()
        {
            return PI * Math.Pow(Radius, 2);
        }

    }

}