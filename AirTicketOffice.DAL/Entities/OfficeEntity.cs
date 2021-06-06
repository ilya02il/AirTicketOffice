﻿using System.Collections.Generic;

namespace AirTicketOffice.DAL.Entities
{
    public class OfficeEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }

        public ICollection<OrderEntity> Orders { get; set; }

        public OfficeEntity()
        {
            Orders = new List<OrderEntity>();
        }
    }
}
