using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5_5
{
    public class To_Do
    {
     
        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Выполнена/Не выполнена задача (по умолчанию не выполнена)
        /// </summary>
        public bool IsDone { get; set; }

        public To_Do()
        {
            
        }

        

    }
}
