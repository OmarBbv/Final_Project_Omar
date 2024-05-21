using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class Package : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string PhotoUrl { get; set; }
        public byte PersonCount { get; set; }
        public double Price { get; set; }
        public decimal Raiting { get; set; }
        public string Description { get; set; }

    }
}
