namespace Exc_playground
{
    public class ClosureExample
    {
        //GOOD CLOSURE EXAMPLE

        //RETURN LAMBDA EXPRESSION CAPTURED OUTER VALUE AND
        //CREATE CLOUSURE
        private Func<int> Test()
        {
            int num = 0;
            return () => num++;
        }

        // CAPTURING OUTER VALUE
        public void Capturing()
        {
            Console.WriteLine("CAPTURING :");
            Func<int> test = Test();
            Console.WriteLine(test().ToString());
            Console.WriteLine(test().ToString());
            Console.WriteLine(test().ToString());
            Console.WriteLine(test().ToString());
        }
        

        //INSTEAD OF DECLARING VALUE OUT OF LAMBDA I DELCARED IT
        //INSIDE IT, THERE IS NO CAPTURING AND VARIABLE WILL BE
        //INSTANTIATED FOR EVERY INSTANCE
        private Func<int> Test2()
        {
            return () => { int num = 0; return num++; };
        }

        //NO CAPTURING 
        public void NoCapturing()
        {
            Console.WriteLine("NO CAPTURING :");
            Func<int> test2 = Test2();
            Console.WriteLine(test2().ToString());
            Console.WriteLine(test2().ToString());
            Console.WriteLine(test2().ToString());
            Console.WriteLine(test2().ToString());
        }
    }
}
