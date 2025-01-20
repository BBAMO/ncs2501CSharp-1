class CSVar
{
    //field(필드): 전역 변수
    int globalVar; //=0; 초기값을 주는 습관을 들이자
    const int MAX = 1024;

    public void Method1()
    {
        //로컬(지역) 변수
        int localVar;

        //아래 할당이 없으면 에러 발생
        localVar = 100;

        Console.WriteLine(globalVar);
        Console.WriteLine(localVar);
    }
}