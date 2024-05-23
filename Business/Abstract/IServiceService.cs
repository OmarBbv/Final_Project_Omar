using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IServiceService
    {
        IResult Add(ServiceCreateDto entity);
        IResult Update(ServiceUpdateDto entity);
        IResult Delete(int id);
        IDataResult<List<Service>> GetAll();
        IDataResult<Service> GetById(int id);
    }
}
