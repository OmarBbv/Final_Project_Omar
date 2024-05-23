using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IPositionService
    {
        IResult Add(PositionCreateDto entity);
        IResult Update(PositionUpdateData entity);
        IResult Delete(int id);
        IDataResult<List<Position>> GetAll();
        IDataResult<Position> GetById(int id);
    }
}
