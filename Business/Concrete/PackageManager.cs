﻿using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Entities.Concrete.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PackageManager : IPackageService
    {
        PackageDal _package = new();

        public IResult Add(Package entity)
        {
            _package.Add(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IResult Delete(Package entity)
        {
            _package.Delete(entity);
            return new SuccessResult(UIMessage.UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Package>> GetAll()
        {
            var data = _package.GetAll();
            return new SuccessDataResult<List<Package>>(data);
        }

        public IDataResult<Package> GetById(int id)
        {
            var data = _package.GetById(id);
            return new SuccessDataResult<Package>(data);
        }

        public IResult Update(Package entity)
        {
            _package.Update(entity);
            return new SuccessResult(UIMessage.UIMessages.UPDATE_MESSAGE);
        }
    }
}