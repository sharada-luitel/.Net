using DartaChalaiCrud.Data;
using DartaChalaiCrud.Interface;
using DartaChalaiCrud.Models;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace DartaChalaiCrud.Repositories
{
    public class DartaRepository : IDarta
    {
        private readonly DartaDbContext _Context;
        private readonly string _userId;
        public DartaRepository(DartaDbContext context, string userId)
        {
            _Context = context;
        }

        public async Task<List<DartaViewModel>> GetAllDarta()
        {
            return await _Context.Dartas.Select(x => new DartaViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                Gender = x.Gender,
                Standard = x.Standard,

            }).ToListAsync();
        }
        public Task<bool> DeleteUpdateDarta(int id)
        {
            throw new NotImplementedException();
        }




        //        public Task<List<DartaViewModel>> GetDartaById(int id)
        //{
        //    _Context.Dartas.Where(x => x.Id == id)
        //        .Select(x => new _Context.Dartas.Select(x => new DartaViewModel()
        //        {
        //            Id = x.Id,
        //            Name = x.Name,
        //            Address = x.Address,
        //            Gender = x.Gender,
        //            Standard = x.Standard,
        //        }).FirstOrDefault() ?? new DartaViewModel();
        //}
        public async Task<DartaViewModel> GetDartaById(int id)
        {

            var result = await _Context.Dartas
                .Where(x => x.Id == id)
                .Select(x => new DartaViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address,
                    Gender = x.Gender,
                    Standard = x.Standard,
                })
                .FirstOrDefaultAsync();

            return result ?? new DartaViewModel();
        }



        public async Task<bool> InsertUpdateDarta(DartaViewModel Model)
        {
            try
            {
                if (Model.Id > 0)
                {
                    var data = await _Context.Dartas.FirstOrDefaultAsync(x => x.Id == Model.Id);
                    if (data != null)
                    {
                        data.Name = Model.Name;
                        data.Address = Model.Address;
                        data.Gender = Model.Gender;
                        data.Standard = Model.Standard;
                        //data.UpdatedBy = _userId;
                        //data.UpdatedDate = DateTime.Now;

                        _Context.Entry(data).State = EntityState.Modified;
                        await _Context.SaveChangesAsync();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                    {
                        var newdata = new Darta()
                        {
                            Name = Model.Name,
                            Address = Model.Address,
                            Gender = Model.Gender,
                            Standard = Model.Standard,


                            //CreatedBy = _userId,
                            //CreatedDate = DateTime.Now,
                        };
                        await _Context.Dartas.AddAsync(newdata);
                        await _Context.SaveChangesAsync();
                    }
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}




