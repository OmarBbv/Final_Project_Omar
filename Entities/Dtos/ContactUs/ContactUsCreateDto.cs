﻿using Entities.Concrete.TableModels;
namespace Entities.Dtos
{
    public class ContactUsCreateDto
    {
        public string Description { get; set; }
        public string Location { get; set; }
        public byte PhoneNumber { get; set; }
        public string Email { get; set; }

        public static ContactUs ToContactUsDto(ContactUsCreateDto dto)
        {
            ContactUs contact = new()
            {
                Description = dto.Description,
                Location = dto.Location,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email
            };

            return contact;
        }
    }
}
