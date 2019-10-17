using System;

namespace MandatoryAssignmentTask1
{
    public class Book
    {
        //Instance Field
        private String _title;
        private int _pageNumber;
        private String _isbn13;
        //Properties
        public string Title {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Characters should be more than two !! ");
                }

                _title = value;
            }


        }
        public String Author { get; set; }

        public int PageNumber
        {
            get
            {
                return _pageNumber;
            }
            set
            {
                if (value < 10 && value >= 1000)
                {
                    throw new ArgumentException("Page number should be greater than 10 and smaller or euals to 1000 ");
                }

                _pageNumber = value;
            }
        }

        public string Isbn13
        {
            get
            {
                return _isbn13;
            }
            set
            {
                if (value.Length == 13)
                {
                    _isbn13 = value;
                }

                else throw new Exception("it should contain 13 characters");
            }

        }
        public Book()
            {
                    }

        public Book(string title, int pageNumber, string isbn13, string author)
        {
            _title = title;
            _pageNumber = pageNumber;
            _isbn13 = isbn13;
            Author = author;
        }

        public override string ToString()
        {
            return $"title:{_title}, pagenumber:{_pageNumber}, author:{Author},Isnm13:{_isbn13} ";
        }

    }
    
}
