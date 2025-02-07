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
        int[] intarray = new int[]{4, 2, 6, 1, 7, 6};
        string str = "wsdawsdassw";
        
        Console.WriteLine(sol.Solution0207(intarray));
        //Util.PrintIntArray(sol.Solution0207(4, 2, 6, 1, 7, 6));

        //Sample sam = new Sample();
        //foreach (int num in sam.GetNumber())
        {
            //Console.WriteLine(num);
        }

        //Util.MakeLotto();

        //MyPoint pt = new MyPoint(10, 12);
        //Console.WriteLine(pt.ToString());

        MyCustomer myc = new MyCustomer(10);
        MyCustomer myc2 = new MyCustomer();

        // 필드를 public으로 하면 위험 / 원치 않는 값 지정 등을 외부에서 할 수 있기 때문
        //myc.yearmoney = -1000;
        //myc.SetYearMoney(-1000);
    }
    
}