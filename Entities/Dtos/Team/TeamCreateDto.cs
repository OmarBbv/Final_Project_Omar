using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class TeamCreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhotoUrl { get; set; }
        public int PositionId { get; set; }
        public string FaceBookLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkednLink { get; set; }

        public static Team ToTime(TeamCreateDto dto)
        {
            Team team = new Team()
            {
                Id = dto.Id,
                Name = dto.Name,
                SurName = dto.SurName,
                PhotoUrl = dto.PhotoUrl,
                PositionId = dto.PositionId,
                FaceBookLink = dto.FaceBookLink,
                TwitterLink = dto.TwitterLink,
                LinkednLink = dto.LinkednLink,
            };

            return team;
        }
    }
}
