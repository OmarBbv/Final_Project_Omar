using Core.Results.Abstract;
using Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface ITestimonialService
    {
        IResult Add(Testimonial entity);
        IResult Update(Testimonial entity);
        IResult Delete(Testimonial entity);
        IDataResult<List<Testimonial>> GetAll();
        IDataResult<Testimonial> GetById(int id);
    }
}
