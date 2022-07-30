using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ISchoolRepository
    {
        List<School> GetAllSchool();
        School GetSchoolById(int id);
        School CreateSchool(School p);
        School UpdateSchool(School p);
        void DeleteSchool(int id);
    }
}
