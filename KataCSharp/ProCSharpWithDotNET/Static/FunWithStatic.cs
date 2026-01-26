namespace KataCSharp.ProCSharpWithDotNET.Static
{
    public static class FunWithStatic
    {
        private static Dictionary<string, int> _dict = new Dictionary<string, int>();
        public static void Start()
        {
            _dict.Add("One", 1);
            Console.WriteLine("Fun with Static Class");
        }
    }

    public class NonStaticClass
    {
        static NonStaticClass()
        {

        }

        public void Start()
        {
            FunWithStatic.Start();
        }
    }
}