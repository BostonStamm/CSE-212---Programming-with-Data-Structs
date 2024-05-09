using System.Runtime.CompilerServices;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        // var priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following items and priority:
        // Homework (5), Dishes (3), Laundry (4), Cleaning (2), Hobby (1).
        // Expected Result: Homework, Laundry, Dishes, Cleaning, Hobby.
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Homework", 5);
        priorityQueue.Enqueue("Dishes", 3);
        priorityQueue.Enqueue("Laundry", 4);
        priorityQueue.Enqueue("Cleaning", 2);
        priorityQueue.Enqueue("Hobby", 1);
        for(int i = 0; i < 5; i++){
            // var item = priorityQueue.Dequeue();
            Console.WriteLine(priorityQueue.Dequeue());
        }

        // Defect(s) Found: Dequeue wasn't removing items.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Try to get an error for an empty queue.
        // Expected Result: Error message should be displayed.
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: Create a queue with the following items and priority:
        // Homework (3), Dishes (2), Laundry (3), Cleaning (2), Hobby (1).
        // Expected Result: Homework, Laundry, Dishes, Cleaning, Hobby.
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Homework", 3);
        priorityQueue.Enqueue("Dishes", 2);
        priorityQueue.Enqueue("Laundry", 3);
        priorityQueue.Enqueue("Cleaning", 2);
        priorityQueue.Enqueue("Hobby", 1);
        for(int i = 0; i < 5; i++){
            // var item = priorityQueue.Dequeue();
            Console.WriteLine(priorityQueue.Dequeue());
        }
        
        // Defect(s) Found: Dequeue is taking the rightmost value, not the leftmost.
    }
}