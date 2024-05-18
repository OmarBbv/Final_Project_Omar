using Core.Results.Abstract;
using Entities.Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IBookingService
    {
        IResult Add(Booking entity);
        IResult Update(Booking entity);
        IResult Delete(Booking entity);
        IDataResult<List<Booking>> GetAll();
        IDataResult<Booking> GetById(int id);
    }
}
