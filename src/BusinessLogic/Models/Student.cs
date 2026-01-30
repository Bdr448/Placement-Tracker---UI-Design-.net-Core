namespace BusinessLogic.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? RollNumber { get; set; }
        public string? Department { get; set; }
        public decimal CGPA { get; set; }
        public string? Batch { get; set; }
        public string? Skills { get; set; }
        public string? Resume { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
