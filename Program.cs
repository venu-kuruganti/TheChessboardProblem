namespace TheChessboardProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the chessboard problem...");

            int i = 1;
            double j = 1;

            while (i <= 64)
            {

                Console.Write("{0}\t", j.ToString());

                j *= 2;

                if (i%8==0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }

                i++;
            }//End of while

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}