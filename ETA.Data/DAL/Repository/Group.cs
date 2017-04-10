using System;
using System.Collections.Generic;
using System.Text;
using ETA.Data.Models;
using System.Linq;

namespace ETA.Data.DAL
{
    public partial class Repository : IRepository
    {
        public void AddGroup(Group obj)
        {
            _context.Group.Add(obj);
            _context.SaveChanges();
        }

        public Group GetGroupByID(int Id)
        {
            return _context.Group.Find(Id);
        }

        public ICollection<Group> GetGroups()
        {
            return _context.Group.ToList();
        }

        public void RemoveGroup(int Id)
        {
            _context.Group.Remove(_context.Group.Find(Id));
            _context.SaveChanges();
        }

        public void UpdateGroup(Group obj)
        {
            _context.Group.Update(obj);
            _context.SaveChanges();
        }
    }
}
