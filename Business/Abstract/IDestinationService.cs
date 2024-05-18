using Core.Results.Abstract;
using Entities.Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IDestinationService
    {
        IResult Add(Destination entity);
        IResult Update(Destination entity);
        IResult Delete(Destination entity);
        IDataResult<List<Destination>> GetAll();
        IDataResult<Destination> GetById(int id);
    }
}
