using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenTest.MovieDB.MovieGenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenTest.MovieDB.MovieGenreRow;

namespace SerenTest.MovieDB
{
    public interface IMovieGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieGenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenreSaveHandler
    {
        public MovieGenreSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}