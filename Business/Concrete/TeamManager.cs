using Business.Abstract;
using Business.UIMessage;
using Core.Extension;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class TeamManager : ITeamService
    {
        TeamDal _team = new();

        public IResult Add(TeamCreateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = TeamCreateDto.ToTime(dto);
            model.PhotoUrl = PictureHelper.UploadImage(photoUrl,webRootPath);
            _team.Add(model);
            return new SuccessResult(UIMessages.ADDED_MESSAGE);
        }

        public IResult Delete(int id)
        {
            var data = GetById(id).Data;
            data.Deleted = id;

            _team.Update(data);
            return new SuccessResult(UIMessages.Deleted_MESSAGE);
        }

        public IDataResult<List<Team>> GetAll()
        {
            var data = _team.GetAll();
            return new SuccessDataResult<List<Team>>(data);
        }

        public IDataResult<Team> GetById(int id)
        {
            var data = _team.GetById(id);
            return new SuccessDataResult<Team>(data);
        }

        public IResult Update(TeamUpdateDto dto, IFormFile photoUrl, string webRootPath)
        {
            var model = TeamUpdateDto.ToTeam(dto);
            var value = GetById(dto.Id).Data;

            if (photoUrl == null)
                model.PhotoUrl = value.PhotoUrl;
            else
                model.PhotoUrl = PictureHelper.UploadImage(photoUrl, webRootPath);

            model.LastUpdateDate = DateTime.Now;
            _team.Update(model);
            return new SuccessResult(UIMessages.UPDATE_MESSAGE);
        }
    }
}
