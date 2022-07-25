using Core.Entity;

namespace AccountManager.Dto.Concrete
{
    public class AccountDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
