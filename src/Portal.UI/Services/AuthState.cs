using BusinessLogic.Models;

namespace Portal.UI.Services
{
    public class AuthState
    {
        public User? CurrentUser { get; set; }
        public bool IsAuthenticated => CurrentUser != null;
        public UserRole? UserRole => CurrentUser?.Role;
        public string UserName => CurrentUser?.FullName ?? "Guest";
        public int? UserId => CurrentUser?.Id;

        public event Action? OnStateChanged;

        public void SetUser(User? user)
        {
            CurrentUser = user;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnStateChanged?.Invoke();
    }
}
