using System;

namespace Lambda
{
    // solving the same problem with interface
    public interface ITransformer
    {
        int Transformer(int x);
    }

    class Util
    {
        public static void TransfromAll(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                // instead of t(values[i])
                values[i] = t.Transformer(values[i]);
            }
        }
    }

    class Run : ITransformer
    {
        public int Transformer(int x) { return x * x; }
            
        public void runCode() {
            int[] values = { 1, 2, 3, 4 };
            Util.TransfromAll(values, new Run());

            // printing the results
            foreach (int i in values) { Console.WriteLine(i); }
            // paues
            Console.ReadKey();
        }
    }

}
