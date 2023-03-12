namespace EasyQuisy.Domain.Models
{
    public class QuestionSettings:EntityBase
    {
        public string QuantityOfQuestion { get; set; }
        public DateTime Time { get; set; }
        public string Name { get; set; }
        
        public string  AskQuestion { get; set; }
        public string OfferAnswer { get; set; }
        
        
    }
}