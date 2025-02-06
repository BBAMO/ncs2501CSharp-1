using System.Reflection.Metadata;

public class MyCustomer
{
    // field: 되도록 private으로
    //public long yearmoney;
    private long yearmoney;
    private string name;
    private int age;
    // event
    public event EventHandler NameChanged;
    // 생성자(Constructor)
    public MyCustomer()
    {
        name = string.Empty;
        age = -1;
    }
    public MyCustomer(int val) // 파라미터 부여 시
    {
        name = string.Empty;
        age = val;
    }
    // 속성(property)
    public string Name
    {
        get {return this.name;}
        set
        {
            if (this.name != value)
            {
                this.name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, EventArgs.Empty);
                }
            }
        }
    }
        /*
        public int Age
        {
            get {return this.age;}
            set {this.age = value;}
        }
        */
        // 다음과 같이 생략 가능
        
        public int Age { get; set; }

        // 메서드(method)
        public string GetCustomerData()
        {
            string data = string.Format("Name: {0} (Age: {1})",
                            this.Name, this.age);
            return data;
        }

        public void SetYearMoney(long val)
        {
            if (val < 0)
            {
                Console.WriteLine($"음수는 안 됩니다.");
            }
            else
            {
            yearmoney = val;
            }
        }
    }
