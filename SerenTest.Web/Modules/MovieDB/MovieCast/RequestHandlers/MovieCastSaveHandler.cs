using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenTest.MovieDB.MovieCastRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenTest.MovieDB.MovieCastRow;

namespace SerenTest.MovieDB
{
    public interface IMovieCastSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastSaveHandler
    {
        public MovieCastSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}