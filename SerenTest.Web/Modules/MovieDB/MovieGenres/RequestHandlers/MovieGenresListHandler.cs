﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenTest.MovieDB.MovieGenresRow>;
using MyRow = SerenTest.MovieDB.MovieGenresRow;

namespace SerenTest.MovieDB
{
    public interface IMovieGenresListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieGenresListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresListHandler
    {
        public MovieGenresListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}