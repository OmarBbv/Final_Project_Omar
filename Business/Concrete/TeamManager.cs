using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;

namespace Business.Concrete
{
    public class TeamManager : ITeamService
    {
        TeamDal _team = new();
        
        public IResult Add(Team entity)
        {
            _team.Add(entity);
            return new SuccessResult(UIMessage.UIMessages.ADDED_MESSAGE);
        }

        public IResult Delete(Team entity)
        {
            _team.Delete(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Team>> GetAll()
        {
            var data = _team.GetAll();
            return new SuccessDataResult<List<Team>>(data);
        }

        public IDataResult<Team> GetById(int id)
        {
            var data = _team.GetById(id);
            return new SuccessDataResult<Team>(data);
        }

        public IResult Update(Team entity)
        {
            _team.Update(entity);
            return new SuccessResult(UIMessage.UIMessages.UPDATE_MESSAGE);
        }
    }
}
