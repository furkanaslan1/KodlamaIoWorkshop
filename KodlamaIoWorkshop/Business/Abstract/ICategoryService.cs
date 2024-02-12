using KodlamaIoWorkshop.Business.Dtos.Requests;
using KodlamaIoWorkshop.Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoWorkshop.Business.Abstract
{
    public interface ICategoryService
    {
        public void Add(CreateCategoryRequest createCategoryRequest);

        public void Update(UpdateCategoryRequest updateCategoryRequest);

        public void Delete(DeleteCategoryRequest deleteCategoryRequest);

        public List<GetAllCategoryResponse> GetAll();

        public GetByIdCategoryResponse GetByIdCategory(int id);
    }
}
