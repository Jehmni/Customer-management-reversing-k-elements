using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_b
{
    internal class CustomerQueue
    {
        // Private properties of the class
        private string[] queue = new string[10];
        private int count = 0;
        private int head = 0;
        private int tail = -1;  // Increment tail always before enqueue

        // Method to add to the queue
        public void Enqueue(string name, int age)
        {
            // Check if the queue is full before adding to it
            if (count < queue.Length)
            {
                tail = (tail + 1) % queue.Length; // Increment tail first and implement a cyclic queue using modulus
                queue[tail] = "Name: " + name + "     Age: " + age.ToString() + "."; // Add the user-supplied value to the tail of the queue
                count++;  // Increment count
            }
            else
            {
                throw new InvalidOperationException("Queue is full"); // Error message when the queue is full
            }
        }

        // Method to remove from the queue
        public string Dequeue()
        {
            // First, check if the queue has a value that can be removed
            if (count > 0)
            {
                string customer = queue[head]; // Remove from the head of the queue and assign it to a variable
                head = (head + 1) % queue.Length; // Increment head and implement a cyclic queue using modulus
                count--; // Decrement count
                return customer;
            }
            else
            {
                throw new InvalidOperationException("Queue is empty"); // Error message when the queue is empty
            }
        }

        // Get method for count to ensure it can be accessed publicly
        public int Count()
        {
            return count;
        }

        // Public get method for the queue
        public string[] GetQueue()
        {
            string[] result = new string[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = queue[(head + i) % queue.Length];
            }
            return result;
        }

        // Reverse the first 'k' elements of the queue
        public void Reverse(int reverseNum)
        {
            if (reverseNum < 0 || reverseNum >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(reverseNum), "Index out of range.");
            }

            string[] reversed = new string[count];
            reverseNum--;
            for (int i = reverseNum; i >= 0; i--)
            {
                reversed[reverseNum - i] = queue[i];
            }

            for (int i = reverseNum + 1; i < count; i++)
            {
                reversed[i] = queue[i];
            }

            queue = reversed;
        }
    }
}