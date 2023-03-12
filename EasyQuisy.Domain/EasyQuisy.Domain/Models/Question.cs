namespace EasyQuisy.Domain.Models
{
    public class Question:EntityBase
    {
        public string TypeOfQuestion { get; set; }
        public string QuestionBody { get; set; }
        
        public IEnumerable<string> VariantsOfAnsvers { get; set; }
        
        
        
        
    }
}