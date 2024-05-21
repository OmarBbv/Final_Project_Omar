using Core.Results.Abstract;
using Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IBookingService
    {
        IResult Add(Booking entity);
        IResult Update(Booking entity);
        IResult Delete(int id);
        IDataResult<List<Booking>> GetAll();
        IDataResult<Booking> GetById(int id);
    }
}
