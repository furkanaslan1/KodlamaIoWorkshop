using KodlamaIoWorkshop.Business.Dtos.Requests;
using KodlamaIoWorkshop.Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoWorkshop.Business.Abstract
{
     public interface ITeacherService

    {
        public void Add(CreateTeacherRequest createTeacherRequest);

        public void Update(UpdateTeacherRequest updateTeacherRequest);

        public void Delete(DeleteTeacherRequest deleteTeacherRequest);

        public List<GetAllTeacherResponse> GetAll();

        public GetByIdTeacherResponse GetByIdTeacher(int id);
    }
}
