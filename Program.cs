internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] str1 = new string[]{"a", "b", "c"};
        string[] str2 = new string[]{"com", "b", "d", "p", "c"};
        int[] intarray = new int[]{};
        string str = "I love you~";
        
       Console.WriteLine(sol.Solution0122(str1, str2));
       // Util.PrintIntArray(sol.Solution0121(intarray));

        //Sample sam = new Sample();
        //sam.EnumSample();
        
    }
    
}