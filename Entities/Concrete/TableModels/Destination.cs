using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class Destination : BaseEntity
    {
        public string PhotoUrl { get; set; }
        public string Location { get; set; }
    }
}
