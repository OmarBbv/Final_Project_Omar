using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IPackageService
    {
        IResult Add(PackageCreateDto entity, IFormFile photoUrl, string webRootPath);
        IResult Update(PackageUpdateDto entity, IFormFile photoUrl, string webRootPath);
        IResult Delete(int id);
        IDataResult<List<Package>> GetAll();
        IDataResult<Package> GetById(int id);
    }
}
