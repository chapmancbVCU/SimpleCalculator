using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class AnswerHistory
    {
        // INSTANCE VARIABLES
        public string History { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="history"></param>
        public AnswerHistory(string history)
        {
            History = history;
        }
    }
}
