﻿using Entities.Concrete.TableModels;

namespace Entities.Dtos
{
    public class ReservationCreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte PublicCount { get; set; }
        public string Message { get; set; }
        public bool isContact { get; set; }


        public static Reservation ToPosition(ReservationCreateDto dto)
        {
            Reservation reservation= new Reservation()
            {
               Id   = dto.Id,
               Name = dto.Name,
               Email = dto.Email,
               PublicCount = dto.PublicCount,
               Message = dto.Message,
               isContact = dto.isContact,
               CreateDate = dto.CreateDate
            };

            return reservation;
        }
    }
}
