using Business.Abstract;
using Business.BaseMessage;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _activitie.Update(data);

            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Activitie>> GetActiviteWithActivitieCategories()
        {
            return new SuccessDataResult<List<Activitie>>(_activitie.GetActiviteWithActivitieCategories());
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
