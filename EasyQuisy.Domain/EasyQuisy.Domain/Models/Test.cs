namespace EasyQuisy.Domain.Models
{
    public class Test:EntityBase
    {
        public string Name { get; set; }
        public string Description  { get; set; }
        public Author Author { get; set; }
        public long AuthorId { get; set; }
        public long QuestionSettingsId { get; set; }
        public QuestionSettings QuestionSettings { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        
    }
}