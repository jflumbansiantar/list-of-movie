using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenTest.MovieDB.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenTest.MovieDB.GenreRow;

namespace SerenTest.MovieDB
{
    public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
    {
        public GenreSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}