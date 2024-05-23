using Business.Abstract;
using Business.UIMessage;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;

namespace Business.Concrete
{
    public class PositionManager : IPositionService
    {
        PositionDal _position = new();

        public IResult Add(PositionCreateDto dto)
        {
            var model = PositionCreateDto.ToPosition(dto);
            _position.Add(model);
            return new SuccessResult(UIMessages.ADDED_MESSAGE);
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

        public IResult Update(PositionUpdateData dto)
        {
            var model = PositionUpdateData.ToPosition(dto);
            model.LastUpdateDate = DateTime.Now;
            _position.Update(model);
            return new SuccessResult(UIMessages.UPDATE_MESSAGE);
        }
    }
}
