using Core.Results.Abstract;
using Entities.Entities.Concrete.TableModels;

namespace Business.Abstract
{
    internal interface IActivitieService
    {
            IResult Add(Activitie entity);
            IResult Update(Activitie entity);
            IResult Delete(Activitie entity);
            IDataResult<List<Activitie>> GetAll();
            IDataResult<Activitie> GetById(int id);
    }
}
