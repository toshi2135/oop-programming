using System;
namespace oop_programming
{
    public class MyException : Exception
    {
        public MyException(string message):base(message)
        {
        }
    }
}
