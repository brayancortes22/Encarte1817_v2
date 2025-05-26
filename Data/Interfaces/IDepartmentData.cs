using Entity.Model.Base;

namespace Data.Interfaces
{
    public interface IDepartmentData : IBaseModelData<Department>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Department department);
        Task<List<Department>> GetByCountryIdAsync(int countryId);
        Task<Department> GetByNameAsync(string name);
    }
}