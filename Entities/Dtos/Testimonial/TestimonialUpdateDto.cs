using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class TestimonialUpdateDto
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string FeedBack { get; set; }

        public static Testimonial ToTestimonial (TestimonialUpdateDto dto)
        {
            Testimonial testimonial = new Testimonial()
            {
                Id = dto.Id,
                PhotoUrl = dto.PhotoUrl,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Location = dto.Location,
                FeedBack = dto.FeedBack,
            };
            return testimonial;
        }
    }
}
