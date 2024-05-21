using Core.Results.Abstract;
using Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IActivitieService
    {
        IResult Add(Activitie entity);
        IResult Update(Activitie entity);
        IResult Delete(int id);
        IDataResult<List<Activitie>> GetActiviteWithActivitieCategories();
        IDataResult<Activitie> GetById(int id);
    }
}
