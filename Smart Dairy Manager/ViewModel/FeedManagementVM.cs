namespace Smart_Dairy_Manager.ViewModel
{
    public class FeedManagementVM
    {
        public int FeedMGId { get; set; }
        public int CowId { get; set; }
        public string? FoodType { get; set; }
        public DateTime FeedingTime { get; set; } = DateTime.Now;
        public double Quantity { get; set; }
        public string? FoodReports { get; set; }
    }
}
