namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            MyClass_A m1 = Sample.MyFunc<int, MyClass_A>(100, 200);
            Console.WriteLine(m1.Status);

            MyClass_B m2 = Sample.MyFunc<int, MyClass_B>(200, 100);
            Console.WriteLine(m2.Status);
        }
    }

    /// <summary>
    /// ベースクラス
    /// </summary>
    public class BaseClass
    {
        public string Status = "None";

        public BaseClass()
        {

        }
    }

    /// <summary>
    /// MyClass_A 
    /// </summary>
    public class MyClass_A : BaseClass
    {
        public MyClass_A()
        {
            this.Status = "MyClass_A";
        }
    }

    /// <summary>
    /// MyClass_B 
    /// </summary>
    public class MyClass_B : BaseClass
    {
        public MyClass_B()
        {
            this.Status = "MyClass_B";
        }
    }

    /// <summary>
    /// ジェネリックサンプル
    /// </summary>
    static class Sample
    {
        /// <summary>
        /// ジェネリックメソッド
        /// </summary>
        public static TResult MyFunc<T, TResult>(T a, T b)
            where T : IComparable<T>
            where TResult : BaseClass, new()
        {
            TResult result = new();
            return result;
        }
    }
}