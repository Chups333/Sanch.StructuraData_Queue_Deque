using Sanch.StructuraData_Queue_Deque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_Queue_Deque
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EazyQueue
            //var eazyQueue = new EazyQueue<int>();
            //eazyQueue.Enqueue(1);
            //eazyQueue.Enqueue(2);
            //eazyQueue.Enqueue(3);
            //eazyQueue.Enqueue(4);
            //eazyQueue.Enqueue(5);

            //Console.WriteLine(eazyQueue.Dequeue());
            //Console.WriteLine(eazyQueue.Peek());
            //Console.WriteLine(eazyQueue.Dequeue());
            //Console.WriteLine(eazyQueue.Peek());
            #endregion

            #region ArrayQueue
            //var arrayQueue = new ArrayQueue<int>(10);
            //arrayQueue.Enqueue(1);
            //arrayQueue.Enqueue(2);
            //arrayQueue.Enqueue(3);
            //arrayQueue.Enqueue(4);
            //arrayQueue.Enqueue(5);

            //Console.WriteLine(arrayQueue.Dequeue());
            //Console.WriteLine(arrayQueue.Peek());
            //Console.WriteLine(arrayQueue.Dequeue());
            //Console.WriteLine(arrayQueue.Peek());
            #endregion

            #region LinkedListQueue
            //var linkedListQueue = new LinkedListQueue<int>();
            //linkedListQueue.Enqueue(1);
            //linkedListQueue.Enqueue(2);
            //linkedListQueue.Enqueue(3);
            //linkedListQueue.Enqueue(4);
            //linkedListQueue.Enqueue(5);

            //Console.WriteLine(linkedListQueue.Dequeue());
            //Console.WriteLine(linkedListQueue.Peek());
            //Console.WriteLine(linkedListQueue.Dequeue());
            //Console.WriteLine(linkedListQueue.Peek());
            #endregion

            #region EasyDeque
            //var easyDeque = new EasyDeque<int>();
            //easyDeque.PushFront(1);
            //easyDeque.PushFront(2);
            //easyDeque.PushFront(3);
            //easyDeque.PushBack(40);
            //easyDeque.PushBack(50);
            //easyDeque.PushFront(600);
            //easyDeque.PushBack(700);



            //Console.WriteLine(easyDeque.PopFront());
            //Console.WriteLine(easyDeque.PopBack());
            //Console.WriteLine(easyDeque.PopFront());
            //Console.WriteLine(easyDeque.PopBack());
            #endregion

            #region DuplexLinkedListDeque
            var duplexDeque = new DuplexLinkedListDeque<int>();
            duplexDeque.PushFront(1);
            duplexDeque.PushFront(2);
            duplexDeque.PushFront(3);
            duplexDeque.PushBack(40);
            duplexDeque.PushBack(50);
            duplexDeque.PushFront(600);
            duplexDeque.PushBack(700);



            Console.WriteLine(duplexDeque.PopFront());
            Console.WriteLine(duplexDeque.PopBack());
            Console.WriteLine(duplexDeque.PopFront());
            Console.WriteLine(duplexDeque.PopBack());
            #endregion

            Console.ReadLine();
        }
    }
}
