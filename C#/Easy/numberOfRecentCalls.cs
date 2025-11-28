public class RecentCounter {
    Queue<int> myQueue;
    public RecentCounter() {
        myQueue = new Queue<int>();
    }
    
    public int Ping(int t) {
        myQueue.Enqueue(t);
        while (myQueue.Peek() < t - 3000) {
            myQueue.Dequeue();
        }
        return myQueue.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */