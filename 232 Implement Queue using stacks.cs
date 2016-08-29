public class Queue {
    Stack<int> inStack= new Stack<int>();
    Stack<int> outStack=new Stack<int>();
    
    // Push element x to the back of queue.
    public void Push(int x) {
         inStack.Push(x);
     
    }

    // Removes the element from front of queue.
    public void Pop() {
        Peek();
        outStack.Pop();
    }

    // Get the front element.
    public int Peek() {
        if(outStack.Count == 0)
        {
            
            while(inStack.Count !=0)
            {
                outStack.Push(inStack.Pop());   
            }
        }
        
            return outStack.Peek();
    }

    // Return whether the queue is empty.
    public bool Empty() {
        return (outStack.Count==0 && inStack.Count==0);
    }
}
