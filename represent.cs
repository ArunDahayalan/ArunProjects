using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Syncfusion.Infrastructure.Data;

namespace interview1.Models
{
    public class represent
    {
     public ReleaseBuild SetupInfo { get; set; }
      public List<ReleaseBuild> books { get; set; }
      public ReleaseBuild bookListFromTable()
      {
          using (var booklist = new masterEntities2())
          {
              books = (from list in booklist.fg_bookslist
                       where list.id != null
                       select new ReleaseBuild
                       {
                           BookId = list.id,
                           Name = list.name,
                           Author = list.authors,
                           Language = list.language,
                           Number = list.booknumber
                       }).ToList();
              return SetupInfo;
          }
      }
      public int updateValues (ReleaseBuild release)
      {
          int releaseId = 0;
          using (var booklist = new masterEntities2())
          {
              books = (from list in booklist.fg_bookslist
                       where list.id != null
                       select new ReleaseBuild
                       {
                           BookId = list.id,
                           Name = list.name,
                           Author = list.authors,
                           Language = list.language,
                           Number = list.booknumber
                       }).ToList();
              var count = books.Count();
              releaseId = count + 1;
              var newList = new fg_bookslist();
              newList.name = release.Name;
              newList.authors = release.Author;
              newList.booknumber = release.Number;
              newList.language = release.Language;
              newList.id = count + 1;
              booklist.fg_bookslist.Add(newList);
              booklist.SaveChanges();
          }
          return releaseId;
      }
       public ReleaseBuild singleBookDetails(int bookId)
      {
          using (var booklist = new masterEntities2())
          {
              books = (from list in booklist.fg_bookslist
                       where list.id == bookId
                       select new ReleaseBuild
                       {
                           BookId = list.id,
                           Name = list.name,
                           Author = list.authors,
                           Language = list.language,
                           Number = list.booknumber
                       }).ToList();
              return SetupInfo;
          }
      }

    }
     public class ReleaseBuild
     {
         public int BookId { get; set; }
         public string Name { get; set; }
         public string Author { get; set; }
         public string Language { get; set; }
         public int Number { get; set; }
     }
}