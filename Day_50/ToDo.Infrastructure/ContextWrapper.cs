using Microsoft.EntityFrameworkCore.Storage;
using ToDo.Application;
using ToDo.Persistence.Context;

namespace ToDo.Infrastructure
{
    public class ContextWrapper : IContextWrapper
    {
        readonly protected ToDoContext _context;

        public ContextWrapper(ToDoContext context)
        {
            _context = context;
        }

        public async Task<IDbContextTransaction> beginTransaction()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public async Task SaveCahnges(CancellationToken cancellationToken)
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
