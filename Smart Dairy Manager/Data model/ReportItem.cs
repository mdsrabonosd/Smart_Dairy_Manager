namespace Smart_Dairy_Manager.Data_model
{
    public class ReportItem
    {
            public int Id { get; set; }
            public string Item { get; set; }
            public DateTime Date { get; set; }
            public string Quantity { get; set; }
            public decimal Total { get; set; }
        
    }
}
