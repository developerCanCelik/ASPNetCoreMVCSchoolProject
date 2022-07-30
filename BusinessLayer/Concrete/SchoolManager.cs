using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SchoolManager : ISchoolService
    {
        private ISchoolRepository _schoolRepositroy;
        public SchoolManager()
        {
            _schoolRepositroy = new SchoolRepository();
        }
        public School CreateSchool(School p)
        {
            return _schoolRepositroy.CreateSchool(p);
        }

        public void DeleteSchool(int id)
        {
            _schoolRepositroy.DeleteSchool(id);
        }

        public List<School> GetAllSchool()
        {
            return _schoolRepositroy.GetAllSchool();
        }

        public School GetSchoolById(int id)
        {
            if (id > 0)
            {
                return _schoolRepositroy.GetSchoolById(id);
            }
            throw new Exception("ID sıfırdan küçük olamaz");
        }

        public School UpdateSchool(School p)
        {
            return _schoolRepositroy.UpdateSchool(p);
        }
    }
}
