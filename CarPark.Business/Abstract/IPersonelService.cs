using CarPark.Core.Models;
using CarPark.Entities.Concrete;

namespace CarPark.Business.Abstract
{
    public interface IPersonelService
    {
        GetManyResult<Personel> GetPersonelsByAge();
    }
}
