using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Example of an exception being thrown within the finally block.
             * 
             * If an exception occurs in the finally block of our ExceptionTesting() method
             * it will propogate up. We can handle this at a higher level with a try/catch 
             * block within the calling function (main in this case), otherwise our application
             * will crash.
             * 
             * Additionally, in our ExceptionTesting() method an exception occured within the 
             * try block, however the exception is lost. This is because the try block exception
             * was not handled within the catch block of the ExceptionTesting() method. Since 
             * afterwards an exception occured within the finally block the original exception
             * is lost.
             */
            try
            {
                ExceptionTesting();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // In this function an exception occurs within the try AND finally blocks, and the try block exception is not handled
        public static void ExceptionTesting()
        {
            try
            {
                Console.WriteLine("Line before TRY block exception"); //Line will execute since no exception has occured yet
                //Foo();
                throw new Exception("EXCEPTION THROWN: in TRY block..."); //This exception will be lost since it's not handled and an exception exists in the finally block
                Console.WriteLine("Line after TRY block exception"); //Line will not execute since exception is thrown before it
            }
            catch // Only execute if exception thrown in try block
            {
                //Try block exception is not handled, we could emit the catch block if we wanted to here
            }
            finally //Finally block will ALWAYS execute
            {
                Console.WriteLine("Line before FINALLY block exception"); //This line will be executed since before exception
                throw new Exception("EXCEPTION THROWN: in FINALLY block..."); //Finally block execution will terminate at this point when exception occurs
                Console.WriteLine("Line after FINALLY block exception"); //This line will NOT be executed since the finally block terminated when the exception occurs
            }
        }

        static void Foo()
        {
            Console.WriteLine("Line before FOO method exception."); //Line executed
            throw new Exception("EXCEPTION THROWN: in FOO method..."); //Exception thrown
            Console.WriteLine("Line after FOO exception is thrown."); //Line after exception not executed
        }
    }
}
