using Serenity.ComponentModel;
using System.ComponentModel;

namespace SerenTest.MovieDB
{
    [EnumKey("MovieDB.MovieKind")]
    public enum MovieKind
    {
        [Description("Film")]
        Film = 1,
        [Description("TvSeries")]
        TvSeries = 2,
        [Description("MiniSeries")]
        MiniSeries = 3
    }
}