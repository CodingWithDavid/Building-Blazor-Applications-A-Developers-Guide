namespace Chapter3.Services
{
    public class CounterService
    {
        public int Count { get; private set; }

        public void IncrementCount()
        {
            Count++;
        }

        public void ResetCount()
        {
            Count = 0;
        }
    }
}
