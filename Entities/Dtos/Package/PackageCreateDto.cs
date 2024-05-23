using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class PackageCreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string PhotoUrl { get; set; }
        public byte PersonCount { get; set; }
        public double Price { get; set; }
        public decimal Raiting { get; set; }
        public string Description { get; set; }

        public static Package ToPackage(PackageCreateDto dto)
        {
            Package package = new Package()
            {
                Id = dto.Id,
                Name = dto.Name,
                Location = dto.Location,
                PhotoUrl = dto.PhotoUrl,
                PersonCount = dto.PersonCount,
                Price = dto.Price,
                Raiting = dto.Raiting,
                Description = dto.Description,
            };

            return package;
        }
    }
}
