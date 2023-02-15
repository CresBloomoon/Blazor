using System;

class B
{
    //インスタンスフィールド
    private byte a = 1;
    protected long b = 2;
    public short c = 3;
    protected string d = "Hello";
    private int e = 4;
    protected short f = 5;

    //静的フィールド
    private static byte sa = 6;
    protected static long sb = 7;
    public static short sc = 8;
    protected static string sd = "sHello";
    private static int se = 9;
    protected static short sf = 10;

    //メソッド定義
    public string GetHello(string message)
    {
        return message + "こんにちは";
    }

    static void Main(string[] args)
    {
        B b1 = new B();
        Console.WriteLine(b1.GetHello("C#"));
        Console.WriteLine(b1.ToString());
        Console.ReadKey();
    }
}