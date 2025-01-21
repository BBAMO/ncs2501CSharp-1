internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] intarray = new int[]{1, 2, 3, 4, 5};
        string str = "I love you~";
        
       //Console.WriteLine(sol.Solution0121(intarray));
        Util.PrintIntArray(sol.Solution0121(intarray));

        //Sample sam = new Sample();
        //sam.StringBuilderSample();
        //sam.RandomSum();
        //sam.List();
    }
    
}