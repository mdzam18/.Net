using Microsoft.EntityFrameworkCore.Storage;

namespace ToDo.Application
{
    public interface IContextWrapper
    {
        Task SaveCahnges(CancellationToken cancellationToken);
        Task<IDbContextTransaction> beginTransaction();
    }
}
