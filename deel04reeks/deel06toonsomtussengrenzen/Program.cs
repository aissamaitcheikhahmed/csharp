namespace deel06toonsomtussengrenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string index1Alstext = Console.ReadLine();
            int index1 = int.Parse(index1Alstext);
            string index2Alstext = Console.ReadLine();
            int index2 = int.Parse(index2Alstext);
            int som = 0;
            for ( index1++; index1 < index2  ; index1++) {
                if (index1+1 < index2) { 
                    Console.Write(index1 + "+");
                }else Console.Write(index1);//om de "+" niet te tonen .
                som = index1 + som;
                
            
            }
            Console.WriteLine("=" + som); 
        }
    }
}