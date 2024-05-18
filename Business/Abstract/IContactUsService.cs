using Core.Results.Abstract;
using Entities.Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IContactUsService
    {
        IResult Add(ContactUs entity);
        IResult Update(ContactUs entity);
        IResult Delete(ContactUs entity);
        IDataResult<List<ContactUs>> GetAll();
        IDataResult<ContactUs> GetById(int id);
    }
}
