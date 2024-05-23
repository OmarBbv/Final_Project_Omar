using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IDestinationService
    {
        IResult Add(DestinationCreateDto dto,IFormFile photoUrl, string webRootPath);
        IResult Update(DestinationUpdateDto dto,IFormFile photoUrl,string webRootPath);
        IResult Delete(int id);
        IDataResult<List<Destination>> GetAll();
        IDataResult<Destination> GetById(int id);
    }
}
