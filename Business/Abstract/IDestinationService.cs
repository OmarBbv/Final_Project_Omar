using Core.Results.Abstract;
using Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IDestinationService
    {
        IResult Add(Destination entity);
        IResult Update(Destination entity);
        IResult Delete(int id);
        IDataResult<List<Destination>> GetAll();
        IDataResult<Destination> GetById(int id);
    }
}
