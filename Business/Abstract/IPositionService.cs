using Core.Results.Abstract;
using Entities.Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IPositionService
    {
        IResult Add(Position entity);
        IResult Update(Position entity);
        IResult Delete(Position entity);
        IDataResult<List<Position>> GetAll();
        IDataResult<Position> GetById(int id);
    }
}
