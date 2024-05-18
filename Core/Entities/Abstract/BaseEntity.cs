namespace Core.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int Deleted { get; set; } = 0;
        public DateTime DateTime { get; set; } = DateTime.Now;
        public DateTime? LastUpdateDate { get; set; }
    }
}
