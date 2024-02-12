using KodlamaIoWorkshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoWorkshop.DataAccess.Abstract
{
    public interface ICourseDal
    {
        public void Add(Course course);
        public void Delete(Course course);
        public void Update(Course course);

        public List<Course> GetAll();

        public Course GetById(int id);

    }
}
