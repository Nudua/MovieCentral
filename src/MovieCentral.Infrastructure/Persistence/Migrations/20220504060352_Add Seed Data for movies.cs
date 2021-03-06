using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieCentral.Infrastructure.Persistence.Migrations
{
    public partial class AddSeedDataformovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackdropUrl",
                table: "Movies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImdbId",
                table: "Movies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("00978049-8d62-462a-a2e3-17c2fddcdc1e"), "https://image.tmdb.org/t/p/w500/mx2jS5Kaa5rmaldEFzKeKpDN9Q2.jpg", "https://image.tmdb.org/t/p/w500/vOEbimiBaTQr9SDFfDHHWCZdZK2.jpg", "The story of British officer T.E. Lawrence's mission to aid the Arab tribes in their revolt against the Ottoman Empire during the First World War. Lawrence becomes a flamboyant, messianic figure in the cause of Arab unity but his psychological instability threatens to undermine his achievements.", null, 18, "tt0056172", 90, new DateTime(1962, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Lawrence of Arabia" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("0289e70f-2614-4ca7-a0c3-d93bb55cb8ba"), "https://image.tmdb.org/t/p/w500/3w2v0iNPPNeIKOV5wu1NU1DDHHy.jpg", "https://image.tmdb.org/t/p/w500/4sHeTAp65WrSSuc05nRBKddhBxO.jpg", "In a near-future Britain, young Alexander DeLarge and his pals get their kicks beating and raping anyone they please. When not destroying the lives of others, Alex swoons to the music of Beethoven. The state, eager to crack down on juvenile crime, gives an incarcerated Alex the option to undergo an invasive procedure that'll rob him of all personal agency. In a time when conscience is a commodity, can Alex change his tune?", null, 15, "tt0066921", 91, new DateTime(1971, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "A Clockwork Orange" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("03305611-3545-4881-be06-b80a846c1cd1"), "https://image.tmdb.org/t/p/w500/6eC6FqD3euWODJkOkaMdDm3yNMf.jpg", "https://image.tmdb.org/t/p/w500/85cWkCVftiVs0BVey6pxX8uNmLt.jpg", "Following the death of District Attorney Harvey Dent, Batman assumes responsibility for Dent's crimes to protect the late attorney's reputation and is subsequently hunted by the Gotham City Police Department. Eight years later, Batman encounters the mysterious Selina Kyle and the villainous Bane, a new terrorist leader who overwhelms Gotham's finest. The Dark Knight resurfaces to protect a city that has branded him an enemy.", null, 1, "tt1345836", 69, new DateTime(2012, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Dark Knight Rises" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("04db1131-2bd6-46d4-a9ab-92897f647bc6"), "https://image.tmdb.org/t/p/w500/rshlQ6LfPRSWFhpGL4s5ZkIPR51.jpg", "https://image.tmdb.org/t/p/w500/fTuxNlgEm04PPFkr1xfK94Jn8BW.jpg", "WWII American Army Medic Desmond T. Doss, who served during the Battle of Okinawa, refuses to kill people and becomes the first Conscientious Objector in American history to receive the Congressional Medal of Honor.", null, 7, "tt2119532", 179, new DateTime(2016, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Hacksaw Ridge" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("05fe9c1a-cd06-46a5-a1f5-36b02bd6ca4a"), "https://image.tmdb.org/t/p/w500/U8QRD7jvTXEYsUXq74IFKaSiL5.jpg", "https://image.tmdb.org/t/p/w500/kve20tXwUZpu4GUX8l6X7Z4jmL6.jpg", "World War II soldier-turned-U.S. Marshal Teddy Daniels investigates the disappearance of a patient from a hospital for the criminally insane, but his efforts are compromised by his troubling visions and also by a mysterious doctor.", null, 7, "tt1130884", 171, new DateTime(2010, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Shutter Island" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("07f2cd2e-affb-4d6a-b691-88de9cf37e52"), "https://image.tmdb.org/t/p/w500/gum3tuO1zKHBdElSQPS08PJ1w67.jpg", "https://image.tmdb.org/t/p/w500/1jL3wA66BnhuGW3ADbiXMPaHlpi.jpg", "In the early years of the 20th century, Mohandas K. Gandhi, a British-trained lawyer, forsakes all worldly possessions to take up the cause of Indian independence. Faced with armed resistance from the British government, Gandhi adopts a policy of 'passive resistance', endeavouring to win freedom for his people without resorting to bloodshed.", null, 7, "tt0083987", 230, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Gandhi" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("0a1cd93b-d397-4834-a9c9-29e927247e9b"), "https://image.tmdb.org/t/p/w500/mQUOFbRoRG9t8oS0SOk955flHJq.jpg", "https://image.tmdb.org/t/p/w500/slsS6jT6SXjcTPOrsFcLIrHboXA.jpg", "In this classic German thriller, Hans Beckert, a serial killer who preys on children, becomes the focus of a massive Berlin police manhunt. Beckert's heinous crimes are so repellant and disruptive to city life that he is even targeted by others in the seedy underworld network. With both cops and criminals in pursuit, the murderer soon realizes that people are on his trail, sending him into a tense, panicked attempt to escape justice.", null, 7, "tt0022100", 81, new DateTime(1931, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "M" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("0a68ab47-5800-4a7e-802d-042a904bd946"), "https://image.tmdb.org/t/p/w500/pCClmlbgfg4cEmn5aERxHRqhbpw.jpg", "https://image.tmdb.org/t/p/w500/bbGtogDZOg09bm42KIpCXUXICkh.jpg", "A group of working-class friends decide to enlist in the Army during the Vietnam War and finds it to be hellish chaos -- not the noble venture they imagined. Before they left, Steven married his pregnant girlfriend -- and Michael and Nick were in love with the same woman. But all three are different men upon their return.", null, 7, "tt0077416", 170, new DateTime(1978, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Deer Hunter" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("0b358f35-cbde-449b-9a46-28fd6ddf0f37"), "https://image.tmdb.org/t/p/w500/c71zkXAykw5uu4cHnUCE6vA3NY0.jpg", "https://image.tmdb.org/t/p/w500/fnbjcRDYn6YviCcePDnGdyAkYsB.jpg", "In the near future, a weary Logan cares for an ailing Professor X in a hideout on the Mexican border. But Logan's attempts to hide from the world and his legacy are upended when a young mutant arrives, pursued by dark forces.", null, 1, "tt3315342", 209, new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Logan" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("0ba62247-56a4-4005-8de6-a32094f1d1f3"), "https://image.tmdb.org/t/p/w500/5A9dsIpb7876nU9QrWEGziDmj0r.jpg", "https://image.tmdb.org/t/p/w500/vvExrsLBUz7bUu1tlMZqKPA6T8K.jpg", "When larcenous real estate clerk Marion Crane goes on the lam with a wad of cash and hopes of starting a new life, she ends up at the notorious Bates Motel, where manager Norman Bates cares for his housebound mother.", null, 11, "tt0054215", 33, new DateTime(1960, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Psycho" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("0cc61cca-731b-4b9b-abbc-47d0a6c2aa54"), "https://image.tmdb.org/t/p/w500/lNCfjI6DOD4huCyBvbzBxflX2M5.jpg", "https://image.tmdb.org/t/p/w500/7oCAPOphDKpIaxTrnukmDrZ8XKD.jpg", "Follow the adventures of Belle, a bright young woman who finds herself in the castle of a prince who's been turned into a mysterious beast. With the help of the castle's enchanted staff, Belle soon learns the most important lesson of all -- that true beauty comes from within.", null, 14, "tt0101414", 245, new DateTime(1991, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Beauty and the Beast" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("1015a943-015c-4735-84a0-e064e5261719"), "https://image.tmdb.org/t/p/w500/jRJrQ72VLyEnVsvwfep8Xjlvu8c.jpg", "https://image.tmdb.org/t/p/w500/yI6X2cCM5YPJtxMhUd3dPGqDAhw.jpg", "Léon, the top hit man in New York, has earned a rep as an effective \"cleaner\". But when his next-door neighbors are wiped out by a loose-cannon DEA agent, he becomes the unwilling custodian of 12-year-old Mathilda. Before long, Mathilda's thoughts turn to revenge, and she considers following in Léon's footsteps.", null, 5, "tt0110413", 30, new DateTime(1994, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Léon: The Professional" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("1141bf87-e0fb-465f-9e04-b7bee202322a"), "https://image.tmdb.org/t/p/w500/zqkmTXzjkAgXmEWLRsY4UpTWCeo.jpg", "https://image.tmdb.org/t/p/w500/6FfCtAuVAW8XJjZ7eWeLibRLWTw.jpg", "Princess Leia is captured and held hostage by the evil Imperial forces in their effort to take over the galactic Empire. Venturesome Luke Skywalker and dashing captain Han Solo team together with the loveable robot duo R2-D2 and C-3PO to rescue the beautiful princess and restore peace and justice in the Empire.", null, 2, "tt0076759", 23, new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Star Wars: Episode IV - A New Hope" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("12233c55-2aa9-4dcc-a32e-fbc4442a677d"), "https://image.tmdb.org/t/p/w500/rr7E0NoGKxvbkb89eR1GwfoYjpA.jpg", "https://image.tmdb.org/t/p/w500/pB8BM7pdSp6B6Ih7QZ4DrQ3PmJK.jpg", "A ticking-time-bomb insomniac and a slippery soap salesman channel primal male aggression into a shocking new form of therapy. Their concept catches on, with underground \"fight clubs\" forming in every town, until an eccentric gets in the way and ignites an out-of-control spiral toward oblivion.", null, 7, "tt0137523", 10, new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Fight Club" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("139a8306-c332-4862-b8d4-b581426ab37b"), "https://image.tmdb.org/t/p/w500/n4GJFGzsc7NinI1VeGDXIcQjtU2.jpg", "https://image.tmdb.org/t/p/w500/iYypPT4bhqXfq1b6EnmxvRt6b2Y.jpg", "Hong Kong, 1962: Chow Mo-Wan and Su Li-Zhen move into neighboring apartments on the same day. Their encounters are formal and polite—until a discovery about their spouses creates an intimate bond between them.", null, 7, "tt0118694", 233, new DateTime(2000, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "In the Mood for Love" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("143d4601-c12a-46e8-b615-001ea98730c2"), "https://image.tmdb.org/t/p/w500/qnJO6ZHj617skSIIKEjcAjGxMLG.jpg", "https://image.tmdb.org/t/p/w500/tyxjxpwr9NiVtSeITtVXuhp84Zl.jpg", "A married farmer falls under the spell of a slatternly woman from the city, who tries to convince him to drown his wife.", null, 7, "tt0018455", 185, new DateTime(1927, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Sunrise" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("14c1998f-567f-4cca-93a0-4fb9a50700e6"), "https://image.tmdb.org/t/p/w500/8BVSqAfU5knNkxyCH4JiANHwjeZ.jpg", "https://image.tmdb.org/t/p/w500/8tZYtuWezp8JbcsvHYO0O46tFbo.jpg", "An apocalyptic story set in the furthest reaches of our planet, in a stark desert landscape where humanity is broken, and most everyone is crazed fighting for the necessities of life. Within this world exist two rebels on the run who just might be able to restore order.", null, 1, "tt1392190", 205, new DateTime(2015, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Mad Max: Fury Road" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("15c29220-4039-421e-817c-3b298c227fb2"), "https://image.tmdb.org/t/p/w500/fNHCogWhABNAmzk0IFdzQP5XLYj.jpg", "https://image.tmdb.org/t/p/w500/r3FctmAMk2tbrwxuWdpeLrZLwIz.jpg", "A retired legal counselor writes a novel hoping to find closure for one of his past unresolved homicide cases and for his unreciprocated love with his superior - both of which still haunt him decades later.", null, 5, "tt1305806", 139, new DateTime(2009, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Secret in Their Eyes" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("15dac414-b765-4612-92ee-db4f3d852d76"), "https://image.tmdb.org/t/p/w500/jLq0ol1f0ZKXni9R9GsPBcyPrNN.jpg", "https://image.tmdb.org/t/p/w500/g2YbTYKpY7N2yDSk7BfXZ18I5QV.jpg", "The elderly Shukishi and his wife, Tomi, take the long journey from their small seaside village to visit their adult children in Tokyo. Their elder son, Koichi, a doctor, and their daughter, Shige, a hairdresser, don't have much time to spend with their aged parents, and so it falls to Noriko, the widow of their younger son who was killed in the war, to keep her in-laws company.", null, 7, "tt0046438", 176, new DateTime(1953, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Tokyo Story" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("16a82740-a53c-49f6-99a9-49694ff1262a"), "https://image.tmdb.org/t/p/w500/gILte6Zd7m1YneIr6MVhh30S9pr.jpg", "https://image.tmdb.org/t/p/w500/aKuFiU82s5ISJpGZp7YkIr3kCUd.jpg", "The true story of Henry Hill, a half-Irish, half-Sicilian Brooklyn kid who is adopted by neighbourhood gangsters at an early age and climbs the ranks of a Mafia family under the guidance of Jimmy Conway.", null, 7, "tt0099685", 18, new DateTime(1990, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Goodfellas" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("16d31b12-9213-4c02-b268-1186841e7add"), "https://image.tmdb.org/t/p/w500/lmZFxXgJE3vgrciwuDib0N8CfQo.jpg", "https://image.tmdb.org/t/p/w500/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg", "As the Avengers and their allies have continued to protect the world from threats too large for any one hero to handle, a new danger has emerged from the cosmic shadows: Thanos. A despot of intergalactic infamy, his goal is to collect all six Infinity Stones, artifacts of unimaginable power, and use them to inflict his twisted will on all of reality. Everything the Avengers have fought for has led up to this moment - the fate of Earth and existence itself has never been more uncertain.", null, 2, "tt4154756", 60, new DateTime(2018, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Avengers: Infinity War" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("18110a5a-0ef9-4fce-b3f6-ae96677b290d"), "https://image.tmdb.org/t/p/w500/C6jcUqld8M6hZQmzBxgwHuQ4qT.jpg", "https://image.tmdb.org/t/p/w500/oDpDXln1x3sbnt8wQBKsU6J5txT.jpg", "In late 1890s Wyoming, Butch Cassidy is the affable, clever and talkative leader of the outlaw Hole in the Wall Gang. His closest companion is the laconic dead-shot 'Sundance Kid'. As the west rapidly becomes civilized, the law finally catches up to Butch, Sundance and their gang.  Chased doggedly by a special posse, the two decide to make their way to South America in hopes of evading their pursuers once and for all.", null, 19, "tt0064115", 221, new DateTime(1969, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Butch Cassidy and the Sundance Kid" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("18383b91-d64c-481e-a577-108ecca0e325"), "https://image.tmdb.org/t/p/w500/wmsePXV2z1b6ecXuKKrFbG0Q92P.jpg", "https://image.tmdb.org/t/p/w500/zUybYvxWdAJy5hhYovsXtHSWI1l.jpg", "Disgruntled Korean War veteran Walt Kowalski sets out to reform his neighbor, Thao Lor, a Hmong teenager who tried to steal Kowalski's prized possession: a 1972 Gran Torino.", null, 7, "tt1205489", 168, new DateTime(2008, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Gran Torino" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("18569fe1-c38f-41dd-bc63-f625fdde1c08"), "https://image.tmdb.org/t/p/w500/7jR6xSOqnWCrm3OGhm06Y8jGCYS.jpg", "https://image.tmdb.org/t/p/w500/a1BrBoErndBAYEZZEJaotIJ6CE1.jpg", "The hopes and dreams of four ambitious people are shattered when their drug addictions begin spiraling out of control. A look into addiction and how it overcomes the mind and body.", null, 5, "tt0180093", 83, new DateTime(2000, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Requiem for a Dream" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("199a516d-c33e-4219-91a5-61880f6df16d"), "https://image.tmdb.org/t/p/w500/lXhgCODAbBXL5buk9yEmTpOoOgR.jpg", "https://image.tmdb.org/t/p/w500/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg", "Aragorn is revealed as the heir to the ancient kings as he, Gandalf and the other members of the broken fellowship struggle to save Gondor from Sauron's forces. Meanwhile, Frodo and Sam take the ring closer to the heart of Mordor, the dark lord's realm.", null, 2, "tt0167260", 7, new DateTime(2003, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Lord of the Rings: The Return of the King" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("19d1015c-3f22-4ce6-aae3-5f5145c98d56"), "https://image.tmdb.org/t/p/w500/ps82zgSDimvlYps6otcMYshrVyS.jpg", "https://image.tmdb.org/t/p/w500/bXNvzjULc9jrOVhGfjcc64uKZmZ.jpg", "In this sound-era silent film, a tramp falls in love with a beautiful blind flower seller.", null, 4, "tt0021749", 35, new DateTime(1931, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "City Lights" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("1b623b39-01bb-4b28-937c-0110ac0fba2a"), "https://image.tmdb.org/t/p/w500/mClhAA1cAoA8ndhRXnOV256OXfW.jpg", "https://image.tmdb.org/t/p/w500/2gDCAgl2iBQNuJuk6p2xtuS1ewg.jpg", "An ex-tennis pro carries out a plot to have his wife murdered after discovering she is having an affair, and assumes she will soon leave him for the other man anyway. When things go wrong, he improvises a new plan—to frame her for murder instead.", null, 5, "tt0046912", 156, new DateTime(1954, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Dial M for Murder" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("1c87c1c4-9e5c-42c5-aff2-81f2e345a5df"), "https://image.tmdb.org/t/p/w500/3nQm5pMc2mJTCNnjfDOrmVD7xNX.jpg", "https://image.tmdb.org/t/p/w500/jQnUtWaHYfqnXPOIf77K7Ycqk4M.jpg", "With Ran, legendary director Akira Kurosawa reimagines Shakespeare's King Lear as a singular historical epic set in sixteenth-century Japan. Majestic in scope, the film is Kurosawa's late-life masterpiece, a profound examination of the folly of war and the crumbling of one family under the weight of betrayal, greed, and the insatiable thirst for power.", null, 1, "tt0089881", 137, new DateTime(1985, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Ran" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("1dc5b988-9be8-40fd-b3d4-39d4fbe9a9f5"), "https://image.tmdb.org/t/p/w500/4FHcxMtVruMr7ltU2cItWssLjTP.jpg", "https://image.tmdb.org/t/p/w500/lNz2Ow0wGCAvzckW7EOjE03KcYv.jpg", "The spoiled daughter of a well-to-do plantation owner is forced to use every means at her disposal to claw her way out of poverty, following Maj. Gen. William Sherman's destructive \"March to the Sea,” during the American Civil War.", null, 7, "tt0031381", 164, new DateTime(1939, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Gone with the Wind" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("1f6ad750-5894-43c6-91ae-d4c3ec6f712b"), "https://image.tmdb.org/t/p/w500/xO2Nzx2mKwfZiLczcmDFQwMk4n5.jpg", "https://image.tmdb.org/t/p/w500/m4WQ1dBIrEIHZNCoAjdpxwSKWyH.jpg", "In 25 AD,Judah Ben-Hur, a Jew in ancient Judea, opposes the occupying Roman empire.  Falsely accused by a Roman childhood friend-turned-overlord of trying to kill the Roman governor, he is put into slavery and his mother and sister are taken away as prisoners.  Three years later and freed by a grateful Roman galley commander whom he has rescued from drowning, he becomes an expert charioteer for Rome, all the while plotting to return to Judea, find and rescue his family, and avenge himself on his former friend.  All the while, the form and work of Jesus move in the background of his life...", null, 1, "tt0052618", 196, new DateTime(1959, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Ben-Hur" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("2388e80f-6a03-4eca-b4cb-25636f0cd433"), "https://image.tmdb.org/t/p/w500/oGMomeS7bE43eN8SGJUaKvQnmud.jpg", "https://image.tmdb.org/t/p/w500/2ti3l1OeB8G94yyqfAI7nmMZUbA.jpg", "Despondent over a painful estrangement from his daughter, trainer Frankie Dunn isn't prepared for boxer Maggie Fitzgerald to enter his life. But Maggie's determined to go pro and to convince Dunn and his cohort to help her.", null, 7, "tt0405159", 199, new DateTime(2004, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Million Dollar Baby" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("243b5459-5c5a-4468-a5f0-7a8e92390d52"), "https://image.tmdb.org/t/p/w500/1PnRPz4A4AguUEVOTcprIyctrax.jpg", "https://image.tmdb.org/t/p/w500/iM8n4nZJPR2abpnyZ36FUgHiRjr.jpg", "The youngest son of an alcoholic former boxer returns home, where he's trained by his father for competition in a mixed martial arts tournament – a path that puts the fighter on a collision course with his estranged, older brother.", null, 7, "tt1291584", 154, new DateTime(2011, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Warrior" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("26a58c05-033c-43d0-ab5a-50febd6a6bc0"), "https://image.tmdb.org/t/p/w500/sTp8K0SfcC2RQef1Tu160z3niHO.jpg", "https://image.tmdb.org/t/p/w500/3clod4q8qkgU7pyOmZ7Re0G7GDc.jpg", "After the insane General Jack D. Ripper initiates a nuclear strike on the Soviet Union, a war room full of politicians, generals and a Russian diplomat all frantically try to stop the nuclear strike.", null, 7, "tt0057012", 59, new DateTime(1964, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("276bd5e7-e278-4b10-8d86-aa0128619b8d"), "https://image.tmdb.org/t/p/w500/aQ2ZbNqIaecoQsryNe33UmDtms.jpg", "https://image.tmdb.org/t/p/w500/kTXxdNv44najTayFcrT487xWuDv.jpg", "In this enchantingly cracked fairy tale, the beautiful Princess Buttercup and the dashing Westley must overcome staggering odds to find happiness amid six-fingered swordsmen, murderous princes, Sicilians and rodents of unusual size. But even death can't stop these true lovebirds from triumphing.", null, 2, "tt0093779", 218, new DateTime(1987, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Princess Bride" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("2772b275-0c05-4a5b-9c79-34cd61c9736f"), "https://image.tmdb.org/t/p/w500/hUn13Hom8OWMYpR1ay0diwswwdP.jpg", "https://image.tmdb.org/t/p/w500/Rzope4Pk93Rg1Q2Ae8H0FYwa7n.jpg", "Three detectives in the corrupt and brutal L.A. police force of the 1950s use differing methods to uncover a conspiracy behind the shotgun slayings of the patrons at an all-night diner.", null, 5, "tt0119488", 111, new DateTime(1997, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "L.A. Confidential" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("2be29f11-be41-40c5-aaae-7448500d92e9"), "https://image.tmdb.org/t/p/w500/tcZi0LQc5iu2u6i5aOWyj9NBBvl.jpg", "https://image.tmdb.org/t/p/w500/gycdE1ARByGQcK4fYR2mgpU6OO.jpg", "Nine years later, Jesse travels across Europe giving readings from a book he wrote about the night he spent in Vienna with Celine. After his reading in Paris, Celine finds him, and they spend part of the day together before Jesse has to again leave for a flight. They are both in relationships now, and Jesse has a son, but as their strong feelings for each other start to return, both confess a longing for more.", null, 7, "tt0381681", 240, new DateTime(2004, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Before Sunset" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("2e314b0d-c4ec-4053-a813-e232a48b84c7"), "https://image.tmdb.org/t/p/w500/c7Mjuip0jfHLY7x8ZSEriRj45cu.jpg", "https://image.tmdb.org/t/p/w500/ceG9VzoRAVGwivFU403Wc3AHRys.jpg", "When Dr. Indiana Jones – the tweed-suited professor who just happens to be a celebrated archaeologist – is hired by the government to locate the legendary Ark of the Covenant, he finds himself up against the entire Nazi regime.", null, 2, "tt0082971", 48, new DateTime(1981, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Raiders of the Lost Ark" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("2e78123e-1ef8-4897-b26e-6c3c077bb96f"), "https://image.tmdb.org/t/p/w500/h8C7KZwCJO5DN7jPifc7AoIjx7k.jpg", "https://image.tmdb.org/t/p/w500/eAdO0qa9m0NFSVLZ26PvCwmPlsr.jpg", "Carl Fredricksen spent his entire life dreaming of exploring the globe and experiencing life to its fullest. But at age 78, life seems to have passed him by, until a twist of fate (and a persistent 8-year old Wilderness Explorer named Russell) gives him a new lease on life.", null, 3, "tt1049413", 114, new DateTime(2009, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Up" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("2fd3d72f-f4d5-42cd-b8a0-4b2d1b7bdc44"), "https://image.tmdb.org/t/p/w500/sj5R5SGor3YMFBuabMj8gPbyBmh.jpg", "https://image.tmdb.org/t/p/w500/58PUObt4eQTczaevgxJT8iGKoMa.jpg", "Fred C. Dobbs and Bob Curtin, both down on their luck in Tampico, Mexico in 1925, meet up with a grizzled prospector named Howard and decide to join with him in search of gold in the wilds of central Mexico. Through enormous difficulties, they eventually succeed in finding gold, but bandits, the elements, and most especially greed threaten to turn their success into disaster.", null, 2, "tt0040897", 124, new DateTime(1948, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Treasure of the Sierra Madre" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("30235648-c52a-4569-afe4-3b528d78e1a8"), "https://image.tmdb.org/t/p/w500/7RyHsO4yDXtBv1zUU3mTpHeQ0d5.jpg", "https://image.tmdb.org/t/p/w500/or06FN3Dka5tukK1e9sl16pB3iy.jpg", "After the devastating events of Avengers: Infinity War, the universe is in ruins due to the efforts of the Mad Titan, Thanos. With the help of remaining allies, the Avengers must assemble once more in order to undo Thanos' actions and restore order to the universe once and for all, no matter what consequences may be in store.", null, 2, "tt4154796", 16, new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Avengers: Endgame" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("306d7ca1-1408-47a5-aeed-67f1ac8f38c4"), "https://image.tmdb.org/t/p/w500/8eLXy49T36e0e1YhYvUQOCXNRhm.jpg", "https://image.tmdb.org/t/p/w500/fhQoQfejY1hUcwyuLgpBrYs6uFt.jpg", "After narrowly escaping a bizarre accident, a troubled teenager is plagued by visions of a large bunny rabbit that manipulates him to commit a series of crimes.", null, 9, "tt0246578", 232, new DateTime(2001, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Donnie Darko" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("31bd40c1-6b5f-465e-80c2-08dd4b00cabb"), "https://image.tmdb.org/t/p/w500/yVPcPk96E6Qffiyez2oJc7OKD2A.jpg", "https://image.tmdb.org/t/p/w500/7sfbEnaARXDDhKm0CZ7D7uc2sbo.jpg", "In Nazi-occupied France during World War II, a group of Jewish-American soldiers known as \"The Basterds\" are chosen specifically to spread fear throughout the Third Reich by scalping and brutally killing Nazis. The Basterds, lead by Lt. Aldo Raine soon cross paths with a French-Jewish teenage girl who runs a movie theater in Paris which is targeted by the soldiers.", null, 7, "tt0361748", 95, new DateTime(2009, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Inglourious Basterds" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("33cdb8b7-83b8-4b11-a2e4-ac72acf222b0"), "https://image.tmdb.org/t/p/w500/wVATRh2WUCoQeQAURBmcnE3peeE.jpg", "https://image.tmdb.org/t/p/w500/wQVvASmpm8jGhJBQU20OkoMcNzi.jpg", "A married couple are faced with a difficult decision - to improve the life of their child by moving to another country or to stay in Iran and look after a deteriorating parent who has Alzheimer's disease.", null, 7, "tt1832382", 112, new DateTime(2011, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "A Separation" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("34b32dd7-024e-4c7d-aab5-fe73a8ab21a0"), "https://image.tmdb.org/t/p/w500/A1mteOfKdvK5er2sD5i02Qw3CWz.jpg", "https://image.tmdb.org/t/p/w500/8OYGtQlO8k9PcOm49apV62eVJQo.jpg", "A classic of the silent age, this film tells the story of the doomed but ultimately canonized 15th-century teenage warrior. On trial for claiming she'd spoken to God, Jeanne d'Arc is subjected to inhumane treatment and scare tactics at the hands of church court officials. Initially bullied into changing her story, Jeanne eventually opts for what she sees as the truth. Her punishment, a famously brutal execution, earns her perpetual martyrdom.", null, 7, "tt0019254", 214, new DateTime(1928, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Passion of Joan of Arc" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("350981c9-8f93-4eea-b327-88c422ef8c6c"), "https://image.tmdb.org/t/p/w500/7UTQCis1B8oWNjIMzQq57LPqma2.jpg", "https://image.tmdb.org/t/p/w500/lEXYbyFKddwryyUJFqspfE132Qv.jpg", "Tom Joad returns to his home after a jail sentence to find his family kicked out of their farm due to foreclosure. He catches up with them on his Uncle’s farm, and joins them the next day as they head for California and a new life... Hopefully.", null, 7, "tt0032551", 225, new DateTime(1940, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Grapes of Wrath" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("35b9d3eb-0dda-42dd-8e6f-b3828a4059d2"), "https://image.tmdb.org/t/p/w500/mxd1UbyWvlmILEdpT09lk81uDmn.jpg", "https://image.tmdb.org/t/p/w500/bSqt9rhDZx1Q7UZ86dBPKdNomp2.jpg", "A holiday favourite for generations...  George Bailey has spent his entire life giving to the people of Bedford Falls.  All that prevents rich skinflint Mr. Potter from taking over the entire town is George's modest building and loan company.  But on Christmas Eve the business's $8,000 is lost and George's troubles begin.", null, 7, "tt0038650", 25, new DateTime(1946, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "It's a Wonderful Life" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("363b78cd-0bf9-4946-a92d-e383878ab540"), "https://image.tmdb.org/t/p/w500/97Nv4cIsVaf8nesmpjNW5uWWQY3.jpg", "https://image.tmdb.org/t/p/w500/dg9escdBIAAATxlUeTya9gurTtI.jpg", "A retired San Francisco detective suffering from acrophobia investigates the strange activities of an old friend's wife, all the while becoming dangerously obsessed with her.", null, 13, "tt0052357", 76, new DateTime(1958, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Vertigo" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("3789de91-8ec7-4fdb-b16c-17f7a2691b8f"), "https://image.tmdb.org/t/p/w500/AdKA2F1SzYPhSZdEbjH1Zh75UVQ.jpg", "https://image.tmdb.org/t/p/w500/b6ko0IKC8MdYBBPkkA1aBPLe2yz.jpg", "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, along with his wife Wendy and their son Danny, must live isolated from the rest of the world for the winter. But they aren't prepared for the madness that lurks within.", null, 11, "tt0081505", 63, new DateTime(1980, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Shining" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("390580e1-932b-4192-bd8b-2daacb481edf"), "https://image.tmdb.org/t/p/w500/zyO6j74DKMWfp5snWg6Hwo0T3Mz.jpg", "https://image.tmdb.org/t/p/w500/cEg6qpVbKA8cZQE2SDsCjSVqbze.jpg", "Brimming with action while incisively examining the nature of truth, \"Rashomon\" is perhaps the finest film ever to investigate the philosophy of justice. Through an ingenious use of camera and flashbacks, Kurosawa reveals the complexities of human nature as four people recount different versions of the story of a man's murder and the rape of his wife.", null, 5, "tt0042876", 115, new DateTime(1950, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Rashômon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("3aa59f4f-cd3c-4c37-be69-f330b57a2d4d"), "https://image.tmdb.org/t/p/w500/xcjJ5khg2yzOa282mza39Lbrm7j.jpg", "https://image.tmdb.org/t/p/w500/4ucLGcXVVSVnsfkGtbLY4XAius8.jpg", "12-year-old Regan MacNeil begins to adapt an explicit new personality as strange events befall the local area of Georgetown. Her mother becomes torn between science and superstition in a desperate bid to save her daughter, and ultimately turns to her last hope: Father Damien Karras, a troubled priest who is struggling with his own faith.", null, 11, "tt0070047", 246, new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Exorcist" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("3b57507c-3425-4d69-986b-444671d41212"), "https://image.tmdb.org/t/p/w500/iaN0D6G1UFgiX9u1EGXAYMK0yqI.jpg", "https://image.tmdb.org/t/p/w500/gQB8Y5RCMkv2zwzFHbUJX3kAhvA.jpg", "At the height of the Vietnam war, Captain Benjamin Willard is sent on a dangerous mission that, officially, \"does not exist, nor will it ever exist.\" His goal is to locate - and eliminate - a mysterious Green Beret Colonel named Walter Kurtz, who has been leading his personal army on illegal guerrilla missions into enemy territory.", null, 7, "tt0078788", 50, new DateTime(1979, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Apocalypse Now" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("3c685712-bff5-4178-8229-6719d97c7739"), "https://image.tmdb.org/t/p/w500/x9ezMgOtDPqHatHDvxEG0ILb6Ie.jpg", "https://image.tmdb.org/t/p/w500/qymaJhucquUwjpb8oiqynMeXnID.jpg", "With his wife's disappearance having become the focus of an intense media circus, a man sees the spotlight turned on him when it's suspected that he may not be innocent.", null, 13, "tt2267998", 182, new DateTime(2014, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Gone Girl" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("3d54fc90-3965-46f4-8268-534163e84ed5"), "https://image.tmdb.org/t/p/w500/askg3SMvhqEl4OL52YuvdtY40Yb.jpg", "https://image.tmdb.org/t/p/w500/gGEsBPAijhVUFoiNpgZXqRVWJt2.jpg", "Despite his family’s baffling generations-old ban on music, Miguel dreams of becoming an accomplished musician like his idol, Ernesto de la Cruz. Desperate to prove his talent, Miguel finds himself in the stunning and colorful Land of the Dead following a mysterious chain of events. Along the way, he meets charming trickster Hector, and together, they set off on an extraordinary journey to unlock the real story behind Miguel's family history.", null, 8, "tt2380307", 72, new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Coco" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("3e6544d7-cdcb-4aed-9e7d-6f2555d35c3f"), "https://image.tmdb.org/t/p/w500/zd7mu6dJKxkVtBdXqlEQ9W3msKl.jpg", "https://image.tmdb.org/t/p/w500/tN7kYPjRhDolpui9sc9Eq9n5b2O.jpg", "A nameless ronin, or samurai with no master, enters a small village in feudal Japan where two rival businessmen are struggling for control of the local gambling trade. Taking the name Sanjuro Kuwabatake, the ronin convinces both silk merchant Tazaemon and sake merchant Tokuemon to hire him as a personal bodyguard, then artfully sets in motion a full-scale gang war between the two ambitious and unscrupulous men.", null, 7, "tt0055630", 119, new DateTime(1961, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Yojimbo" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("3f3ccbfd-4ce1-43b0-9164-60a775935246"), "https://image.tmdb.org/t/p/w500/3KwAmIKMaDcBMonF5wmyNTL0SR6.jpg", "https://image.tmdb.org/t/p/w500/3jcbDmRFiQ83drXNOvRDeKHxS0C.jpg", "While serving time for insanity at a state mental hospital, implacable rabble-rouser, Randle Patrick McMurphy, inspires his fellow patients to rebel against the authoritarian rule of head nurse, Mildred Ratched.", null, 7, "tt0073486", 17, new DateTime(1975, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "One Flew Over the Cuckoo's Nest" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("40103c42-8729-444c-aca8-f65af4fa2ca8"), "https://image.tmdb.org/t/p/w500/nMKdUUepR0i5zn0y1T4CsSB5chy.jpg", "https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg", "Batman raises the stakes in his war on crime. With the help of Lt. Jim Gordon and District Attorney Harvey Dent, Batman sets out to dismantle the remaining criminal organizations that plague the streets. The partnership proves to be effective, but they soon find themselves prey to a reign of chaos unleashed by a rising criminal mastermind known to the terrified citizens of Gotham as the Joker.", null, 7, "tt0468569", 4, new DateTime(2008, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Dark Knight" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("404da287-1f96-4dcc-a4a8-81eed8f2bee1"), "https://image.tmdb.org/t/p/w500/fq3wyOs1RHyz2yfzsb4sck7aWRG.jpg", "https://image.tmdb.org/t/p/w500/7lyBcpYB0Qt8gYhXYaEZUNlNQAv.jpg", "Eighties teenager Marty McFly is accidentally sent back in time to 1955, inadvertently disrupting his parents' first meeting and attracting his mother's romantic interest. Marty must repair the damage to history by rekindling his parents' romance and - with the help of his eccentric inventor friend Doc Brown - return to 1985.", null, 2, "tt0088763", 42, new DateTime(1985, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Back to the Future" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("40c30c5a-4da8-4f65-ba1a-2e29fd493318"), "https://image.tmdb.org/t/p/w500/e9GbzPawXDFvLwSseCXpHkbCyAP.jpg", "https://image.tmdb.org/t/p/w500/6UTzw3kipgTYAJCX8GExoXzcVOx.jpg", "Heroin addict Mark Renton stumbles through bad ideas and sobriety attempts with his unreliable friends -- Sick Boy, Begbie, Spud and Tommy. He also has an underage girlfriend, Diane, along for the ride. After cleaning up and moving from Edinburgh to London, Mark finds he can't escape the life he left behind when Begbie shows up at his front door on the lam, and a scheming Sick Boy follows.", null, 7, "tt0117951", 163, new DateTime(1996, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Trainspotting" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("41c66d2f-8e92-49d9-993a-fa9cc38bc222"), "https://image.tmdb.org/t/p/w500/o3i6AfTcWAuNvzAUV3q5lOmi6Gx.jpg", "https://image.tmdb.org/t/p/w500/lRHE0vzf3oYJrhbsHXjIkF4Tl5A.jpg", "Growing up can be a bumpy road, and it's no exception for Riley, who is uprooted from her Midwest life when her father starts a new job in San Francisco. Riley's guiding emotions— Joy, Fear, Anger, Disgust and Sadness—live in Headquarters, the control centre inside Riley's mind, where they help advise her through everyday life and tries to keep things positive, but the emotions conflict on how best to navigate a new city, house and school.", null, 3, "tt2096673", 150, new DateTime(2015, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Inside Out" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4336a143-97d7-45ef-b3c6-5e2f9c1b059c"), "https://image.tmdb.org/t/p/w500/f3EfYaQCLIVKURufYN5DFk8hAKm.jpg", "https://image.tmdb.org/t/p/w500/8AVb7tyxZRsbKJNOTJHQZl7JYWO.jpg", "King Arthur, accompanied by his squire, recruits his Knights of the Round Table, including Sir Bedevere the Wise, Sir Lancelot the Brave, Sir Robin the Not-Quite-So-Brave-As-Sir-Lancelot and Sir Galahad the Pure. On the way, Arthur battles the Black Knight who, despite having had all his limbs chopped off, insists he can still fight. They reach Camelot, but Arthur decides not  to enter, as \"it is a silly place\".", null, 2, "tt0071853", 110, new DateTime(1975, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Monty Python and the Holy Grail" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("443e378a-ec42-4dd2-a420-fc4f1a1e9ec4"), "https://image.tmdb.org/t/p/w500/viGCwLxupyoaLsa6hrnu1gYrB0B.jpg", "https://image.tmdb.org/t/p/w500/bW4tXG8kZ89ZCurPnzDDSzJbeF5.jpg", "After a chaotic night of rioting in a marginal suburb of Paris, three young friends, Vinz, Hubert and Saïd, wander around unoccupied waiting for news about the state of health of a mutual friend who has been seriously injured when confronting the police.", null, 7, "tt0113247", 231, new DateTime(1995, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "La Haine" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("44f2dce5-537a-4ad5-b6a4-5ed1e90ae13f"), "https://image.tmdb.org/t/p/w500/c7VbRPlev1bRfKvTxr98erw5T7B.jpg", "https://image.tmdb.org/t/p/w500/sgheSKxZkttIe8ONsf2sWXPgip3.jpg", "James Sullivan and Mike Wazowski are monsters, they earn their living scaring children and are the best in the business... even though they're more afraid of the children than they are of them. When a child accidentally enters their world, James and Mike suddenly find that kids are not to be afraid of and they uncover a conspiracy that could threaten all children across the world.", null, 3, "tt0198781", 223, new DateTime(2001, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Monsters, Inc." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("46479db6-4a47-42ca-9484-9d8ee34a4bb9"), "https://image.tmdb.org/t/p/w500/g6R1OT7ETBLGLeUJOE0pOiAFHcI.jpg", "https://image.tmdb.org/t/p/w500/lsBnfheKZBO3UKU7lVHIeGZLWuF.jpg", "A botched robbery indicates a police informant, and the pressure mounts in the aftermath at a warehouse. Crime begets violence as the survivors -- veteran Mr. White, newcomer Mr. Orange, psychopathic parolee Mr. Blonde, bickering weasel Mr. Pink and Nice Guy Eddie -- unravel.", null, 5, "tt0105236", 78, new DateTime(1992, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Reservoir Dogs" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("477ee59e-d7e3-4839-91fe-55baa646303e"), "https://image.tmdb.org/t/p/w500/r8pUcom5Mw8igtBpj3AHSAUvH0R.jpg", "https://image.tmdb.org/t/p/w500/pxbGZewX327IbTvrCVRJgcLJTSQ.jpg", "In a futuristic city sharply divided between the working class and the city planners, the son of the city's mastermind falls in love with a working class prophet who predicts the coming of a savior to mediate their differences.", null, 7, "tt0017136", 109, new DateTime(1927, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Metropolis" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4848b80e-d4b0-4ad0-9c21-e0060d5a3434"), "https://image.tmdb.org/t/p/w500/n5A7brJCjejceZmHyujwUTVgQNC.jpg", "https://image.tmdb.org/t/p/w500/c54HpQmuwXjHq2C9wmoACjxoom3.jpg", "Harry, Ron and Hermione continue their quest to vanquish the evil Voldemort once and for all. Just as things begin to look hopeless for the young wizards, Harry discovers a trio of magical objects that endow him with powers to rival Voldemort's formidable skills.", null, 9, "tt1201607", 216, new DateTime(2011, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Harry Potter and the Deathly Hallows: Part 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("486ad087-2001-4389-994a-b0e5e1d8b0fd"), "https://image.tmdb.org/t/p/w500/rSPw7tgCH9c6NqICZef4kZjFOQ5.jpg", "https://image.tmdb.org/t/p/w500/n6PvMAKL66gavIFxOyRB6czAeQO.jpg", "Spanning the years 1945 to 1955, a chronicle of the fictional Italian-American Corleone crime family. When organized crime family patriarch, Vito Corleone barely survives an attempt on his life, his youngest son, Michael steps in to take care of the would-be killers, launching a campaign of bloody revenge.", null, 7, "tt0068646", 2, new DateTime(1972, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Godfather" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4a06fa81-a325-46a5-bbe5-80a20573e3b2"), "https://image.tmdb.org/t/p/w500/qvZ91FwMq6O47VViAr8vZNQz3WI.jpg", "https://image.tmdb.org/t/p/w500/iAq0sq42vKTLneVGqHn1D4GzgrM.jpg", "A samurai answers a village's request for protection after he falls on hard times. The town needs protection from bandits, so the samurai gathers six others to help him teach the people how to defend themselves, and the villagers provide the soldiers with food.", null, 1, "tt0047478", 20, new DateTime(1954, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Seven Samurai" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4a3013ff-52cb-4554-b86f-50eb035b0080"), "https://image.tmdb.org/t/p/w500/kTUUiKGKrdRhJsCcYT3Ivtfuuzh.jpg", "https://image.tmdb.org/t/p/w500/ihLPR2hiHljvvdTzHk6NeNTVMXf.jpg", "A working man's livelihood is threatened when someone steals his bicycle.", null, 7, "tt0040522", 99, new DateTime(1948, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Bicycle Thieves" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4b21e915-25bd-4088-bdc4-6dde80e5d91f"), "https://image.tmdb.org/t/p/w500/6O1mOoTXuc1WqjKd2R7MFQHZ7Eb.jpg", "https://image.tmdb.org/t/p/w500/rtGDOeG9LzoerkDGZF9dnVeLppL.jpg", "Two sisters move to the country with their father in order to be closer to their hospitalized mother, and discover the surrounding trees are inhabited by Totoros, magical spirits of the forest. When the youngest runs away from home, the older sister seeks help from the spirits to find her.", null, 9, "tt0096283", 133, new DateTime(1988, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "My Neighbor Totoro" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4b72d3b1-2746-4266-9dc9-6682830cd72a"), "https://image.tmdb.org/t/p/w500/hCHO4FMRSJdGf0urLtGnST9Lhi3.jpg", "https://image.tmdb.org/t/p/w500/tsqcwBp1jYZdcceXXoVEby0dZkt.jpg", "Wolfgang Amadeus Mozart is a remarkably talented young Viennese composer who unwittingly finds a fierce rival in the disciplined and determined Antonio Salieri. Resenting Mozart for both his hedonistic lifestyle and his undeniable talent, the highly religious Salieri is gradually consumed by his jealousy and becomes obsessed with Mozart's downfall, leading to a devious scheme that has dire consequences for both men.", null, 10, "tt0086879", 82, new DateTime(1984, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Amadeus" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4bdeafdb-ff30-4e49-8879-4210522b76e8"), "https://image.tmdb.org/t/p/w500/bln0pnieTax3KrEpG5ZjN3fi1sw.jpg", "https://image.tmdb.org/t/p/w500/5K7cOHoay2mZusSLezBOY0Qxh8a.jpg", "In Casablanca, Morocco in December 1941, a cynical American expatriate meets a former lover, with unforeseen complications.", null, 7, "tt0034583", 36, new DateTime(1942, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Casablanca" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4caa7662-8991-4d91-80ac-34fd865ce81a"), "https://image.tmdb.org/t/p/w500/q00H8EqULYSK74lgevMkhmGGLHn.jpg", "https://image.tmdb.org/t/p/w500/sKCr78MXSLixwmZ8DyJLrpMsd15.jpg", "A young lion prince is cast out of his pride by his cruel uncle, who claims he killed his father. While the uncle rules with an iron paw, the prince grows up beyond the Savannah, living by a philosophy: No worries for the rest of your days. But when his past comes to haunt him, the young prince must decide his fate: Will he remain an outcast or face his demons and become what he needs to be?", null, 8, "tt0110357", 45, new DateTime(1994, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Lion King" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4d28016e-57e9-418b-8eba-41308133d3e2"), "https://image.tmdb.org/t/p/w500/evUB9YKE5IPPtQOchcEF6hS90BO.jpg", "https://image.tmdb.org/t/p/w500/mM5Cad2ESBprh6ucPnMzMfI34Cu.jpg", "When Leonard Vole is arrested for the sensational murder of a rich, middle-aged widow, the famous Sir Wilfrid Robarts agrees to appear on his behalf. Sir Wilfrid, recovering from a near-fatal heart attack, is supposed to be on a diet of bland, civil suits—but the lure of the criminal courts is too much for him, especially when the case is so difficult.", null, 7, "tt0051201", 66, new DateTime(1957, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Witness for the Prosecution" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4d95ca40-377f-4379-959b-07a042d000ca"), "https://image.tmdb.org/t/p/w500/wyvUmyzqGOBDyqLHRSukGDjI7bH.jpg", "https://image.tmdb.org/t/p/w500/7XLSwxpfpPoJyTdJVot6a42TS2V.jpg", "Aibileen Clark is a middle-aged African-American maid who has spent her life raising white children and has recently lost her only son; Minny Jackson is an African-American maid who has often offended her employers despite her family's struggles with money and her desperate need for jobs; and Eugenia \"Skeeter\" Phelan is a young white woman who has recently moved back home after graduating college to find out her childhood maid has mysteriously disappeared. These three stories intertwine to explain how life in Jackson, Mississippi revolves around \"the help\"; yet they are always kept at a certain distance because of racial lines.", null, 7, "tt1454029", 236, new DateTime(2011, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Help" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4e5939a6-fe5a-4f54-ae36-03202db8f45c"), "https://image.tmdb.org/t/p/w500/f61COvOzOOIwx7whPl5Yj78s9gY.jpg", "https://image.tmdb.org/t/p/w500/vVUIAVsh2lMzweyrbdsOgiZoQuy.jpg", "Two bounty hunters are in pursuit of \"El Indio,\" one of the most wanted fugitives in the western territories, and his gang.", null, 19, "tt0059578", 107, new DateTime(1965, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "For a Few Dollars More" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4f9a9a5d-85fe-4f6f-a762-bff73be4019b"), "https://image.tmdb.org/t/p/w500/mlolzwV6VrKOZJ1SfYbPHXXDD4p.jpg", "https://image.tmdb.org/t/p/w500/oU7Oq2kFAAlGqbU4VoAE36g4hoI.jpg", "A wealthy entrepreneur secretly creates a theme park featuring living dinosaurs drawn from prehistoric DNA. Before opening day, he invites a team of experts and his two eager grandchildren to experience the park and help calm anxious investors. However, the park is anything but amusing as the security systems go off-line and the dinosaurs escape.", null, 2, "tt0107290", 180, new DateTime(1993, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Jurassic Park" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4feb9916-4bd9-427d-82df-b83e93f411f3"), "https://image.tmdb.org/t/p/w500/d9VUlRTovsGbwkUjNR2OGOGrQuO.jpg", "https://image.tmdb.org/t/p/w500/wcZ21zrOsy0b52AfAF50XpTiv75.jpg", "When disillusioned Swedish knight Antonius Block returns home from the Crusades to find his country in the grips of the Black Death, he challenges Death to a chess match for his life. Tormented by the belief that God does not exist, Block sets off on a journey, meeting up with traveling players Jof and his wife, Mia, and becoming determined to evade Death long enough to commit one redemptive act while he still lives.", null, 9, "tt0050976", 145, new DateTime(1957, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Seventh Seal" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("4ffad4df-3715-45cc-b427-99378385d1b2"), "https://image.tmdb.org/t/p/w500/354kfjVb96mtFALMhBE6jzHGiA2.jpg", "https://image.tmdb.org/t/p/w500/bczBPKNxk1RnLfKZH4slMDwJTjl.jpg", "A commanding officer defends three scapegoats on trial for a failed offensive that occurred within the French Army in 1916.", null, 7, "tt0050825", 61, new DateTime(1957, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Paths of Glory" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5014f7b9-9535-4351-8338-b037948280b1"), "https://image.tmdb.org/t/p/w500/hUzRPXBUHyJhpyGV0NfBDuadbgp.jpg", "https://image.tmdb.org/t/p/w500/shn0dsmsjJ5FNV1Z1WljCFt3C9J.jpg", "Terry Malloy dreams about being a prize fighter, while tending his pigeons and running errands at the docks for Johnny Friendly, the corrupt boss of the dockers union. Terry witnesses a murder by two of Johnny's thugs, and later meets the dead man's sister and feels responsible for his death. She introduces him to Father Barry, who tries to force him to provide information for the courts that will smash the dock racketeers.", null, 5, "tt0047296", 147, new DateTime(1954, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "On the Waterfront" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("50a8cb5a-78de-4eb0-a83b-4582fb6169a3"), "https://image.tmdb.org/t/p/w500/qdIMHd4sEfJSckfVJfKQvisL02a.jpg", "https://image.tmdb.org/t/p/w500/saHP97rTPS5eLmrLQEcANmKrsFl.jpg", "A man with a low IQ has accomplished great things in his life and been present during significant historic events—in each case, far exceeding what anyone imagined he could do. But despite all he has achieved, his one true love eludes him.", null, 4, "tt0109830", 12, new DateTime(1994, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Forrest Gump" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5226990e-622a-42d2-b167-de9337339a38"), "https://image.tmdb.org/t/p/w500/W1ffLQGHoxfAOq0ZYdPtJlvAdb.jpg", "https://image.tmdb.org/t/p/w500/5MwkWH9tYHv3mV9OdYTMR5qreIz.jpg", "Joel Barish, heartbroken that his girlfriend underwent a procedure to erase him from her memory, decides to do the same. However, as he watches his memories of her fade away, he realises that he still loves her, and may be too late to correct his mistake.", null, 15, "tt0338013", 89, new DateTime(2004, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Eternal Sunshine of the Spotless Mind" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("53b19403-1949-4360-a66e-80e6e10d32f8"), "https://image.tmdb.org/t/p/w500/sWWwq8MsfI3Zrn4Zz0HENnhp70J.jpg", "https://image.tmdb.org/t/p/w500/eHuGQ10FUzK1mdOY69wF5pGgEf5.jpg", "Nemo, an adventurous young clownfish, is unexpectedly taken from his Great Barrier Reef home to a dentist's office aquarium. It's up to his worrisome father Marlin and a friendly but forgetful fish Dory to bring Nemo home -- meeting vegetarian sharks, surfer dude turtles, hypnotic jellyfish, hungry seagulls, and more along the way.", null, 3, "tt0266543", 169, new DateTime(2003, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Finding Nemo" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("55aa58d4-8234-4b03-8c05-c9fe2f712f3f"), "https://image.tmdb.org/t/p/w500/mfwq2nMBzArzQ7Y9RKE8SKeeTkg.jpg", "https://image.tmdb.org/t/p/w500/rplLJ2hPcOQmkFhTqUte0MkEaO2.jpg", "Clarice Starling is a top student at the FBI's training academy. Jack Crawford wants Clarice to interview Dr. Hannibal Lecter, a brilliant psychiatrist who is also a violent psychopath, serving life behind bars for various acts of murder and cannibalism. Crawford believes that Lecter may have insight into a case and that Starling, as an attractive young woman, may be just the bait to draw him out.", null, 5, "tt0102926", 24, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Silence of the Lambs" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("55ccea7a-fa45-439c-9df5-3d40becc7e3c"), "https://image.tmdb.org/t/p/w500/vRTKNKNWLZ22fAgPa5kY8wT2b1F.jpg", "https://image.tmdb.org/t/p/w500/tIZN5Lpd8MWFKHXDRIXTjlSA22L.jpg", "Bud Baxter is a minor clerk in a huge New York insurance company, until he discovers a quick way to climb the corporate ladder. He lends out his apartment to the executives as a place to take their mistresses. Although he often has to deal with the aftermath of their visits, one night he's left with a major problem to solve.", null, 4, "tt0053604", 108, new DateTime(1960, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Apartment" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("57e176fd-0b82-470b-82c1-f4daf7d1dbe7"), "https://image.tmdb.org/t/p/w500/oT9diLGD1cgPdvkxqHIJcuSXKUT.jpg", "https://image.tmdb.org/t/p/w500/gCgt1WARPZaXnq523ySQEUKinCs.jpg", "A narcissistic TV weatherman, along with his attractive-but-distant producer, and his mawkish cameraman, is sent to report on Groundhog Day in the small town of Punxsutawney, where he finds himself repeating the same day over and over.", null, 14, "tt0107048", 235, new DateTime(1993, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Groundhog Day" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5a3e6f74-3620-4059-b4c4-10e6ac2ebe44"), "https://image.tmdb.org/t/p/w500/A9fYmLtIy11fQtlpAyxcs9d3Ejq.jpg", "https://image.tmdb.org/t/p/w500/obpPQskaVpSiC9RcJRB6iWDTCXS.jpg", "Obsessive master thief Neil McCauley leads a top-notch crew on various daring heists throughout Los Angeles while determined detective Vincent Hanna pursues him without rest. Each man recognizes and respects the ability and the dedication of the other even though they are aware their cat-and-mouse game may end in violence.", null, 1, "tt0113277", 123, new DateTime(1995, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Heat" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5b135f73-0950-43a3-953f-27624cc792e6"), "https://image.tmdb.org/t/p/w500/dYocWQoWk3Y6vBa0pGc0OQ8GLqn.jpg", "https://image.tmdb.org/t/p/w500/4NmV1Wei4LxT2lpjViCAScgCZLq.jpg", "During America’s Civil War, Union spies steal engineer Johnnie Gray's beloved locomotive, 'The General'—with Johnnie's lady love aboard an attached boxcar—and he single-handedly must do all in his power to both get The General back and to rescue Annabelle.", null, 1, "tt0017925", 162, new DateTime(1926, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The General" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5b703cf7-e99d-4538-a9d2-a9813c8b5c65"), "https://image.tmdb.org/t/p/w500/wPU78OPN4BYEgWYdXyg0phMee64.jpg", "https://image.tmdb.org/t/p/w500/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg", "Framed in the 1940s for the double murder of his wife and her lover, upstanding banker Andy Dufresne begins a new life at the Shawshank prison, where he puts his accounting skills to work for an amoral warden. During his long stretch in prison, Dufresne comes to be admired by the other inmates -- including an older prisoner named Red -- for his integrity and unquenchable sense of hope.", null, 7, "tt0111161", 1, new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Shawshank Redemption" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5bd70a9d-c9e6-4ba5-9458-60a1e754fdc4"), "https://image.tmdb.org/t/p/w500/bGksau9GGu0uJ8DJQ8DYc9JW5LM.jpg", "https://image.tmdb.org/t/p/w500/323BP0itpxTsO0skTwdnVmf7YC9.jpg", "A true story of two men who should never have met – a quadriplegic aristocrat who was injured in a paragliding accident and a young man from the projects.", null, 7, "tt1675434", 40, new DateTime(2011, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Intouchables" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5ceacbf2-c8a6-42f9-8e51-48b956df8359"), "https://image.tmdb.org/t/p/w500/A6Cq1Hjw8qe47DsLAi2nHmNcRyZ.jpg", "https://image.tmdb.org/t/p/w500/44KTRoayojxpzti2okBZGKmjEGM.jpg", "Baran the Bandit, released from prison after serving 35 years, searches for vengeance against his former best friend who betrayed him and stole his lover, teaming up with a young punk with his own demons along the way.", null, 5, "tt0116231", 203, new DateTime(1996, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Bandit" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5d3ad990-5259-479f-a894-81a82edc48ac"), "https://image.tmdb.org/t/p/w500/yW9mPUhrsIzKvogNJKQKuWO8fJO.jpg", "https://image.tmdb.org/t/p/w500/4ykzTiHKLamh3eZJ8orVICtU2Jp.jpg", "When petty criminal Luke Jackson is sentenced to two years in a Florida prison farm, he doesn't play by the rules of either the sadistic warden or the yard's resident heavy, Dragline, who ends up admiring the new guy's unbreakable will. Luke's bravado, even in the face of repeated stints in the prison's dreaded solitary confinement cell, \"the box,\" make him a rebel hero to his fellow convicts and a thorn in the side of the prison officers.", null, 5, "tt0061512", 175, new DateTime(1967, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Cool Hand Luke" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5e5045e0-4dd9-4ebf-95ab-1b5ee5f246a5"), "https://image.tmdb.org/t/p/w500/wsRysp1DpjRdJv8D3eN4lEsGju9.jpg", "https://image.tmdb.org/t/p/w500/fvobAlXFCsCXqZlPYMGhu5W9gvr.jpg", "A German submarine hunts allied ships during the Second World War, but it soon becomes the hunted. The crew tries to survive below the surface, while stretching both the boat and themselves to their limits.", null, 7, "tt0082096", 73, new DateTime(1981, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Das Boot" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5ed869ed-61ab-4f02-86ce-bb3172948a44"), "https://image.tmdb.org/t/p/w500/yWpbG6BT0IdwBnGHpCUicKTDGOm.jpg", "https://image.tmdb.org/t/p/w500/wx4ptyx3vlPBVl5DzBA8KomcJww.jpg", "A renegade reporter and a crazy young heiress meet on a bus heading for New York, and end up stuck with each other when the bus leaves them behind at one of the stops.", null, 4, "tt0025316", 191, new DateTime(1934, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "It Happened One Night" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5f51ab75-cb81-4199-98be-dd920509fbb2"), "https://image.tmdb.org/t/p/w500/guhVuJAqSEMrUgKMB04y0SXJr8Q.jpg", "https://image.tmdb.org/t/p/w500/wcGLnRsuKyCYg3WLXQqIuB0lsJB.jpg", "A private detective takes on a case that involves him with three eccentric criminals, a beautiful liar, and their quest for a priceless statuette.", null, 13, "tt0033870", 226, new DateTime(1941, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Maltese Falcon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("5fdbc792-51ce-4932-9445-d131cb42a4a2"), "https://image.tmdb.org/t/p/w500/j2ZvLJyz163MlmBFsoaDYOwxgws.jpg", "https://image.tmdb.org/t/p/w500/npOnzAbLh6VOIu3naU5QaEcTepo.jpg", "A young boy and a girl with a magic crystal must race against pirates and foreign agents in a search for a legendary floating castle.", null, 2, "tt0092067", 241, new DateTime(1986, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Castle in the Sky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("601bcb43-96a8-4a1e-9d90-bd9696f262c5"), "https://image.tmdb.org/t/p/w500/jKgLVAhoq4fXBs1C9Gjvap93fxd.jpg", "https://image.tmdb.org/t/p/w500/3Gla0nxHboX3nxQzaU4SoqOtTjh.jpg", "Story of a young woman who marries a fascinating widower only to find out that she must live in the shadow of his former wife, Rebecca, who died mysteriously several years earlier. The young wife must come to grips with the terrible secret of her handsome, cold husband, Max De Winter. She must also deal with the jealous, obsessed Mrs. Danvers, the housekeeper, who will not accept her as the mistress of the house.", null, 13, "tt0032976", 178, new DateTime(1940, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Rebecca" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("61a51f69-c8e5-4c21-873c-aca0ec7bda30"), "https://image.tmdb.org/t/p/w500/idWj39RpSeIzb7t3XwIiCuwDTqC.jpg", "https://image.tmdb.org/t/p/w500/s2xcqSFfT6F7ZXHxowjxfG0yisT.jpg", "When an insatiable great white shark terrorizes the townspeople of Amity Island, the police chief, an oceanographer and a grizzled shark hunter seek to destroy the blood-thirsty beast.", null, 11, "tt0073195", 238, new DateTime(1975, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Jaws" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("6247bea4-7095-4551-913a-a3e96ace5577"), "https://image.tmdb.org/t/p/w500/9yepEBnQNcKzWWyHdUiX8Mnqc6U.jpg", "https://image.tmdb.org/t/p/w500/xF4oCG3PLNbcrtPZbqB3BtkIbKg.jpg", "Rome, 1957. A woman, Cabiria, is robbed and left to drown by her boyfriend, Giorgio. Rescued, she resumes her life and tries her best to find happiness in a cynical world. Even when she thinks her struggles are over and she has found happiness and contentment, things may not be what they seem.", null, 7, "tt0050783", 244, new DateTime(1957, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Nights of Cabiria" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("62b0bb48-d3ec-4d34-8fdc-ac8e57f3b2d0"), "https://image.tmdb.org/t/p/w500/jIqp5xXY2aw1kxnBPyCXkKQBOJ3.jpg", "https://image.tmdb.org/t/p/w500/eQRFo1qwRREYwj47Yoe1PisgOle.jpg", "A lone prospector ventures into Alaska looking for gold. He soon gets mixed up with some burly characters, falls in love with the beautiful Georgia, and tries to win her heart with his singular charm.", null, 2, "tt0015864", 140, new DateTime(1925, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Gold Rush" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("65236f91-6228-42b3-a0e6-96cb0fb035a7"), "https://image.tmdb.org/t/p/w500/g7KmJaGFvST5cyvA71V6epKAqIC.jpg", "https://image.tmdb.org/t/p/w500/w03EiJVHP8Un77boQeE7hg9DVdU.jpg", "In 1927 Hollywood, a silent film production company and cast make a difficult transition to sound.", null, 4, "tt0045152", 92, new DateTime(1952, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Singin' in the Rain" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("654aa24b-f5ae-492b-86e2-aaa2803208c9"), "https://image.tmdb.org/t/p/w500/cXQH2u7wUIX1eoIdEj51kHXoWhX.jpg", "https://image.tmdb.org/t/p/w500/8kSerJrhrJWKLk1LViesGcnrUPE.jpg", "A card shark and his unwillingly-enlisted friends need to make a lot of cash quick after losing a sketchy poker match. To do this they decide to pull a heist on a small-time gang who happen to be operating out of the flat next door.", null, 4, "tt0120735", 143, new DateTime(1998, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Lock, Stock and Two Smoking Barrels" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("6596aaf6-2fff-4e79-b95b-adb5ebbe31f7"), "https://image.tmdb.org/t/p/w500/1uOpPfARvbEf1TQfRGadWHhQqJH.jpg", "https://image.tmdb.org/t/p/w500/994cgAiauYUkkwsikMOjnvaLhxk.jpg", "Naive and idealistic Jefferson Smith, leader of the Boy Rangers, is appointed to the United States Senate by the puppet governor of his state. He soon discovers, upon going to Washington, many shortcomings of the political process as his earnest goal of a national boys' camp leads to a conflict with the state political boss.", null, 4, "tt0031679", 152, new DateTime(1939, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Mr. Smith Goes to Washington" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("661ead07-62c6-4ceb-9832-d063ce90d3c3"), "https://image.tmdb.org/t/p/w500/BBVAUchYvkmPThVIqipgAfabfl.jpg", "https://image.tmdb.org/t/p/w500/iyTD2QnySNMPUPE3IedZQipSWfz.jpg", "Crotchety retired doctor Isak Borg travels from Stockholm to Lund, Sweden, with his pregnant and unhappy daughter-in-law, Marianne, in order to receive an honorary degree from his alma mater. Along the way, they encounter a series of hitchhikers, each of whom causes the elderly doctor to muse upon the pleasures and failures of his own life. These include the vivacious young Sara, a dead ringer for the doctor's own first love.", null, 7, "tt0050986", 160, new DateTime(1957, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Wild Strawberries" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("671a5120-5e77-4b00-a22b-e39460bb103e"), "https://image.tmdb.org/t/p/w500/bxY7ve1LP8atCIuvr4jeeJMmU4w.jpg", "https://image.tmdb.org/t/p/w500/2rs16qtfuOuExq1vBtfmTUtRYFj.jpg", "Truman Burbank is the star of The Truman Show, a 24-hour-a-day reality TV show that broadcasts every aspect of his life without his knowledge. His entire life has been an unending soap opera for consumption by the rest of the world. And everyone he knows, including his wife and his best friend is really an actor, paid to be part of his life.", null, 4, "tt0120382", 184, new DateTime(1998, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Truman Show" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("674d31c1-cc0f-4bcd-840d-8f6a54efae51"), "https://image.tmdb.org/t/p/w500/pRMmLhZQncfvS44JelQyB078ZP2.jpg", "https://image.tmdb.org/t/p/w500/gZ8hhuVEQ78CLND09trZJ45Eiy8.jpg", "When veteran anchorman Howard Beale is forced to retire his 25-year post because of his age, he announces to viewers that he will kill himself during his farewell broadcast. Network executives rethink their decision when his fanatical tirade results in a spike in ratings.", null, 7, "tt0074958", 194, new DateTime(1976, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Network" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("678ea559-a0ff-4acc-916b-67e82e84e1ba"), "https://image.tmdb.org/t/p/w500/jFKM4cMVeoXKy8Vez3RcV60WgNJ.jpg", "https://image.tmdb.org/t/p/w500/56mOJth6DJ6JhgoE2jtpilVqJO.jpg", "Unscrupulous boxing promoters, violent bookmakers, a Russian gangster, incompetent amateur robbers and supposedly Jewish jewelers fight to track down a priceless stolen diamond.", null, 5, "tt0208092", 105, new DateTime(2000, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Snatch" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("67ef853d-5211-4258-9c93-2142cf08dede"), "https://image.tmdb.org/t/p/w500/fgRhyGbMAolDsQ65VRBRBtVQZNn.jpg", "https://image.tmdb.org/t/p/w500/f1bF8CHzEu621bPSIg6XiUNAabh.jpg", "After a group of friends graduate from Delhi University, they listlessly haunt their old campus, until a British filmmaker casts them in a film she's making about freedom fighters under British rule. Although the group is largely apolitical, the tragic death of a friend owing to local government corruption awakens their patriotism. Inspired by the freedom fighters they represent in the film, the friends collectively decide to avenge the killing.", null, 4, "tt0405508", 222, new DateTime(2006, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Rang De Basanti" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("68635b5b-d508-45d8-bd01-dd1e322e3895"), "https://image.tmdb.org/t/p/w500/AfyuI3glMCBDFmNPj9PY6DwbgGp.jpg", "https://image.tmdb.org/t/p/w500/j6G24dqI4WgUtChhWjfnI4lnmiK.jpg", "The second of two theatrically released follow-ups to the Neon Genesis Evangelion series. Comprising of two alternate episodes which were first intended to take the place of episodes 25 and 26, this finale answers many of the questions surrounding the series, while also opening up some new possibilities.", null, 7, "tt0169858", 202, new DateTime(1997, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Neon Genesis Evangelion: The End of Evangelion" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("699f713c-9194-4851-9a02-94418686eec7"), "https://image.tmdb.org/t/p/w500/kxklJL1v8MYEU5xdU6W5VvmBwVz.jpg", "https://image.tmdb.org/t/p/w500/ygGmAO60t8GyqUo9xYeYxSZAR3b.jpg", "As the son of a Viking leader on the cusp of manhood, shy Hiccup Horrendous Haddock III faces a rite of passage: he must kill a dragon to prove his warrior mettle. But after downing a feared dragon, he realizes that he no longer wants to destroy it, and instead befriends the beast – which he names Toothless – much to the chagrin of his warrior father.", null, 9, "tt0892769", 181, new DateTime(2010, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "How to Train Your Dragon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("6c772905-e3e6-432d-a495-99c398115bd2"), "https://image.tmdb.org/t/p/w500/pbrkL804c8yAv3zBZR4QPEafpAR.jpg", "https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg", "The adventures of a group of explorers who make use of a newly discovered wormhole to surpass the limitations on human space travel and conquer the vast distances involved in an interstellar voyage.", null, 2, "tt0816692", 32, new DateTime(2014, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Interstellar" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("6cedcc75-daee-4c4d-8dcd-7a2d453fdf6e"), "https://image.tmdb.org/t/p/w500/ruF3Lmd4A8MHbnEBE6lxPMbsHGL.jpg", "https://image.tmdb.org/t/p/w500/sav0jxhqiH0bPr2vZFU0Kjt2nZL.jpg", "Newspaper magnate, Charles Foster Kane is taken from his mother as a boy and made the ward of a rich industrialist. As a result, every well-meaning, tyrannical or self-destructive move he makes for the rest of his life appears in some way to be a reaction to that deeply wounding event.", null, 13, "tt0033467", 74, new DateTime(1941, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Citizen Kane" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("6e58e95d-34a2-4617-92fc-a7beb6a23e56"), "https://image.tmdb.org/t/p/w500/pUKIUdLMHvPkCs5pQeB2TFhPSYM.jpg", "https://image.tmdb.org/t/p/w500/pCURNjeomWbMSdiP64gj8NVVHTQ.jpg", "Held captive for 7 years in an enclosed space, a woman and her young son finally gain their freedom, allowing the boy to experience the outside world for the first time.", null, 7, "tt3170832", 153, new DateTime(2015, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Room" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("7023d547-741f-40a1-8433-faa1a9943d55"), "https://image.tmdb.org/t/p/w500/747dgDfL5d8esobk7h4odaOFhUq.jpg", "https://image.tmdb.org/t/p/w500/rt7cpEr1uP6RTZykBFhBTcRaKvG.jpg", "Jerry, a small-town Minnesota car salesman is bursting at the seams with debt... but he's got a plan. He's going to hire two thugs to kidnap his wife in a scheme to collect a hefty ransom from his wealthy father-in-law. It's going to be a snap and nobody's going to get hurt... until people start dying. Enter Police Chief Marge, a coffee-drinking, parka-wearing - and extremely pregnant - investigator who'll stop at nothing to get her man. And if you think her small-time investigative skills will give the crooks a run for their ransom... you betcha!", null, 5, "tt0116282", 166, new DateTime(1996, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Fargo" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("70f3cf5c-c06b-4da1-a9e1-9dcb12705063"), "https://image.tmdb.org/t/p/w500/hND7xAaxxBgaIspp9iMsaEXOSTz.jpg", "https://image.tmdb.org/t/p/w500/9xLIugjmparUuJBuoncNh4jEEaI.jpg", "In the year 180, the death of emperor Marcus Aurelius throws the Roman Empire into chaos.  Maximus is one of the Roman army's most capable and trusted generals and a key advisor to the emperor.  As Marcus' devious son Commodus ascends to the throne, Maximus is set to be executed.  He escapes, but is captured by slave traders.  Renamed Spaniard and forced to become a gladiator, Maximus must battle to the death with other men for the amusement of paying audiences.", null, 1, "tt0172495", 47, new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Gladiator" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("71b4f6a3-4576-4dc1-a47f-e5385e2ac7f4"), "https://image.tmdb.org/t/p/w500/wE5JGzujfvDPMIfFjJyrhXFjZLc.jpg", "https://image.tmdb.org/t/p/w500/AbbXspMOwdvwWZgVN0nabZq03Ec.jpg", "Woody, Buzz, and the rest of Andy's toys haven't been played with in years. With Andy about to go to college, the gang find themselves accidentally left at a nefarious day care center. The toys must band together to escape and return home to Andy.", null, 3, "tt0435761", 104, new DateTime(2010, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Toy Story 3" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("72fe9e2a-9a0e-41d1-833a-941994337e55"), "https://image.tmdb.org/t/p/w500/soJdiy91Mcyj29GzEgZ5svFcuZg.jpg", "https://image.tmdb.org/t/p/w500/1kAbMLKVJz7LGjs8nnp259tffry.jpg", "Luke Skywalker leads a mission to rescue his friend Han Solo from the clutches of Jabba the Hutt, while the Emperor seeks to destroy the Rebellion once and for all with a second dreaded Death Star.", null, 2, "tt0086190", 80, new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Star Wars: Episode VI - Return of the Jedi" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("7591e738-3bdc-47c5-9cff-aa245dcaf9e7"), "https://image.tmdb.org/t/p/w500/AmR3JG1VQVxU8TfAvljUhfSFUOx.jpg", "https://image.tmdb.org/t/p/w500/bk9GVjN4kxmGekswNigaa5YIdr5.jpg", "During its return to the earth, commercial spaceship Nostromo intercepts a distress signal from a distant planet. When a three-member team of the crew discovers a chamber containing thousands of eggs on the planet, a creature inside one of the eggs attacks an explorer. The entire crew is unaware of the impending nightmare set to descend upon them when the alien parasite planted inside its unfortunate host is birthed.", null, 11, "tt0078748", 52, new DateTime(1979, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Alien" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("759feb6d-eee6-4649-8cad-929e5b6cf315"), "https://image.tmdb.org/t/p/w500/vRQnzOn4HjIMX4LBq9nHhFXbsSu.jpg", "https://image.tmdb.org/t/p/w500/6oom5QYQ2yQTMJIbnvbkBL9cHo6.jpg", "Young hobbit Frodo Baggins, after inheriting a mysterious ring from his uncle Bilbo, must leave his home in order to keep it from falling into the hands of its evil creator. Along the way, a fellowship is formed to protect the ringbearer and make sure that the ring arrives at its final destination: Mt. Doom, the only place where it can be destroyed.", null, 2, "tt0120737", 11, new DateTime(2001, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Lord of the Rings: The Fellowship of the Ring" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("771a36ee-c4e6-413f-8360-52bce8c4e592"), "https://image.tmdb.org/t/p/w500/bd4RndWxzL2H7aiJKoGgk4clEdD.jpg", "https://image.tmdb.org/t/p/w500/69Sns8WoET6CfaYlIkHbla4l7nC.jpg", "Two homicide detectives are on a desperate hunt for a serial killer whose crimes are based on the \"seven deadly sins\" in this dark and haunting film that takes viewers from the tortured remains of one victim to the next. The seasoned Det. Sommerset researches each sin in an effort to get inside the killer's mind, while his novice partner, Mills, scoffs at his efforts to unravel the case.", null, 5, "tt0114369", 21, new DateTime(1995, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Se7en" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("778c1be2-07dc-44c9-b78b-def7f4a2ad91"), "https://image.tmdb.org/t/p/w500/q2CtXYjp9IlnfBcPktNkBPsuAEO.jpg", "https://image.tmdb.org/t/p/w500/yuNs09hvpHVU1cBTCAk9zxsL2oW.jpg", "Leonard Shelby is tracking down the man who raped and murdered his wife. The difficulty of locating his wife's killer, however, is compounded by the fact that he suffers from a rare, untreatable form of short-term memory loss. Although he can recall details of life before his accident, Leonard cannot remember what happened fifteen minutes ago, where he's going, or why.", null, 13, "tt0209144", 51, new DateTime(2000, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Memento" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("7a37ed56-229d-440d-9f10-fa33ac420f19"), "https://image.tmdb.org/t/p/w500/5dF4FNwM2qZIuF0WCUs5zvDGU2H.jpg", "https://image.tmdb.org/t/p/w500/lmz3fQV9wrrYiTU1gCdjhAc8pZ6.jpg", "Ishaan Awasthi is an eight-year-old whose world is filled with wonders that no one else seems to appreciate. Colours, fish, dogs, and kites don't seem important to the adults, who are much more interested in things like homework, marks, and neatness. Ishaan cannot seem to get anything right in class; he is then sent to boarding school, where his life changes forever.", null, 7, "tt0986264", 88, new DateTime(2007, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Taare Zameen Par" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("7aecdae0-5bea-4d8f-b567-b7b15f0a6282"), "https://image.tmdb.org/t/p/w500/fKa8Jy2ge1O0IU6zZXnJ2sxUzdU.jpg", "https://image.tmdb.org/t/p/w500/910xRIUmNJrWH2hkQifBJtoPp5R.jpg", "An expansive Russian drama, this film focuses on the life of revered religious icon painter Andrei Rublev. Drifting from place to place in a tumultuous era, the peace-seeking monk eventually gains a reputation for his art. But after Rublev witnesses a brutal battle and unintentionally becomes involved, he takes a vow of silence and spends time away from his work. As he begins to ease his troubled soul, he takes steps towards becoming a painter once again.", null, 7, "tt0060107", 210, new DateTime(1966, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Andrei Rublev" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("7c4711dd-8587-499e-9e51-72d66a38d7ec"), "https://image.tmdb.org/t/p/w500/aFGPUmbgGoAt93WP3WYsAPa0Yv8.jpg", "https://image.tmdb.org/t/p/w500/66A9MqXOyVFCssoloscw79z8Tew.jpg", "In the tradition of “Ferris Bueller’s Day Off” comes this refreshing comedy about a rebellious prankster with a crafty mind and a heart of gold. Rascal. Joker. Dreamer. Genius... You've never met a college student quite like \"Rancho.\" From the moment he arrives at India's most prestigious university, Rancho's outlandish schemes turn the campus upside down—along with the lives of his two newfound best friends. Together, they make life miserable for \"Virus,\" the school’s uptight and heartless dean. But when Rancho catches the eye of the dean's sexy daughter, Virus sets his sights on flunking out the \"3 idiots\" once and for all.", null, 7, "tt1187043", 85, new DateTime(2009, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "3 Idiots" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("7c8c3d0f-e93d-42f4-9089-c05f22a0fea3"), "https://image.tmdb.org/t/p/w500/o0IWa75BXyXryNDVqw0xoXZzy1J.jpg", "https://image.tmdb.org/t/p/w500/iZTgxn14z9MwbVqq8nnxG4kc1n5.jpg", "Living with her tyrannical stepfather in a new home with her pregnant mother, 10-year-old Ofelia feels alone until she explores a decaying labyrinth guarded by a mysterious faun who claims to know her destiny. If she wishes to return to her real father, Ofelia must complete three terrifying tasks.", null, 9, "tt0457430", 131, new DateTime(2006, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Pan's Labyrinth" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("7c9b3103-3926-47f9-9ab8-a7d30d77b8b4"), "https://image.tmdb.org/t/p/w500/9LSsSPbP715XT9B7acIZzantPyX.jpg", "https://image.tmdb.org/t/p/w500/c2gsmSQ2Cqv8zosqKOCwRS0GFBS.jpg", "Derek Vineyard is paroled after serving 3 years in prison for killing two African-American men. Through his brother, Danny Vineyard's narration, we learn that before going to prison, Derek was a skinhead and the leader of a violent white supremacist gang that committed acts of racial crime throughout L.A. and his actions greatly influenced Danny. Reformed and fresh out of prison, Derek severs contact with the gang and becomes determined to keep Danny from going down the same violent path as he did.", null, 7, "tt0120586", 34, new DateTime(1998, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "American History X" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("7cf06eca-0374-4486-b2db-017131b4fa4e"), "https://image.tmdb.org/t/p/w500/6GCmNNgmftkqQahQMkVJL6sqZOW.jpg", "https://image.tmdb.org/t/p/w500/gBH4H8UMFxl139HaLz6lRuvsel8.jpg", "The Nazis, exasperated at the number of escapes from their prison camps by a relatively small number of Allied prisoners, relocate them to a high-security 'escape-proof' camp to sit out the remainder of the war. Undaunted, the prisoners plan one of the most ambitious escape attempts of World War II. Based on a true story.", null, 2, "tt0057115", 129, new DateTime(1963, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Great Escape" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("7e1c355b-7414-4aeb-9a87-92cf3b3a3d56"), "https://image.tmdb.org/t/p/w500/y6JA85N8DvoonwqDGWlgkr1jnU.jpg", "https://image.tmdb.org/t/p/w500/lsy3aEsEfYIHdLRk4dontZ4s85h.jpg", "A drama based on the true story of a college professor's bond with the abandoned dog he takes into his home.", null, 7, "tt1028532", 208, new DateTime(2009, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Hachi: A Dog's Tale" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("7ecdcc9f-bb0b-4f5e-a168-7c471bd54222"), "https://image.tmdb.org/t/p/w500/7tNTPZMb13W0AhkcuoL6myRrNRr.jpg", "https://image.tmdb.org/t/p/w500/5VTN0pR8gcqV3EPUHHfMGnJYN9L.jpg", "Frodo and Sam are trekking to Mordor to destroy the One Ring of Power while Gimli, Legolas and Aragorn search for the orc-captured Merry and Pippin. All along, nefarious wizard Saruman awaits the Fellowship members at the Orthanc Tower in Isengard.", null, 2, "tt0167261", 15, new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Lord of the Rings: The Two Towers" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("809051fe-6a80-4462-825a-5f47a2f33c97"), "https://image.tmdb.org/t/p/w500/5qtOVAcBFogwktkseoZSfZVq6bx.jpg", "https://image.tmdb.org/t/p/w500/dgNTS4EQDDVfkzJI5msKuHu2Ei3.jpg", "Kanji Watanabe is a middle-aged man who has worked in the same monotonous bureaucratic position for decades. Learning he has cancer, he starts to look for the meaning of his life.", null, 7, "tt0044741", 126, new DateTime(1952, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Ikiru" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("810ab9b0-57fb-4da5-9328-6d7ce35730f2"), "https://image.tmdb.org/t/p/w500/jOh79POQu4hyVIseUxdQxTW7vOf.jpg", "https://image.tmdb.org/t/p/w500/z8onk7LV9Mmw6zKz4hT6pzzvmvl.jpg", "Jack Sparrow, a freewheeling 18th-century pirate, quarrels with a rival pirate bent on pillaging Port Royal. When the governor's daughter is kidnapped, Sparrow decides to help the girl's love save her.", null, 2, "tt0325980", 243, new DateTime(2003, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Pirates of the Caribbean: The Curse of the Black Pearl" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("818886d3-12c4-4efc-bda4-da6e900296fa"), "https://image.tmdb.org/t/p/w500/7aRdT0ijJdME6jY8PzHgzAmw0dd.jpg", "https://image.tmdb.org/t/p/w500/j6MGZpg55cTqlHHwahBtzI2qQg1.jpg", "China in the 1920s. After her father's death, 19 year old Songlian is forced to marry the much older lord of a powerful family. With three wives already, each living in a separate house within the great castle, there is fierce competition for his attention and the privileges that are gained. This competition gets out of hand...", null, 7, "tt0101640", 228, new DateTime(1991, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Raise the Red Lantern" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("834052c0-26f5-4825-b5f0-c74c9c8e30da"), "https://image.tmdb.org/t/p/w500/mpNd0rTVrp6vHJ9Je7wSa3zC8JS.jpg", "https://image.tmdb.org/t/p/w500/pdtzEreKvKAlqa2YEBaGwiA45V8.jpg", "Ashitaka, a prince of the disappearing Emishi people, is cursed by a demonized boar god and must journey to the west to find a cure. Along the way, he encounters San, a young human woman fighting to protect the forest, and Lady Eboshi, who is trying to destroy it. Ashitaka must find a way to bring balance to this conflict.", null, 2, "tt0119698", 65, new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Princess Mononoke" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("876d41b4-850a-4c46-bdaf-c6672a36e5d4"), "https://image.tmdb.org/t/p/w500/mbJIERhLu25fyZb8DQIq1JN3AOR.jpg", "https://image.tmdb.org/t/p/w500/5eZ2xRm4nqwORyzLZN0gUrNFFZx.jpg", "Scout Finch, 6, and her older brother Jem live in sleepy Maycomb, Alabama, spending much of their time with their friend Dill and spying on their reclusive and mysterious neighbor, Boo Radley. When Atticus, their widowed father and a respected lawyer, defends a black man named Tom Robinson against fabricated rape charges, the trial and tangent events expose the children to evils of racism and stereotyping.", null, 5, "tt0056592", 98, new DateTime(1962, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "To Kill a Mockingbird" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("88b59a21-f7b1-442c-9335-27cf1865771d"), "https://image.tmdb.org/t/p/w500/m7U3G8TyUIUsIXVvXrqd2VmVGjC.jpg", "https://image.tmdb.org/t/p/w500/bdXbfUir63TQHA5NTNcXPICZCW8.jpg", "A young nurse, Alma, is put in charge of Elisabeth Vogler: an actress who is seemingly healthy in all respects, but will not talk. As they spend time together, Alma speaks to Elisabeth constantly, never receiving any answer. The time they spend together only strengthens the crushing realization that one does not exist.", null, 7, "tt0060827", 197, new DateTime(1966, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Persona" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("8b368bf3-92ff-4ee4-8abb-37a65a81ac5a"), "https://image.tmdb.org/t/p/w500/gUIVD0rFWVB8Okk8wU8dQxjOYnZ.jpg", "https://image.tmdb.org/t/p/w500/3NcIkKxaO2SmRVsG1v50XhtmL0f.jpg", "A small time thief from Belfast, Gerry Conlon, is falsely implicated in the IRA bombing of a pub that kills several people while he is in London. He and his four friends are coerced by British police into confessing their guilt. Gerry's father and other relatives in London are also implicated in the crime. He spends fifteen years in prison with his father trying to prove his innocence.", null, 7, "tt0107207", 188, new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "In the Name of the Father" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("8c35ee7d-5a52-4cfd-8c8d-ad8abe700349"), "https://image.tmdb.org/t/p/w500/iSbhQqeDnkvFuP7QWwy0qeX0LYy.jpg", "https://image.tmdb.org/t/p/w500/hVIKyTK13AvOGv7ICmJjK44DTzp.jpg", "Two musicians witness a mob hit and struggle to find a way out of the city before they are found by the gangsters. Their only opportunity is to join an all-girl band as they leave on a tour. To make their getaway they must first disguise themselves as women, then keep their identities secret and deal with the problems this brings - such as an attractive bandmate and a very determined suitor.", null, 4, "tt0053291", 118, new DateTime(1959, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Some Like It Hot" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("8c8a12dd-47a8-47e1-a25f-63bc787564ae"), "https://image.tmdb.org/t/p/w500/poec6RqOKY9iSiIUmfyfPfiLtvB.jpg", "https://image.tmdb.org/t/p/w500/bMadFzhjy9T7R8J48QGq1ngWNAK.jpg", "In the continuing saga of the Corleone crime family, a young Vito Corleone grows up in Sicily and in 1910s New York. In the 1950s, Michael Corleone attempts to expand the family business into Las Vegas, Hollywood and Cuba.", null, 7, "tt0071562", 3, new DateTime(1974, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Godfather: Part II" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("8e62a45d-5adc-43a5-9fe0-b2662372c5ce"), "https://image.tmdb.org/t/p/w500/dVr11o9or7AS8AMPfwjSpEU83iU.jpg", "https://image.tmdb.org/t/p/w500/2hFvxCCWrTmCYwfy7yum0GKRi3Y.jpg", "The true story of pianist Władysław Szpilman's experiences in Warsaw during the Nazi occupation. When the Jews of the city find themselves forced into a ghetto, Szpilman finds work playing in a café; and when his family is deported in 1942, he stays behind, works for a while as a laborer, and eventually goes into hiding in the ruins of the war-torn city.", null, 7, "tt0253474", 38, new DateTime(2002, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Pianist" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("8f1a3f3c-9134-446e-ada7-a0c4c616180f"), "https://image.tmdb.org/t/p/w500/blbA7NEHARQOWy5i9VF5K2kHrPc.jpg", "https://image.tmdb.org/t/p/w500/pWHf4khOloNVfCxscsXFj3jj6gP.jpg", "A New York stockbroker refuses to cooperate in a large securities fraud case involving corruption on Wall Street, corporate banking world and mob infiltration. Based on Jordan Belfort's autobiography.", null, 5, "tt0993846", 148, new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Wolf of Wall Street" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("9105922f-b628-450c-9167-10274722d768"), "https://image.tmdb.org/t/p/w500/qqHQsStV6exghCM7zbObuYBiYxw.jpg", "https://image.tmdb.org/t/p/w500/6PlhouMCYktJmdFwS9XtqRZaTqc.jpg", "The defense and the prosecution have rested and the jury is filing into the jury room to decide if a young Spanish-American is guilty or innocent of murdering his father. What begins as an open and shut case soon becomes a mini-drama of each of the jurors' prejudices and preconceptions about the trial, the accused, and each other.", null, 7, "tt0050083", 5, new DateTime(1957, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "12 Angry Men" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("91c07918-8d4f-45c0-a0cb-ade2b9ac6f68"), "https://image.tmdb.org/t/p/w500/63HcRYJI4LKeo8sINlL71ZtlUFY.jpg", "https://image.tmdb.org/t/p/w500/12PuU23kkDLvTd0nb8hMlE3oShB.jpg", "For young Parisian boy Antoine Doinel, life is one difficult situation after another. Surrounded by inconsiderate adults, including his neglectful parents, Antoine spends his days with his best friend, Rene, trying to plan for a better life. When one of their schemes goes awry, Antoine ends up in trouble with the law, leading to even more conflicts with unsympathetic authority figures.", null, 7, "tt0053198", 211, new DateTime(1959, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The 400 Blows" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("933809d4-22d9-472a-a58c-a4a80e5423b3"), "https://image.tmdb.org/t/p/w500/lP0KshD6ZXWuQiHijo66ggrv9Cx.jpg", "https://image.tmdb.org/t/p/w500/yd7ltAY4j2tRrLAFpVVqh9EhahC.jpg", "Shahid Khan is exiled after impersonating the legendary Sultana Daku in order to rob British trains. Now outcast, Shahid becomes a worker at Ramadhir Singh's colliery, only to spur a revenge battle that passes on to generations. At the turn of the decade, Shahid's son, the philandering Sardar Khan vows to get his father's honor back, becoming the most feared man of Wasseypur.", null, 1, "tt1954470", 249, new DateTime(2012, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Gangs of Wasseypur" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("958e6e92-6d7b-4dbc-a770-be98ed923728"), "https://image.tmdb.org/t/p/w500/1m1c5gIWWkb1FEC9lzsoXHhhs7b.jpg", "https://image.tmdb.org/t/p/w500/or1gBugydmjToAEq7OZY0owwFk.jpg", "Enraged at the slaughter of Murron, his new bride and childhood love, Scottish warrior William Wallace slays a platoon of the local English lord's soldiers. This leads the village to revolt and, eventually, the entire country to rise up against English rule.", null, 1, "tt0112573", 75, new DateTime(1995, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Braveheart" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("9777558b-6fa8-4285-99ec-5784708169a9"), "https://image.tmdb.org/t/p/w500/1YlaU9vXlD4K5EBGZKjaCb9rJb9.jpg", "https://image.tmdb.org/t/p/w500/rk2lKgEtjF9HO9N2UFMRc2cMGdj.jpg", "A Victorian surgeon rescues a heavily disfigured man being mistreated by his \"owner\" as a side-show freak. Behind his monstrous façade, there is revealed a person of great intelligence and sensitivity. Based on the true story of Joseph Merrick (called John Merrick in the film), a severely deformed man in 19th century London.", null, 7, "tt0080678", 149, new DateTime(1980, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Elephant Man" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("9824c7be-0096-4682-b3bd-8adcde337742"), "https://image.tmdb.org/t/p/w500/mYI1VlxvuSnHoK6GYwkFzAgcJXh.jpg", "https://image.tmdb.org/t/p/w500/rO2Fq0AZZx9obs52KJdx4mRE8p5.jpg", "In postwar Vienna, Austria, Holly Martins, a writer of pulp Westerns, arrives penniless as a guest of his childhood chum Harry Lime, only to learn he has died. Martins develops a conspiracy theory after learning of a \"third man\" present at the time of Harry's death, running into interference from British officer Major Calloway, and falling head-over-heels for Harry's grief-stricken lover, Anna.", null, 16, "tt0041959", 134, new DateTime(1949, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Third Man" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("9826284c-58df-4f2e-a8f3-06637bfb3d04"), "https://image.tmdb.org/t/p/w500/5MVSXJieOhbyZudCnV1H4YJpfPV.jpg", "https://image.tmdb.org/t/p/w500/ekstpH614fwDX8DUln1a2Opz0N8.jpg", "A mentally unstable Vietnam War veteran works as a night-time taxi driver in New York City where the perceived decadence and sleaze feed his urge for violent action, attempting to save a preadolescent prostitute in the process.", null, 5, "tt0075314", 96, new DateTime(1976, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Taxi Driver" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("995c8d26-f4ef-4010-856d-f6e1b81ee2b2"), "https://image.tmdb.org/t/p/w500/6TjllWT3cGrPFyqDXurVZ3L8bBi.jpg", "https://image.tmdb.org/t/p/w500/fIssD3w3SvIhPPmVo4WMgZDVLID.jpg", "Following an unexpected tragedy, a child psychologist named Malcolm Crowe meets an nine year old boy named Cole Sear, who is hiding a dark secret.", null, 13, "tt0167404", 161, new DateTime(1999, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Sixth Sense" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("9b48f32d-aaf6-4323-bfc1-d714825c4a13"), "https://image.tmdb.org/t/p/w500/eIi3klFf7mp3oL5EEF4mLIDs26r.jpg", "https://image.tmdb.org/t/p/w500/63N9uy8nd9j7Eog2axPQ8lbr3Wj.jpg", "In the smog-choked dystopian Los Angeles of 2019, blade runner Rick Deckard is called out of retirement to terminate a quartet of replicants who have escaped to Earth seeking their creator for a way to extend their short life spans.", null, 15, "tt0083658", 155, new DateTime(1982, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Blade Runner" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("9bcd287f-91de-4ae7-a848-089dcdc972da"), "https://image.tmdb.org/t/p/w500/yozBWKbyeXtPGN75PlHurOaVvEz.jpg", "https://image.tmdb.org/t/p/w500/kMKyx1k8hWWscYFnPbnxxN4Eqo4.jpg", "A pragmatic U.S. Marine observes the dehumanizing effects the U.S.-Vietnam War has on his fellow recruits from their brutal boot camp training to the bloody street fighting in Hue.", null, 7, "tt0093058", 97, new DateTime(1987, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Full Metal Jacket" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("9c56822e-ed0d-4dc0-851b-07a988af2563"), "https://image.tmdb.org/t/p/w500/oO4tfAUwZQkxbs8rkaCXFRNKGEU.jpg", "https://image.tmdb.org/t/p/w500/32pLDObtIt2MJcdPG9mQKuybImL.jpg", "After getting a green card in exchange for assassinating a Cuban government official, Tony Montana stakes a claim on the drug trade in Miami. Viciously murdering anyone who stands in his way, Tony eventually becomes the biggest drug lord in the state, controlling nearly all the cocaine that comes through Miami. But increased pressure from the police, wars with Colombian drug cartels and his own drug-fueled paranoia serve to fuel the flames of his eventual downfall.", null, 1, "tt0086250", 106, new DateTime(1983, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Scarface" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("9ced41c4-afb5-431e-92ce-2a7690cc3fc6"), "https://image.tmdb.org/t/p/w500/dH6m8iWJEPIFoyQaZiuo9Ih7kpA.jpg", "https://image.tmdb.org/t/p/w500/qvktm0BHcnmDpul4Hz01GIazWPr.jpg", "In the post-apocalyptic future, reigning tyrannical supercomputers teleport a cyborg assassin known as the \"Terminator\" back to 1984 to kill Sarah Connor, whose unborn son is destined to lead insurgents against 21st century mechanical hegemony. Meanwhile, the human-resistance movement dispatches a lone warrior to safeguard Sarah. Can he stop the virtually indestructible killing machine?", null, 1, "tt0088247", 227, new DateTime(1984, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Terminator" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("9e0e9f0b-8047-40f4-9a88-2c8b91beea77"), "https://image.tmdb.org/t/p/w500/kSlO1pHpwQfPQdgVPr7dJiJNtJ8.jpg", "https://image.tmdb.org/t/p/w500/7uoiKOEjxBBW0AgDGQWrlfGQ90w.jpg", "The Tramp struggles to live in modern industrial society with the help of a young homeless woman.", null, 4, "tt0027977", 39, new DateTime(1936, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Modern Times" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("a10926cd-f71e-4a36-9882-9739c825ea55"), "https://image.tmdb.org/t/p/w500/8kVANTHMtwwbW1bI9vzEBkb8p55.jpg", "https://image.tmdb.org/t/p/w500/pvSty5MCAxdj8LlAEXCDfM1YNOl.jpg", "Six deadly stories that explore the extremities of human behaviour involving distressed people seeking revenge.", null, 7, "tt3011894", 183, new DateTime(2014, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Relatos salvajes" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("a355cefb-5582-42e4-ae13-a254d22ae144"), "https://image.tmdb.org/t/p/w500/tJRToZBfb52NhF6SMGAe0bWQc6z.jpg", "https://image.tmdb.org/t/p/w500/ai40gM7SUaGA6fthvsd87o8IQq4.jpg", "At an elite, old-fashioned boarding school in New England, a passionate English teacher inspires his students to rebel against convention and seize the potential of every day, courting the disdain of the stern headmaster.", null, 7, "tt0097165", 224, new DateTime(1989, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Dead Poets Society" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("a36b0700-ac37-424f-8f42-9cf20f3acd89"), "https://image.tmdb.org/t/p/w500/2UFxrUHVuSK3Tth7DvQQlF4mGTd.jpg", "https://image.tmdb.org/t/p/w500/r7vmZjiyZw9rpJMQJdXpjgiCOk9.jpg", "Light years from Earth, 26 years after being abducted, Peter Quill finds himself the prime target of a manhunt after discovering an orb wanted by Ronan the Accuser.", null, 1, "tt2015381", 239, new DateTime(2014, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Guardians of the Galaxy" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("a3c9e355-5c76-488a-bf55-229256c900d4"), "https://image.tmdb.org/t/p/w500/6CLV2HakYO1tyAV5GUHOeNPyaTd.jpg", "https://image.tmdb.org/t/p/w500/bUPmtQzrRhzqYySeiMpv7GurAfm.jpg", "Held in an L.A. interrogation room, Verbal Kint attempts to convince the feds that a mythic crime lord, Keyser Soze, not only exists, but was also responsible for drawing him and his four partners into a multi-million dollar heist that ended with an explosion in San Pedro harbor – leaving few survivors. Verbal lures his interrogators with an incredible story of the crime lord's almost supernatural prowess.", null, 7, "tt0114814", 29, new DateTime(1995, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Usual Suspects" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("a4582c62-c053-4d50-a0a2-fc192a64e596"), "https://image.tmdb.org/t/p/w500/bsoAg22remHKL5O0xJH0m9DX6Pu.jpg", "https://image.tmdb.org/t/p/w500/mQJz8J4naOA7RmCtypTPjgXZIMY.jpg", "Private eye Jake Gittes lives off of the murky moral climate of sunbaked, pre-World War II Southern California. Hired by a beautiful socialite to investigate her husband's extra-marital affair, Gittes is swept into a maelstrom of double dealings and deadly deceits, uncovering a web of personal and political scandals that come crashing together.", null, 5, "tt0071315", 132, new DateTime(1974, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Chinatown" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("a60231b1-0b00-4591-8204-bcea2cfd46cf"), "https://image.tmdb.org/t/p/w500/qxSArjpoHUOIzP5ha3EHvWbPCdY.jpg", "https://image.tmdb.org/t/p/w500/hbhFnRzzg6ZDmm8YAmxBnQpQIPh.jpg", "WALL·E is the last robot left on an Earth that has been overrun with garbage and all humans have fled to outer space. For 700 years he has continued to try and clean up the mess, but has developed some rather interesting human-like qualities. When a ship arrives with a sleek new type of robot, WALL·E thinks he's finally found a friend and stows away on the ship when it leaves.", null, 3, "tt0910970", 64, new DateTime(2008, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "WALL·E" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("a735a825-b0c6-463e-bbf0-4f540184ed76"), "https://image.tmdb.org/t/p/w500/qAvou7F5P4VcIR72JzzrnKEQSN3.jpg", "https://image.tmdb.org/t/p/w500/bSA6DbAC5gdkaooU164lQUX6rVs.jpg", "Young Dorothy finds herself in a magical world where she makes friends with a lion, a scarecrow and a tin man as they make their way along the yellow brick road to talk with the Wizard and ask for the things they miss most in their lives. The Wicked Witch of the West is the only thing that could stop them.", null, 2, "tt0032138", 237, new DateTime(1939, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Wizard of Oz" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("a74aa7ac-32fa-4352-8adb-240eb3dc6b17"), "https://image.tmdb.org/t/p/w500/8AMKZODrCvWe2sCy9Ts7VsLcKd6.jpg", "https://image.tmdb.org/t/p/w500/1QpO9wo7JWecZ4NiBuu625FiY1j.jpg", "Dictator Adenoid Hynkel tries to expand his empire while a poor Jewish barber tries to avoid persecution from Hynkel's regime.", null, 4, "tt0032553", 56, new DateTime(1940, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Great Dictator" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("a9ca38f7-c830-44e2-88ef-9a46a5dcef73"), "https://image.tmdb.org/t/p/w500/7zN7m5jEyrNxFYm2EbQJAZwAG5i.jpg", "https://image.tmdb.org/t/p/w500/jkixsXzRh28q3PCqFoWcf7unghT.jpg", "A teacher lives a lonely life, all the while struggling over his son’s custody. His life slowly gets better as he finds love and receives good news from his son, but his new luck is about to be brutally shattered by an innocent little lie.", null, 7, "tt2106476", 103, new DateTime(2012, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Hunt" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("abbf890a-a5ca-4cb6-8e69-9d5d24a86315"), "https://image.tmdb.org/t/p/w500/jmlM5sa8vrBWHSBubqAithX6Fx5.jpg", "https://image.tmdb.org/t/p/w500/neZ0ykEsPqxamsX6o5QNUFILQrz.jpg", "A secret military project endangers Neo-Tokyo when it turns a biker gang member into a rampaging psychic psychopath that only two teenagers and a group of psychics can stop.", null, 3, "tt0094625", 248, new DateTime(1988, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Akira" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ad4e0225-9d85-4ba9-a374-de5970f420c0"), "https://image.tmdb.org/t/p/w500/7sFjHJSPMjWS7OdeceTzz2ojKB7.jpg", "https://image.tmdb.org/t/p/w500/vz0w9BSehcqjDcJOjRaCk7fgJe7.jpg", "Gordie, Chris, Teddy and Vern are four friends who decide to hike to find the corpse of Ray Brower, a local teenager, who was hit by a train while plucking blueberries in the wild.", null, 5, "tt0092005", 189, new DateTime(1986, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Stand by Me" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ae5ba7f5-5aa2-41d4-a9f9-02a66d07fa1d"), "https://image.tmdb.org/t/p/w500/je2QsgBLEy4lzsvWprwfoZKmIX1.jpg", "https://image.tmdb.org/t/p/w500/sizg1AU8f8JDZX4QIgE4pjUMBvx.jpg", "When Dr. Henry Jones Sr. suddenly goes missing while pursuing the Holy Grail, eminent archaeologist Indiana must team up with Marcus Brody, Sallah and Elsa Schneider to follow in his father's footsteps and stop the Nazis from recovering the power of eternal life.", null, 2, "tt0097576", 113, new DateTime(1989, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Indiana Jones and the Last Crusade" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("b01d8bd3-f0dc-4960-8994-911a0e393b74"), "https://image.tmdb.org/t/p/w500/caKZWDGmv5iW2U99skHs75MmOmU.jpg", "https://image.tmdb.org/t/p/w500/uWcMgxO3p3qwVFUxsRz1HbTzGvT.jpg", "A biographical drama centered on the rivalry between Formula 1 drivers James Hunt and Niki Lauda during the 1976 Formula One motor-racing season.", null, 7, "tt1979320", 207, new DateTime(2013, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Rush" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("b0ccd15d-9f5f-401b-8eec-0dae56dc3a9f"), "https://image.tmdb.org/t/p/w500/ibONMoA8S6T9NgjLarWSrzW3Oke.jpg", "https://image.tmdb.org/t/p/w500/jWqh1CJWAEcxckMRrf6ARhIEh0R.jpg", "Zohre's shoes are gone; her older brother Ali lost them. They are poor, there are no shoes for Zohre until they come up with an idea: they will share one pair of shoes, Ali's. School awaits.", null, 7, "tt0118849", 130, new DateTime(1997, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Children of Heaven" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("b11e7192-467c-45b9-9839-f0f37e6f70f6"), "https://image.tmdb.org/t/p/w500/6yrbWzzrPp7pwz6zHdifspJk8t3.jpg", "https://image.tmdb.org/t/p/w500/lUE0Bp7wH0EterJ44qMRsqtKFnp.jpg", "Near a gray and unnamed city is the Zone, a place guarded by barbed wire and soldiers, and where the normal laws of physics are victim to frequent anomalies. A stalker guides two men into the Zone, specifically to an area in which deep-seated desires are granted.", null, 15, "tt0079944", 186, new DateTime(1979, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Stalker" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("b2c8785c-fb21-48b0-ac60-a17cab3de2d1"), "https://image.tmdb.org/t/p/w500/5qjbu7po6eqLNd4kUPAyIpFRwQK.jpg", "https://image.tmdb.org/t/p/w500/cJRPOLEexI7qp2DKtFfCh7YaaUG.jpg", "Dangal is an extraordinary true story based on the life of Mahavir Singh and his two daughters, Geeta and Babita Phogat. The film traces the inspirational journey of a father who trains his daughters to become world class wrestlers.", null, 7, "tt5074352", 84, new DateTime(2016, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Dangal" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("b3d5b2d5-9e53-41a8-8313-84df184099c3"), "https://image.tmdb.org/t/p/w500/qnmmNjEq4AMopoHE5Mb1vNrwjxs.jpg", "https://image.tmdb.org/t/p/w500/m3mmFkPQKvPZq5exmh0bDuXlD9T.jpg", "As a young and naive recruit in Vietnam, Chris Taylor faces a moral crisis when confronted with the horrors of war and the duality of man.", null, 7, "tt0091763", 192, new DateTime(1986, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Platoon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("b44429c7-ba27-4f9e-b456-d5d65e7968b4"), "https://image.tmdb.org/t/p/w500/moTOuNKnM2phZCYPF49Y1Hb7WJj.jpg", "https://image.tmdb.org/t/p/w500/6NuFYT1f1rG0AeIVTJEgsRa7AOi.jpg", "A man wanders out of the desert not knowing who he is. His brother finds him, and helps to pull his memory back of the life he led before he walked out on his family and disappeared four years earlier.", null, 7, "tt0087884", 242, new DateTime(1984, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Paris, Texas" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("b57e5eee-39fb-4ad7-bfd1-db2b032e4573"), "https://image.tmdb.org/t/p/w500/ci8NMpK3HvuySQRGPMAPyBSlL7f.jpg", "https://image.tmdb.org/t/p/w500/dcKY23xowYTU9B1cagUdHQwsxOB.jpg", "A left-wing journalist whose wife died while giving birth to his son during a military coup returns to his family's farm. Estranged from his father for turning his back on the family and wasting his life with political activism instead, he tries to reconnect with him so that his son will have a place to live as his health is deteriorating due to the extensive torture he had to endure.", null, 7, "tt0476735", 136, new DateTime(2005, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Babam ve Oglum" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("b5c7cc1f-f976-4aaf-9040-ff2f411bc804"), "https://image.tmdb.org/t/p/w500/xKb6mtdfI5Qsggc44Hr9CCUDvaj.jpg", "https://image.tmdb.org/t/p/w500/weVXMD5QBGeQil4HEATZqAkXeEc.jpg", "Nearly 10 years have passed since Sarah Connor was targeted for termination by a cyborg from the future. Now her son, John, the future leader of the resistance, is the target for a newer, more deadly terminator. Once again, the resistance has managed to send a protector back to attempt to save John and his mother Sarah.", null, 1, "tt0103064", 43, new DateTime(1991, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Terminator 2: Judgment Day" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("b87dd60d-40cd-4785-9482-cab1f18dc745"), "https://image.tmdb.org/t/p/w500/pW1sEV4R2GL99OoUq73Pvf7r7Ce.jpg", "https://image.tmdb.org/t/p/w500/b4LKlquh0ls5Rgb27QLPlkC7Oya.jpg", "A tale of friendship between two unlikely pen pals: Mary, a lonely, eight-year-old girl living in the suburbs of Melbourne, and Max, a forty-four-year old, severely obese man living in New York. In the mid-1970s, a homely, friendless Australian girl of 8 picks a name out of a Manhattan phone book and writes to him; she includes a chocolate bar. He writes back, with chocolate. Thus begins a 20-year correspondence. Will the two ever meet face to face?", null, 3, "tt0978762", 177, new DateTime(2009, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Mary and Max" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("b8b14210-b9dd-4e4e-8baa-b3fa3639da0c"), "https://image.tmdb.org/t/p/w500/zoVeIgKzGJzpdG6Gwnr7iOYfIMU.jpg", "https://image.tmdb.org/t/p/w500/8SRUfRUi6x4O68n0VCbDNRa6iGL.jpg", "A filmmaker recalls his childhood, when he fell in love with the movies at his village's theater and formed a deep friendship with the theater's projectionist.", null, 7, "tt0095765", 55, new DateTime(1988, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Cinema Paradiso" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("bddc5d0e-deef-44fe-bc02-d33c61db61ee"), "https://image.tmdb.org/t/p/w500/h31SOVlekuHXsMWVGxI8nPPfY82.jpg", "https://image.tmdb.org/t/p/w500/qbYgqOczabWNn2XKwgMtVrntD6P.jpg", "As the railroad builders advance unstoppably through the Arizona desert on their way to the sea, Jill arrives in the small town of Flagstone with the intention of starting a new life.", null, 7, "tt0064116", 37, new DateTime(1968, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Once Upon a Time in the West" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("be4375b5-b94b-44eb-8d2f-6f33d2fc5872"), "https://image.tmdb.org/t/p/w500/loRmRzQXZeqG78TqZuyvSlEQfZb.jpg", "https://image.tmdb.org/t/p/w500/sF1U4EUQS8YHUYjNl3pMGNIQyr0.jpg", "The true story of how businessman Oskar Schindler saved over a thousand Jewish lives from the Nazis while they worked as slaves in his factory during World War II.", null, 7, "tt0108052", 6, new DateTime(1993, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Schindler's List" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("bf76c193-c4a8-4de2-bb0c-ee97697c33cf"), "https://image.tmdb.org/t/p/w500/gwj4R8Uy1GwejKqfofREKI9Jh7L.jpg", "https://image.tmdb.org/t/p/w500/qG3RYlIVpTYclR9TYIsy8p7m7AT.jpg", "In the final months of World War II, 14-year-old Seita and his sister Setsuko are orphaned when their mother is killed during an air raid in Kobe, Japan. After a falling out with their aunt, they move into an abandoned bomb shelter. With no surviving relatives and their emergency rations depleted, Seita and Setsuko struggle to survive.", null, 3, "tt0095327", 53, new DateTime(1988, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Grave of the Fireflies" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("c131ccc6-7454-4ec6-96b8-e8a69ab9367b"), "https://image.tmdb.org/t/p/w500/x2IqsMlpbOhS8zIUJfyl1yO4gHF.jpg", "https://image.tmdb.org/t/p/w500/iiZZdoQBEYBv6id8su7ImL0oCbD.jpg", "Miles Morales is juggling his life between being a high school student and being a spider-man. When Wilson \"Kingpin\" Fisk uses a super collider, others from across the Spider-Verse are transported to this dimension.", null, 1, "tt4633694", 54, new DateTime(2018, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Spider-Man: Into the Spider-Verse" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("c20baed5-57e6-4e27-a359-301e5793becb"), "https://image.tmdb.org/t/p/w500/3mxteiwtcCPjbYKlyC0WxY1G9J3.jpg", "https://image.tmdb.org/t/p/w500/bCywq0RkrdI2qzhPNuuJ9PvGuzd.jpg", "A tragic love story set in East Berlin with the backdrop of an undercover Stasi controlled culture. Stasi captain Wieler is ordered to follow author Dreyman and plunges deeper and deeper into his life until he reaches the threshold of doubting the system.", null, 7, "tt0405094", 58, new DateTime(2006, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Lives of Others" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("c2b59ee3-1738-454c-838b-a61cad3aa3e0"), "https://image.tmdb.org/t/p/w500/5g0W5MUP75zyfluLhhVet15F71z.jpg", "https://image.tmdb.org/t/p/w500/a4OvIWU5pYSvHNUvHVt1lLtTeIR.jpg", "After seven months have passed without a culprit in her daughter's murder case, Mildred Hayes makes a bold move, painting three signs leading into her town with a controversial message directed at Bill Willoughby, the town's revered chief of police. When his second-in-command Officer Jason Dixon, an immature mother's boy with a penchant for violence, gets involved, the battle between Mildred and Ebbing's law enforcement is only exacerbated.", null, 5, "tt5027774", 146, new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Three Billboards Outside Ebbing, Missouri" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("c3c262cc-0a5a-43ee-9d8c-c099bb62c5c9"), "https://image.tmdb.org/t/p/w500/3xuHaDtCFUjgTrWEKlA4krZquHd.jpg", "https://image.tmdb.org/t/p/w500/5DpmtMBXXNDujIuSlKW3WLKuqEd.jpg", "Jeffrey 'The Dude' Lebowski, a Los Angeles slacker who only wants to bowl and drink White Russians, is mistaken for another Jeffrey Lebowski, a wheelchair-bound millionaire, and finds himself dragged into a strange series of events involving nihilists, adult film producers, ferrets, errant toes, and large sums of money.", null, 4, "tt0118715", 172, new DateTime(1998, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Big Lebowski" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("c51f36ef-e04f-41b6-9bb4-aea606ad5a0c"), "https://image.tmdb.org/t/p/w500/rvRGFevvZK48onX0PYI1eQLbuJd.jpg", "https://image.tmdb.org/t/p/w500/yKyLJmRAtyXEEYKOvPhKHXIcPq9.jpg", "William Munny is a retired, once-ruthless killer turned gentle widower and hog farmer. To help support his two motherless children, he accepts one last bounty-hunter mission to find the men who brutalized a prostitute. Joined by his former partner and a cocky greenhorn, he takes on a corrupt sheriff.", null, 19, "tt0105695", 121, new DateTime(1992, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Unforgiven" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("c67b48e5-9451-4e97-a1f2-7afeee54ae22"), "https://image.tmdb.org/t/p/w500/xgAEfHByamMdRCA31oERQrsiutF.jpg", "https://image.tmdb.org/t/p/w500/cP1ElGjBhbZAAqmueXjHDKlSwiP.jpg", "In April of 1945, Germany stands at the brink of defeat with the Russian Army closing in from the east and the Allied Expeditionary Force attacking from the west. In Berlin, capital of the Third Reich, Adolf Hitler proclaims that Germany will still achieve victory and orders his generals and advisers to fight to the last man. When the end finally does come, and Hitler lies dead by his own hand, what is left of his military must find a way to end the killing that is the Battle of Berlin, and lay down their arms in surrender.", null, 7, "tt0363163", 120, new DateTime(2004, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Downfall" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("c7d8f992-3e13-4ff1-abea-e7a986f3d0d1"), "https://image.tmdb.org/t/p/w500/mvyERNa0oNsBjbHqn5qSGMHk2FM.jpg", "https://image.tmdb.org/t/p/w500/2MSGZEE6XZd2r4ODNziwAw7Hpw0.jpg", "After graduating from Emory University in 1992, top student and athlete Christopher McCandless abandons his possessions, gives his entire $24,000 savings account to charity, and hitchhikes to Alaska to live in the wilderness.", null, 2, "tt0758758", 190, new DateTime(2007, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Into the Wild" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("c94d5e07-41a5-4496-aac1-f7a796a9e4a5"), "https://image.tmdb.org/t/p/w500/umUyVxJ4HeNebLMAcScdhF0QB3h.jpg", "https://image.tmdb.org/t/p/w500/xdANQijuNrJaw1HA61rDccME4Tm.jpg", "In the pre-Civil War United States, Solomon Northup, a free black man from upstate New York, is abducted and sold into slavery. Facing cruelty as well as unexpected kindnesses Solomon struggles not only to stay alive, but to retain his dignity. In the twelfth year of his unforgettable odyssey, Solomon’s chance meeting with a Canadian abolitionist will forever alter his life.", null, 7, "tt2024544", 198, new DateTime(2013, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "12 Years a Slave" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ca5b2758-9a28-452a-a841-1c3a1aea3ad4"), "https://image.tmdb.org/t/p/w500/cDFtxTxEtE3ljadfQ5SwtRTi8Iw.jpg", "https://image.tmdb.org/t/p/w500/kWWAt2FMRbqLFFy8o5R4Zr8cMAb.jpg", "To take down South Boston's Irish Mafia, the police send in one of their own to infiltrate the underworld, not realizing the syndicate has done likewise. While an undercover cop curries favor with the mob kingpin, a career criminal rises through the police ranks. But both sides soon discover there's a mole among them.", null, 7, "tt0407887", 41, new DateTime(2006, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Departed" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("cc2cc167-586d-49b3-a464-c497327ef57e"), "https://image.tmdb.org/t/p/w500/zAL3LOswagN9onjN8DPcNFTqKuD.jpg", "https://image.tmdb.org/t/p/w500/6numIZH6uR3NlJgY9m7nGH0jhs.jpg", "From the moment she glimpses her idol at the stage door, Eve Harrington is determined to take the reins of power away from the great actress Margo Channing. Eve maneuvers her way into Margo's Broadway role, becomes a sensation and even causes turmoil in the lives of Margo's director boyfriend, her playwright and his wife. Only the cynical drama critic sees through Eve, admiring her audacity and perfect pattern of deceit.", null, 7, "tt0042192", 116, new DateTime(1950, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "All About Eve" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("cc6bd49e-da21-4339-9454-365f185a1544"), "https://image.tmdb.org/t/p/w500/jMBpJFRtrtIXymer93XLavPwI3P.jpg", "https://image.tmdb.org/t/p/w500/r1x5JGpyqZU8PYhbs4UcrO1Xb6x.jpg", "When Ripley's lifepod is found by a salvage crew over 50 years later, she finds that terra-formers are on the very planet they found the alien species. When the company sends a family of colonists out to investigate her story—all contact is lost with the planet and colonists. They enlist Ripley and the colonial marines to return and search for answers.", null, 1, "tt0090605", 68, new DateTime(1986, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Aliens" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("cc933fa7-d3b8-428b-9dd5-646066dfe98c"), "https://image.tmdb.org/t/p/w500/hQrHN6WXERVw6XUMpfCgLfvrh5V.jpg", "https://image.tmdb.org/t/p/w500/8RW2runSEc34IwKN2D1aPcJd2UL.jpg", "Driven by tragedy, billionaire Bruce Wayne dedicates his life to uncovering and defeating the corruption that plagues his home, Gotham City.  Unable to work within the system, he instead creates a new identity, a symbol of fear for the criminal underworld - The Batman.", null, 1, "tt0372784", 117, new DateTime(2005, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Batman Begins" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("cc94235d-4f21-4e68-807d-7e5b2541a31f"), "https://image.tmdb.org/t/p/w500/AsoxSg4gkTFUpVUs4joxTxkUNKL.jpg", "https://image.tmdb.org/t/p/w500/k7eYdWvhYQyRQoU2TB2A2Xu2TfD.jpg", "Buscapé was raised in a very violent environment. Despite the feeling that all odds were against him, he finds out that life can be seen with other eyes...", null, 7, "tt0317248", 22, new DateTime(2002, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "City of God" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("cd218176-4769-4de3-95c3-c688458a1acb"), "https://image.tmdb.org/t/p/w500/73aKTjdQ46jpv3InqNVnV76Nl0K.jpg", "https://image.tmdb.org/t/p/w500/kbqTKqz3amub4GUE5qLEQFFR8Ro.jpg", "A series of mysterious events changes the life of a blind pianist who now must report a crime that was actually never witnessed by him.", null, 5, "tt8108198", 159, new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Andhadhun" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("cdd85e86-8f69-4b46-82f6-b36b9633b58c"), "https://image.tmdb.org/t/p/w500/g8yVrnJ72eOt1Xw4uyYBIsBBE2g.jpg", "https://image.tmdb.org/t/p/w500/cqumfgd74ftVzOKJpFGOG64WlXL.jpg", "In 1947, four German judges who served on the bench during the Nazi regime face a military tribunal to answer charges of crimes against humanity. Chief Justice Haywood hears evidence and testimony not only from lead defendant Ernst Janning and his defense attorney Hans Rolfe, but also from the widow of a Nazi general, an idealistic U.S. Army captain and reluctant witness Irene Wallner.", null, 7, "tt0055031", 138, new DateTime(1961, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Judgment at Nuremberg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ce01ff24-e67e-438e-8009-972eaf74dfc3"), "https://image.tmdb.org/t/p/w500/l6hQWH9eDksNJNiXWYRkWqikOdu.jpg", "https://image.tmdb.org/t/p/w500/velWPhVMQeQKcxggNEU8YmIo52R.jpg", "A supernatural tale set on death row in a Southern prison, where gentle giant John Coffey possesses the mysterious power to heal people's ailments. When the cell block's head guard, Paul Edgecomb, recognizes Coffey's miraculous gift, he tries desperately to help stave off the condemned man's execution.", null, 9, "tt0120689", 31, new DateTime(1999, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Green Mile" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("cecd827b-c327-4911-ba43-e1183ff34f2d"), "https://image.tmdb.org/t/p/w500/5vPW6MPAyCFd84FEQQgtPDmVDPQ.jpg", "https://image.tmdb.org/t/p/w500/eWdyYQreja6JGCzqHWXpWHDrrPo.jpg", "The Grand Budapest Hotel tells of a legendary concierge at a famous European hotel between the wars and his friendship with a young employee who becomes his trusted protégé. The story involves the theft and recovery of a priceless Renaissance painting, the battle for an enormous family fortune and the slow and then sudden upheavals that transformed Europe during the first half of the 20th century.", null, 4, "tt2278388", 187, new DateTime(2014, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Grand Budapest Hotel" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("cf149f82-292d-4e12-aca2-f6f74e242f88"), "https://image.tmdb.org/t/p/w500/eoCSp75lxatmIa6aGqfnzwtbttd.jpg", "https://image.tmdb.org/t/p/w500/bX2xnavhMYjWDoZp1VM6VnU1xwe.jpg", "While the Civil War rages between the Union and the Confederacy, three men – a quiet loner, a ruthless hit man and a Mexican bandit – comb the American Southwest in search of a strongbox containing $200,000 in stolen gold.", null, 19, "tt0060196", 9, new DateTime(1966, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Good, the Bad and the Ugly" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("cf82d599-2e57-421c-aeb7-206580a67a56"), "https://image.tmdb.org/t/p/w500/Ag6qhzsJd3k1NKuNrG9RmhZDMh7.jpg", "https://image.tmdb.org/t/p/w500/sdYgEkKCDPWNU6KnoL4qd8xZ4w7.jpg", "A true story about Frank Abagnale Jr. who, before his 19th birthday, successfully conned millions of dollars worth of checks as a Pan Am pilot, doctor, and legal prosecutor. An FBI agent makes it his mission to put him behind bars. But Frank not only eludes capture, he revels in the pursuit.", null, 7, "tt0264464", 212, new DateTime(2002, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Catch Me If You Can" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("d041a742-6c9b-41bb-99e6-24da14facd0f"), "https://image.tmdb.org/t/p/w500/oIQMt3Q6Qa37YD0JOdYkrIAPYDk.jpg", "https://image.tmdb.org/t/p/w500/qNbMsKVzigERgJUbwf8pKyZogpb.jpg", "The invasion of a village in Byelorussia by German forces sends young Florya into the forest to join the weary Resistance fighters, against his family's wishes. There he meets a girl, Glasha, who accompanies him back to his village. On returning home, Florya finds his family and fellow peasants massacred. His continued survival amidst the brutal debris of war becomes increasingly nightmarish, a battle between despair and hope.", null, 7, "tt0091251", 167, new DateTime(1985, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Come and See" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("d0bc028a-7b1c-47c2-98d6-a63c98336d7a"), "https://image.tmdb.org/t/p/w500/gxfvtq5eYiClS2X7hxAAPBNrbWA.jpg", "https://image.tmdb.org/t/p/w500/wGAMZ5DgfqAGsJ4EzXlm23vCGb1.jpg", "A stranger in the city asks questions no one has asked before. Known only by his initials, the man's innocent questions and childlike curiosity take him on a journey of love, laughter and letting go.", null, 4, "tt2338151", 250, new DateTime(2014, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "PK" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("d1dd829a-8ead-4b05-a09d-91612561b748"), "https://image.tmdb.org/t/p/w500/vXQM4RH7mYLoR6oCsXTNk2cIVUj.jpg", "https://image.tmdb.org/t/p/w500/hEjK9A9BkNXejFW4tfacVAEHtkn.jpg", "When world heavyweight boxing champion, Apollo Creed wants to give an unknown fighter a shot at the title as a publicity stunt, his handlers choose palooka Rocky Balboa, an uneducated collector for a Philadelphia loan shark. Rocky teams up with trainer  Mickey Goldmill to make the most of this once in a lifetime break.", null, 7, "tt0075148", 219, new DateTime(1976, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("d2059c9f-54f2-414c-b050-b4dbed22534a"), "https://image.tmdb.org/t/p/w500/zGs5tZOlvc9cprdcU6kDOVNpujf.jpg", "https://image.tmdb.org/t/p/w500/qitnZcLP7C9DLRuPpmvZ7GiEjJN.jpg", "A wheelchair-bound photographer spies on his neighbors from his apartment window and becomes convinced one of them has committed murder.", null, 16, "tt0047396", 46, new DateTime(1954, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Rear Window" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("d436c391-c0de-45b9-8002-e6a42be00da3"), "https://image.tmdb.org/t/p/w500/v2SCnNZDZ7USonAWnsGtL4PUqHt.jpg", "https://image.tmdb.org/t/p/w500/1G9r3rqtbFAQuyWKOZm4Y5J5s7Q.jpg", "A film projectionist longs to be a detective, and puts his meagre skills to work when he is framed by a rival for stealing his girlfriend's father's pocketwatch.", null, 1, "tt0015324", 174, new DateTime(1924, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Sherlock Jr." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("d8f8d8e4-5ced-4a79-8b44-151eb334d54d"), "https://image.tmdb.org/t/p/w500/1r9lH3DaSWKGyvZaoo6BF5STOk5.jpg", "https://image.tmdb.org/t/p/w500/fpxhmgeCuPQOeatfeCPwtOwUwlb.jpg", "Set in the 1930s this intricate caper deals with an ambitious small-time crook and a veteran con man who seek revenge on a vicious crime lord who murdered one of their gang.", null, 4, "tt0070735", 102, new DateTime(1973, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Sting" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("d9ff480c-ff6b-4084-81b1-05e3facda9f3"), "https://image.tmdb.org/t/p/w500/A9IY3j3Hwf4Q8Q9w5QxSQPYSvCu.jpg", "https://image.tmdb.org/t/p/w500/5YIzZaQlwYJY5ZEqHRs9dG9DduB.jpg", "Valentine, a student model in Geneva, struggles with a possessive boyfriend and a troubled family. When she runs over a dog, she discovers that its owner, a retired judge, is illegally wiretapping and eavesdropping on his neighbors' phone calls. Although Valentine is outraged, she develops a strange bond with the judge – and as the two become closer, she finds herself caught in the middle of events that could change her life.", null, 7, "tt0111495", 247, new DateTime(1994, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Three Colors: Red" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("db1985b6-aa8a-4c54-bd85-38b76053208b"), "https://image.tmdb.org/t/p/w500/hudKBabOC0PSuAd2TCQQxinU4kn.jpg", "https://image.tmdb.org/t/p/w500/lSSA64WF0M0BXnjwr2quMh6shCl.jpg", "Brian Cohen is an average young Jewish man, but through a series of ridiculous events, he gains a reputation as the Messiah. When he's not dodging his followers or being scolded by his shrill mother, the hapless Brian has to contend with the pompous Pontius Pilate and acronym-obsessed members of a separatist movement. Rife with Monty Python's signature absurdity, the tale finds Brian's life paralleling Biblical lore, albeit with many more laughs.", null, 4, "tt0079470", 195, new DateTime(1979, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Monty Python's Life of Brian" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("db558020-16aa-4a51-847c-c66ff609a8c0"), "https://image.tmdb.org/t/p/w500/vwBa7djy1oxfxUjc7YtVgGNsjrT.jpg", "https://image.tmdb.org/t/p/w500/TkTPELv4kC3u1lkloush8skOjE.jpg", "When Sophie, a shy young woman, is cursed with an old body by a spiteful witch, her only chance of breaking the spell lies with a self-indulgent yet insecure young wizard and his companions in his legged, walking castle.", null, 9, "tt0347149", 135, new DateTime(2004, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Howl's Moving Castle" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("dba81a02-0b94-4ded-813a-0399681fdfd8"), "https://image.tmdb.org/t/p/w500/s3TBrRGB1iav7gFOCNx3H31MoES.jpg", "https://image.tmdb.org/t/p/w500/edv5CZvWj09upOsy2Y6IwDhK8bt.jpg", "Cobb, a skilled thief who commits corporate espionage by infiltrating the subconscious of his targets is offered a chance to regain his old life as payment for a task considered to be impossible: \"inception\", the implantation of another person's idea into a target's subconscious.", null, 1, "tt1375666", 14, new DateTime(2010, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Inception" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("de7eaa2d-5cbe-46d7-91e9-6a8b12140255"), "https://image.tmdb.org/t/p/w500/3Rfvhy1Nl6sSGJwyjb0QiZzZYlB.jpg", "https://image.tmdb.org/t/p/w500/uXDfjJbdP4ijW5hWSBrPrlKpxab.jpg", "Led by Woody, Andy's toys live happily in his room until Andy's birthday brings Buzz Lightyear onto the scene. Afraid of losing his place in Andy's heart, Woody plots against Buzz. But when circumstances separate Buzz and Woody from their owner, the duo eventually learns to put aside their differences.", null, 3, "tt0114709", 87, new DateTime(1995, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Toy Story" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("deb00c46-be07-4575-b843-1ee527885490"), "https://image.tmdb.org/t/p/w500/8FbbcmwmpGd7brfiC7f7lWFNGdi.jpg", "https://image.tmdb.org/t/p/w500/rBkptJyAMqCfoMwUGQfCpubroec.jpg", "The true story of how the Boston Globe uncovered the massive scandal of child molestation and cover-up within the local Catholic Archdiocese, shaking the entire Catholic Church to its core.", null, 7, "tt1895587", 213, new DateTime(2015, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Spotlight" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("dfc8d31f-b5fa-44a9-8401-1621a99f4739"), "https://image.tmdb.org/t/p/w500/uPYa165sraN2c8gZBM9C47g3JoU.jpg", "https://image.tmdb.org/t/p/w500/i0enkzsL5dPeneWnjl1fCWm6L7k.jpg", "A former Prohibition-era Jewish gangster returns to the Lower East Side of Manhattan over thirty years later, where he once again must confront the ghosts and regrets of his old life.", null, 7, "tt0087843", 71, new DateTime(1984, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Once Upon a Time in America" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("dfd10f23-4d7c-436c-9095-4bab783fb03b"), "https://image.tmdb.org/t/p/w500/oWKcexbupmmdUEtU8h0WK1DUWmt.jpg", "https://image.tmdb.org/t/p/w500/tuZhZ6biFMr5n9YSVuHOJnNL1uU.jpg", "Keller Dover faces a parent's worst nightmare when his 6-year-old daughter, Anna, and her friend go missing. The only lead is an old motorhome that had been parked on their street. The head of the investigation, Detective Loki, arrests the driver, but a lack of evidence forces Loki to release his only suspect. Dover, knowing that his daughter's life is at stake, decides that he has no choice but to take matters into his own hands.", null, 7, "tt1392214", 204, new DateTime(2013, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Prisoners" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e17f07b0-e6b7-4fa1-b8e1-e6a6dfc84396"), "https://image.tmdb.org/t/p/w500/lVy5Zqcty2NfemqKYbVJfdg44rK.jpg", "https://image.tmdb.org/t/p/w500/v7TaX8kXMXs5yFFGR41guUDNcnB.jpg", "An assassin is shot by her ruthless employer, Bill, and other members of their assassination circle – but she lives to plot her vengeance.", null, 1, "tt0266697", 173, new DateTime(2003, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Kill Bill: Vol. 1" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e2c03f6f-e08a-472e-8da5-df64ab579e3d"), "https://image.tmdb.org/t/p/w500/6t4jqCok1yGBn7z7CKlCsWsjoNX.jpg", "https://image.tmdb.org/t/p/w500/rEviyDWNbAFmvvCPlkMRPAGUElG.jpg", "The life of boxer Jake LaMotta, whose violence and temper that led him to the top in the ring destroyed his life outside of it.", null, 7, "tt0081398", 128, new DateTime(1980, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Raging Bull" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e3024f5c-f395-4a36-a3a6-159ce86963b3"), "https://image.tmdb.org/t/p/w500/qA2TyqPldTtoTVY3LKrNIG5g6bH.jpg", "https://image.tmdb.org/t/p/w500/khKJwHxgXSpDl3iKGJ5S15I8ABI.jpg", "On his way to Vienna, American Jesse meets Céline, a student returning to Paris. After long conversations forge a surprising connection between them, Jesse convinces Celine to get off the train with him in Vienna. Since his flight to the U.S. departs the next morning and he has no money for lodging, they wander the city together, taking in the experiences of Vienna and each other.", null, 7, "tt0112471", 201, new DateTime(1995, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Before Sunrise" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e312e298-81ae-4fa9-ae48-63966420d2b1"), "https://image.tmdb.org/t/p/w500/47rioCQJLDe6gT7NYdPf7IRy3Nu.jpg", "https://image.tmdb.org/t/p/w500/pWDtjs568ZfOTMbURQBYuT4Qxka.jpg", "With no clue how he came to be imprisoned, drugged and tortured for 15 years, a desperate businessman seeks revenge on his captors.", null, 7, "tt0364569", 67, new DateTime(2003, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Oldeuboi" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e37c9176-4e39-41a7-be77-fbd61bbd2481"), "https://image.tmdb.org/t/p/w500/4H81TyAvjt7WOLXl7km34ZZQGl6.jpg", "https://image.tmdb.org/t/p/w500/drgMcyTsySQBnUPGaBThCHGdlWT.jpg", "A tramp cares for a boy after he's abandoned as a newborn by his mother. Later the mother has a change of heart and aches to be reunited with her son.", null, 4, "tt0012349", 101, new DateTime(1921, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Kid" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e54b2e66-f78f-4e69-bc30-cfbedda7dbb0"), "https://image.tmdb.org/t/p/w500/xqZq0MOnIJzjLi0Vz9QhFWI0vi.jpg", "https://image.tmdb.org/t/p/w500/fa0RDkAlCec0STeMNAhPaF89q6U.jpg", "Ruthless silver miner, turned oil prospector, Daniel Plainview, moves to oil-rich California. Using his son to project a trustworthy, family-man image, Plainview cons local landowners into selling him their valuable properties for a pittance. However, local preacher Eli Sunday suspects Plainview's motives and intentions, starting a slow-burning feud that threatens both their lives.", null, 7, "tt0469494", 158, new DateTime(2007, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "There Will Be Blood" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e5540e68-3ae8-4d42-a58c-4720a7c2f7b2"), "https://image.tmdb.org/t/p/w500/hZth9NCeXvvO7Xi98d8q34e1Ier.jpg", "https://image.tmdb.org/t/p/w500/39wmItIWsg5sZMyRUHLkWBcuVCM.jpg", "A young girl, Chihiro, becomes trapped in a strange new world of spirits. When her parents undergo a mysterious transformation, she must call upon the courage she never knew she had to free her family.", null, 3, "tt0245429", 27, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Spirited Away" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e57273ad-6a08-44ca-88af-662e2c4f9654"), "https://image.tmdb.org/t/p/w500/ljEdpkceJ9b3TEcTVQISS0Goft0.jpg", "https://image.tmdb.org/t/p/w500/p3pHw85UMZPegfMZBA6dZ06yarm.jpg", "Inspired by true events, this film takes place in Rwanda in the 1990s when more than a million Tutsis were killed in a genocide that went mostly unnoticed by the rest of the world. Hotel owner Paul Rusesabagina houses over a thousand refuges in his hotel in attempt to save their lives.", null, 7, "tt0395169", 200, new DateTime(2004, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Hotel Rwanda" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e609d393-78a9-493d-97c2-70e996fe1fa4"), "https://image.tmdb.org/t/p/w500/sFEYsEfzTx7hhjetlNrme8B5OUo.jpg", "https://image.tmdb.org/t/p/w500/2ySXWBckQboalTZjhaLWRqc3gCN.jpg", "In a world in which Great Britain has become a fascist state, a masked vigilante known only as “V” conducts guerrilla warfare against the oppressive British government. When V rescues a young woman from the secret police, he finds in her an ally with whom he can continue his fight to free the people of Britain.", null, 1, "tt0434409", 151, new DateTime(2006, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "V for Vendetta" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e6689752-a5c1-437e-a47e-011573716b19"), "https://image.tmdb.org/t/p/w500/bpV8wn48s82au37QyUJ51S7X2Vf.jpg", "https://image.tmdb.org/t/p/w500/bABCBKYBK7A5G1x0FzoeoNfuj2.jpg", "Will Hunting has a genius-level IQ but chooses to work as a janitor at MIT. When he solves a difficult graduate-level math problem, his talents are discovered by Professor Gerald Lambeau, who decides to help the misguided youth reach his potential. When Will is arrested for attacking a police officer, Professor Lambeau makes a deal to get leniency for him if he will get treatment from therapist Sean Maguire.", null, 7, "tt0119217", 100, new DateTime(1997, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Good Will Hunting" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e6ca5ce3-96b8-421d-b5e8-d4bd95581d2d"), "https://image.tmdb.org/t/p/w500/kCEXA22ASuq7Y29jnngyaisyA0X.jpg", "https://image.tmdb.org/t/p/w500/ve72VxNqjGM69Uky4WTo2bK6rfq.jpg", "Humanity finds a mysterious object buried beneath the lunar surface and sets off to find its origins with the help of HAL 9000, the world's most advanced super computer.", null, 15, "tt0062622", 86, new DateTime(1968, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "2001: A Space Odyssey" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e70db5f8-4a15-4079-8ffb-07846a28b3c1"), "https://image.tmdb.org/t/p/w500/aFmoJntgDPR0Jd8XD1ZfFSmcqMg.jpg", "https://image.tmdb.org/t/p/w500/jcBpmWjjvvcYwrxpYd1g7BHquCt.jpg", "A mother's last wishes send twins Jeanne and Simon on a journey to Middle East in search of their tangled roots. Adapted from Wajdi Mouawad's acclaimed play, Incendies tells the powerful and moving tale of two young adults' voyage to the core of deep-rooted hatred, never-ending wars and enduring love.", null, 7, "tt1255953", 125, new DateTime(2010, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Incendies" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e801b370-770a-40bb-bac1-95e63c9e8c79"), "https://image.tmdb.org/t/p/w500/pLR2O3dmA9xkCiPA26U7ErCUYSi.jpg", "https://image.tmdb.org/t/p/w500/znekQtDwXQrll2XYZqXOxncCgLd.jpg", "In early-1970s Las Vegas, low-level mobster Sam \"Ace\" Rothstein gets tapped by his bosses to head the Tangiers Casino. At first, he's a great success in the job, but over the years, problems with his loose-cannon enforcer Nicky Santoro, his ex-hustler wife Ginger, her con-artist ex Lester Diamond and a handful of corrupt politicians put Sam in ever-increasing danger.", null, 5, "tt0112641", 144, new DateTime(1995, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Casino" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e83eb793-629d-45d1-b9a0-0a9cbd0212a8"), "https://image.tmdb.org/t/p/w500/fONtQBk12LGjQo4q6bXDROVQmTy.jpg", "https://image.tmdb.org/t/p/w500/8gvfRlVpcKaTVqipXpYOGWBN1aO.jpg", "Advertising man Roger Thornhill is mistaken for a spy, triggering a deadly cross-country chase.", null, 13, "tt0053125", 77, new DateTime(1959, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "North by Northwest" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e83f643e-a95e-4ad7-872f-f62481fc9c89"), "https://image.tmdb.org/t/p/w500/fOl0FJ81VoQU0BlRgXA3aVeNlXE.jpg", "https://image.tmdb.org/t/p/w500/tzGY49kseSE9QAKk47uuDGwnSCu.jpg", "Members of an American scientific research outpost in Antarctica find themselves battling a parasitic alien organism capable of perfectly imitating its victims. They soon discover that this task will be harder than they thought, as they don't know which members of the team have already been assimilated and their paranoia threatens to tear them apart.", null, 11, "tt0084787", 165, new DateTime(1982, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Thing" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e981fd68-8c5d-48fa-9d8b-49eaa453ab19"), "https://image.tmdb.org/t/p/w500/suaEOtk1N1sgg2MTM7oZd2cfVp3.jpg", "https://image.tmdb.org/t/p/w500/fIE3lAGcZDV1G6XM5KmuWnNsPp1.jpg", "A burger-loving hit man, his philosophical partner, a drug-addled gangster's moll and a washed-up boxer converge in this sprawling, comedic crime caper. Their adventures unfurl in three stories that ingeniously trip back and forth in time.", null, 16, "tt0110912", 8, new DateTime(1994, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Pulp Fiction" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("e98dbca7-1cd4-47c8-a3ee-60a99414a276"), "https://image.tmdb.org/t/p/w500/ulVUa2MvnJAjAeRt7h23FFJVRKH.jpg", "https://image.tmdb.org/t/p/w500/sIpcATxMrKHRRUJAGI5UIUT7XMG.jpg", "After a global war, the seaside kingdom known as the Valley of the Wind remains one of the last strongholds on Earth untouched by a poisonous jungle and the powerful insects that guard it. Led by the courageous Princess Nausicaä, the people of the Valley engage in an epic struggle to restore the bond between humanity and Earth.", null, 2, "tt0087544", 217, new DateTime(1984, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Nausicaä of the Valley of the Wind" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ea7e76e8-0a1c-4b3a-af39-510d553e6b82"), "https://image.tmdb.org/t/p/w500/dMZxEdrWIzUmUoOz2zvmFuutbj7.jpg", "https://image.tmdb.org/t/p/w500/y8kozeXuFDRKGCBRJGfZY0KbGi1.jpg", "The epic saga continues as Luke Skywalker, in hopes of defeating the evil Galactic Empire, learns the ways of the Jedi from aging master Yoda. But Darth Vader is more determined than ever to capture Luke. Meanwhile, rebel leader Princess Leia, cocky Han Solo, Chewbacca, and droids C-3PO and R2-D2 are thrown into various stages of capture, betrayal and despair.", null, 2, "tt0080684", 13, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Star Wars: Episode V - The Empire Strikes Back" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("eb87e1d4-ceb9-4508-997c-b8a3d835648f"), "https://image.tmdb.org/t/p/w500/gddUsvfyySrM5k8B8wwJy2VRlBx.jpg", "https://image.tmdb.org/t/p/w500/6d5XOczc226jECq0LIX0siKtgHR.jpg", "Llewelyn Moss stumbles upon dead bodies, $2 million and a hoard of heroin in a Texas desert, but methodical killer Anton Chigurh comes looking for it, with local sheriff Ed Tom Bell hot on his trail. The roles of prey and predator blur as the violent pursuit of money and justice collide.", null, 5, "tt0477348", 157, new DateTime(2007, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "No Country for Old Men" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ec93ebe0-bb35-488e-a196-ed78183b38d5"), "https://image.tmdb.org/t/p/w500/3YzVtvNERQOIJXnrcWv3xhj5EMT.jpg", "https://image.tmdb.org/t/p/w500/vV4vlD4ool5JSsS1rB82qjCF6z8.jpg", "A fatalistic car crash in Mexico City sets off a chain of events in the lives of three persons: a young man aching to run off with his sister-in-law, a supermodel, and a homeless man. Their lives are catapulted into unforeseen circumstances instigated by the seemingly inconsequential destiny of a dog.", null, 7, "tt0245712", 215, new DateTime(2000, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Amores Perros" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ecc6d016-4f75-4981-a11d-b1beff8236c9"), "https://image.tmdb.org/t/p/w500/6aNKD81RHR1DqUUa8kOZ1TBY1Lp.jpg", "https://image.tmdb.org/t/p/w500/mfnkSeeVOBVheuyn2lo4tfmOPQb.jpg", "A touching story of an Italian book seller of Jewish ancestry who lives in his own little fairy tale. His creative and happy life would come to an abrupt halt when his entire family is deported to a concentration camp during World War II. While locked up he tries to convince his son that the whole thing is just a game.", null, 4, "tt0118799", 26, new DateTime(1997, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Life Is Beautiful" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ed2774e3-886a-4fb4-952e-dd83a1eb686d"), "https://image.tmdb.org/t/p/w500/2Xe9lISpwXKhvKiHttbFfVRERQX.jpg", "https://image.tmdb.org/t/p/w500/7BsvSuDQuoqhWmU2fL7W2GOcZHU.jpg", "Tony Lip, a bouncer in 1962, is hired to drive pianist Don Shirley on a tour through the Deep South in the days when African Americans, forced to find alternate accommodations and services due to segregation laws below the Mason-Dixon Line, relied on a guide called The Negro Motorist Green Book.", null, 7, "tt6966692", 127, new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Green Book" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ed3ad1a4-be1d-45fe-8885-1a9f9fa89af7"), "https://image.tmdb.org/t/p/w500/u546kDNwrZ1ii6q8NqqQgHwRvoW.jpg", "https://image.tmdb.org/t/p/w500/kkfKLeOTo7RjS9TxHKpknlL7huS.jpg", "A rich woman and a calculating insurance agent plot to kill her unsuspecting husband after he signs a double indemnity policy. Against a backdrop of distinctly Californian settings, the partners in crime plan the perfect murder to collect the insurance, which pays double if the death is accidental.", null, 5, "tt0036775", 94, new DateTime(1944, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Double Indemnity" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ed463246-61b2-488a-a55c-b8ecc068522e"), "https://image.tmdb.org/t/p/w500/oMpX8thZFDVZNS4j240HYSMMvyg.jpg", "https://image.tmdb.org/t/p/w500/pNcwhz3Eyfn3KQ2XykTozbARMpr.jpg", "The cruel and abusive headmaster of a boarding school, Michel Delassalle, is murdered by an unlikely duo -- his meek wife and the mistress he brazenly flaunts. The women become increasingly unhinged by a series of odd occurrences after Delassalle's corpse mysteriously disappears.", null, 7, "tt0046911", 234, new DateTime(1955, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Diabolique" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("f46183ac-26ef-449e-a39a-46127a464256"), "https://image.tmdb.org/t/p/w500/ncEsesgOJDNrTUED89hYbA117wo.jpg", "https://image.tmdb.org/t/p/w500/f89U3ADr1oiB1s9GkdPOEpXUk5H.jpg", "Set in the 22nd century, The Matrix tells the story of a computer hacker who joins a group of underground insurgents fighting the vast and powerful computers who now rule the earth.", null, 1, "tt0133093", 19, new DateTime(1999, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Matrix" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("f4c43674-7f78-48cd-9263-9b136c8a49ca"), "https://image.tmdb.org/t/p/w500/d1oSJMMygWT1redrtBANtllwNZb.jpg", "https://image.tmdb.org/t/p/w500/mHAxH3msDPHfHsbrPvZ4M6CAWgS.jpg", "The classic story of English POWs in Burma forced to build a bridge to aid the war effort of their Japanese captors. British and American intelligence officers conspire to blow up the structure, but Col. Nicholson , the commander who supervised the bridge's construction, has acquired a sense of pride in his creation and tries to foil their plans.", null, 7, "tt0050212", 142, new DateTime(1957, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Bridge on the River Kwai" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("f683f566-a8a5-433a-a3cd-fee4f2ed0864"), "https://image.tmdb.org/t/p/w500/yw55hiqnDOwZiXpkraXu114rmGz.jpg", "https://image.tmdb.org/t/p/w500/yFihWxQcmqcaBR31QM6Y8gT6aYV.jpg", "NYPD cop John McClane's plan to reconcile with his estranged wife is thrown for a serious loop when, minutes after he arrives at her office, the entire building is overtaken by a group of terrorists. With little help from the LAPD, wisecracking McClane sets out to single-handedly rescue the hostages and bring the bad guys down.", null, 1, "tt0095016", 122, new DateTime(1988, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Die Hard" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("f8aeba80-de4f-4874-a754-92a65dbe3649"), "https://image.tmdb.org/t/p/w500/2oZklIzUbvZXXzIFzv7Hi68d6xf.jpg", "https://image.tmdb.org/t/p/w500/7oWY8VDWW7thTzWh3OKYRkWUlD5.jpg", "With the help of a German bounty hunter, a freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.", null, 7, "tt1853728", 62, new DateTime(2012, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Django Unchained" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("faee7fec-ab7e-4767-be3c-960d0a628aee"), "https://image.tmdb.org/t/p/w500/DztBnZaqmla2sGUW9s8AyOmskT.jpg", "https://image.tmdb.org/t/p/w500/wby9315QzVKdW9BonAefg8jGTTb.jpg", "Lester Burnham, a depressed suburban father in a mid-life crisis, decides to turn his hectic life around after developing an infatuation with his daughter's attractive friend.", null, 7, "tt0169547", 70, new DateTime(1999, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "American Beauty" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("faf3860e-3727-4fde-a338-88e70662ca67"), "https://image.tmdb.org/t/p/w500/mfJepkInUbiZ0mFXFhDNz8ko6Zr.jpg", "https://image.tmdb.org/t/p/w500/bdN3gXuIZYaJP7ftKK2sU0nPtEA.jpg", "A mysterious story of two magicians whose intense rivalry leads them on a life-long battle for supremacy -- full of obsession, deceit and jealousy with dangerous and deadly consequences.", null, 7, "tt0482571", 49, new DateTime(2006, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Prestige" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("fb2e6fc2-2113-4b57-87c8-686c719b0071"), "https://image.tmdb.org/t/p/w500/9TEUJy5aRP7LaM1LKTfcxVK34JK.jpg", "https://image.tmdb.org/t/p/w500/oTKduWL2tpIKEmkAqF4mFEAWAsv.jpg", "At a tiny Parisian café, the adorable yet painfully shy Amélie accidentally discovers a gift for helping others. Soon Amelie is spending her days as a matchmaker, guardian angel, and all-around do-gooder. But when she bumps into a handsome stranger, will she find the courage to become the star of her very own love story?", null, 4, "tt0211915", 93, new DateTime(2001, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Amélie" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("fbaab0cd-16af-4775-a8d0-3d93958fbac9"), "https://image.tmdb.org/t/p/w500/a3MmLFhOLSgODby8JQyPtca4o1q.jpg", "https://image.tmdb.org/t/p/w500/A0byHUHMwZ7dtBQtfZ44QIgDbjo.jpg", "An Irish rogue uses his cunning and wit to work his way up the social classes of 18th century England, transforming himself from the humble Redmond Barry into the noble Barry Lyndon.", null, 7, "tt0072684", 220, new DateTime(1975, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Barry Lyndon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("fbdd12f0-e76c-4df0-a650-5d011fedafbd"), "https://image.tmdb.org/t/p/w500/fRGxZuo7jJUWQsVg9PREb98Aclp.jpg", "https://image.tmdb.org/t/p/w500/6uSPcdGNA2A6vJmCagXkvnutegs.jpg", "Under the direction of a ruthless instructor, a talented young drummer begins to pursue perfection at any cost, even his humanity.", null, 7, "tt2582802", 44, new DateTime(2014, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Whiplash" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("fbe316c5-25aa-425c-b664-5201326b466d"), "https://image.tmdb.org/t/p/w500/sdNPipjZoOJFuTBwH8EyEb5dsKv.jpg", "https://image.tmdb.org/t/p/w500/py6jLpcwr7qQRufQJneCZZjsQqL.jpg", "In the South American jungle, supplies of nitroglycerine are needed at a remote oil field. The oil company pays four men to deliver the supplies in two trucks. A tense rivalry develops between the two sets of drivers on the rough remote roads where the slightest jolt can result in death.", null, 7, "tt0046268", 206, new DateTime(1953, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Wages of Fear" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("fc201ed0-18a4-4da0-9af9-21594809764e"), "https://image.tmdb.org/t/p/w500/p47ihFj4A7EpBjmPHdTj4ipyq1S.jpg", "https://image.tmdb.org/t/p/w500/9zM8ECgHL0fz5AJzm5mDamLHwEB.jpg", "A hack screenwriter writes a screenplay for a former silent film star who has faded into Hollywood obscurity.", null, 7, "tt0043014", 57, new DateTime(1950, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Sunset Blvd." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("fcc4647a-0ee6-4c00-b5be-a059a8963688"), "https://image.tmdb.org/t/p/w500/vVBcIN68kFq681b4lObiNJhEVro.jpg", "https://image.tmdb.org/t/p/w500/zwzWCmH72OSC9NA0ipoqw5Zjya8.jpg", "John Nash is a brilliant but asocial mathematician fighting schizophrenia. After he accepts secret work in cryptography, his life takes a turn for the nightmarish.", null, 7, "tt0268978", 141, new DateTime(2001, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "A Beautiful Mind" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("fd0161ee-9b7c-49ec-8b67-8858635eb923"), "https://image.tmdb.org/t/p/w500/3E5pvJLNEz5WmYWl6GfFW8hEVV3.jpg", "https://image.tmdb.org/t/p/w500/1wY4psJ5NVEhCuOYROwLH2XExM2.jpg", "As U.S. troops storm the beaches of Normandy, three brothers lie dead on the battlefield, with a fourth trapped behind enemy lines. Ranger captain John Miller and seven men are tasked with penetrating German-held territory and bringing the boy home.", null, 7, "tt0120815", 28, new DateTime(1998, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Saving Private Ryan" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("fdccc61c-a4c7-4d06-a327-057c931dd35d"), "https://image.tmdb.org/t/p/w500/mMtUybQ6hL24FXo0F3Z4j2KG7kZ.jpg", "https://image.tmdb.org/t/p/w500/q719jXXEzOoYaps6babgKnONONX.jpg", "High schoolers Mitsuha and Taki are complete strangers living separate lives. But one night, they suddenly switch places. Mitsuha wakes up in Taki’s body, and he in hers. This bizarre occurrence continues to happen randomly, and the two must adjust their lives around each other.", null, 14, "tt5311514", 79, new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Your Name." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("fe2829fd-638e-4588-9dd4-42ded95d7f31"), "https://image.tmdb.org/t/p/w500/eUKJrORgXWAMFoBwTqJgwqSFprs.jpg", "https://image.tmdb.org/t/p/w500/8MnMGO3oALkaiavehLmsKwvBU8S.jpg", "1930s Korea, in the period of Japanese occupation, a young woman is hired as a handmaiden to a Japanese heiress who lives a secluded life on a large countryside estate with her domineering uncle, but she's involved in something greater that will soon be revealed.", null, 16, "tt4016934", 229, new DateTime(2016, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "The Handmaiden" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "BackdropUrl", "CoverUrl", "Description", "Director", "Genre", "ImdbId", "Ranking", "ReleaseDate", "Runtime", "Title" },
                values: new object[] { new Guid("ffa2a4c6-bc93-4030-a3e4-6b8349796994"), "https://image.tmdb.org/t/p/w500/2NArMoObkAbnIPvqlHC3gRGsfBb.jpg", "https://image.tmdb.org/t/p/w500/jcgUjx1QcupGzjntTVlnQ15lHqy.jpg", "1986 Gyunggi Province. The body of a young woman is found brutally raped and murdered. Two months later, a series of rapes and murders commences under similar circumstances. And in a country that had never known such crimes, the dark whispers about a serial murderer grow louder. A special task force is set up in the area, with two local detectives Park Doo-Man and Jo Young-Goo joined by a detective from Seoul who requested to be assigned to the case.", null, 5, "tt0353969", 193, new DateTime(2003, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0), "Memories of Murder" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("00978049-8d62-462a-a2e3-17c2fddcdc1e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0289e70f-2614-4ca7-a0c3-d93bb55cb8ba"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("03305611-3545-4881-be06-b80a846c1cd1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("04db1131-2bd6-46d4-a9ab-92897f647bc6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("05fe9c1a-cd06-46a5-a1f5-36b02bd6ca4a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("07f2cd2e-affb-4d6a-b691-88de9cf37e52"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0a1cd93b-d397-4834-a9c9-29e927247e9b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0a68ab47-5800-4a7e-802d-042a904bd946"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0b358f35-cbde-449b-9a46-28fd6ddf0f37"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0ba62247-56a4-4005-8de6-a32094f1d1f3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0cc61cca-731b-4b9b-abbc-47d0a6c2aa54"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1015a943-015c-4735-84a0-e064e5261719"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1141bf87-e0fb-465f-9e04-b7bee202322a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("12233c55-2aa9-4dcc-a32e-fbc4442a677d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("139a8306-c332-4862-b8d4-b581426ab37b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("143d4601-c12a-46e8-b615-001ea98730c2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("14c1998f-567f-4cca-93a0-4fb9a50700e6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("15c29220-4039-421e-817c-3b298c227fb2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("15dac414-b765-4612-92ee-db4f3d852d76"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("16a82740-a53c-49f6-99a9-49694ff1262a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("16d31b12-9213-4c02-b268-1186841e7add"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("18110a5a-0ef9-4fce-b3f6-ae96677b290d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("18383b91-d64c-481e-a577-108ecca0e325"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("18569fe1-c38f-41dd-bc63-f625fdde1c08"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("199a516d-c33e-4219-91a5-61880f6df16d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("19d1015c-3f22-4ce6-aae3-5f5145c98d56"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1b623b39-01bb-4b28-937c-0110ac0fba2a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1c87c1c4-9e5c-42c5-aff2-81f2e345a5df"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1dc5b988-9be8-40fd-b3d4-39d4fbe9a9f5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1f6ad750-5894-43c6-91ae-d4c3ec6f712b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2388e80f-6a03-4eca-b4cb-25636f0cd433"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("243b5459-5c5a-4468-a5f0-7a8e92390d52"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("26a58c05-033c-43d0-ab5a-50febd6a6bc0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("276bd5e7-e278-4b10-8d86-aa0128619b8d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2772b275-0c05-4a5b-9c79-34cd61c9736f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2be29f11-be41-40c5-aaae-7448500d92e9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2e314b0d-c4ec-4053-a813-e232a48b84c7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2e78123e-1ef8-4897-b26e-6c3c077bb96f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2fd3d72f-f4d5-42cd-b8a0-4b2d1b7bdc44"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("30235648-c52a-4569-afe4-3b528d78e1a8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("306d7ca1-1408-47a5-aeed-67f1ac8f38c4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("31bd40c1-6b5f-465e-80c2-08dd4b00cabb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("33cdb8b7-83b8-4b11-a2e4-ac72acf222b0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("34b32dd7-024e-4c7d-aab5-fe73a8ab21a0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("350981c9-8f93-4eea-b327-88c422ef8c6c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("35b9d3eb-0dda-42dd-8e6f-b3828a4059d2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("363b78cd-0bf9-4946-a92d-e383878ab540"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3789de91-8ec7-4fdb-b16c-17f7a2691b8f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("390580e1-932b-4192-bd8b-2daacb481edf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3aa59f4f-cd3c-4c37-be69-f330b57a2d4d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3b57507c-3425-4d69-986b-444671d41212"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3c685712-bff5-4178-8229-6719d97c7739"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3d54fc90-3965-46f4-8268-534163e84ed5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3e6544d7-cdcb-4aed-9e7d-6f2555d35c3f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3f3ccbfd-4ce1-43b0-9164-60a775935246"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("40103c42-8729-444c-aca8-f65af4fa2ca8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("404da287-1f96-4dcc-a4a8-81eed8f2bee1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("40c30c5a-4da8-4f65-ba1a-2e29fd493318"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("41c66d2f-8e92-49d9-993a-fa9cc38bc222"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4336a143-97d7-45ef-b3c6-5e2f9c1b059c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("443e378a-ec42-4dd2-a420-fc4f1a1e9ec4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("44f2dce5-537a-4ad5-b6a4-5ed1e90ae13f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("46479db6-4a47-42ca-9484-9d8ee34a4bb9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("477ee59e-d7e3-4839-91fe-55baa646303e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4848b80e-d4b0-4ad0-9c21-e0060d5a3434"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("486ad087-2001-4389-994a-b0e5e1d8b0fd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4a06fa81-a325-46a5-bbe5-80a20573e3b2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4a3013ff-52cb-4554-b86f-50eb035b0080"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4b21e915-25bd-4088-bdc4-6dde80e5d91f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4b72d3b1-2746-4266-9dc9-6682830cd72a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4bdeafdb-ff30-4e49-8879-4210522b76e8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4caa7662-8991-4d91-80ac-34fd865ce81a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4d28016e-57e9-418b-8eba-41308133d3e2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4d95ca40-377f-4379-959b-07a042d000ca"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4e5939a6-fe5a-4f54-ae36-03202db8f45c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4f9a9a5d-85fe-4f6f-a762-bff73be4019b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4feb9916-4bd9-427d-82df-b83e93f411f3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4ffad4df-3715-45cc-b427-99378385d1b2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5014f7b9-9535-4351-8338-b037948280b1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("50a8cb5a-78de-4eb0-a83b-4582fb6169a3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5226990e-622a-42d2-b167-de9337339a38"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("53b19403-1949-4360-a66e-80e6e10d32f8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("55aa58d4-8234-4b03-8c05-c9fe2f712f3f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("55ccea7a-fa45-439c-9df5-3d40becc7e3c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("57e176fd-0b82-470b-82c1-f4daf7d1dbe7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5a3e6f74-3620-4059-b4c4-10e6ac2ebe44"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5b135f73-0950-43a3-953f-27624cc792e6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5b703cf7-e99d-4538-a9d2-a9813c8b5c65"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5bd70a9d-c9e6-4ba5-9458-60a1e754fdc4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5ceacbf2-c8a6-42f9-8e51-48b956df8359"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5d3ad990-5259-479f-a894-81a82edc48ac"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5e5045e0-4dd9-4ebf-95ab-1b5ee5f246a5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5ed869ed-61ab-4f02-86ce-bb3172948a44"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5f51ab75-cb81-4199-98be-dd920509fbb2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5fdbc792-51ce-4932-9445-d131cb42a4a2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("601bcb43-96a8-4a1e-9d90-bd9696f262c5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("61a51f69-c8e5-4c21-873c-aca0ec7bda30"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6247bea4-7095-4551-913a-a3e96ace5577"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("62b0bb48-d3ec-4d34-8fdc-ac8e57f3b2d0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("65236f91-6228-42b3-a0e6-96cb0fb035a7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("654aa24b-f5ae-492b-86e2-aaa2803208c9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6596aaf6-2fff-4e79-b95b-adb5ebbe31f7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("661ead07-62c6-4ceb-9832-d063ce90d3c3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("671a5120-5e77-4b00-a22b-e39460bb103e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("674d31c1-cc0f-4bcd-840d-8f6a54efae51"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("678ea559-a0ff-4acc-916b-67e82e84e1ba"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("67ef853d-5211-4258-9c93-2142cf08dede"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("68635b5b-d508-45d8-bd01-dd1e322e3895"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("699f713c-9194-4851-9a02-94418686eec7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6c772905-e3e6-432d-a495-99c398115bd2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6cedcc75-daee-4c4d-8dcd-7a2d453fdf6e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6e58e95d-34a2-4617-92fc-a7beb6a23e56"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7023d547-741f-40a1-8433-faa1a9943d55"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("70f3cf5c-c06b-4da1-a9e1-9dcb12705063"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("71b4f6a3-4576-4dc1-a47f-e5385e2ac7f4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("72fe9e2a-9a0e-41d1-833a-941994337e55"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7591e738-3bdc-47c5-9cff-aa245dcaf9e7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("759feb6d-eee6-4649-8cad-929e5b6cf315"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("771a36ee-c4e6-413f-8360-52bce8c4e592"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("778c1be2-07dc-44c9-b78b-def7f4a2ad91"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7a37ed56-229d-440d-9f10-fa33ac420f19"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7aecdae0-5bea-4d8f-b567-b7b15f0a6282"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7c4711dd-8587-499e-9e51-72d66a38d7ec"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7c8c3d0f-e93d-42f4-9089-c05f22a0fea3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7c9b3103-3926-47f9-9ab8-a7d30d77b8b4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7cf06eca-0374-4486-b2db-017131b4fa4e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7e1c355b-7414-4aeb-9a87-92cf3b3a3d56"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7ecdcc9f-bb0b-4f5e-a168-7c471bd54222"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("809051fe-6a80-4462-825a-5f47a2f33c97"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("810ab9b0-57fb-4da5-9328-6d7ce35730f2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("818886d3-12c4-4efc-bda4-da6e900296fa"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("834052c0-26f5-4825-b5f0-c74c9c8e30da"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("876d41b4-850a-4c46-bdaf-c6672a36e5d4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("88b59a21-f7b1-442c-9335-27cf1865771d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8b368bf3-92ff-4ee4-8abb-37a65a81ac5a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8c35ee7d-5a52-4cfd-8c8d-ad8abe700349"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8c8a12dd-47a8-47e1-a25f-63bc787564ae"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8e62a45d-5adc-43a5-9fe0-b2662372c5ce"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8f1a3f3c-9134-446e-ada7-a0c4c616180f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9105922f-b628-450c-9167-10274722d768"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("91c07918-8d4f-45c0-a0cb-ade2b9ac6f68"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("933809d4-22d9-472a-a58c-a4a80e5423b3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("958e6e92-6d7b-4dbc-a770-be98ed923728"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9777558b-6fa8-4285-99ec-5784708169a9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9824c7be-0096-4682-b3bd-8adcde337742"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9826284c-58df-4f2e-a8f3-06637bfb3d04"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("995c8d26-f4ef-4010-856d-f6e1b81ee2b2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9b48f32d-aaf6-4323-bfc1-d714825c4a13"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9bcd287f-91de-4ae7-a848-089dcdc972da"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9c56822e-ed0d-4dc0-851b-07a988af2563"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9ced41c4-afb5-431e-92ce-2a7690cc3fc6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9e0e9f0b-8047-40f4-9a88-2c8b91beea77"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a10926cd-f71e-4a36-9882-9739c825ea55"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a355cefb-5582-42e4-ae13-a254d22ae144"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a36b0700-ac37-424f-8f42-9cf20f3acd89"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a3c9e355-5c76-488a-bf55-229256c900d4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a4582c62-c053-4d50-a0a2-fc192a64e596"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a60231b1-0b00-4591-8204-bcea2cfd46cf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a735a825-b0c6-463e-bbf0-4f540184ed76"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a74aa7ac-32fa-4352-8adb-240eb3dc6b17"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a9ca38f7-c830-44e2-88ef-9a46a5dcef73"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("abbf890a-a5ca-4cb6-8e69-9d5d24a86315"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ad4e0225-9d85-4ba9-a374-de5970f420c0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ae5ba7f5-5aa2-41d4-a9f9-02a66d07fa1d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b01d8bd3-f0dc-4960-8994-911a0e393b74"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b0ccd15d-9f5f-401b-8eec-0dae56dc3a9f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b11e7192-467c-45b9-9839-f0f37e6f70f6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b2c8785c-fb21-48b0-ac60-a17cab3de2d1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b3d5b2d5-9e53-41a8-8313-84df184099c3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b44429c7-ba27-4f9e-b456-d5d65e7968b4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b57e5eee-39fb-4ad7-bfd1-db2b032e4573"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b5c7cc1f-f976-4aaf-9040-ff2f411bc804"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b87dd60d-40cd-4785-9482-cab1f18dc745"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b8b14210-b9dd-4e4e-8baa-b3fa3639da0c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bddc5d0e-deef-44fe-bc02-d33c61db61ee"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("be4375b5-b94b-44eb-8d2f-6f33d2fc5872"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bf76c193-c4a8-4de2-bb0c-ee97697c33cf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c131ccc6-7454-4ec6-96b8-e8a69ab9367b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c20baed5-57e6-4e27-a359-301e5793becb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c2b59ee3-1738-454c-838b-a61cad3aa3e0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c3c262cc-0a5a-43ee-9d8c-c099bb62c5c9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c51f36ef-e04f-41b6-9bb4-aea606ad5a0c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c67b48e5-9451-4e97-a1f2-7afeee54ae22"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c7d8f992-3e13-4ff1-abea-e7a986f3d0d1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c94d5e07-41a5-4496-aac1-f7a796a9e4a5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ca5b2758-9a28-452a-a841-1c3a1aea3ad4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cc2cc167-586d-49b3-a464-c497327ef57e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cc6bd49e-da21-4339-9454-365f185a1544"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cc933fa7-d3b8-428b-9dd5-646066dfe98c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cc94235d-4f21-4e68-807d-7e5b2541a31f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cd218176-4769-4de3-95c3-c688458a1acb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cdd85e86-8f69-4b46-82f6-b36b9633b58c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ce01ff24-e67e-438e-8009-972eaf74dfc3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cecd827b-c327-4911-ba43-e1183ff34f2d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cf149f82-292d-4e12-aca2-f6f74e242f88"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cf82d599-2e57-421c-aeb7-206580a67a56"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d041a742-6c9b-41bb-99e6-24da14facd0f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d0bc028a-7b1c-47c2-98d6-a63c98336d7a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d1dd829a-8ead-4b05-a09d-91612561b748"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d2059c9f-54f2-414c-b050-b4dbed22534a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d436c391-c0de-45b9-8002-e6a42be00da3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d8f8d8e4-5ced-4a79-8b44-151eb334d54d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d9ff480c-ff6b-4084-81b1-05e3facda9f3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("db1985b6-aa8a-4c54-bd85-38b76053208b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("db558020-16aa-4a51-847c-c66ff609a8c0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dba81a02-0b94-4ded-813a-0399681fdfd8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("de7eaa2d-5cbe-46d7-91e9-6a8b12140255"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("deb00c46-be07-4575-b843-1ee527885490"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dfc8d31f-b5fa-44a9-8401-1621a99f4739"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dfd10f23-4d7c-436c-9095-4bab783fb03b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e17f07b0-e6b7-4fa1-b8e1-e6a6dfc84396"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e2c03f6f-e08a-472e-8da5-df64ab579e3d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e3024f5c-f395-4a36-a3a6-159ce86963b3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e312e298-81ae-4fa9-ae48-63966420d2b1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e37c9176-4e39-41a7-be77-fbd61bbd2481"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e54b2e66-f78f-4e69-bc30-cfbedda7dbb0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e5540e68-3ae8-4d42-a58c-4720a7c2f7b2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e57273ad-6a08-44ca-88af-662e2c4f9654"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e609d393-78a9-493d-97c2-70e996fe1fa4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e6689752-a5c1-437e-a47e-011573716b19"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e6ca5ce3-96b8-421d-b5e8-d4bd95581d2d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e70db5f8-4a15-4079-8ffb-07846a28b3c1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e801b370-770a-40bb-bac1-95e63c9e8c79"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e83eb793-629d-45d1-b9a0-0a9cbd0212a8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e83f643e-a95e-4ad7-872f-f62481fc9c89"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e981fd68-8c5d-48fa-9d8b-49eaa453ab19"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e98dbca7-1cd4-47c8-a3ee-60a99414a276"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ea7e76e8-0a1c-4b3a-af39-510d553e6b82"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("eb87e1d4-ceb9-4508-997c-b8a3d835648f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ec93ebe0-bb35-488e-a196-ed78183b38d5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ecc6d016-4f75-4981-a11d-b1beff8236c9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ed2774e3-886a-4fb4-952e-dd83a1eb686d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ed3ad1a4-be1d-45fe-8885-1a9f9fa89af7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ed463246-61b2-488a-a55c-b8ecc068522e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f46183ac-26ef-449e-a39a-46127a464256"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f4c43674-7f78-48cd-9263-9b136c8a49ca"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f683f566-a8a5-433a-a3cd-fee4f2ed0864"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f8aeba80-de4f-4874-a754-92a65dbe3649"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("faee7fec-ab7e-4767-be3c-960d0a628aee"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("faf3860e-3727-4fde-a338-88e70662ca67"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fb2e6fc2-2113-4b57-87c8-686c719b0071"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fbaab0cd-16af-4775-a8d0-3d93958fbac9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fbdd12f0-e76c-4df0-a650-5d011fedafbd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fbe316c5-25aa-425c-b664-5201326b466d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fc201ed0-18a4-4da0-9af9-21594809764e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fcc4647a-0ee6-4c00-b5be-a059a8963688"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fd0161ee-9b7c-49ec-8b67-8858635eb923"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fdccc61c-a4c7-4d06-a327-057c931dd35d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fe2829fd-638e-4588-9dd4-42ded95d7f31"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ffa2a4c6-bc93-4030-a3e4-6b8349796994"));

            migrationBuilder.DropColumn(
                name: "BackdropUrl",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImdbId",
                table: "Movies");
        }
    }
}
