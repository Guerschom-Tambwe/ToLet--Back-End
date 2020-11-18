using FullStack.API.Helpers;
using FullStack.Data;
using FullStack.Data.Entities;
using FullStack.ViewModels;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStack.API.Services
{
    public interface IAdvertService
    {
        IEnumerable<AdvertModel> GetAdverts();
        AdvertModel GetAdvert(int id);
        void DeleteAdvert(int id);
        AdvertModel UpdateAdvert(AdvertModel advert);
        AdvertModel CreateAdvert(AdvertModel advert);

    }
    public class AdvertService : IAdvertService
    {
        private IFullStackRepository _repo;
        private readonly AppSettings _appSettings;
        public AdvertService(IFullStackRepository repo, IOptions<AppSettings> appSettings)
        {
            this._repo = repo;
            this._appSettings = appSettings.Value;

        }

        public IEnumerable<AdvertModel> GetAdverts()
        {
            //only use for testing
            var userList = _repo.GetAdverts();
            return userList.Select(u => MaptoAdvertModel(u));
        }

        public AdvertModel GetAdvert(int id)
        {
            var userEntity = _repo.GetAdvert(id);
            if (userEntity == null) return null;

            return MaptoAdvertModel(userEntity);
        }

        public void DeleteAdvert(int id)
        {
            var userEntity = _repo.GetAdvert(id);
            _repo.DeleteAdvert(id);
        }

        public AdvertModel UpdateAdvert(AdvertModel advert)
        {
            var advertToUpdate = MaptoAdvertEntity(advert);
            var updateResult = _repo.UpdateAdvert(advertToUpdate);
            return MaptoAdvertModel(updateResult);
        }



        public AdvertModel CreateAdvert(AdvertModel advert)
        {
            var advertToCreate = MaptoAdvertEntity(advert);
            var creationResult = _repo.CreateAdvert(advertToCreate);
            return MaptoAdvertModel(creationResult);
        }

        private AdvertModel MaptoAdvertModel(Advert advert)
        {
            return new AdvertModel
            {
                AdvertId = advert.AdvertId,
                Headline = advert.Headline,
                Province = advert.Province,
                City = advert.City,
                AdvertDetails = advert.AdvertDetails,
                Price = advert.Price,
                UserId = advert.UserId,
                AdvertStatus = advert.AdvertStatus,
                PublishedDate = advert.PublishedDate

            };
        }

        private Advert MaptoAdvertEntity(AdvertModel advert)
        {
            return new Advert
            {
                AdvertId = advert.AdvertId,
                Headline = advert.Headline,
                Province = advert.Province,
                City = advert.City,
                AdvertDetails = advert.AdvertDetails,
                Price = advert.Price,
                UserId = advert.UserId,
                AdvertStatus = advert.AdvertStatus,
                PublishedDate = advert.PublishedDate
            };
        }



    }
}
