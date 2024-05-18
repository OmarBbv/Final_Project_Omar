using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Entities.Concrete.TableModels;

namespace Business.Concrete
{
    public class PositionManager : IPositionService
    {
        PositionDal _position = new();

        public IResult Add(Position entity)
        {
            _position.Add(entity);
            return new SuccessResult(UIMessage.UIMessages.ADDED_MESSAGE);
        }

        public IResult Delete(Position entity)
        {
            _position.Delete(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Position>> GetAll()
        {
            var data = _position.GetAll();
            return new SuccessDataResult<List<Position>>(data);
        }

        public IDataResult<Position> GetById(int id)
        {
            var data = _position.GetById(id);
            return new SuccessDataResult<Position>(data);
        }

        public IResult Update(Position entity)
        {
            _position.Update(entity);
            return new SuccessResult(UIMessage.UIMessages.UPDATE_MESSAGE);
        }
    }
}
