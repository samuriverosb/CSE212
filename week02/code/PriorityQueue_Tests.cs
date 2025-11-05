using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a priority queue wuth the following priorities: Bob (2), Tim (5), Sue (3)
    // Expected Result: [tim, sue, bob]
    // Defect(s) Found: Persons are not being removed from the queue correctly based on priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 5);
        var sue = new PriorityItem("Sue", 3);

        PriorityItem[] expectedResult = [tim, sue, bob];

        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, person);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Create a priority queue with the following priorities: Bob (2), Tim (5), Sue (3), Miguel (3)
    // Expected Result: [tim, sue, miguel, bob]
    // Defect(s) Found: It's keeping the last item with the highest priority instead of the first one.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 5);
        var sue = new PriorityItem("Sue", 3);
        var miguel = new PriorityItem("Miguel", 3);

        PriorityItem[] expectedResult = [tim, sue, miguel, bob];

        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);
        priorityQueue.Enqueue(miguel.Value, miguel.Priority);

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var person = priorityQueue.Dequeue();
            Console.WriteLine(person.ToString());
            Assert.AreEqual(expectedResult[i].Value, person);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Create a priority queue with the following priorities: Bob (2), Tim (5), Sue (3), Miguel (3)
    // Expected Result: [tim, sue, miguel, bob]
    // Defect(s) Found: It's keeping the last item with the highest priority instead of the first one.
    public void TestPriorityQueue_3()
    {
        var queue = new PriorityQueue();

        try
        {
            queue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}