using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6_3
{
    class MyArrayDataExceptions : Exception
    {
        public int i;
        public int j;

        public MyArrayDataExceptions()
        {

        }
        public MyArrayDataExceptions(string message)
            : base(message)
        {
        }
        public MyArrayDataExceptions(string message, Exception inner)
            : base(message, inner) { }

        public MyArrayDataExceptions(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }
}
