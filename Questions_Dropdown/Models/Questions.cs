namespace Questions_Dropdown.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public required string Topic { get; set; }
        public required string Question { get;set; }
        public required string Answer { get;set; }
    }
}
