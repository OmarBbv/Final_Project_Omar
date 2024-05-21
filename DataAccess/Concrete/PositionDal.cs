using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.SqlServerDbContext;
using Entities.Concrete.TableModels;

namespace DataAccess.Concrete
{
    public class PositionDal : BaseRepository<Position, AppDbContext>, IPositionDal
    {
        public void Add(Service entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Service entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Service entity)
        {
            throw new NotImplementedException();
        }
    }
}
