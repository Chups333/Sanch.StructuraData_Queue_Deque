using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_Queue_Deque.Model
{
    public class LinkedListQueue<T>
    {
        private Item<T> head;
        private Item<T> tail;
        public int Count { get; private set; }

        public LinkedListQueue()
        {

        }
        public LinkedListQueue(T data)
        {
            //проверка
            SetHeadAndTailItem(data);
        }

        private void SetHeadAndTailItem(T data)
        {
            var item = new Item<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadAndTailItem(data);
                return;
            }

            var item = new Item<T>(data)
            {
                Next = tail
            };

            tail = item;
            Count++;

        }

        public T Dequeue()
        {
            var data = head.Data;
            var current = tail.Next;
            var previous = tail;
            while (current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            head = previous;
            head.Next = null;
            Count--;
            return data;
        }
        public T Peek()
        {
            return head.Data;
        }
    }
}
