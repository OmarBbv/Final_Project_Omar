using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class BookingDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }

        public static Booking ToBooking (BookingDto dto)
        {
            Booking booking = new Booking()
            {
                Id = dto.Id,
                Title = dto.Title,
                Description = dto.Description,
                IconUrl = dto.IconUrl,
            };

            return booking;
        }
    }
}
