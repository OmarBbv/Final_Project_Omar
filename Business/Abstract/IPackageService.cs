using Core.Results.Abstract;
using Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IPackageService
    {
        IResult Add(Package entity);
        IResult Update(Package entity);
        IResult Delete(int id);
        IDataResult<List<Package>> GetAll();
        IDataResult<Package> GetById(int id);
    }
}
