using System;
using System.Collections.Generic;

namespace mssa_11._2._2
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Program
    {
        static ListNode BuildList(int[] arr)
        {
            ListNode dummy = new ListNode();
            ListNode curr = dummy;
            foreach (var v in arr)
            {
                curr.next = new ListNode(v);
                curr = curr.next;
            }
            return dummy.next;
        }

        static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
        }

        static List<int> ListToArray(ListNode head)
        {
            var result = new List<int>();
            while (head != null)
            {
                result.Add(head.val);
                head = head.next;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[][] testCases = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[] {1,2},
                new int[] {}
            };

            foreach (var test in testCases)
            {
                var head = BuildList(test);
                var reversed = ReverseList(head);
                var output = ListToArray(reversed);
                Console.WriteLine($"Input: [{string.Join(",", test)}] Output: [{string.Join(",", output)}]");
            }
        }
    }
}
