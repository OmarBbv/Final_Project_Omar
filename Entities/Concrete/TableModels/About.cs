using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class About : BaseEntity
    {
        public About()
        {
            Activitie = new HashSet<Activitie>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<Activitie> Activitie { get; set; }

    }
}
