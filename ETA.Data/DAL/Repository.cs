using System;
using System.Collections.Generic;
using System.Text;
using ETA.Data.Models;

namespace ETA.Data.DAL
{
    public partial class Repository : IRepository
    {
        public ETAContext _context;
        public Repository(ETAContext context)
        {
            _context = context;
        }
    }
}
