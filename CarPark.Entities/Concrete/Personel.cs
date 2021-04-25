using System;
using System.Collections.Generic;

namespace CarPark.Entities.Concrete
{

    public class Personel : BaseModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string[] Roles { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public PersonelContact PersonelContact { get; set; }
        public short Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
