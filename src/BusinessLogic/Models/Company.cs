namespace BusinessLogic.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        public decimal AveragePackage { get; set; }
        public int OpenPositions { get; set; }
        public string JobDescription { get; set; }
        public string Requirements { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
