using Models.AbstractClasses;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Models
{
    public static class LibInitializer
    {
        public static Library InitLibrary()
        {
            List<string> themes = InitThemes();
            List<Book> books = InitBooks(themes);
            List<VideoCourse> videos = InitVideos(themes);
            List<InternetResource> internetResources = InitInternetResources(themes);
            List<LibResource> resources = new List<LibResource>();
            resources.AddRange(books);
            resources.AddRange(videos);
            resources.AddRange(internetResources);

            var library = Library.GetInstance();
            library.Resources = resources;
            return library;
            //return new Library {Resources = resources};
        }

        public static List<string> InitThemes()
        {
            List<string> themes = new List<string>
            {
                "Программирование",
                "C#",
                "ASP.NET Core",
                "Фронтэнд"
            };
            return themes;
        }

        public static List<Book> InitBooks(List<string> themes)
        {
            List<Book> books = new List<Book>();

            Book book1 = new Book
            {
                Title = "Язык программирования C# 6.0 и платформа .NET 4.6",
                Authors = new[] {"Троелсен Эндрю", "Джепикс Филипп"},
                Themes = new List<string>
                {
                    themes.First(t => t.Equals("Программирование")),
                    themes.First(t => t.Equals("C#"))
                },
                Edition = 7,
                Links = new List<Link>
                {
                    new Link {Title = "Ozon", Path = @"https://www.ozon.ru/context/detail/id/137598683/"},
                    new Link { Title = "Williams Publishing", Path = @"http://www.williamspublishing.com/Books/978-5-8459-2099-7.html" }
                },
                Year = 2016,
                Pages = 1440,
                Publishment = "Williams Publishing",
                PathToCover = "troelsen.jpg",
                PathToDescription = "troelsen.txt"
            };
            books.Add(book1);

            List<Chapter> chapters2 = new List<Chapter>
            {
                new Chapter
                {
                    Order = 1,
                    Title = "C# and the .NET Framework",
                    FirstPage = 1,
                    Pages = 16,
                    SubChapters = new List<Chapter>
                    {
                        new Chapter {Order = 1, Title = "Before .NET", FirstPage = 2, Pages = 1},
                        new Chapter {Order = 2, Title = "Enter Microsoft .NET", FirstPage = 3, Pages = 4},
                        new Chapter {Order = 3, Title = "Compiling to the Common Intermediate Language", FirstPage = 7, Pages = 1 },
                        new Chapter {Order = 4, Title = "Compiling to Native Code and Execution", FirstPage = 8, Pages = 2},
                        new Chapter {Order = 5, Title = "The Common Language Runtime", FirstPage = 10, Pages = 1},
                        new Chapter {Order = 6, Title = "The Common Language Infrastructure", FirstPage = 11, Pages = 2},
                        new Chapter {Order = 7, Title = "Review of the Acronyms", FirstPage = 13, Pages = 1},
                        new Chapter {Order = 8, Title = "The Evolution of C#", FirstPage = 14, Pages = 1},
                        new Chapter {Order = 9, Title = "C# and the Evolution of Windows", FirstPage = 15, Pages = 1}
                    }
                },
                new Chapter {Order = 2, Title = "C# and .NET Core", FirstPage = 17, Pages = 6},
                new Chapter {Order = 3, Title = "Overview of C# Programming", FirstPage = 23, Pages = 20},
                new Chapter {Order = 4, Title = "Types, Storage and Variables", FirstPage = 43, Pages = 16},
                new Chapter {Order = 5, Title = "Classes: The Basics", FirstPage = 59, Pages = 18},
                new Chapter {Order = 6, Title = "Methods", FirstPage = 77, Pages = 52},
                new Chapter {Order = 7, Title = "More About Classes", FirstPage = 129, Pages = 46},
                new Chapter {Order = 8, Title = "Classes and Inheritance", FirstPage = 175, Pages = 42},
                new Chapter {Order = 9, Title = "Expressions and Operators", FirstPage = 217, Pages = 44},
                new Chapter {Order = 10, Title = "Statements", FirstPage = 261, Pages = 32},
                new Chapter {Order = 11, Title = "Structs", FirstPage = 293, Pages = 10},
                new Chapter {Order = 12, Title = "Enumerations", FirstPage = 303, Pages = 14},
                new Chapter {Order = 13, Title = "Arrays", FirstPage = 317, Pages = 30},
                new Chapter {Order = 14, Title = "Delegates", FirstPage = 347, Pages = 24},
                new Chapter {Order = 15, Title = "Events", FirstPage = 371, Pages = 16},
                new Chapter {Order = 16, Title = "Interfaces", FirstPage = 387, Pages = 28},
                new Chapter {Order = 17, Title = "Conversions", FirstPage = 415, Pages = 30},
                new Chapter {Order = 18, Title = "Generics", FirstPage = 445, Pages = 40},
                new Chapter {Order = 19, Title = "Enumerators and Iterators", FirstPage = 485, Pages = 22},
                new Chapter {Order = 20, Title = "Introduction to LINQ", FirstPage = 507, Pages = 58},
                new Chapter {Order = 21, Title = "Introduction to Asynchronous Programming", FirstPage = 565, Pages = 64},
                new Chapter {Order = 22, Title = "Namespaces and Assemblies", FirstPage = 629, Pages = 30},
                new Chapter {Order = 23, Title = "Exceptions", FirstPage = 659, Pages = 22},
                new Chapter {Order = 24, Title = "Preprocessor Directives", FirstPage = 681, Pages = 12},
                new Chapter {Order = 25, Title = "Reflection and Attributes", FirstPage = 693, Pages = 28},
                new Chapter {Order = 26, Title = "What's New in C# 6 and 7", FirstPage = 721, Pages = 30},
                new Chapter {Order = 27, Title = "Other Topics", FirstPage = 751, Pages = 34}
            };

            Book book2 = new Book
            {
                Title = "Illustrated C# 7: The C# Language Presented Clearly, Concisely, and Visually",
                Authors = new[] { "Daniel Solis", "Cal Schrotenboer" },
                Themes = new List<string>
                {
                    themes.First(t => t.Equals("Программирование")),
                    themes.First(t => t.Equals("C#"))
                },
                Edition = 5,
                Links = new List<Link>
                {
                    new Link {Title = "Amazon", Path = @"https://www.amazon.com/Illustrated-Language-Presented-Concisely-Visually/dp/1484232879"},
                    new Link { Title = "Apress", Path = @"https://www.apress.com/gp/book/9781484232873" }
                },
                Year = 2018,
                Pages = 800,
                Publishment = "Apress",
                PathToCover = "illustratedccharp.jpg",
                PathToDescription = "illustratedccharp.txt",
                Chapters = chapters2
            };
            books.Add(book2);

            List<Chapter> chapters3 = new List<Chapter>
            {
                new Chapter {Order = 1, Title = "Understanding Angular and ASP.NET Core MVC", FirstPage = 1, Pages = 4},
                new Chapter {Order = 2, Title = "Getting Ready", FirstPage = 5, Pages = 16},
                new Chapter {Order = 3, Title = "Creating the Project", FirstPage = 21, Pages = 22},
                new Chapter {Order = 4, Title = "Creating the Data Model", FirstPage = 43, Pages = 26},
                new Chapter {Order = 5, Title = "Creating a Web Service", FirstPage = 69, Pages = 34},
                new Chapter {Order = 6, Title = "Completing a Web Service", FirstPage = 103, Pages = 32},
                new Chapter {Order = 7, Title = "Structuring an Angular Application", FirstPage = 135, Pages = 24},
                new Chapter {Order = 8, Title = "Creating the Store", FirstPage = 159, Pages = 38},
                new Chapter {Order = 9, Title = "Completing the Angular Store", FirstPage = 187, Pages = 40},
                new Chapter {Order = 10, Title = "Creating Administration Features", FirstPage = 227, Pages = 24},
                new Chapter {Order = 11, Title = "Securing the Application", FirstPage = 251, Pages = 28},
                new Chapter {Order = 12, Title = "Preparing for Deployment", FirstPage = 279, Pages = 16}
            };

            Book book3 = new Book
            {
                Title = "Essential Angular for ASP.NET Core MVC",
                Authors = new[] { "Adam Freeman" },
                Themes = new List<string>
                {
                    themes.First(t => t.Equals("ASP.NET Core")),
                    themes.First(t => t.Equals("Фронтэнд"))
                },
                Edition = 1,
                Links = new List<Link>
                {
                    new Link {Title = "Amazon", Path = @"https://www.amazon.com/Essential-Angular-ASP-NET-Core-MVC/dp/1484229150"},
                    new Link { Title = "Apress", Path = @"https://www.apress.com/gp/book/9781484229156" }
                },
                Year = 2017,
                Pages = 298,
                Publishment = "Apress",
                PathToCover = "essentialangular.jpg",
                PathToDescription = "essentialangular.txt",
                Chapters = chapters3
            };
            books.Add(book3);

            return books;
        }

        private static List<VideoCourse> InitVideos(List<string> themes)
        {
            List<VideoCourse> courses = new List<VideoCourse>();

            VideoCourse course1 = new VideoCourse
            {
                Title = "Developer Productivity: What's New in C# 6",
                Authors = new[] {"Bill Wagner"},
                Themes = new List<string>
                {
                    themes.First(t => t.Equals("Программирование")),
                    themes.First(t => t.Equals("C#"))
                },
                Links = new List<Link>
                {
                    new Link
                    {
                        Title = "Microsoft",
                        Path =
                            @"https://mva.microsoft.com/en-US/training-courses/developer-productivity-whats-new-in-c-6-8733?l=VBfRDaS1_904984382"
                    }
                },
                Year = 2015,
                PathToDescription = "mvanewccharp6.txt",
                Sections = new List<VideoSection>
                {
                    new VideoSection
                    {
                        Order = 1,
                        Title = "C# Productivity, Conciseness",
                        Fragments = new List<VideoFragment>
                        {
                            new VideoFragment
                            {
                                Order = 1,
                                Title = "C# Features and Productivity and Conciseness",
                                Length = 2771
                            },
                        },
                        Length = 2771
                    },
                    new VideoSection
                    {
                        Order = 2,
                        Title = "Data Transfer Object Enhancements",
                        Fragments = new List<VideoFragment>
                        {
                            new VideoFragment {Order = 1, Title = "Data Transfer Object Enhancements", Length = 2654},
                        },
                        Length = 2654
                    },
                    new VideoSection
                    {
                        Order = 3,
                        Title = "String Handling",
                        Fragments = new List<VideoFragment>
                        {
                            new VideoFragment {Order = 1, Title = "String Handling", Length = 3546},
                        },
                        Length = 3546
                    },
                    new VideoSection
                    {
                        Order = 4,
                        Title = "Exceptions and Error Handling",
                        Fragments = new List<VideoFragment>
                        {
                            new VideoFragment {Order = 1, Title = "Exceptions and Error Handling", Length = 2881},
                        },
                        Length = 2881
                    },
                    new VideoSection
                    {
                        Order = 5,
                        Title = "Adopting C# 6",
                        Fragments = new List<VideoFragment>
                        {
                            new VideoFragment {Order = 1, Title = "Adopting C# 6", Length = 3089},
                        },
                        Length = 3089
                    }
                },
                Length = 2771 + 2654 + 3546 + 2881 + 3089
            };
            courses.Add(course1);

            VideoCourse course2 = new VideoCourse
            {
                Title = "C# Базовый. Урок 1. Введение в ООП. Классы и объекты",
                Authors = new[] { "Александр Шевчук" },
                Themes = new List<string>
                {
                    themes.First(t => t.Equals("Программирование")),
                    themes.First(t => t.Equals("C#"))
                },
                Links = new List<Link>
                {
                    new Link
                    {
                        Title = "ITVDN",
                        Path =
                            @"https://www.youtube.com/watch?v=x0udrpe_gZE"
                    }
                },
                Year = 2013,
                PathToDescription = "itvdnbasic1.txt",
                Sections = new List<VideoSection>
                {
                    new VideoSection
                    {
                        Order = 1,
                        Title = "Введение в ООП. Классы и объекты",
                        Fragments = new List<VideoFragment>
                        {
                            new VideoFragment
                            {
                                Order = 1,
                                Title = "Введение в ООП. Классы и объекты",
                                Length = 11215
                            },
                        },
                        Length = 11215
                    }
                },
                Length = 11215
            };
            courses.Add(course2);

            return courses;
        }

        private static List<InternetResource> InitInternetResources(List<string> themes)
        {
            return new List<InternetResource>
            {
                new InternetResource
                {
                    Title = "Полное руководство по языку программирования С# 7.0 и платформе .NET 4.7",
                    Authors = new []{"Metanit"},
                    MainLink = "https://metanit.com/sharp/tutorial/",
                    Year = 2017,
                    Themes = new List<string>
                    {
                        themes.First(t => t.Equals("Программирование")),
                        themes.First(t => t.Equals("C#"))
                    }
                },
                new InternetResource
                {
                    Title = "Руководство по ASP.NET Core 2.0",
                    Authors = new []{"Metanit"},
                    MainLink = "https://metanit.com/sharp/aspnet5/",
                    Year = 2017,
                    Themes = new List<string>
                    {
                        themes.First(t => t.Equals("ASP.NET Core")),
                        themes.First(t => t.Equals("C#"))
                    }
                },
                new InternetResource
                {
                    Title = "Руководство по Angular 6",
                    Authors = new []{"Metanit"},
                    MainLink = "https://metanit.com/web/angular2/",
                    Year = 2018,
                    Themes = new List<string>
                    {
                        themes.First(t => t.Equals("ASP.NET Core")),
                        themes.First(t => t.Equals("Фронтэнд"))
                    }
                }
            };
        }

        
    }
}
