using Core.Results.Abstract;
using Entities.Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IPackageService
    {
        IResult Add(Package entity);
        IResult Update(Package entity);
        IResult Delete(Package entity);
        IDataResult<List<Package>> GetAll();
        IDataResult<Package> GetById(int id);
    }
}
