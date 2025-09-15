namespace BMIcalculator
{
    internal class Program
    {
        static double CalculateBMI(double weight, double height, string unit = "metric")
        {
            if (unit == "metric")
            {
                return weight / (height * height);
            }
            else if (unit == "imperial")
            {
                return (weight / (height * height)) * 703;
            }
            else
            {
                Console.WriteLine("Okänd enhet, returnerar 0");
                return 0;
            }
        }
        static void Main(string[] args)
        {
          Console.Write("Ange din vikt i kg: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Ange din längd i meter: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Ange enhet (metric/imperial), default metric: ");
            string unit = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(unit))
            {
                unit = "metric";
            }

            //Beräkna BMI
            double bmi = CalculateBMI(weight, height, unit);
            Console.WriteLine($"Ditt BMI är: {bmi:F2}");

            //Visa även med olika argumentordning för demonstration
            double bmiNamed1 = CalculateBMI(height: height, weight: weight, unit: unit);
            Console.WriteLine($"BMI med namngivna argument (vikt först): {bmiNamed1:F2}"); 

            double bmiNamed2 = CalculateBMI(height: height, weight: weight, unit: unit);
            Console.WriteLine($"BMI med namngivna argument (längd först): {bmiNamed2:F2}");
        }
    }
}
