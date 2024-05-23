using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IReservationService
    {
        IResult Add(ReservationCreateDto entity);
        IResult Update(ReservationUpdateDto entity);
        IResult Delete(int id);
        IDataResult<List<Reservation>> GetAll();
        IDataResult<Reservation> GetById(int id);
    }
}
