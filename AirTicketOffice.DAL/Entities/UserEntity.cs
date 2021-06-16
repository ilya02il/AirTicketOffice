using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
    public class UserEntity : IEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool Proxy { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public string PassportNumber { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<TicketEntity> Tickets { get; set; }
        public virtual ICollection<OrderEntity> Orders { get; set; }
    }
}
