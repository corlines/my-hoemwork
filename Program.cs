using System;
using System.Buffers;
using System.Globalization;
using System.Runtime.InteropServices;
using static System.Console;
namespace IntergralType
{
    #region 예제 1
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        sbyte a = -10;
    //        byte b = 40;

    //        Console.WriteLine($"a={a}, b={b}");

    //        short c = -30000;
    //        ushort d = 60000;

    //        Console.WriteLine($"c={c}, d={d}");

    //        int e = -1000_0000; // 0이 7개
    //        uint f = 3_0000_0000; // 0이 8개

    //        Console.WriteLine($"e={e}, f={f}");

    //        long g = -5000_0000_0000; // 0이 11개

    //        ulong h = 200_0000_0000_0000_0000; // 0이 18개

    //        Console.WriteLine($"g={g}, h={h}");


    //    }
    //}
    #endregion
    #region 예제 2
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        byte a = 240;
    //        Console.WriteLine($"a={a}");

    //        byte b = 0b1111_0000;
    //        Console.WriteLine($"b={b}");

    //        byte c = 0XF0;
    //        Console.WriteLine($"c={c}");

    //        uint d = 0x1234_abcd;
    //        Console.WriteLine($"d={d}");
    //    }
    //}
    #endregion
    #region 예제 3
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        byte a = 255;
    //        sbyte b = (sbyte)a;

    //        Console.WriteLine(a);
    //        Console.WriteLine(b);

    //    }
    //}
    #endregion

    #region 예제 4
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        uint a = uint.MaxValue;
    //        Console.WriteLine(a);
    //        a = a + 1;

    //    }
    //}
    #endregion

    #region  예제 5
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        float a = 3.1415_9265_3589_7932_3846f;
    //        Console.WriteLine(a);

    //        double b = 3.1415_9265_3589_7932_3846;
    //        Console.WriteLine(b);
    //    }
    //}
    #endregion
    #region 5
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        float a = 3.141592653589793238462643383279f;
    //        double b = 3.141592653589793238462643383279f;
    //        decimal c = 3.141592653589793238462643383279m;

    //        Console.WriteLine(a);
    //        Console.WriteLine(b);
    //        Console.WriteLine(c);

    //    }

    //}
    #endregion
    #region 6
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        object a = 123;
    //        object b = 3.1415926535897932384626338327m;
    //        object c = true;
    //        object d = "안녕하세요";

    //        Console.WriteLine(a);
    //        Console.WriteLine(b);
    //        Console.WriteLine(c);
    //        Console.WriteLine(d);
    //    }
    //}
    #endregion
    #region 7
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int a = 123;
    //        object b = (object)a;
    //        int c= (int)b;

    //        Console.WriteLine(a);
    //        Console.WriteLine(b);
    //        Console.WriteLine(c);
    //        double x = 3.1414213;
    //        object y = x;
    //        double z = (double)y;

    //        Console.WriteLine(x);
    //        Console.WriteLine(y);
    //        Console.WriteLine(z);
    //    }
    //}
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        sbyte a = 127;
    //        Console.WriteLine(a);

    //        int b = (int)a;
    //        Console.WriteLine(b);

    //        int x = 128; // sbyte의 최대값 127보다 큰 수
    //        Console.WriteLine(x);

    //        sbyte y = (sbyte)x; 
    //        Console.WriteLine(y);
    //    }
    //}
    #endregion

    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {

    //        float a = 69.6875f;
    //        Console.WriteLine("a : {0}", a);

    //        double  b = (double)a;
    //        Console.WriteLine("b : {0}", b);
    //        Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);

    //        float x = 0.1f;
    //        Console.WriteLine("x : {0}", x);

    //        double y = (double)x;
    //        Console.WriteLine("y : {0}", y);
    //        Console.WriteLine("0.1 == y : {0}",0.1 == y);


    //    }
    //}

    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int a = 500;
    //        Console.WriteLine(a);

    //        uint b = (uint)a;
    //        Console.WriteLine(b);

    //        int x = -30;
    //        Console.WriteLine(x);

    //        uint y = (uint)x;
    //        Console.WriteLine(y);
    //    }
    //}
    #endregion
    #region

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        float a = 0.9f;
    //        int b = (int)a;
    //        Console.WriteLine(b);
    //        float c = 1.1f;
    //        int d = (int)c;
    //        Console.WriteLine(d);
    //    }
    //}
    #endregion

    #region
    //class MainApp
    //{
    //    static void Main(String[] args)
    //    {
    //        int a = 123;
    //        string b = a.ToString();
    //        Console.WriteLine(b);

    //        float c = 3.14f;
    //        string d = c.ToString();
    //        Console.WriteLine(d);

    //        string e = "123456";
    //        int f = Convert.ToInt32(e);
    //        Console.WriteLine(f);

    //        string g = "1.2345";
    //        float h = float.Parse(g);
    //        Console.WriteLine(h);

    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //  }
    //}
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        const int MAX_INT = 2147483647;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
    //        const int MIN_INT = -214748647;

    //        Console.WriteLine(MAX_INT);
    //        Console.WriteLine(MIN_INT);

    //    }
    //}
    #endregion
    #region 
    //    class MainApp
    //    {
    //        enum Dialogresult { YES, NO, CANCEL, CONFIRM, OK }
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine((int)Dialogresult.YES);
    //            Console.WriteLine((int)Dialogresult.NO);
    //            Console.WriteLine((int)Dialogresult.CANCEL);
    //            Console.WriteLine((int)Dialogresult.CONFIRM);
    //            Console.WriteLine((int)Dialogresult.OK);
    //        }
    //    }
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int? a = null;
    //        Console.WriteLine(a.HasValue);
    //        Console.WriteLine(a != null);

    //        a = 3;
    //        Console.WriteLine(a.HasValue);
    //        Console.WriteLine(a != null);
    //        Console.WriteLine(a.Value);

    //        float k = float.Parse("123qqq");

    //        if(float.TryParse("123qqq", out float k2))
    //        {

    //        }

    //    }
    //}
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        var a = 20;
    //        Console.WriteLine("Type {0}, value: {1}", a.GetType(), a);

    //        var b = 3.1414213;
    //        Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

    //        var c = "Hello, World!";
    //        Console.WriteLine("Type:{0}, Value: {1}", c.GetType(), c);

    //        var d = new int[] { 10, 20, 30 };
    //        Console.Write("Type:{0}, Value: ", d.GetType());
    //        foreach (var e in d)
    //            Console.Write("{0}", e);

    //        Console.WriteLine();

    //    }
    //}
    #endregion

    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        System.Int32 a = 123;
    //        int b = 456;

    //        Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
    //        Console.WriteLine("b type:{0}, value:{1}",b.GetType().ToString(), b);

    //        System.String c = "abc";
    //        string d = "def";

    //        Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
    //        Console.WriteLine("d type:{0}, vlaue:{1}",d.GetType().ToString(), d);

    //    }
    //}
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        string greeting = "Good Morning";

    //        WriteLine(greeting);
    //        WriteLine();

    //        WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
    //        WriteLine("Index 'o' : {0}", greeting.IndexOf('o'));

    //        WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
    //        WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));

    //        WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
    //        WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

    //        WriteLine("EndWith 'Good' : {0}", greeting.EndsWith("Good"));
    //        WriteLine("EndWith 'Morning' : {0}", greeting.EndsWith("Morning"));

    //        WriteLine("Contains 'Good' : {0}", greeting.Contains("Evening"));
    //        WriteLine("contains 'Morning' : {0}", greeting.Contains("Morning"));
    //    }
    //}
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        WriteLine("ToLower() : '{0}'","ABC".ToLower());
    //        WriteLine("Toupper() : '{0}'","abc".ToUpper());

    //        WriteLine("insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
    //        WriteLine("Remove() : '{0}'", "I Don'Love you.".Remove(2, 6));
    //        WriteLine("Trim() : '{0}'", " No Spaces ".Trim())           ;

    //        WriteLine("TrimStart() : '{0}'", " NO spaces ".TrimStart());
    //        WriteLine("trimend() : '{0}'", " NO spaces ".TrimEnd());
    //    }
    //}
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        string greeting = "티모 모자 가지고 싶다";

    //        WriteLine(greeting.Substring(0, 5));
    //        WriteLine(greeting.Substring(5));
    //        WriteLine();
    //        string[] arr = greeting.Split(new string[] {" "}, StringSplitOptions.None);
    //        WriteLine("Word Count : {0}", arr.Length);

    //        foreach (string element in arr)
    //            WriteLine(element);
    //    }
    //}
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        string fmt = "{0,-20}{1,-15}{2,30}";

    //        WriteLine(fmt, "publisher","Author","Title");
    //        WriteLine(fmt, "Marvel", "Stan lee", "Iron Man");
    //        WriteLine(fmt, "hanbit","Sanghyun Park", "This is c#");
    //        WriteLine(fmt,"Prentice Hall","K&R","The C Programming Language");
    //    }
    //}
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        WriteLine("10진수: {0:D}", 123);
    //        WriteLine("10진수: {0:D5}", 123);
    //        WriteLine("16진수: 0x{0:X}", 0xFF1234);
    //        WriteLine("16진수: 0x{0:X8}", 0xFF1234);
    //        WriteLine("숫자: {0:N}", 123456789);
    //        WriteLine("숫자: {0:NO}", 123456789);

    //        WriteLine("고정 소수점: {0:F}", 123.45);
    //        WriteLine("고정 소수점:{0:F5}", 123, 456);

    //        WriteLine("공학: {0:E}", 123, 456789);
    //    }
    //}
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        System.Int32 a = 123;
    //        int b = 456;

    //        Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
    //        Console.WriteLine("b type:{0}, value:{1}", b.GetType().ToString(), b);
    //        System.String c = "abc";
    //        string d = "def";

    //        Console.WriteLine("c type:{0}, value:{1}",c.GetType().ToString(), c);
    //        Console.WriteLine("d type:{0}, value:{1}", d.GetType().ToString(), d);

    //    }
    //}
    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        string greeting = "Good Morning";

    //        WriteLine(greeting);
    //        WriteLine();

    //        //Index OF
    //        WriteLine("IndexOf 'Good' : {0}",greeting.IndexOf("Good"));
    //        WriteLine("indexOf 'o' : {0}",greeting.IndexOf('o'));

    //        WriteLine("lastIndexOf 'Good' : {0}",greeting.LastIndexOf("Good"));
    //        WriteLine("lastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));

    //        WriteLine("Startswith 'Good' : {0}", greeting.StartsWith("Good"));
    //        WriteLine("startswith 'Morning' : {0}", greeting.StartsWith("Morning"));

    //        WriteLine("endswith 'Good' : {0}", greeting.EndsWith("Good"));
    //        WriteLine("endswith 'Morning' : {0}", greeting.EndsWith("Morning"));

    //        WriteLine("Contains 'Evening' : {0}",greeting.Contains("Evening"));
    //        WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

    //        WriteLine("REplaced 'Morning' with 'Evening': {0}",
    //            greeting.Replace("Morning", "Evening"));

    //    }
    //}
    #endregion
    #region 99
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        WriteLine("ToLower() : '{0}'", "ABC".ToLower());
    //        WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

    //        WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, "sunny"));
    //        WriteLine("remove() : '{0}'", "I Don't Love You.".Remove(2, 6));

    //        WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
    //        WriteLine("TrimStart() : '{0}'", " NO Spaces ".TrimStart());
    //        WriteLine("TrimEnd() : '{0}'", " NO Spaces ".TrimEnd());
    //        WriteLine("indexof()".IndexOf('e'));
    //        WriteLine("blue".Concat("sky"));
    //        WriteLine("minecraft".Contains("craft"));
    //    }
    //}
    #endregion
    #region 100 중요
    //class MainApp
    //{
    //static void Main(string[] args)
    //{
    //    string greeting = "Good Morning";
    //    WriteLine(greeting.Substring(0, 5));
    //   WriteLine(greeting.Substring(5));
    //    WriteLine();

    //    string[] arr = greeting.Split(new string[] {" "},StringSplitOptions.None);
    //    WriteLine("Word Count : {0}",arr.Length);

    //    foreach (string r in arr)
    //       WriteLine(r);
    //    }
    //}

    #endregion
    #region
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);
    //        WriteLine("12시간 형식{0:yyyy-MM-dd tt hh:mm:ss (ddd)}",dt);
    //        WriteLine("24시간 형식{0:yyyy-MM-dd tt HH:mm:ss (dddd)}", dt);

    //        CultureInfo ciKo = new CultureInfo("ko-KR");
    //        WriteLine();
    //        WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
    //        WriteLine(dt.ToString("yyyy-MM-dd tt HH:mm:ss (dddd)",ciKo));
    //        WriteLine(dt.ToString(ciKo));

    //        CultureInfo ciEn = new CultureInfo("en-US");
    //        WriteLine();
    //        WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
    //        WriteLine(dt.ToString("yyyy-MM-dd tt HH:mm:ss (dddd)", ciEn));
    //        WriteLine(dt.ToString(ciEn));
    //    }
    //}
    #endregion
    #region 113
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        string name = "김튼튼";
    //        int age = 23;
    //        WriteLine($"{name,-10},{age:D3}");

    //        name = "박날씬";
    //        age = 30;
    //        WriteLine($"{name},{age,-10:D3}");

    //        name = "이비실";
    //        age = 17;
    //        WriteLine($"{name},{(age > 20 ? "성인" : "미성년자")}");

    //    }
    //}
    #endregion
    #region 연습문제 *******************************************************************************
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        WriteLine("사각형의 너비를 입력하세요.");
    //        string a = Console.ReadLine();
    //        WriteLine("사각형의 높이를 입력하세요.");
    //        string b = Console.ReadLine();

    //        WriteLine(Convert.ToInt32(a)*Convert.ToInt32(b));
    //    }
    //}
    //2번 문제 다음 코드에서 잘못된 부분을 찾고, 그 이유를 설명하세요
    //int a = 7.3;
    //float b = 3.14;
    //double c = a*b;
    //char d = "abc";
    //string e = "한";
    //정답 int a = 7.3; -> int a = 7;로 바꾼다

    //3번 값 형식과 참조 형식의 차이는 무었인가요?
    //값 형식은 변수를 깊게 복사하고 참조형식은 변수를 얕게 복사한다
    //참조형식은 예를 들어 통장이 1개 있는데 2개의 카드를 각각 긁을때마다 돈이 나가는 식이다

    //4번 박싱과 언박싱을 설명하세요.
    //박싱이란 상자안에 있는 데이터를 보관한다는거고
    //언박싱이란 상자안에 있는 데이터를 꺼낸다는거다


    //5번 다음 코드를 컴파일한 후의 a와b는 각각 어떤 데이터 형식이겠습니까?
    //var a = 2020;
    //var b = "double"
    //정답 1 = int, 2 = char

    #endregion
    #region
    
}







































