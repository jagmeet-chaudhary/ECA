using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using ECA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace ECA.Tests
{
    public static  class TestInit
    {
        static TestInit()
        {
            MockDb = new ECAEntities();
            InitTestDBContext(MockDb);
        }
        public  static ECAEntities MockDb;
        private static string GetStringValue(SharedStringTable stringTable, Cell c, int id)
        {
            
            return stringTable.ElementAt(Convert.ToInt32(c.CellValue.Text)).FirstOrDefault().InnerText;
        }
        public static void InitTestDBContext(ECAEntities @this)
        {

            using (SpreadsheetDocument mySpreadsheet = SpreadsheetDocument.Open(@"../../TestData.xlsx", false))
            {
                var sheets = mySpreadsheet.WorkbookPart.Workbook.Sheets;
                SharedStringTable stringTable = mySpreadsheet.WorkbookPart.SharedStringTablePart.SharedStringTable;

                //Author
                Sheet sAuthor = sheets.Descendants<Sheet>().Where(s => s.Name == "Author").FirstOrDefault();
                WorksheetPart wsPart = mySpreadsheet.WorkbookPart.GetPartById(sAuthor.Id) as WorksheetPart;
                SheetData sheetData = wsPart.Worksheet.Elements<SheetData>().First();

                @this.Authors = new FakeDbSet<Model.Author>();
                foreach (Row r in sheetData.Elements<Row>())
                {
                    if (r.RowIndex == 1)
                        continue;

                    ECA.Model.Author author = new Model.Author();
                    author.AuthorId = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(0), 0);
                    author.AuthorName = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(1), 1);
                    @this.Authors.Add(author);
                }

                //Book
                Sheet sBook = sheets.Descendants<Sheet>().Where(s => s.Name == "Book").FirstOrDefault();
                wsPart = mySpreadsheet.WorkbookPart.GetPartById(sBook.Id) as WorksheetPart;
                sheetData = wsPart.Worksheet.Elements<SheetData>().First();

                @this.Books = new FakeDbSet<Model.Book>();

                foreach (Row r in sheetData.Elements<Row>())
                {
                    if (r.RowIndex == 1)
                        continue;
                    ECA.Model.Book book = new Model.Book();
                    book.ID = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(0), 0);
                    book.Title = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(1), 1);
                    book.Description = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(2), 2);
                    book.AuthorId = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(3), 3);
                    book.GenreId = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(4), 4);
                    book.CategoryId = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(5), 5);
                    book.ISBN = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(6), 6);
                    @this.Books.Add(book);
                }
                //Book Category
                Sheet sBookCategory = sheets.Descendants<Sheet>().Where(s => s.Name == "BookCategory").FirstOrDefault();
                wsPart = mySpreadsheet.WorkbookPart.GetPartById(sBookCategory.Id) as WorksheetPart;
                sheetData = wsPart.Worksheet.Elements<SheetData>().First();

                @this.BookCategories  = new FakeDbSet<Model.BookCategory>();
                
                foreach (Row r in sheetData.Elements<Row>())
                {
                    if (r.RowIndex == 1)
                        continue;
                    ECA.Model.BookCategory category = new Model.BookCategory();
                    category.CategoryId = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(0), 0);
                    category.CategoryName = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(1), 1);

                    @this.BookCategories.Add(category);
                }

                //Genre
                Sheet sGenre = sheets.Descendants<Sheet>().Where(s => s.Name == "Genre").FirstOrDefault();
                wsPart = mySpreadsheet.WorkbookPart.GetPartById(sGenre.Id) as WorksheetPart;
                sheetData = wsPart.Worksheet.Elements<SheetData>().First();

                @this.Genres = new FakeDbSet<Model.Genre>();

                foreach (Row r in sheetData.Elements<Row>())
                {
                    if (r.RowIndex == 1)
                        continue;
                    ECA.Model.Genre genre = new Model.Genre();
                    genre.GenreId = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(0), 0);
                    genre.GenreName = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(1), 1);
                    @this.Genres.Add(genre);
                }
                //Shopping Cart
                Sheet sCart = sheets.Descendants<Sheet>().Where(s => s.Name == "Cart").FirstOrDefault();
                wsPart = mySpreadsheet.WorkbookPart.GetPartById(sCart.Id) as WorksheetPart;
                sheetData = wsPart.Worksheet.Elements<SheetData>().First();

                @this.Carts  = new FakeDbSet<Model.Cart>();

                foreach (Row r in sheetData.Elements<Row>())
                {
                    if (r.RowIndex == 1)
                        continue;
                    ECA.Model.Cart cart = new Model.Cart();
                  
                    cart.UserId  =  Convert.ToInt32( r.Elements<Cell>().ElementAt(0).CellValue.Text);
                    cart.ItemCode = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(1), 1);
                    cart.Quantity  = Convert.ToInt32(r.Elements<Cell>().ElementAt(2).CellValue.Text);
                    @this.Carts.Add(cart);
                }
                //Users
                Sheet sUser = sheets.Descendants<Sheet>().Where(s => s.Name == "User").FirstOrDefault();
                wsPart = mySpreadsheet.WorkbookPart.GetPartById(sUser.Id) as WorksheetPart;
                sheetData = wsPart.Worksheet.Elements<SheetData>().First();

                @this.Users  = new FakeDbSet<Model.User>();

                foreach (Row r in sheetData.Elements<Row>())
                {
                    if (r.RowIndex == 1)
                        continue;
                    ECA.Model.User  user = new Model.User();
                    user.UserId = Convert.ToInt32(r.Elements<Cell>().ElementAt(0).CellValue.Text);
                    user.UserName = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(1), 1);
                    @this.Users.Add(user);
                   
                }
                //Roles
                Sheet sRoles = sheets.Descendants<Sheet>().Where(s => s.Name == "Role").FirstOrDefault();
                wsPart = mySpreadsheet.WorkbookPart.GetPartById(sRoles.Id) as WorksheetPart;
                sheetData = wsPart.Worksheet.Elements<SheetData>().First();

                @this.webpages_Roles  = new FakeDbSet<Model.webpages_Roles>();
                
                foreach (Row r in sheetData.Elements<Row>())
                {
                    if (r.RowIndex == 1)
                        continue;
                    ECA.Model.webpages_Roles role = new Model.webpages_Roles();
                    role.RoleId  = Convert.ToInt32(r.Elements<Cell>().ElementAt(0).CellValue.Text);
                    role.RoleName = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(1), 1);
                    @this.webpages_Roles.Add(role);

                }
                @this.webpages_Roles.Where(r => r.RoleId == 1).FirstOrDefault().Users = new List<User>()
                {
                    new User(){ UserId = 1, UserName = "Jagmeet Singh"},
                    new User(){ UserId = 2,UserName = "Richard"}
                };
                @this.webpages_Roles.Where(r => r.RoleId == 2).FirstOrDefault().Users = new List<User>()
                {
                    new User(){ UserId = 3, UserName = "John Dan"}
                };
                //Membership
                Sheet sMembership = sheets.Descendants<Sheet>().Where(s => s.Name == "Membership").FirstOrDefault();
                wsPart = mySpreadsheet.WorkbookPart.GetPartById(sMembership.Id) as WorksheetPart;
                sheetData = wsPart.Worksheet.Elements<SheetData>().First();

                @this.webpages_Membership  = new FakeDbSet<Model.webpages_Membership>();

                foreach (Row r in sheetData.Elements<Row>())
                {
                    if (r.RowIndex == 1)
                        continue;
                    ECA.Model.webpages_Membership membership = new Model.webpages_Membership();
                    membership.UserId = Convert.ToInt32(r.Elements<Cell>().ElementAt(0).CellValue.Text);
                    membership.Password  = GetStringValue(stringTable, r.Elements<Cell>().ElementAt(6), 6);
                    @this.webpages_Membership.Add(membership);

                }
            }

        }
        
    }

    //public abstract class SingletonBase<T> where T : class
    //{
    //    private static readonly Lazy<T> _Lazy = new Lazy<T>(() =>
    //    {
    //        // Get non-public constructors for T.
    //        var ctors = typeof(T).GetConstructors(System.Reflection.BindingFlags.Instance |
    //                                  System.Reflection.BindingFlags.NonPublic);
    //        if (!Array.Exists(ctors, (ci) => ci.GetParameters().Length == 0))
    //            throw new InvalidOperationException("Non-public ctor() was not found.");
    //        var ctor = Array.Find(ctors, (ci) => ci.GetParameters().Length == 0);
    //        // Invoke constructor and return resulting object.
    //        return ctor.Invoke(new object[] { }) as T;
    //    }, System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
    //    public static T Instance
    //    {
    //        get
    //        {
    //            return _Lazy.Value;
    //        }
    //    }
    //}
  
}
