using Challenge.IntegraMedia.Persistence.Setup;
using System;

namespace Challenge.IntegraMedia.Commands.BaseCommand
{
    public abstract class BaseCommand
    {
        private readonly IDataBaseContext _context;

        protected BaseCommand(IDataBaseContext context)
        {
            _context = context;
        }

        protected void ExecuteCommandInternal(Action<IDataBaseContext> action)
        {
            using (_context)
            {
                action(_context);
                _context.SaveChanges();
            }
        }
    }
}
