using System;
using System.Collections.Generic;
using System.Text;
namespace Lesson6_3
{
    [Serializable]
    public class MyArraySizeException : Exception
    {
        public MyArraySizeException()
        {

        }
        public MyArraySizeException(string message)
            : base(message)
        { 
        }
        public MyArraySizeException(string message, Exception inner)
            : base(message, inner) { }
    }
}
