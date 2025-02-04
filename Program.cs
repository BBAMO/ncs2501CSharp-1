internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] str1 = new string[]{"We", "are", "the", "world!"};
        string[] str2 = new string[]{"com", "b", "d", "p", "c"};
        int[] intarray = new int[]{0, 1, 0, 10, 0, 1, 0, 10, 0, -1, -2, -1};
        string str = "wsdawsdassw";
        
       Console.WriteLine(sol.Solution02042(intarray));
        //Util.PrintIntArray(sol.Solution0131(intarray));

        //Sample sam = new Sample();
        //foreach (int num in sam.GetNumber())
        {
            //Console.WriteLine(num);
        }

        //Util.MakeLotto();
        
    }
    
}