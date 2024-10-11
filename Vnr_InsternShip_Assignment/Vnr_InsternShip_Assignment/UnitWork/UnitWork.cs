using Vnr_InsternShip_Assignment.Models;
using Vnr_InsternShip_Assignment.Repository;

namespace Vnr_InsternShip_Assignment.UnitWork
{
    public class UnitWork : IUnitWork
    {
        private readonly VnrInternShipContext _context;

        public IKhoaHocRepository KhoaHocRepository { get; private set; }

        public UnitWork(VnrInternShipContext context)
        {
            _context = context;
            KhoaHocRepository = new KhoaHocRepository(_context);
        }

        public async Task<bool> CompletedAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
