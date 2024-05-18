using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Entities.Concrete.TableModels;
using System.Diagnostics.Contracts;

namespace Business.Concrete
{
    public class DestinationManager : IDestinationService
    {

        DestinationDal _destination = new();

        public IResult Add(Destination entity)
        {
            _destination.Add(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IResult Delete(Destination entity)
        {
            _destination.Delete(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Destination>> GetAll()
        {
            var data = _destination.GetAll();
            return new SuccessDataResult<List<Destination>>(data);
        }

        public IDataResult<Destination> GetById(int id)
        {
            var data = _destination.GetById(id);
            return new SuccessDataResult<Destination>(data);
        }

        public IResult Update(Destination entity)
        {
            _destination.Update(entity);
            return new SuccessResult(UIMessage.UIMessages.UPDATE_MESSAGE);
        }
    }
}
