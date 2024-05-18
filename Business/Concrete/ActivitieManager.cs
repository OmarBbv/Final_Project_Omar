using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Entities.Concrete.TableModels;

namespace Business.Concrete
{
    public class ActivitieManager : IActivitieService
    {
        ActivitieDal _activitie = new();

        public IResult Add(Activitie entity)
        {
            _activitie.Add(entity);
            return new SuccessResult(UIMessage.UIMessages.ADDED_MESSAGE);
        }

        public IResult Delete(Activitie entity)
        {
            _activitie.Delete(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Activitie>> GetAll()
        {
            var data = _activitie.GetAll();
            return new SuccessDataResult<List<Activitie>>(data);
        }

        public IDataResult<Activitie> GetById(int id)
        {
            var data = _activitie.GetById(id);
            return new SuccessDataResult<Activitie>(data);
        }

        public IResult Update(Activitie entity)
        {
            _activitie.Update(entity);
            return new SuccessResult(UIMessage.UIMessages.UPDATE_MESSAGE);
        }
    }
}
