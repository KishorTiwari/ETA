using ETA.Data.Models;
using System.Collections.Generic;

namespace ETA.Data.DAL
{
    public interface IRepository
    {
        //Group
        void AddGroup(Group obj);
        void RemoveGroup(int Id);
        void UpdateGroup(Group obj);
        Group GetGroupByID(int Id);
        ICollection<Group> GetGroups();

        //User
        void AddUser(User obj);
        void RemoveUser(int Id);
        void UpdateUser(User obj);
        User GetUserByID(int Id);
        ICollection<User> GetUsers();

        //Transaction
        void AddTransaction(Transaction obj);
        void RemoveTransaction(int Id);
        void UpdateTransaction(Transaction obj);
        Transaction GetTransactionByID(int Id);
        ICollection<Transaction> GetTransactions();

    }
}
