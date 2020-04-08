namespace Vidly.Models
{
    using System.Collections.Generic;
    using System.Data.Entity;

    public class MyContextInitialize:CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Genre g0 = new Genre {  GenreType="Comedy" };
            Genre g1 = new Genre { GenreType = "Action" };
            Genre g2 = new Genre { GenreType = "Thriller" };
            Genre g3 = new Genre { GenreType = "Cartoon" };
            Genre g4 = new Genre { GenreType = "TV Series" };
            Genre g5 = new Genre { GenreType = "Scientfiction" };

            context.Genres.AddRange(new List<Genre> { g0, g1, g2, g3, g4, g5 });

            context.SaveChanges();

            MemberShip ms0 = new MemberShip { MemberShipType = "Month", PercentCount = 5 };
            MemberShip ms1 = new MemberShip { MemberShipType = "Half Year", PercentCount = 10 };
            MemberShip ms2 = new MemberShip { MemberShipType = "Year", PercentCount = 15 };

            context.MemberShips.AddRange(new List<MemberShip> { ms0, ms1, ms2 });

            context.SaveChanges();

            Movies m0 = new Movies { Name = "Shrek", GenreId = g3.Id, Detail = "Very interesting movies.Recommend for children.", ReleaseDate=2001 };
            Movies m1 = new Movies { Name = "Bleyd", GenreId = g2.Id, Detail = "Nice Action. Recomend for elderly  people", ReleaseDate = 2002};
            Movies m2 = new Movies { Name = "Bleyd - 2", GenreId = g1.Id, Detail = "Very interesting film , good character.", ReleaseDate = 2010 };
            Movies m3 = new Movies { Name = "Bleyd - 3", GenreId = g1.Id, Detail = "good plot", ReleaseDate=2342 };
            Movies m4 = new Movies { Name = "Interstellar", GenreId = g5.Id, Detail = "Very good plot.Recommend for all people", ReleaseDate=1992 };
            Movies m5 = new Movies { Name = "Friend", GenreId = g4.Id, Detail = "Very nice tv series. Has a lot of series", ReleaseDate = 1992 };
            Movies m6 = new Movies { Name = "Star Wars", GenreId = g1.Id, Detail = "Not bad , but not good", ReleaseDate = 1996 };

            context.Movies.AddRange(new List<Movies> { m0, m1, m2, m3, m4, m5, m6 });

            context.SaveChanges();

            for (int i = 0; i < 8; i++)
            {
                var t = new Bogus.Faker<Customer>("uk")
               .RuleFor(r => r.Birthhday, o => o.Person.DateOfBirth.ToString())
               .RuleFor(r => r.Email, o => o.Person.Email.ToString())
               .RuleFor(r => r.GenreId, o => o.Random.Int(1, 5))
               .RuleFor(r => r.MemberShipId, o => o.Random.Int(1, 3))
               .RuleFor(r => r.Name, o => o.Name.FullName());
               context.Customers.Add(t);
               context.SaveChanges();
            }
            

            base.Seed(context);
        }
    }

}