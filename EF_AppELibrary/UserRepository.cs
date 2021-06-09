using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AppELibrary
{
    class UserRepository
    {
        private AppContext context;
        public UserRepository()
        {
            context = new AppContext();
        }

        public User SelectUserById(int id)
        {
            var userById = context.Users.FirstOrDefault(user => user.Id == id);
            return userById;
        }

        public User[] SelectAll()
        {
            var usersAll = context.Users.ToArray<User>();
            return usersAll;
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);
        }
        public void RemoveUser(User user)
        {
            context.Users.Remove(user);
        }

        public void UpdateNameById(int id, string newName)
        {
            var userById = context.Users.FirstOrDefault(user => user.Id == id);
            userById.Name = newName;
            context.SaveChanges();
        }

        public bool IsBookOnHands(string bookTitle)
        {
            var isInHand = context.Users.Any(book => book.Book.TitleBook == bookTitle);
            return isInHand;
        }

        public int GetCountBooks(string userName)
        {
            var countBooks = context.Users.Count(user => user.Name == userName);
            return countBooks;
        }


    }
}
