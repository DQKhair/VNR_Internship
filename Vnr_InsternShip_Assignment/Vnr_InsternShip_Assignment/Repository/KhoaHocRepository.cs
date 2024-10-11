using Microsoft.EntityFrameworkCore;
using Vnr_InsternShip_Assignment.Models;

namespace Vnr_InsternShip_Assignment.Repository
{
    public class KhoaHocRepository : GenericRepository<KhoaHoc>, IKhoaHocRepository
    {
        public KhoaHocRepository(VnrInternShipContext context) : base(context)
        {
        }

        public async Task<IEnumerable<MonHoc>> GetListMonHocByKhoaHocId(int? id)
        {
            try
            {
                var _listMonHocById = await _context.MonHocs.Where(m => m.KhoaHocId == id).ToListAsync();
                if (_listMonHocById != null)
                {
                    return _listMonHocById;
                }
                return null!;
            }
            catch (Exception ex)
            {
                return null!;
            }
        }
    }
}
