using System;

namespace DataStructuresAssignment
{
    // Real-world scenario: Searching for product arrays by ProductId
    public class Product : IComparable<Product>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public int CompareTo(Product other)
        {
            if (other == null) return 1;
            return this.ProductId.CompareTo(other.ProductId);
        }
    }

    public class SearchEngine
    {
        // Linear Search implementation (O(n) complex lookup)
        public static int LinearSearch(Product[] list, int targetId)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].ProductId == targetId)
                    return i;
            }
            return -1;
        }

        // Binary Search implementation (O(log n) complex lookup - requires items sorted)
        public static int BinarySearch(Product[] sortedList, int targetId)
        {
            int left = 0;
            int right = sortedList.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (sortedList[mid].ProductId == targetId)
                    return mid;

                if (sortedList[mid].ProductId < targetId)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }

    class SearchProgram
    {
        static void Main(string[] args)
        {
            Product[] inventory = new Product[]
            {
                new Product { ProductId = 101, ProductName = "Laptop", Category = "Electronics" },
                new Product { ProductId = 105, ProductName = "Smartphone", Category = "Electronics" },
                new Product { ProductId = 110, ProductName = "Wireless Headphones", Category = "Audio" },
                new Product { ProductId = 120, ProductName = "Mechanical Keyboard", Category = "Peripherals" }
            };

            int searchId = 110;

            // Execute linear evaluation 
            int linIndex = SearchEngine.LinearSearch(inventory, searchId);
            Console.WriteLine($"[Linear Search] Item found at array index: {linIndex}");

            // Execute binary evaluation (Inventory is pre-sorted by ID)
            int binIndex = SearchEngine.BinarySearch(inventory, searchId);
            Console.WriteLine($"[Binary Search] Item found at array index: {binIndex}");
        }
    }
}