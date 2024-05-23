using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class TeamUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhotoUrl { get; set; }
        public int PositionId { get; set; }
        public string FaceBookLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkednLink { get; set; }

        public static Team ToTeam(TeamUpdateDto dto)
        {
            Team team = new Team()
            {
                Id = dto.Id,
                Name = dto.Name,
                SurName = dto.SurName,
                PhotoUrl = dto.PhotoUrl,
                TwitterLink = dto.TwitterLink,
                LinkednLink = dto.LinkednLink,
                FaceBookLink = dto.FaceBookLink,
                PositionId = dto.PositionId,
            };

            return team;
        }
    }
}
