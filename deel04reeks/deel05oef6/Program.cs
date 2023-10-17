namespace deel05oef6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char operatorInvoer = ' ';
            int resultaat = 0;
            int getal = 0;

            //loop over deze tot operator is = 
            do
            {
                //vraag eerste nummer 
                getal = int.Parse(Console.ReadLine());

                //vraag operator
                operatorInvoer = char.Parse(Console.ReadLine());
                //vraag twede nummer 
                if (operatorInvoer == '+')
                {
                    resultaat = getal + resultaat;
                }
                else if (operatorInvoer == '-')
                {
                    resultaat = getal - resultaat;

                }
            } while (operatorInvoer != '=');

            Console.WriteLine(resultaat);
        }
    }
}