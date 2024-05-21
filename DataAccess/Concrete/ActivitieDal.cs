using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.SqlServerDbContext;
using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.Concrete
{
    public class ActivitieDal : BaseRepository<Activitie, AppDbContext>, IActivitieDal
    {
        AppDbContext app = new();
        public List<Activitie> GetActiviteWithActivitieCategories()
        {
            var data = app.Activities
                .Where(x => x.Deleted == 0)
                .Include(x => x.About).ToList();

            return data;
        }
    }
}
