namespace Entities.Dtos
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte PublicCount { get; set; }
        public string Message { get; set; }
        public bool isContact { get; set; }

    }
}
