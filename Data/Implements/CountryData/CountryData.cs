using Data.Implements.BaseData;
using Data.Interfaces;
using Entity.Context;
using Entity.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace Data.Implements.CountryData
{
    public class CountryData : BaseModelData<Country>, ICountryData
    {
        public CountryData(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> ActiveAsync(int id, bool status)
        {
            var country = await _context.Set<Country>().FindAsync(id);
            if (country == null)
                return false;

            country.Status = status;
            _context.Entry(country).Property(c => c.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdatePartial(Country country)
        {
            var existingCountry = await _context.Set<Country>().FindAsync(country.Id);
            if (existingCountry == null) return false;

            // Update only the fields that are not null or empty
            if (!string.IsNullOrEmpty(country.Name))
                existingCountry.Name = country.Name;
            if (!string.IsNullOrEmpty(country.PhoneCode))
                existingCountry.PhoneCode = country.PhoneCode;

            _context.Set<Country>().Update(existingCountry);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Country> GetByNameAsync(string name)
        {
            var countries = await _context.Set<Country>().ToListAsync();
            return countries.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}