using CarPark.Business.Abstract;
using CarPark.Core.Models;
using CarPark.DataAccess.Abstract;
using CarPark.Entities.Concrete;

namespace CarPark.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDataAccess _personelDataAccess;

        public PersonelManager(IPersonelDataAccess personelDataAccess)
        {
            _personelDataAccess = personelDataAccess;
        }

        public GetManyResult<Personel> GetPersonelsByAge()
        {
            var personelList = _personelDataAccess.GetAll();
            return personelList;
        }
    }
}
