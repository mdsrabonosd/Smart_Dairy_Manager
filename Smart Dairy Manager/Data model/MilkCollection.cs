using System.ComponentModel.DataAnnotations;

namespace Smart_Dairy_Manager.Data_model
{
    public class MilkCollection
    {
        [Key]
        public int MilkCollectionId { get; set; }
        public int CowId { get; set; }
        public DateTime Date { get; set; }

        public double MorningYield { get; set; }// 0.5 kg/litter milk
        public double EveningYield { get; set; }
        public double TotalYield { get; set; }

    }
}
