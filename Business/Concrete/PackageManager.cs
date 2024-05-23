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
    public class PackageManager : IPackageService
    {
        PackageDal _package = new();

        public IResult Add(PackageCreateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = PackageCreateDto.ToPackage(dto);
            model.PhotoUrl = PictureHelper.UploadImage(photoUrl, webRootPath);
            _package.Add(model);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _package.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Package>> GetAll()
        {
            var data = _package.GetAll();
            return new SuccessDataResult<List<Package>>(data);
        }

        public IDataResult<Package> GetById(int id)
        {
            var data = _package.GetById(id);
            return new SuccessDataResult<Package>(data);
        }

        public IResult Update(PackageUpdateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = PackageUpdateDto.ToPackage(dto);
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
            _package.Update(model);
            return new SuccessResult(UIMessages.UPDATE_MESSAGE);
        }
    }
}
