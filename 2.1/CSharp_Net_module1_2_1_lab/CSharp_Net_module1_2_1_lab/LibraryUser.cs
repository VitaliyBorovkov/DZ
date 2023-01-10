using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace CSharp_Net_module1_2_1_lab
{
    enum User
    {
        FirstName,
        LastName,
        Id,
        Phone,
        BooksLimit,

    }

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
    interface ILibraryUser
    {
        string AddBook();
        string RemoveBook();
        string BookInfo();
        int BooksCount();
    }


    // 2) declare class LibraryUser, it implements ILibraryUser

    class LibraryUser : ILibraryUser
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Id { get; }
        public string Phone { get; set; }
        public int BookLimit { get; }

        public LibraryUser(string first, string last, int id, string phone, int limit)
        {
            FirstName = first;
            LastName = last;
            Id = id;    
            Phone = phone;
            BookLimit = limit;
        }
               
        public LibraryUser(string first, string last, string phone, int limit)
        {
            FirstName = first;
            LastName = last;
            Phone = phone;
            BookLimit = limit;
        }

        public string AddBook()
        {
            throw new NotImplementedException();
        }

        public string RemoveBook()
        {
            throw new NotImplementedException();
        }

        public string BookInfo()
        {
            throw new NotImplementedException();
        }

        public int BooksCount()
        {
            throw new NotImplementedException();
        }
        string[] bookList;
    }

    // 3) declare properties: FirstName (read only), LastName (read only), 
    // Id (read only), Phone (get and set), BookLimit (read only)

    // 4) declare field (bookList) as a string array

    

    // 5) declare indexer BookList for array bookList

    // 6) declare constructors: default and parameter

    // 7) declare methods: 

    //AddBook() – add new book to array bookList

    //RemoveBook() – remove book from array bookList

    //BookInfo() – returns book info by index

    //BooksCout() – returns current count of books

}
