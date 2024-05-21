using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhotoUrl { get; set; }
        public int PositionId { get; set; }
        public string FaceBookLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkednLink { get; set; }
        public virtual Position Position { get; set; }
    }
}
