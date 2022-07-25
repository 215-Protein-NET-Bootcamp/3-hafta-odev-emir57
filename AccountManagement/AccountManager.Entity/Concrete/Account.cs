using Core.Entity;
using System.ComponentModel.DataAnnotations;

namespace AccountManager.Entity.Concrete
{
    public class Account : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime LastActivity { get; set; }
    }
}
