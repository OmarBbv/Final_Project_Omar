using Business.Abstract;
using Business.UIMessage;
using Core.Extension;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class DestinationManager : IDestinationService
    {

        DestinationDal _destination = new();

        public IResult Add(DestinationCreateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = DestinationCreateDto.ToDestination(dto);
            model.PhotoUrl = PictureHelper.UploadImage(photoUrl, webRootPath);
            _destination.Add(model);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }


        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _destination.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
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

        public IResult Update(DestinationUpdateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = DestinationUpdateDto.ToDestination(dto);
            var value = GetById(dto.Id).Data;

            if (photoUrl == null)
                model.PhotoUrl = value.PhotoUrl;
            else
                model.PhotoUrl = PictureHelper.UploadImage(photoUrl, webRootPath);

            model.LastUpdateDate = DateTime.Now;
            _destination.Update(model);
            return new SuccessResult(UIMessages.UPDATE_MESSAGE);

        }
    }
}
