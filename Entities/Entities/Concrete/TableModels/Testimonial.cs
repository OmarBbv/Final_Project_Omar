using Core.Entities.Abstract;

namespace Entities.Entities.Concrete.TableModels
{
    public class Testimonial : BaseEntity
    {
        public string PhotoUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string FeedBack { get; set; }
    }
}
