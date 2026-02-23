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
                Console.WriteLine(vettoreA[i]);
                Console.WriteLine(vettoreB[i]);
                
            
            }


        }
        static void Main(string[] args)
        {
            int[] vettoreA = new int[12];
            int[] vettoreB = new int[12];
            popolaVendite(vettoreA, vettoreB);
        }
    }
}
