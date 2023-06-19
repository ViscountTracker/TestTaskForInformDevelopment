namespace TestTaskForInformDevelopment.Data
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Owner { get; set; }
        public string Type { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int InitialValue { get; set; }
        public int PriceDepreciationPeriod { get; set; }
        public int PriceDepreciation { get; set; }
        public int CurrentValue { get; set; }
        
    }
   
}
