﻿namespace LibrarySystem2.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly LibrarySystem2DbContext _context;

        public InitialHostDbBuilder(LibrarySystem2DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
