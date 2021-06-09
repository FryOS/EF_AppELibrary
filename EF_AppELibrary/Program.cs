using System;

namespace EF_AppELibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var db = new AppContext())
            {
                var userRepository = new UserRepository();

                var user1 = new User { Name = "Arthur", Email = "first@gmail.com"};
                var user2 = new User { Name = "klim", Email = "second@gmail.com" };

                var book1 = new Book { ReleaseYearBook = "2020", TitleBook = "Fisrt" };
                var book2 = new Book { ReleaseYearBook = "2021", TitleBook = "Second" };

                //db.Users.Add(user1);
                //db.Users.Add(user2);

                //db.Books.Add(book1);
                //db.Books.Add(book2);

                
                //db.SaveChanges();
                //var uId = userRepository.SelectUserById(5);

                //Console.WriteLine(uId.Id);
                //Console.ReadKey();
            }
        }
    }
}
