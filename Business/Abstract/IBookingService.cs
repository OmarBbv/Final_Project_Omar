using Core.Results.Abstract;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IBookingService
    {
        IResult Add(BookingCreateDto dto, IFormFile photoUrl, string webRootPath);
        IResult Update(BookingUpdateDto dto, IFormFile photoUrl, string webRootPath);
        IResult Delete(int id);
        IDataResult<List<Booking>> GetAll();
        IDataResult<Booking> GetById(int id);
    }
}
