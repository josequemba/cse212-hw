using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding many elements to the queue and verifying the order.
    // Expected Result: Items should be stored in the queue maintaining their priority order.
    // Defect(s) Found: The queue does not correctly puts the elements based on their priority,
    // they are put in insertion order instead of being rearranged based on priority.
    public void TestPriorityQueue_1()
    {
        //testing adding items correctly in the queue
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Jose", 1); //adding items to the queue with its priority
        priorityQueue.Enqueue("Eliud", 2);
        priorityQueue.Enqueue("Quemba", 3);

        var result = priorityQueue.ToString(); //conveting it to string to compair the results
        Assert.AreEqual("[Jose (Pri:1), Eliud (Pri:2), Quemba (Pri:3)]", result, "Queue have to store items in descending order following priority.");
    }

    [TestMethod]
    // Scenario: Dequeuing the highest priority item from the queue.
    // Expected Result: The item with the highest priority should be removed first.
    // Defect(s) Found: No defects found.
    public void TestPriorityQueue_2()
    { 
        //testing removing items
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("High", 3);

        var dequeued = priorityQueue.Dequeue(); // getting the high priority item

        //Debug.WriteLine(dequeued);

        Assert.AreEqual("High", dequeued, "Dequeue should return the highest-priority item."); //comparering
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: calling Dequeue on an empty queue.
    // Expected Result: An InvalidOperationException error should be thrown.
    // Defect(s) Found: No defects found.
    public void TestPriorityQueue_3()
    {
        //testing if it throws an exception when called on an empty queue
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Testing FIFO power when multiple items have the same priority.
    // Expected Result: Items with the same priority should be dequeued in the order they were enqueued.
    // Defect(s) Found: No defects found items are being removed in the order they were enqueued.
    public void TestPriorityQueue_4()
    {
        //testing if it mantains FIFO if priority are the same in between items
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Jose", 3); //adding items to the queue with its priority
        priorityQueue.Enqueue("Eliud", 3);
        priorityQueue.Enqueue("Quemba", 3);

        //handles asserssions in FIFO order
        Assert.AreEqual("Jose", priorityQueue.Dequeue(), "FIFO order should be maintained for equal priorities.");
        Assert.AreEqual("Eliud", priorityQueue.Dequeue(), "FIFO order should be maintained for equal priorities.");
        Assert.AreEqual("Quemba", priorityQueue.Dequeue(), "FIFO order should be maintained for equal priorities.");
    }

    [TestMethod]
    // Scenario: Enqueueing items with mixed priority values and dequeuing them in order.
    // Expected Result: Items should be dequeued in descending priority order.
    // Defect(s) Found: The queue does not maintain priorities based on the 
    // order when inserting the items, with different priorities.
    public void TestPriorityQueue_5()
    {
        //testing adding items correctly in the queue
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Jose", 5);
        priorityQueue.Enqueue("Eliud", 1);
        priorityQueue.Enqueue("Dias", 3);
        priorityQueue.Enqueue("Dos", 4);
        priorityQueue.Enqueue("Santos", 2);

        //handles asserssions in the descending order
        Assert.AreEqual("Jose", priorityQueue.Dequeue(), "Highest priority item should be dequeued first.");
        Assert.AreEqual("Dos", priorityQueue.Dequeue(), "Second highest priority item should be dequeued second.");
        Assert.AreEqual("Dias", priorityQueue.Dequeue(), "Third highest priority item should be dequeued third.");
        Assert.AreEqual("Santos", priorityQueue.Dequeue(), "Fourth highest priority item should be dequeued fourth.");
        Assert.AreEqual("Eliud", priorityQueue.Dequeue(), "Lowest priority item should be dequeued last.");
    }

    [TestMethod]
    // Scenario: Enqueueing items with duplicate priorities and verifying order.
    // Expected Result: The queue should maintain relative FIFO order for items with the same priority.
    // Defect(s) Found: No defects found.
    public void TestPriorityQueue_6()
    {
        //testing adding items correctly in the queue
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Jose", 2);
        priorityQueue.Enqueue("Eliud", 5);
        priorityQueue.Enqueue("Dias", 5);
        priorityQueue.Enqueue("Dos", 3);
        priorityQueue.Enqueue("Santos", 2);

        //handles asserssions in the descending order
        Assert.AreEqual("Eliud", priorityQueue.Dequeue(), "Highest priority item should be dequeued first.");
        Assert.AreEqual("Dias", priorityQueue.Dequeue(), "Next highest priority item should be dequeued second.");
        Assert.AreEqual("Dos", priorityQueue.Dequeue(), "Third highest priority item should be dequeued third.");
        Assert.AreEqual("Jose", priorityQueue.Dequeue(), "FIFO order should be maintained for equal priorities.");
        Assert.AreEqual("Santos", priorityQueue.Dequeue(), "FIFO order should be maintained for equal priorities.");
    }
}