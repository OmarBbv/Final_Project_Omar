using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Entities.Concrete.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {

        ReservationDal _reservation = new();

        public IResult Add(Reservation entity)
        {
            _reservation.Add(entity);
            return new SuccessResult(UIMessage.UIMessages.ADDED_MESSAGE);
        }

        public IResult Delete(Reservation entity)
        {
            _reservation.Delete(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Reservation>> GetAll()
        {
            var data = _reservation.GetAll();
            return new SuccessDataResult<List<Reservation>>(data);
        }

        public IDataResult<Reservation> GetById(int id)
        {
            var data = _reservation.GetById(id);
            return new SuccessDataResult<Reservation>(data);
        }

        public IResult Update(Reservation entity)
        {
            _reservation.Update(entity);
            return new SuccessResult(UIMessage.UIMessages.UPDATE_MESSAGE);
        }
    }
}
