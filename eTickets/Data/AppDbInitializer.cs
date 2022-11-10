using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "PVR",
                            Logo = "/dataSource/Cinema/pvr.png",
                            Description = "PVR"
                        },
                        new Cinema()
                        {
                            Name = "Cinepolis",
                            Logo = "/dataSource/Cinema/cinepolis.png",
                            Description = "Cinepolis"
                        },
                        new Cinema()
                        {
                            Name = "IMAX",
                            Logo = "/dataSource/Cinema/imax.png",
                            Description = "IMAX"
                        },
                        new Cinema()
                        {
                            Name = "INOX",
                            Logo = "/dataSource/Cinema/inox.png",
                            Description = "INOX"
                        },
                        new Cinema()
                        {
                            Name = "Cineworld",
                            Logo = "/dataSource/Cinema/Cineworld.png",
                            Description = "Cineworld"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Chadwick Boseman",
                            Bio = "Actor",
                            ProfilePictureURL = "/dataSource/Actor/chadBose.png"

                        },
                        new Actor()
                        {
                            FullName = "Jonathan Majors",
                            Bio = "Actor",
                            ProfilePictureURL = "/dataSource/Actor/jonathanMajors.png"
                        },
                        new Actor()
                        {
                            FullName = "Kate Winslet",
                            Bio = "Actress",
                            ProfilePictureURL = "/dataSource/Actor/kateWinslet.png"
                        },
                        new Actor()
                        {
                            FullName = "Rishabh Shetty",
                            Bio = "Actor",
                            ProfilePictureURL = "/dataSource/Actor/rishabhShetty.png"
                        },
                        new Actor()
                        {
                            FullName = "Yash Soni",
                            Bio = "Actor",
                            ProfilePictureURL = "/dataSource/Actor/yashSoni.png"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Dharma Productions",
                            Bio = "Production House",
                            ProfilePictureURL = "/dataSource/Producer/dharma.png"

                        },
                        new Producer()
                        {
                            FullName = "Disney",
                            Bio = "Production House",
                            ProfilePictureURL = "/dataSource/Producer/disney.png"
                        },
                        new Producer()
                        {
                            FullName = "Maddock Films",
                            Bio = "Production House",
                            ProfilePictureURL = "/dataSource/Producer/maddock.png"
                        },
                        new Producer()
                        {
                            FullName = "Eros International",
                            Bio = "Production House",
                            ProfilePictureURL = "/dataSource/Producer/eros.png"
                        },
                        new Producer()
                        {
                            FullName = "Warner Brothers",
                            Bio = "Production House",
                            ProfilePictureURL = "/dataSource/Producer/warnerBro.png"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Ant-Man and the Wasp: Quantumania\n",
                            Description = "Ant-Man and the Wasp: Quantumania is an upcoming American superhero film based on Marvel Comics",
                            Price = 200,
                            ImageURL = "/dataSource/Movie/antman3.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Avatar: The Way of Water",
                            Description = "Avatar: The Way of Water is an upcoming American epic science fiction film directed by James Cameron",
                            Price = 250,
                            ImageURL = "/dataSource/Movie/avatar2.png",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Black Panther: Wakanda Forever",
                            Description = "Black Panther: Wakanda Forever is a 2022 American superhero film based on the Marvel Comics character Black Panther.",
                            Price = 180,
                            ImageURL = "/dataSource/Movie/blackPanther.png",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Fakt Mahilao Maate",
                            Description = "Surrounded and frustrated by all the women and their bickering, one day Chintan receives supernatural powers that enable him to listen to the inner voice of the women around him. Will he now know what women actually want?",
                            Price = 190,
                            ImageURL = "/dataSource/Movie/faktMahilaoMaate.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Kantara",
                            Description = "Kantara is a 2022 Indian Kannada-language action thriller film[3] written and directed by Rishab Shetty",
                            Price = 220,
                            ImageURL = "/dataSource/Movie/kantara.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Pathan",
                            Description = "Pathaan is a 2023 Hindi-language action thriller film directed by Siddharth Anand",
                            Price = 200,
                            ImageURL = "/dataSource/Movie/pathan.png",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Action
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
