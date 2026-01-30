namespace BusinessLogic.Models
{
    public class Application
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CompanyId { get; set; }
        public ApplicationStatus Status { get; set; }
        public DateTime AppliedAt { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string InterviewLink { get; set; }
        public string InterviewNotes { get; set; }
    }

    public enum ApplicationStatus
    {
        Applied,
        Shortlisted,
        InterviewScheduled,
        Rejected,
        Accepted,
        Completed
    }
}
