internal class Program
{
    struct MyPoint
    {
        public int x;
        public int y;
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] str1 = new string[]{"We", "are", "the", "world!"};
        string[] str2 = new string[]{"com", "b", "d", "p", "c"};
        int[] intarray = new int[]{12, 4, 15, 46, 38, 1, 14, 56, 32, 10};
        string str = "08540";
        
        Console.WriteLine(sol.Solution02122(3, 5));
        //Util.PrintIntArray(sol.Solution0212(intarray));

        //Sample sam = new Sample();
        //foreach (int num in sam.GetNumber())
        {
            //Console.WriteLine(num);
        }

        //MyPoint pt = new MyPoint(10, 12);
        //Console.WriteLine(pt.ToString());

        //MyCustomer myc = new MyCustomer(10);
        //MyCustomer myc2 = new MyCustomer();

        // 필드를 public으로 하면 위험 / 원치 않는 값 지정 등을 외부에서 할 수 있기 때문
        //myc.yearmoney = -1000;
        //myc.SetYearMoney(-1000);

        // 로또
        // Util.MakeLotto();
    }
    
}