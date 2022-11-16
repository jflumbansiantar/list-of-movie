using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenTest.MovieDB.MovieGenreRow;

namespace SerenTest.MovieDB
{
    public interface IMovieGenreDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieGenreDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenreDeleteHandler
    {
        public MovieGenreDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}