using Business.Abstract;
using Business.UIMessage;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        AboutDal _about = new();

        public IResult Add(About entity)
        {
            _about.Add(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _about.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<About>> GetAll()
        {
            var data = _about.GetAll();
            return new SuccessDataResult<List<About>>(data);
        }

        public IDataResult<About> GetById(int id)
        {
            var data = _about.GetById(id);
            return new SuccessDataResult<About>(data);
        }

        public IResult Update(About entity)
        {
            _about.Update(entity);
            return new SuccessResult(UIMessage.UIMessages.UPDATE_MESSAGE);
        }
    }
}
