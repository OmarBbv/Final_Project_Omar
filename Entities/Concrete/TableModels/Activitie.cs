using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class Activitie : BaseEntity
    {
        public string Text { get; set; }
        public int AboutId { get; set; }
        public virtual About About { get; set; }
    }
}
