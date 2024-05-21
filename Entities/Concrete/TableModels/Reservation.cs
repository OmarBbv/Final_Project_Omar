using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class Reservation : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte PublicCount { get; set; }
        public string Message { get; set; }
        public bool isContact { get; set; }
    }
}
