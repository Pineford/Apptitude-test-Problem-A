namespace Apptitude_test_Problem_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Två inmatningar som inte kan vara null eller 
            Console.WriteLine("Vänligen skriv in vinkelvärdet som kompassen står på nu");
            int number1 = int.Parse(Console.ReadLine());
            if (Console.ReadLine == null || number1 > 360 || number1 < 0)
            {
                Console.WriteLine("Vänligen fyll i giltiga nummer i fältet");
            }
            else
            {
                Console.WriteLine("Tack!");
            }
            Console.WriteLine("Vänligen skriv in det verkliga vinkelvärdet");
            int number2 = int.Parse(Console.ReadLine());
            if (Console.ReadLine == null || number2 > 360 || number2 < 0)
            {
                Console.WriteLine("Vänligen fyll i giltiga nummer i fältet");
            }
            else
            {
                Console.WriteLine("Tack!");
            }
            //Bedömer de två inmatningarna för att hitta det lägsta numret
            int distance = Math.Abs(number1 - number2);
            int posD1 = Math.Abs(0 + distance);
            int negD2 = Math.Abs(distance - 360);
            int minDistance = Math.Min(posD1, negD2);

            if (minDistance == 180)
            {
                Console.WriteLine("180");
            }
            //För att se till att få ett negativt resultat vid motsolsriktning så behövs följande else if sats
            else if (minDistance == negD2)
            {
                Console.WriteLine(minDistance * -1);
            }
            else
            {
                Console.WriteLine(minDistance);
            }
        }
    }
}