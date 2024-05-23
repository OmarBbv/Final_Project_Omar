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
    public class AboutManager : IAboutService
    {
        AboutDal _about = new();

        public IResult Add(AboutCreateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = AboutCreateDto.ToAbout(dto);
            model.PhotoUrl = PictureHelper.UploadImage(photoUrl, webRootPath);
            _about.Add(model);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _about.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<About>> GetAll()
        {
            var data = _about.GetAll();
            return new SuccessDataResult<List<About>>(data);
        }

        public IDataResult<About> GetById(int id)
        {
            var data = _about.GetById(id);
            return new SuccessDataResult<About>(data);
        }

        public IResult Update(AboutUpdateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = AboutUpdateDto.ToAbout(dto);
            var value = GetById(dto.Id).Data;
            if (photoUrl == null)
            {
                model.PhotoUrl = value.PhotoUrl;
            }
            else
            {
                model.PhotoUrl = PictureHelper.UploadImage(photoUrl, webRootPath);
            }

            model.LastUpdateDate = DateTime.Now;
            _about.Update(model);
            return new SuccessResult(UIMessages.UPDATE_MESSAGE);
        }
    }
}
