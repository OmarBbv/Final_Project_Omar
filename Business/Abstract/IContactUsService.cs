using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IContactUsService
    {
        IResult Add(ContactUsCreateDto entity);
        IResult Update(ContactUsUpdateDto entity);
        IResult Delete(int id);
        IDataResult<List<ContactUs>> GetAll();
        IDataResult<ContactUs> GetById(int id);
    }
}
