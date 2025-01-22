using System.Collections;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

class Sample
{
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