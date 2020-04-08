namespace Vidly.Models
{
    using System.Data.Entity;

    public class MyContextInitialize:DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Genre g0 = new Genre {  GenreType="Comedy" };
            Genre g1 = new Genre { GenreType = "Action" };
            Genre g2 = new Genre { GenreType = "Thriller" };
            Genre g3 = new Genre { GenreType = "Cartoon" };
            Genre g4 = new Genre { GenreType = "TV Series" };
            Genre g5 = new Genre { GenreType = "Scientfiction" };

            MemberShip ms0 = new MemberShip { MemberShipType = "Month", PercentCount = 5 };
            MemberShip ms1 = new MemberShip { MemberShipType = "Half Year", PercentCount = 10 };
            MemberShip ms2 = new MemberShip { MemberShipType = "Year", PercentCount = 15 };

            Movies m0 = new Movies { Name = "Shrek", GenreId = g3.Id, Detail = "Very interesting movies.Recommend for children." };
            Movies m1 = new Movies { Name = "Bleyd", GenreId = g2.Id, Detail = "Nice Action. Recomend for elderly  people" };
            Movies m2 = new Movies { Name = "Bleyd - 2", GenreId = g1.Id, Detail = "Very interesting film , good character." };
            Movies m3 = new Movies { Name = "Bleyd - 3", GenreId = g1.Id, Detail = "good plot" };
            Movies m4 = new Movies { Name = "Interstellar", GenreId = g5.Id, Detail = "Very good plot.Recommend for all people" };
            Movies m5 = new Movies { Name = "Friend", GenreId = g4.Id, Detail = "Very nice tv series. Has a lot of series" };
            Movies m6 = new Movies { Name = "Star Wars", GenreId = g1.Id, Detail = "Not bad , but not good" };


            var t = new Bogus.Faker<Customer>("uk")
               .RuleFor(r => r.Birthhday, o => o.Date.Random.ToString())
               .RuleFor(r => r.Email, o => o.Person.Email)
               .RuleFor(r => r.GenreId, o => o.Random.Int(1, 5))
               .RuleFor(r => r.MemberShipId, o => o.Random.Int(1, 3))
               .RuleFor(r => r.Name, o => o.Name.FullName());

               




            base.Seed(context);
        }
    }

}