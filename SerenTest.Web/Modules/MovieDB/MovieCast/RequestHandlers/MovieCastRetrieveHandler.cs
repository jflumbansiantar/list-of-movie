using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenTest.MovieDB.MovieCastRow>;
using MyRow = SerenTest.MovieDB.MovieCastRow;

namespace SerenTest.MovieDB
{
    public interface IMovieCastRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastRetrieveHandler
    {
        public MovieCastRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}