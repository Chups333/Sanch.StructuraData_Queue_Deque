using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_Queue_Deque.Model
{
    public class EazyQueue<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count;

        public EazyQueue()
        {

        }
        public EazyQueue(T data)
        {
            //проверка
            items.Add(data);
        }

        public void Enqueue(T data)
        {
            items.Insert(0, data);//вставляем элемент в самое начало списка
        }

        public T Dequeue()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }
        public T Peek()
        {
            return Head;
        }
    }
}
