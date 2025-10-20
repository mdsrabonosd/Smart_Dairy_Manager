using System.ComponentModel.DataAnnotations;

namespace Smart_Dairy_Manager.Data_model
{
    public class MilkCollection
    {
        [Key]
        public int MilkCollectionId { get; set; }
        public int CowId { get; set; }
        public DateTime Date { get; set; }

        public int MorningYield { get; set; }
        public double EveningYield { get; set; }
        public double TotalYield { get; set; }

    }
}
