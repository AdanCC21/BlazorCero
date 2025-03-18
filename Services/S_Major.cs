using Data.Context;
using Entities.Model;
using Microsoft.EntityFrameworkCore;
using System.Xml.Schema;

namespace Services
{
    public class S_Major
    {
        private readonly MyDbContext _dbContext;
        
        public S_Major(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<List<E_Major>> getAllMajors()
        {
            var lista = await this._dbContext.Majors.ToListAsync();
            return lista;
        }

        public async Task<E_Major> getMajor(int id)
        {
            var majorFound = await _dbContext.Majors.FindAsync(id);
            Console.WriteLine(majorFound);
            return majorFound;
        }

        public async Task<bool> insertMajor(E_Major major)
        {
            try
            {
                _dbContext.Add(major);
                await _dbContext.SaveChangesAsync();
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<bool> updateMajor(E_Major upMajor)
        {
            var majorExist = await _dbContext.Majors.FindAsync(upMajor.Id);

            if (majorExist == null)
            {
                Console.WriteLine("No existe el registro");
                return false;
            }

            majorExist.Name = upMajor.Name;
            majorExist.Alias = upMajor.Alias;
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
