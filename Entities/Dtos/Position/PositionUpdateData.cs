using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class PositionUpdateData
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static Position ToPosition(PositionUpdateData dto)
        {
            Position position = new Position()
            {
                Id = dto.Id,
                Name = dto.Name,
            };

            return position;
        }
    }
}
