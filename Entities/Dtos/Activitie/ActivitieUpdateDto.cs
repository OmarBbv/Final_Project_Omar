using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class ActivitieUpdateDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int AboutId { get; set; }

        public static Activitie ToActivitie(ActivitieUpdateDto dto)
        {
            Activitie activitie = new Activitie()
            {
                Id = dto.Id,
                Text = dto.Text,
                AboutId = dto.AboutId,
            };

            return activitie;
        }
    }
}
