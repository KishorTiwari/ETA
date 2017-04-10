using System;
using System.Collections.Generic;
using System.Text;
using ETA.Data.Models;
using System.Linq;

namespace ETA.Data.DAL
{
    public partial class Repository : IRepository
    {
        public void AddTransaction(Transaction obj)
        {
            _context.Transaction.Add(obj);
            _context.SaveChanges();
        }

        public Transaction GetTransactionByID(int Id)
        {
            return _context.Transaction.Find(Id);
        }

        public ICollection<Transaction> GetTransactions()
        {
            return _context.Transaction.ToList();
        }

        public void RemoveTransaction(int Id)
        {
            _context.Transaction.Remove(_context.Transaction.Find(Id));
            _context.SaveChanges();
        }

        public void UpdateTransaction(Transaction obj)
        {
            _context.Transaction.Update(obj);
            _context.SaveChanges();
        }
    }
}
