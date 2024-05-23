using Core.Results.Abstract;
using Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface ITeamService
    {
        IResult Add(Team entity);
        IResult Update(Team entity);
        IResult Delete(int id);
        IDataResult<List<Team>> GetAll();
        IDataResult<Team> GetById(int id);
    }
}
