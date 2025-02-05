using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

class Sample
{
    
    public IEnumerable<int> GetNumber()
    {
        yield return 10; // 첫 번째 루프에서 리턴
        yield return 20; // 두 번째 루프에서 리턴
        yield return 30; // 세 번째 루프에서 리턴
    }

    
    public void DoWhileSample()
    {
        int i = 1;
        Console.Write("Do While:");
        do
        {
            Console.Write($" {i}");
            i++;
        }while (i < 10);
        Console.WriteLine();

        i = 1;

        Console.Write("While:");
        while(i < 10)
        {
            Console.Write($" {i}");
            i++;
        }
        Console.WriteLine();
    }
    public void LoopSample()
    {
        const int MAX_LOOP = 10;
        for (int i = MAX_LOOP; i > 0; i--)
        {
            //Console.WriteLine($"Loop{i}");
        }
        //Console.WriteLine();

        //While
        int ii = MAX_LOOP;
        while (ii > 0)
        {
            //Console.Write($"While{ii},");
            ii--;
        }

        string[] array = new string[] {"AB", "CD", "EF"};
        foreach (var s in array)
        {
            //Console.WriteLine(s);
        }

        string[,,] arr = new string[,,]
        {
            {{"1","2"},{"11","22"}},
            {{"3","4"},{"33","44"}}
        };
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    //Console.Write(arr[i, j, k]);
                }
            }
        }
        //Console.WriteLine();
        foreach (var item in arr)
        {
            //Console.Write($"{item},");
        }
    }
    static bool verbose = false;
    static bool continueOnError = false;
    static bool logging = false;
    public void SwitchStatememt(string[] args)
    {
        string category = "딸기";
        int price = 100;
        
        switch (category)
        {
            case "사과":
                price = 1000;
                break;
            case "딸기":
                price = 1100;
                break;
            case "포도":
                price = 900;
                break;
            default:
                price = 0;
                break;
        }
        /*
        if (category == "사과")
        {
            price = 1000;
        }
        else if (category == "딸기")
        {
            price = 1100;
        }
        else if (category == "포도")
        {
            price = 900;
        }
        else
        {
            price = 0;
        }
        */
        
        //Console.WriteLine($"Price: {price}");

        if (args.Length != 1)
        {
            Console.WriteLine("Usage: MyApp.exe option");
            return;
        }

        string option = args[0];
        switch (option.ToLower())
        {
            case "/v":
            case "/verbose":
                verbose = true;
                break;
            case "/c":
                continueOnError = true;
                break;
            case "/l":
                logging = true;
                break;
            default:
                Console.WriteLine($"Unknown argument: {option}");
                break;
        }
    }
    public void Operator()
    {
        // 나머지 연산자 %

        int a = (1 + 2 - 1) * (4 / 2) % 3;

        // 할당 연산자 =, +=, -=, *=, %=

        int b = 100;
        a %= 2; // a를 2로 나눈 나머지

        // 증감 연산자

        a++; // a = a + 1 / a += 1
        a--; // a = a - 1 / a -= 1

        ++a; // 순서 차이. a++ 나중에 , ++a 맨 먼저

        // 논리 연산자 &&(And), ||(Or), !(Not)

        int c = 1, d = 2;
        bool e = true;

        if((a > 1 && b < 0) || c == 1 || !e) a = 0;

        // 관계/비교 연산자 <, >, ==, !=, >=, <=

        if (a <= b) a = 0;
    
        // 비트 연산자 &(AND), |(OR), ^(XOR)
        // 비트 연산에서 &은 둘 다 1인 경우만 1이 되고, |는 둘 중에 하나라도 1인 경우 1이 되며, ^는 둘 중에 하나만 1인 경우 1이 된다.
        
        byte aa = 7;
        byte bb = (byte)((aa & 3) | 4);
        Console.WriteLine($"byte bb: {bb}");

        // Shift 연산자 >>. <<
        // << = *2, >> = /2
        int i = 2;
        i = i << 5; // i의 값을 왼쪽으로 5 비트 이동한다.
        Console.WriteLine($"2 after left Shift 5: {i}");

        // 조건 연산자 ?, ??(C# 3.0 이상만 지원, 왼쪽 값이 null일 경우 뒤의 값을 리턴)
        int val = (a>b) ? a : b;
        int? iii = null;
        i = iii ?? 0;

        string s = null;
        //string ss = s ?? string.Empty;
        string ss;;
        if (s == null)
        {
            ss = string.Empty;
        }
        else
        {
            ss = s;
        }
    }
    enum City
    {
        Seoul, //0
        Daejun, //1
        Busan = 5, //5
        Jeju = 10 //10
    }

    [Flags]
    enum Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8,
    }
    public void EnumSample()
    {
        City myCity;

        // enum 타입에 값을 대입하는 방법
        myCity = City.Seoul;

        // enum을 int로 변환(casting)하는 방법
        // (int)를 앞에 지정
        int cityValue = (int) myCity;

        if (myCity == City.Seoul) // enum 값을 비교하는 방법
        {
            Console.WriteLine("Welcome to Seoul");
        }

        // OR 연산자로 다중 플래그 할당
        Border b = Border.Top | Border.Bottom;

        // & 연산자로 플래그 체크
        if ((b & Border.Top) != 0)
        {
            //HasFlag()이용 플래그 체크
            if (b.HasFlag(Border.Bottom))
            {
                // "Top, Bottom" 출력
                Console.WriteLine(b.ToString());
            }
        }
    }
    public void StringBuilderSample()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i <= 26; i++)
        {
            sb.Append((char)('A' + i));
            sb.Append(System.Environment.NewLine);
        }
        string s = sb.ToString();
        Console.WriteLine(s);
    }
    public void StringSample()
    {
        string s1 = "C#";
        string s2 = "Programming";

        //char c1 = 'A';
        //char c2 = 'B';

        string s3 = s1 + " " + s2;
        //Console.WriteLine("String: {1} {0}", s3, 10);

        string s3substring = s3.Substring(1, 5);
        //Console.WriteLine("Substring: {0}", s3substring);

        string s = "C# Studies";
        //문자열을 배열 인덱스로 한문자 엑세스
        for (int i = 0; i < s.Length; i++)
        {
            //Console.WriteLine("{0}: {1}", i, s[i]);
            //Console.WriteLine($"{i}: {s[i]}");
        }
        //문자열을 문자배열로 변환
        string str = "Hello";
        char[] charArray = str.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            //Console.WriteLine(charArray[i]);
        }
        //문자배열을 문자열로 변환
        char[] charArray2 = {'A','B','C','D',};
        s = new string(charArray2);
        //Console.WriteLine(s);
        //문자 연산
        char c1 = 'A';
        char c2 = (char)(c1 + 3);
        //Console.WriteLine(c2); //D 출력

    }
    public void Dictionary()
    {
        
        //var
        var dic = new Dictionary<int, int>(); // var로 간소화

        //hashtable
        Hashtable ht = new Hashtable();
        ht.Add("irina", "Irina Sp");
        ht.Add("tom", "Tom Cr");

        if (ht.Contains("tom"))
        {
           //Console.WriteLine(ht["tom"]);
        }

        // dictionary
        Dictionary<int, string> emp = new Dictionary<int, string>();
        emp.Add(1001, "Jane");
        emp.Add(1002, "Tom");
        emp.Add(1003, "Cindy");
        
        //Console.WriteLine("Count:" + emp.Count);

        string name = emp[1002];
        //Console.WriteLine(name);
        if (emp.ContainsKey(1004))
        {
            name = emp[1004];
           // Console.WriteLine(name);
        }
    }
    public void List()
    {
        List<int> intlist = new List<int>();
        List<char> charlist = new List<char>();
        List<float> flist = new List<float>();
        List<bool> blist = new List<bool>();
        List<string> slist = new List<string>();

        intlist.Add(0);
        intlist.Add(2);

        intlist.Remove(0);

        int val = intlist.Count;
        //Console.WriteLine("intlist의 크기:" + val);

        // linked list

        LinkedList<string> list = new LinkedList<string>();
        list.AddLast("Apple");
        list.AddLast("Banana");
        list.AddLast("Lemon");

        LinkedListNode<string> node = list.Find("Banana");
        LinkedListNode<string> newNode = new LinkedListNode<string>("Grape");

        list.AddAfter(node, newNode);

        list.ToList<string>().ForEach(p => Console.WriteLine(p));

        foreach (var item in list)
        {
            //Console.WriteLine(item);
        }
    }
}