using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        //testing adding items correctly in the queue
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Jose", 1); //adding items to the queue with its priority
        priorityQueue.Enqueue("Eliud", 2);
        priorityQueue.Enqueue("Quemba", 3);

        var result = priorityQueue.ToString(); //conveting it to string to compair the results
        Assert.AreEqual("[Jose (Pri:1), Eliud (Pri:2), Quemba (Pri:3)]", result);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        //testing removing items
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("High", 3);

        var dequeued = priorityQueue.Dequeue(); // getting the high priority item

        Debug.WriteLine(dequeued);

        Assert.AreEqual("High", dequeued, "Dequeue should return the highest-priority item."); //comparering
    }

    // Add more test cases as needed below.
    public void TestPriorityQueue_3()
    {
        //testing if it throws an exception when called on an empty queue
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
    public void TestPriorityQueue_4()
    {
        //testing if it mantains FIFO if priority are the same in between items
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Jose", 3); //adding items to the queue with its priority
        priorityQueue.Enqueue("Eliud", 3);
        priorityQueue.Enqueue("Quemba", 3);

        Assert.AreEqual("Jose", priorityQueue.Dequeue(), "FIFO order should be maintained for equal priorities.");
        Assert.AreEqual("Eliud", priorityQueue.Dequeue(), "FIFO order should be maintained for equal priorities.");
        Assert.AreEqual("Quemba", priorityQueue.Dequeue(), "FIFO order should be maintained for equal priorities.");
    }
}