namespace Bazele.Implementaions
{
    public struct QueueImplementation
    {
        Stack<int> input;
        Stack<int> output;

        public QueueImplementation()
        {
            input = new Stack<int>();
            output = new Stack<int>();
        }

        public void Enqueue(int value)
        {
            input.Push(value);
        }

        public int Dequeue()
        {
            if (output.Count == 0)
            {
                //Mutam toate elementele din stack-ul de input in stack-ul de output
                while (input.Count > 0)
                {
                    output.Push(input.Pop());
                }
            }

            return output.Pop();
        }

        public bool IsEmpty()
        {
            return input.Count == 0 && output.Count == 0;
        }

        public int Peek()
        {
            if (output.Count == 0)
            {
                while (input.Count > 0)
                {
                    output.Push(input.Pop());
                }
            }

            return output.Peek();
        }
    }
}
