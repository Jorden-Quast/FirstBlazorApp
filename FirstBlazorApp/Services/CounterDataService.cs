namespace FirstBlazorApp.Services
{
    public class CounterDataService
    {
        // The two variables we're tracking, what the count is and how much to increase the count every time
        int Count { get; set; } = 0;
        public int IncrementAmount { get; set; } = 1;

        // An action is a delegate function. We set this anywhere we want to handle an updated count
        public Action OnCountUpdate { get; set; }

        public int GetIncrementAmount() { return IncrementAmount; }

        public int GetCount() { return Count; }

        public void SetIncrementAmount(int newAmount) { IncrementAmount = newAmount; }
        
        public void UpdateCount()
        {
            Count += IncrementAmount;
            OnCountUpdate?.Invoke();
        }


    }
}
