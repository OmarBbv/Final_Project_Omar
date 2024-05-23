using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ITeamService
    {
        IResult Add(TeamCreateDto entity, IFormFile photoUrl, string webRootPath);
        IResult Update(TeamUpdateDto entity, IFormFile photoUrl, string webRootPath);
        IResult Delete(int id);
        IDataResult<List<Team>> GetAll();
        IDataResult<Team> GetById(int id);
    }
}
