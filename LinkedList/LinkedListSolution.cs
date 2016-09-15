using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListSolution
    {
        public int Solution(IntList L)
        {
            // cant ForEach, grrrr

            // stores our count to be returned
            int listCount = 0;

            // the current list item to check
            var intList = L;

            // flag to see if there are more items
            bool hasMore = true;

            //var item = L;
            //while (item.Next != null)
            //{
            //    listCount++;
            //    item = item.Next;
            //}

            do
            {
                if (intList != null)
                {
                    listCount += 1;
                    intList = intList.Next;
                }
                else
                {
                    hasMore = false;
                }
            } while (hasMore);


            return listCount;
        }
    }

    public class IntList
    {
        public int Value { get; set; }
        public IntList Next { get; set; }
    }
}
