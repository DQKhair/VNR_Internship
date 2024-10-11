using Vnr_InsternShip_Assignment.Repository;

namespace Vnr_InsternShip_Assignment.UnitWork
{
    public interface IUnitWork : IDisposable
    {
        IKhoaHocRepository KhoaHocRepository { get; }

        Task<bool> CompletedAsync();
    }
}
