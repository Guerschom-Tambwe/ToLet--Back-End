using FullStack.API.Helpers;
using FullStack.Data;
using FullStack.Data.Entities;
using FullStack.ViewModels;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace FullStack.API.Services
{
    public interface IProvinceService
    {
        IEnumerable<ProvinceModel> GetProvinces();
        ProvinceModel GetProvince(int id);
        ProvinceModel GetProvinceCity(string provinceName);
        void DeleteProvince(int id);
        ProvinceModel UpdateProvince(ProvinceModel province);
        ProvinceModel AddProvince(ProvinceModel province);
    }
    public class ProvinceService: IProvinceService
    {
        private IFullStackRepository _repo;
        public ProvinceService(IFullStackRepository repo, IOptions<AppSettings> appSettings)
        {
            this._repo = repo;
        }

        public IEnumerable<ProvinceModel> GetProvinces()
        {
            var userList = _repo.GetProvices();
            return userList.Select(u => MaptoProvinceModel(u));
        }

        public ProvinceModel GetProvince(int id)
        {
            var userEntity = _repo.GetProvince(id);
            if (userEntity == null) return null;

            return MaptoProvinceModel(userEntity);
        }

        public ProvinceModel GetProvinceCity(string provinceName)
        {
            var provinceEntity = _repo.GetCityFromProvice(provinceName);
            if (provinceEntity == null) return null;

            return MaptoProvinceModel(provinceEntity);
        }

        public void DeleteProvince(int id)
        {
            var userEntity = _repo.GetProvince(id);
            _repo.DeleteProvince(id);
        }

        public ProvinceModel UpdateProvince(ProvinceModel province)
        {
            var provinceToUpdate = MaptoProvinceEntity(province);
            var updateResult = _repo.UpdateProvince(provinceToUpdate);
            return MaptoProvinceModel(updateResult);
        }

        public ProvinceModel AddProvince(ProvinceModel province)
        {
            var provinceToCreate = MaptoProvinceEntity(province);
            var creationResult = _repo.AddProvince(provinceToCreate);
            return MaptoProvinceModel(creationResult);
        }

        private ProvinceModel MaptoProvinceModel(Province province)
        {
            return new ProvinceModel
            {
                ProvinceId = province.ProvinceId,
                Cities = province.Cities,
                ProvinceName = province.ProvinceName
            };
        }

        private Province MaptoProvinceEntity(ProvinceModel province)
        {
            return new Province
            {
                ProvinceId = province.ProvinceId,
                Cities = province.Cities,
                ProvinceName = province.ProvinceName
            };
        }
    }
}