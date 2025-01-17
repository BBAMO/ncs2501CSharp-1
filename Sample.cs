using System.Collections;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

class Sample
{
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
            Console.WriteLine(ht["tom"]);
        }

        // dictionary
        Dictionary<int, string> emp = new Dictionary<int, string>();
        emp.Add(1001, "Jane");
        emp.Add(1002, "Tom");
        emp.Add(1003, "Cindy");
        
        Console.WriteLine("Count:" + emp.Count);

        string name = emp[1002];
        Console.WriteLine(name);
        if (emp.ContainsKey(1004))
        {
            name = emp[1004];
            Console.WriteLine(name);
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
        Console.WriteLine("intlist의 크기:" + val);

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
            Console.WriteLine(item);
        }
    }
}