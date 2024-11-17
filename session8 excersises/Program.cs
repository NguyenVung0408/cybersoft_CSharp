using System;
using BaiTap;

class Program
{
    static void Main()
    {
        // Bài 1
        int[] lstNumber = { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        Console.WriteLine("Bài 1 - Tổng các số trong mảng: " + Bai1.SumOfList(lstNumber));

        // Bài 2
        int[] nums2 = { 2, 7, 11, 15 };
        int target = 9;
        int[] result2 = Bai2.TwoSum(nums2, target);
        Console.WriteLine("Bài 2 - Chỉ số: [" + string.Join(", ", result2) + "]");

        // Bài 3
        int[] nums3 = { 1, 1, 2, 2, 3, 4, 4, 5 };
        int length3 = Bai3.RemoveDuplicates(nums3);
        Console.WriteLine("Bài 3 - Mảng sau khi loại bỏ trùng lặp: [" + string.Join(", ", nums3[..length3]) + "]");

        // Bài 4
        int[] nums4 = { 1, 1, 1, 2, 2, 3 };
        int k = 2;
        var result4 = Bai4.TopKFrequent(nums4, k);
        Console.WriteLine("Bài 4 - Các phần tử xuất hiện nhiều nhất: [" + string.Join(", ", result4) + "]");

        // Bài 5
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine("Bài 5 - Lợi nhuận lớn nhất: " + Bai5.MaxProfit(prices));
    }
}
