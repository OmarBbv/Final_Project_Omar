using Business.Abstract;
using Business.UIMessage;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;

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

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _position.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
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
