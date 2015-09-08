using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_delegate_anFunction_lambda_review
{
    //***SOLVING THE TRANSFORM PROBLEM WITH INTERFACE INSTEAD OF DELEGATE ****//
    public interface ITransformer
    {
        int Transform(int x);
    }

    class TransformerInterfaceTest
    {
        public static void TransformAll(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t.Transform(values[i]);
            }
        }
    }

    class Square : ITransformer
    {
        public int Transform(int x)
        {
            return x * x;
        }
    }
}
