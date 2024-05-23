using Business.Abstract;
using Business.UIMessage;
using Core.Extension;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class BookingManager : IBookingService
    {
        BookingDal _booking = new();

        //public IResult Add(BookingCreateDto dto)
        //{
        //    var model = BookingCreateDto.ToBooking(dto);
        //    _booking.Add(model);
        //    return new SuccessResult(UIMessages.Deleted_MESSAGE);


        //}

        public IResult Add(BookingCreateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = BookingCreateDto.ToBooking(dto);
            model.IconUrl = PictureHelper.UploadImage(photoUrl, webRootPath);
            _booking.Add(model);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _booking.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
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

        //public IResult Update(BookingUpdateDto dto)
        //{
        //    var model = BookingUpdateDto.ToAbout(dto);
        //    model.LastUpdateDate = DateTime.Now;
        //    _booking.Update(model);
        //    return new SuccessResult(UIMessages.UPDATE_MESSAGE);
        //}

        public IResult Update(BookingUpdateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = BookingUpdateDto.ToAbout(dto);
            var value = GetById(dto.Id).Data;
            if (photoUrl == null)
            {
                model.IconUrl =value.IconUrl;
            }
            else
            {
                model.IconUrl = PictureHelper.UploadImage(photoUrl, webRootPath);
            }

            model.LastUpdateDate = DateTime.Now;
            _booking.Update(model);
            return new SuccessResult(UIMessages.UPDATE_MESSAGE);

        }
    }
}
