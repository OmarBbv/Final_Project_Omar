using Core.Entities.Abstract;

namespace Entities.Entities.Concrete.TableModels
{
    public class About : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public List<Activitie> Activitie { get; set; }

        /*public string Name { get; set; }
        public string FaceBookLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkednLink { get; set; }
        public string UserPhoto { get; set; }*/
    }
}
