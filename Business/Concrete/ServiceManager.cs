using Business.Abstract;
using Business.UIMessage;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;

namespace Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        ServiceDal _service = new();

        public IResult Add(ServiceCreateDto dto)
        {
            var model = ServiceCreateDto.ToService(dto);
            _service.Add(model);
            return new SuccessResult(UIMessages.ADDED_MESSAGE);
        }

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _service.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Service>> GetAll()
        {
            var data = _service.GetAll();
            return new SuccessDataResult<List<Service>>(data);
        }

        public IDataResult<Service> GetById(int id)
        {
            var data = _service.GetById(id);
            return new SuccessDataResult<Service>(data);
        }

        public IResult Update(ServiceUpdateDto dto)
        {
            var model = ServiceUpdateDto.ToService(dto);
            model.LastUpdateDate = DateTime.Now;
            _service.Update(model);
            return new SuccessResult(UIMessages.UPDATE_MESSAGE);
        }
    }
}
