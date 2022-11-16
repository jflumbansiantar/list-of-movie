using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenTest.MovieDB.MovieGenreRow>;
using MyRow = SerenTest.MovieDB.MovieGenreRow;

namespace SerenTest.MovieDB
{
    public interface IMovieGenreListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieGenreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenreListHandler
    {
        public MovieGenreListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}