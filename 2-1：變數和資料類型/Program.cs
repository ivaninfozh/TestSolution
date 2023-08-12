namespace _2_1_變數和資料類型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic test = 20;
            Console.WriteLine("Hello, World!");
        }
    }


    public class Test : ReadOnly範例
    {
        readonly int MyReadOnlyVar = 10;

        public Test(int value) : base(value)
        {
            MyReadOnlyVar = value; // 在構造函數內可以設置
            ReadOnly範例.StaticFunc();
        }
        public override void MyReadOnly()
        {
        }
    }
    public abstract class ReadOnly範例
    {
        readonly int MyReadOnlyVar = 10;

        public ReadOnly範例(int value)
        {
            MyReadOnlyVar = value; // 在構造函數內可以設置
        }

        public virtual void MyReadOnly() { }

        public static void StaticFunc()
        { 
        }


    }
}