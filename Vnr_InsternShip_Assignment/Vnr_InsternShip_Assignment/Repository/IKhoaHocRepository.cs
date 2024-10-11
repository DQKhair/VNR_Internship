using Vnr_InsternShip_Assignment.Models;

namespace Vnr_InsternShip_Assignment.Repository
{
    public interface IKhoaHocRepository : IGenericRepository<KhoaHoc>
    {
        Task<IEnumerable<MonHoc>> GetListMonHocByKhoaHocId(int? id);
    }
}
