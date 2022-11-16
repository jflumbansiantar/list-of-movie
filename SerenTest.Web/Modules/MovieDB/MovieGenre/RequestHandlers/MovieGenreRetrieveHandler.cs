using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenTest.MovieDB.MovieGenreRow>;
using MyRow = SerenTest.MovieDB.MovieGenreRow;

namespace SerenTest.MovieDB
{
    public interface IMovieGenreRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieGenreRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenreRetrieveHandler
    {
        public MovieGenreRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}