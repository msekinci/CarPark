using System.Collections.Generic;

namespace CarPark.Entities.Concrete
{
    public class SlotInformation : BaseModel
    {
        public ICollection<Translation> Translation { get; set; }
    }
}
