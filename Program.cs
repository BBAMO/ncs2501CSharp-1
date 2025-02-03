internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] str1 = new string[]{"We", "are", "the", "world!"};
        string[] str2 = new string[]{"com", "b", "d", "p", "c"};
        int[] intarray = new int[]{12, 4, 15, 46, 38, -2, 15};
        string str = "bus";
        
       Console.WriteLine(sol.Solution0203(intarray));
        //Util.PrintIntArray(sol.Solution0131(intarray));

        //Sample sam = new Sample();
        //foreach (int num in sam.GetNumber())
        {
            //Console.WriteLine(num);
        }

        //Util.MakeLotto();
        
    }
    
}