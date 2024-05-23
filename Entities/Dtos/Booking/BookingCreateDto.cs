using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class BookingCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }

        public static Booking ToBooking(BookingCreateDto dto)
        {
            Booking booking = new Booking()
            {
                Title = dto.Title,
                Description = dto.Description,
                IconUrl = dto.IconUrl,
            };


            return booking;
        } 
    }
}
