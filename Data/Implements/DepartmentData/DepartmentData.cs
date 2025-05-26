using Data.Implements.BaseData;
using Data.Interfaces;
using Entity.Context;
using Entity.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace Data.Implements.DepartmentData
{
    public class DepartmentData : BaseModelData<Department>, IDepartmentData
    {
        public DepartmentData(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> ActiveAsync(int id, bool status)
        {
            var department = await _context.Set<Department>().FindAsync(id);
            if (department == null)
                return false;

            department.Status = status;
            _context.Entry(department).Property(d => d.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdatePartial(Department department)
        {
            var existingDepartment = await _context.Set<Department>().FindAsync(department.Id);
            if (existingDepartment == null) return false;

            // Update only the fields that are not null or empty
            if (!string.IsNullOrEmpty(department.Name))
                existingDepartment.Name = department.Name;
            if (!string.IsNullOrEmpty(department.Code))
                existingDepartment.Code = department.Code;
            if (department.CountryId > 0)
                existingDepartment.CountryId = department.CountryId;

            _context.Set<Department>().Update(existingDepartment);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Department>> GetByCountryIdAsync(int countryId)
        {
            return await _context.Set<Department>()
                .Where(d => d.CountryId == countryId && d.Status)
                .ToListAsync();
        }

        public async Task<Department> GetByNameAsync(string name)
        {
            return await _context.Set<Department>()
                                 .FirstOrDefaultAsync(d => d.Name.ToLower() == name.ToLower() && d.Status);
        }
    }
}