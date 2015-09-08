using System;

namespace Lambda
{
    class Delegate1
    {
        delegate int MyDel(int x);
        delegate string Del2(string n);
        //static void Main(string[] args)
        //{
        //    // test one
        //    MyDel testDel = (int x) => x * x;
        //    // you don't need to mention the type of the variable
        //    MyDel testDel2 = x => x * x;
        //    int result = testDel(12);
        //    int result2 = testDel2(13);
        //    Console.WriteLine(result);
        //    Console.WriteLine(result2);
        //    // another test
        //    Del2 newTest = (string name) => "hello " + name ;
        //    Console.WriteLine(newTest("Hooman"));


        //    // statmement lambda
        //    MyDel testDel3 = (int x) =>
        //    {
        //        return x * x;
        //    };
        //    Console.WriteLine(testDel3(24));
        //}

    }
}
