using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IActivitieService
    {
        IResult Add(ActivitieCreateDto entity);
        IResult Update(ActivitieUpdateDto entity);
        IResult Delete(int id);
        IDataResult<List<Activitie>> GetActiviteWithActivitieCategories();
        IDataResult<Activitie> GetById(int id);
    }
}
