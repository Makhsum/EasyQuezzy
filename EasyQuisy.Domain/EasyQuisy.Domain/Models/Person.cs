namespace EasyQuisy.Domain.Models
{
    public abstract class Person:EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        
    }
}