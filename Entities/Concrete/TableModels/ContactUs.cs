using Core.Entities.Abstract;

namespace Entities.Concrete.TableModels
{
    public class ContactUs : BaseEntity
    {
        public string Description { get; set; }
        public string Location { get; set; }
        public byte PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
