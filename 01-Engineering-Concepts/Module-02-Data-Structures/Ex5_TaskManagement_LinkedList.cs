using System;

namespace DataStructuresAssignment
{
    // Real-world scenario: Tracking business flow dependencies via Node Links
    public class UserTask
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Status { get; set; }
    }

    public class Node
    {
        public UserTask Data { get; set; }
        public Node Next { get; set; }

        public Node(UserTask task)
        {
            Data = task;
            Next = null;
        }
    }

    public class TaskSinglyLinkedList
    {
        private Node head;

        // Adds a node to the absolute end of the link chain
        public void AddTask(UserTask taskData)
        {
            Node newNode = new Node(taskData);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        // Iterates down the chain node by node and dumps the data safely
        public void DisplayAllTasks()
        {
            if (head == null)
            {
                Console.WriteLine("The task manager queue is empty.");
                return;
            }

            Node current = head;
            while (current != null)
            {
                Console.WriteLine($"-> [ID: {current.Data.TaskId}] Name: {current.Data.TaskName} | Progress: {current.Data.Status}");
                current = current.Next;
            }
        }
    }

    class LinkProgram
    {
        static void Main(string[] args)
        {
            TaskSinglyLinkedList manager = new TaskSinglyLinkedList();

            manager.AddTask(new UserTask { TaskId = 1, TaskName = "Database Setup", Status = "Completed" });
            manager.AddTask(new UserTask { TaskId = 2, TaskName = "API Integration", Status = "In Progress" });
            manager.AddTask(new UserTask { TaskId = 3, TaskName = "Unit Testing UI", Status = "Pending" });

            Console.WriteLine("--- Displaying Task Singly Linked List Chain ---");
            manager.DisplayAllTasks();
        }
    }
}