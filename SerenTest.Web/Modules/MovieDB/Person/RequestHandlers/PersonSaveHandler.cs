using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenTest.MovieDB.PersonRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenTest.MovieDB.PersonRow;

namespace SerenTest.MovieDB
{
    public interface IPersonSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PersonSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonSaveHandler
    {
        public PersonSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}