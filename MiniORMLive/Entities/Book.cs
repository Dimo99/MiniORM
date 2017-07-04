using System;
using MiniORMLive.Attributes;

namespace MiniORMLive.Entities
{
    [Entity(TableName = "Books")]
    class Book
    {
        [Id]
        private int id;

        [Column(ColumnName = "Title")]
        private string title;

        [Column(ColumnName = "Author")]
        private string author;

        [Column(ColumnName = "PublishedOn")]
        private DateTime publishedOn;

        [Column(ColumnName = "Language")]
        private string language;

        [Column(ColumnName = "IsHardCovered")]
        private bool isHardCovered;

        [Column(ColumnName = "Rating")]
        private decimal rating;

        public Book(string title, string author, DateTime publishedOn, string language, bool isHardCovered, decimal rating)
        {
            Title = title;
            Author = author;
            PublishedOn = publishedOn;
            Language = language;
            IsHardCovered = isHardCovered;
            Rating = rating;
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public DateTime PublishedOn
        {
            get
            {
                return publishedOn;
            }

            set
            {
                publishedOn = value;
            }
        }

        public string Language
        {
            get
            {
                return language;
            }

            set
            {
                language = value;
            }
        }

        public bool IsHardCovered
        {
            get
            {
                return isHardCovered;
            }

            set
            {
                isHardCovered = value;
            }
        }

        public decimal Rating
        {
            get
            {
                return rating;
            }

            set
            {
                if (value < 0 | value > 10)
                {
                    throw new ArgumentException("The rating should be between 0 and 10 inclusive.");
                }

                rating = value;
            }
        }
    }
}
