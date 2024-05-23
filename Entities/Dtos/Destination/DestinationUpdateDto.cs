using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class DestinationUpdateDto
    {

        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string Location { get; set; }

        public static Destination ToDestination(DestinationUpdateDto dto)
        {
            Destination destination = new Destination()
            {
                Id = dto.Id,
                PhotoUrl = dto.PhotoUrl,
                Location = dto.Location,
            };

            return destination;
        }
    }
}
