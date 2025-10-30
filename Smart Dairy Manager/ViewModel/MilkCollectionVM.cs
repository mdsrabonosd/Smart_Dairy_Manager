namespace Smart_Dairy_Manager.ViewModel
{
    public class MilkCollectionVM
    {
        public int MilkCollectionId { get; set; }
        public int CowId { get; set; }
        public DateTime Date { get; set; }

        public int MorningYield { get; set; }
        public double EveningYield { get; set; }
        public double TotalYield { get; set; }

    }
}
