
namespace Stack
{
    public class Stack<T>
    {
        static void Main()
        { }
            private T[] stackArray;
            private int maximumLength;

            public int Size { get; private set; }

            public Stack(int length)
            {
                maximumLength = length;
                stackArray = new T[length];
            }
        
    }

    class CMain
    {
        public static void Main() { }
    }
}