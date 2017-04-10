using System;
using System.Collections.Generic;
using System.Text;
using ETA.Data.Models;
using System.Linq;

namespace ETA.Data.DAL
{
    public partial class Repository : IRepository
    {
        public void AddUser(User obj)
        {
            _context.User.Add(obj);
            _context.SaveChanges();
        }

        public User GetUserByID(int Id)
        {
            return _context.User.Find(Id);
        }

        public ICollection<User> GetUsers()
        {
            return _context.User.ToList();
        }

        public void RemoveUser(int Id)
        {
            _context.Remove(_context.User.Find(Id));
            _context.SaveChanges();
        }

        public void UpdateUser(User obj)
        {
            _context.User.Update(obj);
            _context.SaveChanges();
        }
    }
}
