using BusinessLogic.Models;

namespace BusinessLogic.Services
{
    public class CompanyService
    {
        private static List<Company> _companies = new List<Company>
        {
            new Company
            {
                Id = 1,
                Name = "Tech Solutions Ltd",
                Industry = "IT & Software",
                Email = "contact@techsol.com",
                Phone = "+91-98765-43210",
                ContactPerson = "John Smith",
                Location = "Bangalore",
                Website = "www.techsol.com",
                AveragePackage = 750000m,
                OpenPositions = 10,
                JobDescription = "Hiring Software Engineers for Cloud Development",
                Requirements = "BE/B.Tech in Computer Science, 0-2 years experience",
                CreatedAt = DateTime.Now,
                IsActive = true
            },
            new Company
            {
                Id = 2,
                Name = "Innovation Labs",
                Industry = "Software Development",
                Email = "hr@innovationlabs.com",
                Phone = "+91-88765-43210",
                ContactPerson = "Sarah Johnson",
                Location = "Hyderabad",
                Website = "www.innovationlabs.com",
                AveragePackage = 850000m,
                OpenPositions = 15,
                JobDescription = "Seeking Full Stack Developers for Enterprise Solutions",
                Requirements = "BE/B.Tech in CS/IT, Knowledge of MERN/Java Stack",
                CreatedAt = DateTime.Now,
                IsActive = true
            },
            new Company
            {
                Id = 3,
                Name = "Digital Systems",
                Industry = "IT Services",
                Email = "recruitment@digitalsys.com",
                Phone = "+91-77765-43210",
                ContactPerson = "Mike Wilson",
                Location = "Mumbai",
                Website = "www.digitalsys.com",
                AveragePackage = 650000m,
                OpenPositions = 20,
                JobDescription = "Hiring Developers and QA Engineers",
                Requirements = "Any Engineering Graduate, Basic Programming Skills",
                CreatedAt = DateTime.Now,
                IsActive = true
            }
        };

        public List<Company> GetAllCompanies()
        {
            return _companies.Where(c => c.IsActive).ToList();
        }

        public Company? GetCompanyById(int id)
        {
            return _companies.FirstOrDefault(c => c.Id == id);
        }

        public bool AddCompany(Company company)
        {
            company.Id = _companies.Max(c => (int?)c.Id) ?? 0 + 1;
            company.CreatedAt = DateTime.Now;
            company.IsActive = true;
            _companies.Add(company);
            return true;
        }

        public bool UpdateCompany(Company company)
        {
            var existing = _companies.FirstOrDefault(c => c.Id == company.Id);
            if (existing == null) return false;

            existing.Name = company.Name;
            existing.Industry = company.Industry;
            existing.Email = company.Email;
            existing.Phone = company.Phone;
            existing.ContactPerson = company.ContactPerson;
            existing.Location = company.Location;
            existing.Website = company.Website;
            existing.AveragePackage = company.AveragePackage;
            existing.OpenPositions = company.OpenPositions;
            existing.JobDescription = company.JobDescription;
            existing.Requirements = company.Requirements;

            return true;
        }

        public bool DeleteCompany(int id)
        {
            var company = _companies.FirstOrDefault(c => c.Id == id);
            if (company == null) return false;
            company.IsActive = false;
            return true;
        }

        public List<Company> SearchCompanies(string query)
        {
            return _companies
                .Where(c => c.IsActive &&
                       (c.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                        c.Industry.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                        c.Location.Contains(query, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }
    }
}
