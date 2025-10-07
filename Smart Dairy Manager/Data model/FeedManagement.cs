using System.ComponentModel.DataAnnotations;

namespace Smart_Dairy_Manager.Data_model
{
    public class FeedManagement
    {
        [Key]
        public int FeedMGId { get; set; }
        public string? FoodType { get; set; }
        public DateTime FeedingTime { get; set; } = DateTime.Now;
        public double Quantity { get; set; }
        public string? FoodReports { get; set; }

    }
}
