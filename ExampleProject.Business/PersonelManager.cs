using ExampleProject.Access;
using ExampleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Business
{
    public class PersonelManager : IPersonelService
    {

        private IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }
    }
}
