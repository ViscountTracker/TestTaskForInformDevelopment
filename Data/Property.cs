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
}
