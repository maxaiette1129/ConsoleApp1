namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [][] jaggedArray = new int[50][];

           Random rnd = new Random();

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = new int[rnd.Next(1,100)];
                Console.WriteLine(jaggedArray[i].Length);

                
            }
            
     

            



        }
    }
}