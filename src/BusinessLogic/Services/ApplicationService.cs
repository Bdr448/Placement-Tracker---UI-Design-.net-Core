using BusinessLogic.Models;

namespace BusinessLogic.Services
{
    public class ApplicationService
    {
        private static List<Application> _applications = new List<Application>
        {
            new Application
            {
                Id = 1,
                StudentId = 1,
                CompanyId = 1,
                Status = ApplicationStatus.Shortlisted,
                AppliedAt = DateTime.Now.AddDays(-5),
                InterviewDate = DateTime.Now.AddDays(3),
                InterviewLink = "https://meet.google.com/abc-defg-hij",
                InterviewNotes = "Technical round scheduled"
            }
        };

        public List<Application> GetApplicationsByStudent(int studentId)
        {
            return _applications.Where(a => a.StudentId == studentId).ToList();
        }

        public List<Application> GetApplicationsByCompany(int companyId)
        {
            return _applications.Where(a => a.CompanyId == companyId).ToList();
        }

        public bool ApplyForCompany(int studentId, int companyId)
        {
            // Check if already applied
            if (_applications.Any(a => a.StudentId == studentId && a.CompanyId == companyId))
                return false;

            var application = new Application
            {
                Id = _applications.Max(a => (int?)a.Id) ?? 0 + 1,
                StudentId = studentId,
                CompanyId = companyId,
                Status = ApplicationStatus.Applied,
                AppliedAt = DateTime.Now
            };

            _applications.Add(application);
            return true;
        }

        public bool UpdateApplicationStatus(int applicationId, ApplicationStatus status)
        {
            var app = _applications.FirstOrDefault(a => a.Id == applicationId);
            if (app == null) return false;

            app.Status = status;
            return true;
        }

        public bool ScheduleInterview(int applicationId, DateTime interviewDate, string interviewLink)
        {
            var app = _applications.FirstOrDefault(a => a.Id == applicationId);
            if (app == null) return false;

            app.Status = ApplicationStatus.InterviewScheduled;
            app.InterviewDate = interviewDate;
            app.InterviewLink = interviewLink;
            return true;
        }

        public Application? GetApplicationById(int id)
        {
            return _applications.FirstOrDefault(a => a.Id == id);
        }

        public List<Application> GetAllApplications()
        {
            return _applications;
        }

        public int GetPlacedStudentsCount()
        {
            return _applications.Where(a => a.Status == ApplicationStatus.Accepted).Select(a => a.StudentId).Distinct().Count();
        }

        public int GetPendingApplicationsCount()
        {
            return _applications.Where(a => a.Status == ApplicationStatus.Applied || a.Status == ApplicationStatus.Shortlisted).Count();
        }

        public int GetScheduledInterviewsCount()
        {
            return _applications.Where(a => a.Status == ApplicationStatus.InterviewScheduled && a.InterviewDate.HasValue && a.InterviewDate.Value > DateTime.Now).Count();
        }
    }
}
