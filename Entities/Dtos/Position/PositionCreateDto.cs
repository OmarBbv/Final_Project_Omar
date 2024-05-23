using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class PositionCreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static Position ToPosition(PositionCreateDto dto)
        {
            Position position = new()
            {
                Id = dto.Id,
                Name = dto.Name
            };

            return position;
        }
    }
}
