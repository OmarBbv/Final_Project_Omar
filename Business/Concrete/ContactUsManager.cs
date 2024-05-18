using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Entities.Concrete.TableModels;

namespace Business.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        ContactUsDal _contact= new();

        public IResult Add(ContactUs entity)
        {
            _contact.Add(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IResult Delete(ContactUs entity)
        {
            _contact.Delete(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
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

        public IResult Update(ContactUs entity)
        {
            _contact.Update(entity);
            return new SuccessResult(UIMessage.UIMessages.UPDATE_MESSAGE);
        }
    }
}
