using BethanysPieShop.Models;
using Moq;


namespace BethanysPieShopTests.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<IPieRepository> GetPieRepository()
        {
            var pies = new List<Pie>
            {
                new Pie
                {
                    PieName = "Apple Pie",
                    Price = 12.95M,
                    ShortDescription = "Our famous apple pies!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                    AllergyDescription = ""
                },
                new Pie
                {
                    PieName = "Blueberry Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "You'll love it!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                    AllergyDescription = ""
                },
                new Pie
                {
                    PieName = "Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "Plain cheese cake. Plain pleasure.",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Cheese cakes"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                    AllergyDescription = ""
                },
                new Pie
                {
                    PieName = "Cherry Pie",
                    Price = 15.95M,
                    ShortDescription = "A summer classic!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                    AllergyDescription = ""
                },
                new Pie
                {
                    PieName = "Christmas Apple Pie",
                    Price = 13.95M,
                    ShortDescription = "Happy holidays with this pie!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                    AllergyDescription = ""
                },
                new Pie
                {
                    PieName = "Cranberry Pie",
                    Price = 17.95M,
                    ShortDescription = "A Christmas favorite",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                    AllergyDescription = ""
                },
                new Pie
                {
                    PieName = "Peach Pie",
                    Price = 15.95M,
                    ShortDescription = "Sweet as peach",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                    InStock = false,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                    AllergyDescription = ""
                },
                new Pie
                {
                    PieName = "Pumpkin Pie",
                    Price = 12.95M,
                    ShortDescription = "Our Halloween favorite",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Seasonal pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                    AllergyDescription = ""
                },
                new Pie
                {
                    PieName = "Rhubarb Pie",
                    Price = 15.95M,
                    ShortDescription = "My God, so sweet!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true,
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                    AllergyDescription = ""
                },
                new Pie
                {
                    PieName = "Strawberry Pie",
                    Price = 15.95M,
                    ShortDescription = "Our delicious strawberry pie!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Category = Categories["Fruit pies"],
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnailUrl =
                        "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                    AllergyDescription = ""
                },
            };

            var mockPieRepository = new Mock<IPieRepository>();
            mockPieRepository.Setup(repo => repo.AllPies).Returns(pies);
            mockPieRepository.Setup(repo => repo.PiesOfTheWeek).Returns(pies.Where(p => p.IsPieOfTheWeek));
            mockPieRepository.Setup(repo => repo.GetPieById(It.IsAny<int>())).Returns(pies[0]);
            return mockPieRepository;
        }

        public static Mock<ICategoryRepository> GetCategoryRepository()
        {
            var categories = new List<Category>
            {
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Fruit Pies",
                    Description = "Lorem ipsum"
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Cheese cakes",
                    Description = "Lorem ipsum"
                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Fruit Pies",
                    Description = "Seasonal pies"
                }
            };

            var mockCategoryRepository = new Mock<ICategoryRepository>();
            mockCategoryRepository.Setup(repo => repo.AllCategories).Returns(categories);

            return mockCategoryRepository;
        }

        private static Dictionary<string, Category>? _categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Fruit pies" },
                        new Category { CategoryName = "Cheese cakes" },
                        new Category { CategoryName = "Seasonal pies" }
                    };

                    _categories = new Dictionary<string, Category>();

                    foreach (var genre in genresList)
                    {
                        _categories.Add(genre.CategoryName, genre);
                    }
                }

                return _categories;
            }
        }
    }
}