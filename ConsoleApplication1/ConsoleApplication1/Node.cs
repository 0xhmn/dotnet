namespace Application1
{
    class Node<T>
    {
        private T _data;
        private Node<T> _next;
         
        public Node(T data, Node<T> next)
        {
            this._data = data;
            this._next = next;
        }

        public T GetData()
        {
            return _data;
        }

        public void SetData(T data)
        {
            this._data = data;
        }

        public Node<T> GetNextNode()
        {
            return _next;
        }

        public void SetNextNode(Node<T> next)
        {
            this._next = next;
        }
    }
}
