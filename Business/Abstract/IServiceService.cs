using Core.Results.Abstract;
using Entities.Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IServiceService
    {
        IResult Add(Service entity);
        IResult Update(Service entity);
        IResult Delete(Service entity);
        IDataResult<List<Service>> GetAll();
        IDataResult<Service> GetById(int id);
    }
}
