using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ITestimonialService
    {
        IResult Add(TestimonialCreateDto dto, IFormFile photoUrl, string webRootPath);
        IResult Update(TestimonialUpdateDto dto, IFormFile photoUrl, string webRootPath);
        IResult Delete(int id);
        IDataResult<List<Testimonial>> GetAll();
        IDataResult<Testimonial> GetById(int id);
    }
}
