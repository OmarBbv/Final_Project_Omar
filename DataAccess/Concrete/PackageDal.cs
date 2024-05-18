using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.SqlServerDbContext;
using Entities.Entities.Concrete.TableModels;

namespace DataAccess.Concrete
{
    public class PackageDal : BaseRepository<Package, AppDbContext>, IPackageDal
    {

    }
}
