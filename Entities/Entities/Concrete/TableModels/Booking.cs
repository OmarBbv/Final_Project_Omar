using Core.Entities.Abstract;

namespace Entities.Entities.Concrete.TableModels
{
    public class Booking : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}
