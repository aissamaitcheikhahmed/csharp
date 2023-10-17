namespace TweeGetalenZonderMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getal 1?: ");
            int getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Getal 2?: ");
            int getal2 = int.Parse(Console.ReadLine());
            int tempGetal = 0;

            //if (invoergetal1 > invoergetal2)
            //{
            //    getal2 = invoergetal1;
            //    getal1 = invoergetal2;
            //}
            //else
            //{
            //    invoergetal1 = getal1;
            //    invoergetal2 = getal2;
            //}
            if (getal1 > getal2)
            {
                tempGetal = getal1;
                getal1 = getal2;
                getal2 = tempGetal;
            }








            do
            {
                Console.Write(getal1++ + " ");

            } while (getal1 <= getal2);
        }
    }
}