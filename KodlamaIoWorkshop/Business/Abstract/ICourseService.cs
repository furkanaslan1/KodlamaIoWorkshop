using KodlamaIoWorkshop.Business.Dtos.Requests;
using KodlamaIoWorkshop.Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoWorkshop.Business.Abstract
{
    public interface ICourseService

    {
        public void Add(CreateCourseRequest createCourseRequest);

        public void Update(UpdateCourseRequest updateCourseRequest);

        public void Delete(DeleteCourseRequest deleteCourseRequest);

        public List<GetAllCourseResponse> GetAll();

        public GetByIdCourseResponse GetByIdCourse(int id);
    }
}
