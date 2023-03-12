namespace EasyQuisy.Domain.Models
{
    public class Ansver:EntityBase
    {
        public string Body { get; set; }
        
        public bool IsRight { get; set; }
        public long QuestionId { get; set; }
        
        
        public Question Question { get; set; }
        
        
        
    }
}