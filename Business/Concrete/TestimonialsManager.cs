using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Entities.Concrete.TableModels;

namespace Business.Concrete
{
    public class TestimonialsManager : ITestimonialService
    {
        TestimonialDal _testimonial = new();

        public IResult Add(Testimonial entity)
        {
            _testimonial.Add(entity);
            return new SuccessResult(UIMessage.UIMessages.ADDED_MESSAGE);
        }

        public IResult Delete(Testimonial entity)
        {
            _testimonial.Delete(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Testimonial>> GetAll()
        {
            var data = _testimonial.GetAll();
            return new SuccessDataResult<List<Testimonial>>(data);
        }

        public IDataResult<Testimonial> GetById(int id)
        {
            var data = _testimonial.GetById(id);
            return new SuccessDataResult<Testimonial>(data);
        }

        public IResult Update(Testimonial entity)
        {
            _testimonial.Update(entity);
            return new SuccessResult(UIMessage.UIMessages.UPDATE_MESSAGE);
        }
    }
}
