using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Entities.Concrete.TableModels;

namespace Business.Concrete
{
    public class BookingManager : IBookingService
    {
        BookingDal _booking = new();

        public IResult Add(Booking entity)
        {
            _booking.Add(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IResult Delete(Booking entity)
        {
            _booking.Delete(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Booking>> GetAll()
        {

            var data = _booking.GetAll();
            return new SuccessDataResult<List<Booking>>(data);
        }

        public IDataResult<Booking> GetById(int id)
        {
            var data = _booking.GetById(id);
            return new SuccessDataResult<Booking>(data);
        }

        public IResult Update(Booking entity)
        {
            _booking.Update(entity);
            return new SuccessResult(UIMessage.UIMessages.UPDATE_MESSAGE);
        }
    }
}
