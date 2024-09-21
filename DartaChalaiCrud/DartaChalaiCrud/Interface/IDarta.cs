using DartaChalaiCrud.Models;

namespace DartaChalaiCrud.Interface
{
    public interface IDarta
    {
        Task<List<DartaViewModel>> GetAllDarta();
        Task<DartaViewModel> GetDartaById(int id);
        Task<bool> InsertUpdateDarta(DartaViewModel Model);
        Task<bool> DeleteUpdateDarta(int id);
    }
}
