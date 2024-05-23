using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IAboutService
    {
        IResult Add(AboutCreateDto entity,IFormFile photoUrl,string webRootPath);
        IResult Update(AboutUpdateDto entity,IFormFile photoUrl,string webRootPath);
        IResult Delete(int id);
        IDataResult<List<About>> GetAll();
        IDataResult<About> GetById(int id);
    }
}
