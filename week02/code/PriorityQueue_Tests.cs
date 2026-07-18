using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three elements with distinct rising priorities (1, 3, 5), keeping the highest 
    // priority value localized at the absolute final index of the array list structure.
    // Expected Result: "Gold" (Pri: 5), then "Silver" (Pri: 3), then "Bronze" (Pri: 1)
    // Defect(s) Found: The loop condition `_queue.Count - 1` skipped examining the item at the final index. 
    // Additionally, nodes were never removed from the tracking array upon Dequeue calls.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bronze", 1);
        priorityQueue.Enqueue("Silver", 3);
        priorityQueue.Enqueue("Gold", 5);

        Assert.AreEqual("Gold", priorityQueue.Dequeue());
        Assert.AreEqual("Silver", priorityQueue.Dequeue());
        Assert.AreEqual("Bronze", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple values that share duplicate maximum priority numbers to verify 
    // compliance with foundational FIFO rules.
    // Expected Result: "First High" must arrive out first because it is closest to the front boundary, followed by "Second High".
    // Defect(s) Found: The logical assignment evaluated priorities using `>=` instead of strictly `>`, 
    // causing it to replace older matches with newer ones further back in line.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First High", 5);
        priorityQueue.Enqueue("Low", 2);
        priorityQueue.Enqueue("Second High", 5);

        Assert.AreEqual("First High", priorityQueue.Dequeue());
        Assert.AreEqual("Second High", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue zero nodes and attempt to execute a Dequeue query on an empty collection instance.
    // Expected Result: InvalidOperationException thrown with message "The queue is empty."
    // Defect(s) Found: None. The safety check block was correctly tracking an empty count context.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("An exception should have been thrown for an empty queue.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}