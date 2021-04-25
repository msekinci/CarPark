using System.Collections.Generic;

namespace CarPark.Entities.Concrete
{
    public class WorkingDay : BaseModel
    {
        public ICollection<Translation> Translation { get; set; }
        public ICollection<WorkingHour> WorkingHours { get; set; }
    }
}
