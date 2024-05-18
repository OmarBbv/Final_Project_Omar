using Core.Results.Abstract;
using Entities.Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IReservationService
    {
        IResult Add(Reservation entity);
        IResult Update(Reservation entity);
        IResult Delete(Reservation entity);
        IDataResult<List<Reservation>> GetAll();
        IDataResult<Reservation> GetById(int id);
    }
}
