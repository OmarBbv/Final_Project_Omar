using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class Service : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
