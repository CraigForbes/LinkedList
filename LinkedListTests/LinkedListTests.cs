using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void BasicTest()
        {
            var list = CreateIntList(new[] { 4, 7, 5, 1, 8, 2 });
            var solution = new LinkedListSolution();
            var result = solution.Solution(list);

            Assert.AreEqual(6, result);
        }

        private IntList CreateIntList(int[] values)
        {
            var head = new IntList();
            var current = head;
            IntList previous = null;
            foreach (var value in values)
            {
                current.Value = value;
                if (previous != null)
                {
                    previous.Next = current;
                }
                previous = current;
                current = new IntList();
            }
            return head;
        }
    }
}
