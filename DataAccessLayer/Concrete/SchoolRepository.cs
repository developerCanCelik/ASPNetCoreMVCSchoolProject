using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class SchoolRepository : ISchoolRepository
    {
        public School CreateSchool(School p)
        {
            using (var context = new Context())
            {
                context.schools.Add(p);
                context.SaveChanges();
                return p;
            }
        }

        public void DeleteSchool(int id)
        {
            using (var context = new Context())
            {
                var deleteSchool = GetSchoolById(id);
                context.schools.Remove(deleteSchool);
                context.SaveChanges();
            }
        }

        public List<School> GetAllSchool()
        {
            using (var context = new Context())
            {
                return context.schools.ToList();
            }
        }

        public School GetSchoolById(int id)
        {
            using (var context = new Context())
            {
                return context.schools.Find(id);
            }
        }

        public School UpdateSchool(School p)
        {
            using (var context = new Context())
            {
                context.schools.Update(p);
                context.SaveChanges();
                return p;
            }
        }
    }
}
