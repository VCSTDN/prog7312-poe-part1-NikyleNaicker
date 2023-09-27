using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3B_2023
{
    public class CallNumber : IComparable<CallNumber>
    {
        public int callNumber { get; set; }
        public string Author { get; set; }

        public CallNumber(int thecallNumber, string theAuthor)
        {
            this.callNumber = thecallNumber;
            this.Author = theAuthor;
        }
        public int CompareTo(CallNumber call)
        {
            int results = callNumber.CompareTo(call.callNumber);
            if (results == 0)
            {
                results = Author.CompareTo(call.Author);
            }
            return results;
        }
    }
}