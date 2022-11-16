using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenTest.MovieDB.MovieCastRow;

namespace SerenTest.MovieDB
{
    public interface IMovieCastDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastDeleteHandler
    {
        public MovieCastDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}