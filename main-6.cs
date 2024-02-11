/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        TCircle circle = null; // Об'єкт круга, який буде створено пізніше
        TSphere sphere = null; // Об'єкт сфери, який буде створено пізніше

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Create a circle object");
            Console.WriteLine("2. Print the data about the circle object");
            Console.WriteLine("3. Determine the area of a circle (bounded by a circle) and the area of a sector");
            Console.WriteLine("4. Determine the length of the circle");
            Console.WriteLine("5. Compare with another circle");
            Console.WriteLine("6. Operator overload for the wheel");
            Console.WriteLine("7. Create a sphere object");
            Console.WriteLine("8. Print data about the sphere object");
            Console.WriteLine("9. Compare with another industry");
            Console.WriteLine("10. Operator overload for the industry");
            Console.WriteLine("11. Exit the program");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nCreate a circle object:");
                    circle = CreateCircle();
                    break;
                case "2":
                    DisplayCircleData(circle);
                    break;
                case "3":
                    CalculateAreas(circle);
                    break;
                case "4":
                    CalculateCircumference(circle);
                    break;
                case "5":
                    CompareWithOtherCircle(circle);
                    break;
                case "6":
                    PerformOperatorOverloadingForCircle(circle);
                    break;
                case "7":
                    Console.WriteLine("\nCreating a sphere object:");
                    sphere = CreateSphere();
                    break;
                case "8":
                    DisplaySphereData(sphere);
                    break;
                case "9":
                    CompareWithOtherSphere(sphere);
                    break;
                case "10":
                    PerformOperatorOverloadingForSphere(sphere);
                    break;
                case "11":
                    Console.WriteLine("The program is complete.");
                    return;
                default:
                    Console.WriteLine("Wrong choice. Please try again.");
                    break;
            }
        }
    }

    static TCircle CreateCircle()
    {
        double radius;
        do
        {
            Console.Write("Enter the radius of the circle (greater than 0): ");
        }
        while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0);

        return new TCircle(radius);
    }

    static void DisplayCircleData(TCircle circle)
    {
        if (circle != null)
        {
            Console.WriteLine("\nData about the circle object:");
            circle.DisplayData();
        }
        else
        {
            Console.WriteLine("The circle object was not created.");
        }
    }

    static void CalculateAreas(TCircle circle)
    {
        if (circle != null)
        {
            Console.Write("\nEnter the angle of the circle sector in degrees: ");
            double angle;
            while (!double.TryParse(Console.ReadLine(), out angle) || angle <= 0)
            {
                Console.WriteLine("Incorrect data. Please enter a positive numeric value for the angle (must also be greater than 0).");
                Console.Write("Enter the angle of the circle sector in degrees: ");
            }
            Console.WriteLine($"The area of a circle (bounded by a circle): {circle.CalculateCircleBoundedArea(angle)}");
            Console.WriteLine($"Sector area: {circle.CalculateSectorArea(angle)}");
        }
        else
        {
            Console.WriteLine("First, create a circle object.");
        }
    }

    static void CalculateCircumference(TCircle circle)
    {
        if (circle != null)
        {
            Console.WriteLine($"\nThe length of the circle: {circle.CalculateCircumference()}");
        }
        else
        {
            Console.WriteLine("First, create a circle object.");
        }
    }

    static void CompareWithOtherCircle(TCircle circle)
    {
        if (circle != null)
        {
            TCircle otherCircle = CreateCircle();
            string comparisonResult = circle.CompareTo(otherCircle);
            Console.WriteLine($"The result of the comparison with another circle: {comparisonResult}");
        }
        else
        {
            Console.WriteLine("First, create a circle object.");
        }
    }

    static void PerformOperatorOverloadingForCircle(TCircle circle)
    {
        if (circle != null)
        {
            TCircle otherCircle = CreateCircle();

            TCircle sumCircle = circle + otherCircle;
            Console.WriteLine("\nsum of radii (operator +):");
            sumCircle.DisplayData();

            TCircle diffCircle = circle - otherCircle;
            Console.WriteLine("\nRadius difference (operator -):");
            diffCircle.DisplayData();

            double multiplier;
            Console.Write("Enter a multiplier to multiply by the radius: ");
            while (!double.TryParse(Console.ReadLine(), out multiplier))
            {
                Console.WriteLine("Incorrect data. Please enter a numeric value for the multiplier.");
                Console.Write("Enter a multiplier to multiply by the radius: ");
            }
            TCircle scaledCircle = circle * multiplier;
            Console.WriteLine($"\nThe circle multiplied by {multiplier} (operator *):");
            scaledCircle.DisplayData();
        }
        else
        {
            Console.WriteLine("First, create a circle object.");
        }
    }

    static TSphere CreateSphere()
    {
        double radius;
        do
        {
            Console.Write("Enter the radius of the sphere (greater than 0): ");
        }
        while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0);

        return new TSphere(radius);
    }

    static void DisplaySphereData(TSphere sphere)
    {
        if (sphere != null)
        {
            Console.WriteLine("\nData about the sphere object:");
            sphere.DisplayData();
        }
        else
        {
            Console.WriteLine("The sphere object was not created.");
        }
    }

    static void CompareWithOtherSphere(TSphere sphere)
    {
        if (sphere != null)
        {
            TSphere otherSphere = CreateSphere();
            string comparisonResult = sphere.CompareTo(otherSphere);
            Console.WriteLine($"The result of a comparison with another industry: {comparisonResult}");
        }
        else
        {
            Console.WriteLine("First, create a sphere object.");
        }
    }

    static void PerformOperatorOverloadingForSphere(TSphere sphere)
    {
        if (sphere != null)
        {
            TSphere otherSphere = CreateSphere();

            TSphere sumSphere = sphere + otherSphere;
            Console.WriteLine("\nSum of radius (+ operator):");
            sumSphere.DisplayData();

            TSphere diffSphere = sphere - otherSphere;
            Console.WriteLine("\nRadius difference (operator -):");
            diffSphere.DisplayData();

            double multiplier;
            Console.Write("Enter a multiplier to multiply by the radius: ");
            while (!double.TryParse(Console.ReadLine(), out multiplier))
            {
                Console.WriteLine("Incorrect data. Please enter a numeric value for the multiplier.");
                Console.Write("Enter a multiplier to multiply by the radius: ");
            }
            TSphere scaledSphere = sphere * multiplier;
            Console.WriteLine($"\nThe sphere multiplied by {multiplier} (operator *):");
            scaledSphere.DisplayData();
        }
        else
        {
            Console.WriteLine("First, create a sphere object.");
        }
    }
}

class TCircle
{
    protected double radius;

    public TCircle()
    {
        radius = 0;
    }

    public TCircle(double r)
    {
        if (r >= 0)
            radius = r;
        else
        {
            Console.WriteLine("The radius cannot be negative. The radius will be set to zero.");
            radius = 0;
        }
    }

    public virtual void InputData()
    {
        bool validInput = false;
        while (!validInput)
        {
            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double result) && result >= 0)
            {
                radius = result;
                validInput = true;
            }
            else
            {
                Console.WriteLine("Incorrect data. Please enter a non-negative numeric value.");
            }
        }
    }

    public void DisplayData()
    {
        Console.WriteLine($"The radius of the circle: {radius}");
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    public string CompareTo(TCircle other)
    {
        int comparisonResult = radius.CompareTo(other.radius);
        if (comparisonResult > 0)
        {
            return "The first circle is larger than the second";
        }
        else if (comparisonResult < 0)
        {
            return "The second circle is larger than the first";
        }
        else
        {
            return "The circles have the same radius";
        }
    }

    public static TCircle operator +(TCircle c1, TCircle c2)
    {
        return new TCircle(c1.radius + c2.radius);
    }

    public static TCircle operator -(TCircle c1, TCircle c2)
    {
        return new TCircle(Math.Max(0, Math.Abs(c1.radius - c2.radius)));
    }

    public static TCircle operator *(TCircle c, double multiplier)
    {
        return new TCircle(c.radius * multiplier);
    }

    public double CalculateSectorArea(double angleInDegrees)
    {
        double angleInRadians = angleInDegrees * Math.PI / 180;
        return 0.5 * radius * radius * angleInRadians;
    }

    public double CalculateCircleBoundedArea(double angleInDegrees)
    {
        double circleArea = CalculateArea();
        double sectorArea = CalculateSectorArea(angleInDegrees);
        return circleArea - sectorArea;
    }
}

class TSphere : TCircle
{
    public TSphere() : base()
    {
    }

    public TSphere(double r) : base(r)
    {
    }

    public string CompareTo(TSphere other)
    {
        int comparisonResult = radius.CompareTo(other.radius);
        if (comparisonResult > 0)
        {
            return "The first sphere is larger than the second";
        }
        else if (comparisonResult < 0)
        {
            return "The second area is larger than the first";
        }
        else
        {
            return "The spheres have the same radius";
        }
    }

    public static TSphere operator +(TSphere s1, TSphere s2)
    {
        return new TSphere(s1.radius + s2.radius);
    }

    public static TSphere operator -(TSphere s1, TSphere s2)
    {
        return new TSphere(Math.Max(0, Math.Abs(s1.radius - s2.radius)));
    }

    public static TSphere operator *(TSphere s, double multiplier)
    {
        return new TSphere(s.radius * multiplier);
    }
}
