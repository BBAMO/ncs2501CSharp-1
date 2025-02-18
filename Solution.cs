using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

class Solution
{
    /// <summary>
    /// 주사위 게임 1
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Solution02122(int a, int b)
    {
        int answer = 0;

        if (a % 2 == 1)
        {
            if (b % 2 == 1)
            {
                answer = a * a + b * b;
            }
            else
            {
                answer = 2 * (a + b);
            }
        }
        else
        {
            if (b % 2 == 1)
            {
                answer = 2 * (a + b);
            }
            else
            {
                answer = Math.Abs(a - b); // 절대값 구하기
            }
        }

        return answer;
    }
    /// <summary>
    /// 뒤에서 5등 위로
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] Solution0212(int[] num_list)
    {
        /*
        // List 사용
        var list = new List<int>(num_list);
        // List 정렬(Sort)
        list.Sort();
        // index : for 문
        var list2 = new List<int>();

        for (int i = 5; i < list.Count; i++)
        {
            // 다른 list에 넣기
            list2.Add(list[i]);
        }
        // list를 int[]로 변환해서 리턴
        return list2.ToArray();
        */  

        var list = new List<int>(num_list);
        
        list.Sort();

        for (int i = 0; i < 5; i++)
        {
            list.RemoveAt(0); // RemoveAt : 필요없는 항목 지우기
        }
        
        return list.ToArray();
    }
   
    /// <summary>
    /// 홀수 정렬
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution02112(int n)
    {
        int[] answer = new int[]{};
        var list = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                list.Add(i);
            }
        }
        return list.ToArray();
    }

    /// <summary>
    /// 0 떼기
    /// </summary>
    /// <param name="n_str"></param>
    /// <returns></returns>
    public string Solution0211(string n_str)
    {
        string answer = string.Empty;
        
        bool zero = true;

        while (zero)
        {
            //if (n_str[0] == '0')
            if (n_str[0].CompareTo('0') == 0)
            {
                n_str = n_str.Substring(1); //n_str.Length);
            }
            else
            {
                zero = false;
            }
        }
        answer = n_str;
        return answer;
    }
    public int Solution0207(int[] num_list)
    {
        int Ev = 0;
        int Od = 0;
        
        for (int i = 0; i < num_list.Length; i++)
        {
            if (i % 2 == 1)
            {
                Od += num_list[i];
            }
            else
            {
                Ev += num_list[i];
            }
        }

        return Math.Max(Ev, Od);
        
        /*
        if (Ev > Od)
        {
            return Ev;
        }
        else if (Ev < Od)
        {
            return Od;
        }
        else
        {
            return Ev;
        }
        */



    }

    /// <summary>
    /// 카운트 업
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public int[] Solution0206(int start, int end)
    {
        // 리턴할 배열의 크기를 먼저 구한다
        int len = end - start + 1;
        // 그 크기만큼 배열을 만든다
        int[] answer = new int[len];
       
       // 크기만큼 반복
        for (int i = 0; i < len; i++)
        {
            // 배열의 처음부터 start에 인덱스 값 더해서 넣는다
            answer[i] = start + i;
        }
        // 배열 리턴
        return answer;
    }
    public int Solution0205(int a, int b)
    {
        string temp = "" + a + b;

        int hi = Convert.ToInt32(temp);

        int hello = 2 * a * b;

        if (hi >= hello)
        {
            return hi;
        }
        else
        {
            return hello;
        }
        
    }
    public string Solution02042(int[] numLog)
    {
        string answer = string.Empty;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < numLog.Length - 1; i++)
        {
            int val = numLog[i+1] - numLog[i];

            if (val == 1)   sb.Append('w');
            else if (val == -1) sb.Append('s');
            else if (val == 10) sb.Append('d');
            else if (val == -10) sb.Append('a');
        }
        answer = sb.ToString();
        return answer;
    }
    /// <summary>
    /// 수 조작하기 1
    /// </summary>
    /// <param name="n"></param>
    /// <param name="control"></param>
    /// <returns></returns>
    public int Solution0204(int n, string control)
    {
        foreach (var item in control)
        {
            switch (item)
            {
                case 'w':
                    n++;
                    break;
                case 's':
                    n--;
                    break;
                case 'd':
                    n += 10;
                    break;
                case 'a':
                    n -= 10;
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
        return n;
    }
    /// <summary>
    /// 첫 번째로 나오는 음수
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int Solution0203(int[] num_list)
    {
        for (int i = 0; i < num_list.Length; i++)
        {
            if(num_list[i] < 0)
            {
                return i;
            }
        }
        return -1;
    }
    /// <summary>
    /// 피자 나눠 먹기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution01312(int n) 
    {
        int answer = 0;

        int piz = n / 7;

        int res = ((n % 7) == 0) ? 0 : 1;
        answer = piz + res;

        return answer;
        /*
        int answer = 0;
        answer = n / 7;
        if(n % 7 != 0)
            answer++;
        return answer;
        */
    }
    /// <summary>
    /// 배열 뒤집기
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] Solution0131(int[] num_list)
    {
        int[] answer = new int[num_list.Length];
        for (int i = 0; i < num_list.Length; i++)
        {
            answer[num_list.Length - 1 - i] = num_list[i];
        }
        return answer;
    }
    /// <summary>
    /// 모음 제거
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
     public string Solution01272(string my_string) 
    {
        string answer = string.Empty;
        //char[] mo = new char[5]{'a','e','i','o','u'};
        answer = my_string.Replace("a", "").Replace("e", "")
        .Replace("i", "").Replace("o", "").Replace("u", "");
        return answer;
    }

    /// <summary>
    /// 배열 원소의 길이
    /// </summary>
    /// <param name="strlist"></param>
    /// <returns></returns>
    public int[] Solution0127(string[] strlist)
    {
        int len = strlist.Length;
        int[] answer = new int[len];
        for (int i = 0; i < len; i++)
        {
            answer[i] = strlist[i].Length;
        }
        return answer;
    }
    public string Solution01242(string my_string, int s, int e)
    {
        /*
        char[] chr = my_string.ToCharArray();
        int len = e - s + 1;
        Array.Reverse(chr, s, len);
        string answer = new string(chr);
        return answer;
        */

        char[] chr = my_string.ToCharArray();
        Array.Reverse(chr, s, e - s + 1);
        return new string(chr);
    }

    /// <summary>
    /// 문자열 뒤집기
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string Solution0124(String my_string)
    {
        string answer = string.Empty;
        
        /*
        for (int i = 0; i < my_string.Length; i++)
        {
            answer = my_string[i] + answer;
        }
        
        return answer;
        */

        /*
        foreach (var item in my_string)
        {
            answer = item + answer;
        }
        
        return answer;
        */

        StringBuilder sb = new StringBuilder();
        foreach (var item in my_string)
        {
            sb.Insert(0, item);
        }
        
        answer = sb.ToString();

        return answer;
    }
    /// <summary>
    /// 아이스 아메리카노
    /// </summary>
    /// <param name="money"></param>
    /// <returns></returns>
    public int[] Solution0123(int money)
    {
        /*
        const int COFFEE_PRICE = 5500;
        int[] answer = new int[2];
        answer[0] = money / COFFEE_PRICE;
        answer[1] = money % COFFEE_PRICE;
        return answer;
        */
        return new int[]{money / 5500, money % 5500};   
    }
    /// <summary>
    /// 배열의 유사도
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public int Solution0122(string[] s1, string[] s2)
    {
        int answer = 0;
        foreach (var item1 in s1)
        {
            foreach (var item2 in s2)
            {
                if (item1 == item2)
                {
                    answer++;
                }
            }
        }
        return answer;
    }

    /// <summary>
    /// 배열 곱하기
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int[] Solution0121(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            //numbers[i] = numbers[i] * 2;
            numbers[i] *= 2;
        }
        return numbers;
    }
    /// <summary>
    /// 피자 나누기
    /// </summary>
    /// <param name="slice"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0120(int slice, int n) 
    {
        int answer = 0;
        // for문
        //for (int i = 2; i <= n; i += slice)
       // {
       //     answer++; //한 판 추가
       // }
       // return answer;

       // while
       while (answer * slice < 0)
       {
        answer++;
       }
       return answer;
    }

    /// <summary>
    /// 짝수 홀수 개수
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] solution01172(int[] num_list)
    {
        int[] answer = new int[2];

        foreach(var item in num_list)
        {
            if (item % 2 == 0)
            {
                answer[0]++;
            }
            else
            {
                answer[1]++;
            }
        }
        
        return answer;
    }

    /// <summary>
    /// 머쓱이보다 키 큰 사람(foreach로 비교 출력)
    /// </summary>
    /// <param name="array"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    public int solution0117(int[] array, int height)
    {
        int answer = 0;

        //for
        /*
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > height)
            {
                answer++; //answer+=1을 줄인 모습
            }
        }
        */
        // foreach
        foreach (var item in array)
        {
            if (item > height)
            {
                answer++;
            }
        }

        return answer;
    }
    public int[] solution01162(int[] numbers, int num1, int num2)
    {
        //리턴할 배열의 크기를 먼저 구한다
        int len = num2 - num1 + 1;
        //구한 크기만큼 배열을 선언
        int[] answer = new int [len];
        // 크기만큼 반복
        for (int i = 0; i < len; i++)
        {
           //인덱스에 해당하는 값을 배열에 넣는다
           answer[i] = numbers[num1 + i];
        }
        //배열 리턴
        return answer;
    }
    /// <summary>
    /// 편지
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public int solution0116(string message) 
    {
        int answer = 0;
        answer = message.Length * 2;
        return answer;
    }


    /// <summary>
    /// 양꼬치
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int solution01142(int n, int k)
    {
        int answer = 0;
        // 서비스 음료수가 몇 병이냐
        int ser = n / 10;
        //양꼬치 * 12000 + 음료수 * 2000 - 서비스 음료수 * 2000
        answer = n * 12000 + k * 2000 - ser * 2000;
       
        return answer;
    }
    /// <summary>
    /// 짝수의 합
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int solution0114(int n)
    {
        //계산된 값을 저장할 변수를 준비한다
        int answer = 0;
        //n까지 반복한다
        for (int i = 1; i <= n; i++)
        {
            //짝수인가?
            if (i % 2 == 0)
            {
                //짝수면 변수에 계산
                answer += i;
            }
        }
        //계산된 최종값을 리턴한다
        return answer;
    }

    /// <summary>
    /// 숫자 비교하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0113(int num1, int num2)
    {
        int answer = 0;
        if (num1 == num2)
        {
            answer = 1;
        }
        else
        {
            answer = -1;
        }
        return answer;
    }

    /// <summary>
    /// 나이 출력
    /// </summary>
    /// <param name="age">2022년도의 나이</param>
    /// <returns>출생연도</returns>
    public int solution01102(int age)
    {
        int answer = 0;
        answer = 2022 - age + 1; 
        return answer;
    }

    /// <summary>
    /// 나머지 구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0110(int num1, int num2)
    {
        // 정상적인 계산으로 나올 수 없는 값을 기본값으로 해 준다 !
        int answer = -1;
        answer = num1 % num2;
        return answer;
    }

    /// <summary>
    /// 두 수의 차
    /// </summary>
    /// <param name="num1">인자1</param>
    /// <param name="num2">인자2</param>
    /// <returns>반환값</returns>
    public int solution0109(int num1, int num2)
    {
        // 더 간단하게
        return num1 - num2;

        // 간단하게
        //int anything = num1 - num2;
        //return anything;

        // 정답
        //int anything;
        //anything = num1 - num2;
        //return anything;
    }

    /// <summary>
    /// 두 수의 곱
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int solution0108(int num1, int num2)
    {
        int answer = 0;
        answer = num1 * num2;
        return answer;
    }
}
