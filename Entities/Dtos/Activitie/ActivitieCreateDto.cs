
using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class ActivitieCreateDto
    {
        public string Text { get; set; }
        public int AboutId { get; set; }

        public static Activitie ToActivitie(ActivitieCreateDto dto)
        {
            Activitie activitie = new()
            {
                Text = dto.Text,
                AboutId = dto.AboutId,
            };

            return activitie;
        }
    }
}
