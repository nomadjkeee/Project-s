using System.Collections.Generic;
using System.Data.Entity;

namespace VidlyAuth.Models
{
    public class DataBaseInitialize:DropCreateDatabaseAlways<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            Genre g0 = new Genre { GenreType = "Comedy" };
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

            Movies m0 = new Movies  { Name = "Blitz", GenreId = g3.Id, Detail = "A tough cop is dispatched to take down a serial killer who has been targeting police officers.", ReleaseDate = 2011 };
            Movies m1 = new Movies  { Name = "Homefront", GenreId = g1.Id, Detail = "A former DEA agent moves his family to a quiet town, where he soon tangles with a local meth druglord.", ReleaseDate = 2013 };
            Movies m2 = new Movies { Name = "Mechanic Resurrection", GenreId = g1.Id, Detail = "Bishop's most formidable foe kidnaps the love of his life in order to make him complete three impossible assassinations and make them look like accidents.,", ReleaseDate = 2013 };
            Movies m3 = new Movies { Name = "John Rambo", GenreId = g1.Id, Detail = "In Thailand, John Rambo joins a group of mercenaries to venture into war-torn Burma, and rescue a group of Christian aid workers who were kidnapped by the ruthless local infantry unit.", ReleaseDate = 2008 };
            Movies m4 = new Movies { Name = "London Has Fallen", GenreId = g5.Id, Detail = "In London for the Prime Minister's funeral, Mike Banning is caught up in a plot to assassinate all the attending world leaders.", ReleaseDate = 2016 };
            Movies m5 = new Movies { Name = "The Expendables 2", GenreId = g4.Id, Detail = "The Expendables 2 is a 2012 release in the action genre. The legendary Sylvester Stallone returns for the sequel to the 2010 movie as a writer and as the lead character of Barney Ross. The movie also stars Jean-Claude Van Damme as the antagonist, with small", ReleaseDate = 2012 };
            Movies m6 = new Movies { Name = "Law Abiding Citizen", GenreId = g1.Id, Detail = "A frustrated man decides to take justice into his own hands after a plea bargain sets one of his family's killers free.", ReleaseDate = 2009 };
            Movies m7 = new Movies { Name = "Transformers: The Last Knight", GenreId = g1.Id, Detail = "A deadly threat from Earth's history reappears, and a hunt for a lost artifact takes place between Autobots and Decepticons, while Optimus Prime encounters his creator in space.", ReleaseDate = 2017 };
            Movies m8 = new Movies { Name = "Fight to Finish", GenreId = g1.Id, Detail = "A young fighter gets involved in his neighbour's personal matters with her abusive ex-boyfriend, a hardened criminal, who in turn threatens the fighter. He decides to settle scores in the boxing ring", ReleaseDate = 2015 };
            Movies m9 = new Movies { Name = "Kickboxer", GenreId = g1.Id, Detail = "Kurt Sloane must learn the ancient kick boxing art of Muay Thai in order to avenge his brother.", ReleaseDate = 1989 };
            Movies m10 = new Movies { Name = "Drive Angry", GenreId = g1.Id, Detail = "A vengeful father escapes from hell and chases after the men who killed his daughter and kidnapped his granddaughter.", ReleaseDate = 2011 };
            Movies m11 = new Movies { Name = "xXx: Return of Xander Cage", GenreId = g0.Id, Detail = "Watch xXx: Return of Xander Cage Full Movie in Hindi Online on MX Player xXx: Return of Xander Cage is a Hollywood movie released in 2017. The movie is directed by D.J. Caruso. The movie is third from the xXx series and stars Vin Diesel, Deepika Padukone, Donnie Yen", ReleaseDate = 2017 };
            Movies m12 = new Movies { Name = "Bleeding Steel", GenreId = g1.Id, Detail = "A Special Forces Agent is assigned to protect a scientist and his creation from a sinister gang.", ReleaseDate = 2018 };
            Movies m13 = new Movies { Name = "The Hitman's Bodyguard", GenreId = g1.Id, Detail = "Watch The Hitman's Bodyguard in Hindi Online on MX Player Released in 2017, The Hitman's Bodyguard is a Hollywood comedy movie. The movie is directed by Patrick Hughes and The Hitman's Bodyguard cast includes Ryan Reynolds, Samuel L. Jackson, Gray Oldman and Salma Hayek. The action, comedy movie will be enjoyed by the entire family and will be loved by people of all ages. Now you can watch the English movie The Hitman's Bodyguard in Hindi online for free on MX Player.", ReleaseDate = 2017 };
            Movies m14 = new Movies { Name = "Looper", GenreId = g1.Id, Detail = "Watch Looper Full Movie Dubbed in Hindi Online on MX Player Looper is a Hollywood movie that was released in September 2012. The science fiction film is directed by Rian Jhonson and the Looper cast includes Emily Blunt, Bruce Willis, Joseph Gordon-Levitt. The action film is a full family entertainer and has something for all kinds of audience. You can now watch the Hollywood movie dubbed in Hindi online here. Watch Looper movie dubbed in Hindi online on MX Player. Get information on Looper movie cast, plot and story online The Looper plot revolves around a contract killer group called ‘loopers‘. The group is hired by a criminal syndicate from the future. The syndicates send the victims into the past and the looper is then expected to kill them. Ultimately, the looper has to kill one’s future self and terminate the contract. Once that is done, the loop is said to be closed. One day, Joe, played by Joseph Gordon-Levitt, realises that his own future self has been sent in the past for his assassination. Will Joe find a way out of this? With his personal life in jeopardy, will Joe stand in breach of the contract he signed up for? Watch the sci-fi movie that will keep you glued to your seats as you anticipate as to what happens next in the story. Watch Looper movie in Hindi online on MX Player.", ReleaseDate = 2012 };
            Movies m15 = new Movies { Name = "Olympus Has Fallen", GenreId = g1.Id, Detail = "Watch Olympus Has Fallen Full Movie in Hindi Online on MX Player The Hollywood movie Olympus Has Fallen was released in March 2013. The action thriller film is directed by Antoine Fuqua. The film is first in the series, and Olympus Has Fallen cast includes Gerald Butler, Aaron Eckhart, Morgan Freeman, Robert Forster, Angela Bassett, Cole Hauser, and Melissa Leo. The hit action movie is a perfect watch on a movie night at the comfort of your home. If you love the action thriller movies that keep you on the edge then Olympus Has Fallen is a perfect watch for you. Now watch the hit Hollywood movie dubbed in Hindi online here. Catch Olympus Has Fallen dubbed version online for free on MX Player. Catch Olympus Has Fallen in Hindi Online Here Olympus Has Fallen is a story of Mike Banning, played by Gerald Butler, who is the President’s loyalist. Mike Banning was an officer of secret services who was appointed for the protection of the President and his family. In an unfortunate event, Banning is unable to save the First Lady from a fatal attack, which leads to him getting sacked from his position. Years later when the information of North- Korea attacking the White House surfaces, Mike Banning is called again. A North Korean terrorist organisation holds the US President hostage and many other officers are assassinated on camera. Banning is now racing against time to save the country’s President as well as the USA from a nuclear attack. Get Olympus Has Fallen full movie, cast and trailer online on MX Player.", ReleaseDate = 2017 };
            Movies m16 = new Movies { Name = "Friends Never Die", GenreId = g1.Id, Detail = "A bullied student forms a bond with the leader of a youth gang and discovers the power and meaning of true friendship.", ReleaseDate = 2012 };

            context.Movies.AddRange(new List<Movies> { m0, m1, m2, m3, m4, m5, m6,m7,m8,m9,m10,m11,m12,m16,});

            context.SaveChanges();

            //Random add customers
            for (int i = 0; i < 15; i++)
            {
                var t = new Bogus.Faker<Customer>("uk")
               .RuleFor(r => r.Birthhday, o => o.Person.DateOfBirth.Year.ToString())
               .RuleFor(r => r.Email, o => o.Person.Email.ToString())
               .RuleFor(r => r.GenreId, o => o.Random.Int(1, 5))
               .RuleFor(r => r.MemberShipId, o => o.Random.Int(1, 3))
               .RuleFor(r => r.Name, o => o.Name.FullName());
                context.Customers.Add(t);
               
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}