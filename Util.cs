using System.Runtime.InteropServices;

class Util
{
    /// <summary>
    /// 정수 배열의 내용을 출력
    /// </summary>
    /// <param name="intarray">출력할 배열</param>
    public static void PrintIntArray(int[] intarray)
    {
        Console.Write("{");
        for (int i = 0; i < intarray.Length; i++)
        {
            if (i != 0)
            {
            Console.Write(",");
            }
            Console.Write(intarray[i]);
        }
        Console.WriteLine("}");
    }

/// <summary>
/// 내 꿈을 실현시켜줄 함수~!
/// </summary>
    public static void MakeLotto()
    {
        // 상수들
        const int MAX_NUMBER = 45;
        const int PICK_COUNT = 6;

        // 숫자를 뽑을 리스트
        var list = new List<int>();

        // c#에서 Random을 사용하려면 미리 정의해야 함
        Random rand = new Random();

        int cnt = 0;
        // 만족할 때까지 반복
        while (cnt < PICK_COUNT)
        {
            // Unity에서의 방법 = Random.Range(1, MAX_NUMBER + 1);
            // 다음 숫자 뽑기
            int pick = rand.Next(1, MAX_NUMBER + 1);

            // 기존에 뽑힌 숫자와 비교해서
            if (list.Contains(pick) == false)
            {
                // 없으면 리스트에 넣어준다
                list.Add(pick);
                // 카운트 증가
                cnt++;
            }
        }

        // 화면에 출력
        list.Sort();
        Console.Write ("이번 주 로또 당첨 번호는");
        foreach (var item in list)
        {
            Console.Write($" {item}");
        }
        Console.WriteLine("입니다.");
    }
}