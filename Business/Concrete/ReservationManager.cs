using Business.Abstract;
using Business.UIMessage;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;
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

        public IResult Add(ReservationCreateDto dto)
        {
            var model = ReservationCreateDto.ToPosition(dto);
            _reservation.Add(model);
            return new SuccessResult(UIMessages.ADDED_MESSAGE);
        }

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _reservation.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
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

        public IResult Update(ReservationUpdateDto dto)
        {
            var model = ReservationUpdateDto.ToReservation(dto);
            model.LastUpdateDate = DateTime.Now;
            _reservation.Update(model);
            return new SuccessResult(UIMessages.UPDATE_MESSAGE);
        }
    }
}
