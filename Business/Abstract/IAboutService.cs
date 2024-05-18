﻿using Core.Results.Abstract;
using Entities.Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface IAboutService
    {
        IResult Add(About entity);
        IResult Update(About entity);
        IResult Delete(About entity);
        IDataResult<List<About>> GetAll();
        IDataResult<About> GetById(int id);
    }
}
