namespace TestTaskForInformDevelopment.Data
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Owner { get; set; }
        public string Type { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal InitialValue { get; set; }
        public string PriceDepreciationPeriod { get; set; }
        public decimal PriceDepreciation { get; set; }
        public decimal CurrentValue { get; set; }
    }
    public double CurrentValue()
    {
        get
        {
            var daysOwned = DateTime.Now - PurchaseDateTime; // Днів володіння власністю

            // Ініціалізація змінних
            int periodCount = 0;
            int periodDays = PriceDepreciationPeriod;
            double totalDays = daysOwned.TotalDays;

            if (periodDays > 0)
            {
                periodCount = (int)(totalDays / periodDays);
            }

            return InitialValue - (PriceDepreciation * periodCount);
        }

    }
}
