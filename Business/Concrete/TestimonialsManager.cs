using Business.Abstract;
using Business.UIMessage;
using Core.Extension;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class TestimonialsManager : ITestimonialService
    {
        TestimonialDal _testimonial = new();

        public IResult Add(TestimonialCreateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = TestimonialCreateDto.ToTestimonial(dto);
            model.PhotoUrl = PictureHelper.UploadImage(photoUrl, webRootPath);
            _testimonial.Add(model);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _testimonial.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
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

        public IResult Update(TestimonialUpdateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = TestimonialUpdateDto.ToTestimonial(dto);
            var value = GetById(dto.Id).Data;

            if (photoUrl == null)
                model.PhotoUrl = value.PhotoUrl;
            else
                model.PhotoUrl = PictureHelper.UploadImage(photoUrl, webRootPath);

            model.LastUpdateDate = DateTime.Now;
            _testimonial.Update(model);
            return new SuccessResult(UIMessages.UPDATE_MESSAGE);
        }
    }
}
