
using Entity.Model.Base;

namespace Data.Interfaces
{
    public interface ICountryData : IBaseModelData<Country>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Country country);
        Task<Country> GetByNameAsync(string name);
    }
}