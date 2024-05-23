using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class DestinationCreateDto
    {
        public string PhotoUrl { get; set; }
        public string Location { get; set; }

        public static Destination ToDestination(DestinationCreateDto dto)
        {
            Destination destination = new()
            {
                PhotoUrl = dto.PhotoUrl,
                Location = dto.Location
            };

            return destination;
        }
    }
}
