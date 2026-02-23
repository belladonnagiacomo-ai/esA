namespace esA
{
    internal class Program
    {
        static void popolaVendite(int[] vettoreA,  int[] vettoreB){

            Random rnd = new Random();
            for (int i = 0; i < vettoreA.Length; i++)
            {
                vettoreA[i] = rnd.Next(100, 1000);
                vettoreB[i] = 0;

                Console.WriteLine("vettoreA " + vettoreA[i]);
             
            }

            
        }
         
        static void cumulativa(int[] vettoreA, int[] vettoreB)
        {
            popolaVendite(vettoreA, vettoreB);
            Console.WriteLine("---------------------");
            for (int i = 0; i < vettoreB.Length; i++)
            {
                if (i == 0)
                {
                    vettoreB[i] = vettoreA[i];
                }
                if (i > 0)
                {
                    vettoreB[i] = vettoreA[i] + vettoreB[i - 1];
                }
                Console.WriteLine("vettoreB " + vettoreB[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] vettoreA = new int[12];
            int[] vettoreB = new int[12];
            cumulativa(vettoreA, vettoreB);
        }
    }
}
