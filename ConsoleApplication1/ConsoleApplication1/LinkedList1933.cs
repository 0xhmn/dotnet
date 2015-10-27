using System;
using System.Collections;
using System.Collections.Generic;

namespace Application1
{
    public class LinkedList1933<T> : IList<T>
        where T : class
    {
        private Node<T> _head = new Node<T>(null, null);
        public int ListCount { get; set; }

        public LinkedList1933()
        {
            ListCount = 0;
        }

        #region IEnumerator implementations
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        #region overriden methods

        public int Count => this.ListCount;
        public void Add(T item)
        {
            // we are adding every new node as the last node to the list
            var data = new Node<T>(item, null);
            var list = _head;
            while (list.GetNextNode() != null)  // if it's null it meand that's the last node
            {
                list = list.GetNextNode();
            }
            list.SetNextNode(data);
            ListCount++;
        }

        public bool Remove(T item)
        {
            var temp = new Node<T>(null, null);
            var list = _head;
            while (list.GetNextNode() != null)
            {
                if (item.Equals(list.GetData()))
                {
                    list.SetNextNode(list.GetNextNode().GetNextNode());
                    ListCount--;
                    return true;
                }
                list = list.GetNextNode();
            }
            return false;
        }

        public bool Contains(T item)
        {
            var list = _head;
            while (list.GetNextNode() != null)
            {
                if (item.Equals(list.GetData()))
                {
                    return true;
                }
                list = list.GetNextNode();
            }
            return false;
        }

        public void Insert(int index, T item)
        {
            var list = _head;
            var newNode = new Node<T>(item, null);
            for (var i = 0; i < index; i++)
            {
                list = list.GetNextNode();
            }
            list.SetNextNode(newNode);
            newNode.SetNextNode(list.GetNextNode());
            ListCount++;
        }

        public T this[int index]
        {
            get
            {
                var list = _head.GetNextNode();
                for (var i = 0; i < index; i ++)
                {
                    list = list.GetNextNode();
                }
                return list.GetData();
            }
            set { throw new NotImplementedException(); }
        }

        #endregion

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool IsReadOnly { get; }
        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }


    }
}
