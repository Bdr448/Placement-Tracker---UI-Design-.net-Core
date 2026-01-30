using BusinessLogic.Models;

namespace BusinessLogic.Services
{
    public class AuthenticationService
    {
        private static List<User> _users = new List<User>
        {
            new User 
            { 
                Id = 1, 
                Email = "admin@placement.com", 
                PasswordHash = HashPassword("admin123"), 
                FullName = "Admin User", 
                Phone = "9876543210",
                Role = UserRole.Admin,
                CreatedAt = DateTime.Now,
                IsActive = true
            },
            new User 
            { 
                Id = 2, 
                Email = "student1@placement.com", 
                PasswordHash = HashPassword("student123"), 
                FullName = "Raj Kumar", 
                Phone = "9123456789",
                Role = UserRole.Student,
                CreatedAt = DateTime.Now,
                IsActive = true
            },
            new User 
            { 
                Id = 3, 
                Email = "student2@placement.com", 
                PasswordHash = HashPassword("student123"), 
                FullName = "Priya Singh", 
                Phone = "9987654321",
                Role = UserRole.Student,
                CreatedAt = DateTime.Now,
                IsActive = true
            }
        };

        private static List<Student> _students = new List<Student>
        {
            new Student 
            { 
                Id = 1, 
                UserId = 2, 
                RollNumber = "STU001", 
                Department = "Computer Science",
                CGPA = 8.5m,
                Batch = "2023",
                Skills = "C#, ASP.NET, JavaScript, SQL",
                Resume = "resume_raj.pdf",
                CreatedAt = DateTime.Now
            },
            new Student 
            { 
                Id = 2, 
                UserId = 3, 
                RollNumber = "STU002", 
                Department = "Computer Science",
                CGPA = 8.8m,
                Batch = "2023",
                Skills = "Java, Python, Spring Boot, React",
                Resume = "resume_priya.pdf",
                CreatedAt = DateTime.Now
            }
        };

        public User? Login(string email, string password)
        {
            var user = _users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
            
            if (user == null || !VerifyPassword(password, user.PasswordHash))
                return null;

            return user;
        }

        public bool Register(string email, string password, string fullName, string phone, UserRole role)
        {
            if (_users.Any(u => u.Email.ToLower() == email.ToLower()))
                return false;

            var newUser = new User
            {
                Id = _users.Max(u => u.Id) + 1,
                Email = email,
                PasswordHash = HashPassword(password),
                FullName = fullName,
                Phone = phone,
                Role = role,
                CreatedAt = DateTime.Now,
                IsActive = true
            };

            _users.Add(newUser);

            // If student, create student profile
            if (role == UserRole.Student)
            {
                var student = new Student
                {
                    Id = _students.Max(s => (int?)s.Id) ?? 0 + 1,
                    UserId = newUser.Id,
                    RollNumber = $"STU{newUser.Id:D3}",
                    Department = "Computer Science",
                    CGPA = 0,
                    Batch = DateTime.Now.Year.ToString(),
                    Skills = "",
                    Resume = "",
                    CreatedAt = DateTime.Now
                };
                _students.Add(student);
            }

            return true;
        }

        public User? GetUserById(int userId)
        {
            return _users.FirstOrDefault(u => u.Id == userId);
        }

        public Student? GetStudentByUserId(int userId)
        {
            return _students.FirstOrDefault(s => s.UserId == userId);
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }

        private static string HashPassword(string password)
        {
            return Convert.ToBase64String(
                System.Security.Cryptography.SHA256.HashData(
                    System.Text.Encoding.UTF8.GetBytes(password)));
        }

        private static bool VerifyPassword(string password, string hash)
        {
            var hashOfInput = Convert.ToBase64String(
                System.Security.Cryptography.SHA256.HashData(
                    System.Text.Encoding.UTF8.GetBytes(password)));
            return hashOfInput.Equals(hash);
        }
    }
}
