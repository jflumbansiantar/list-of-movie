using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenTest.MovieDB.Columns
{
    [ColumnsScript("MovieDB.MovieGenre")]
    [BasedOnRow(typeof(MovieGenreRow), CheckNames = true)]
    public class MovieGenreColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int MovieGenreId { get; set; }
        public string MovieTitle { get; set; }
        public string GenreName { get; set; }
    }
}