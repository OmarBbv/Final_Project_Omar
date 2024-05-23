using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class ServiceUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        public static Service ToService(ServiceUpdateDto dto)
        {
            Service service = new Service()
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                Icon = dto.Icon,
            };

            return service;
        }
    }
}
