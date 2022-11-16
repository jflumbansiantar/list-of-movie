using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenTest.MovieDB.Forms
{
    [FormScript("MovieDB.MovieGenre")]
    [BasedOnRow(typeof(MovieGenreRow), CheckNames = true)]
    public class MovieGenreForm
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}