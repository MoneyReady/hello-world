﻿/**
 * File: linear_search.cs
 * Created Time: 2022-12-23
 * Author: haptear (haptear@hotmail.com)
 */

using hello_algo.include;
using NUnit.Framework;

namespace hello_algo.chapter_searching
{
    public class linear_search
    {
        /* 线性查找（数组） */
        static int linearSearch(int[] nums, int target)
        {
            // 遍历数组
            for (int i = 0; i < nums.Length; i++)
            {
                // 找到目标元素，返回其索引
                if (nums[i] == target)
                    return i;
            }
            // 未找到目标元素，返回 -1
            return -1;
        }

        /* 线性查找（链表） */
        static ListNode? linearSearch(ListNode head, int target)
        {
            // 遍历链表
            while (head != null)
            {
                // 找到目标结点，返回之
                if (head.val == target)
                    return head;
                head = head.next;
            }
            // 未找到目标结点，返回 null
            return null;
        }

        [Test]
        public void Test()
        {
            int target = 3;

            /* 在数组中执行线性查找 */
            int[] nums = { 1, 5, 3, 2, 4, 7, 5, 9, 10, 8 };
            int index = linearSearch(nums, target);
            Console.WriteLine("目标元素 3 的索引 = " + index);

            /* 在链表中执行线性查找 */
            ListNode head = ListNode.ArrToLinkedList(nums);
            ListNode? node = linearSearch(head, target);
            Console.WriteLine("目标结点值 3 的对应结点对象为 " + node);
        }
    }
}
