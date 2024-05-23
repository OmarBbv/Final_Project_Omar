using Business.Abstract;
using Business.UIMessage;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;

namespace Business.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        ContactUsDal _contact = new();

        public IResult Add(ContactUsCreateDto dto)
        {
            var model = ContactUsCreateDto.ToContactUsDto(dto);
            _contact.Add(model);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _contact.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<ContactUs>> GetAll()
        {
            var data = _contact.GetAll();
            return new SuccessDataResult<List<ContactUs>>(data);
        }

        public IDataResult<ContactUs> GetById(int id)
        {
            var data = _contact.GetById(id);
            return new SuccessDataResult<ContactUs>(data);
        }

        public IResult Update(ContactUsUpdateDto dto)
        {
            var model = ContactUsUpdateDto.ToContactUs(dto);
            model.LastUpdateDate = DateTime.Now;
            _contact.Update(model);
            return new SuccessResult(UIMessages.UPDATE_MESSAGE);
        }
    }
}
