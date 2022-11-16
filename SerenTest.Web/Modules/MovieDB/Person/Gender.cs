﻿using Serenity.ComponentModel;
using System.ComponentModel;

namespace SerenTest.MovieDB
{
    [EnumKey("MovieDB.Gender")]
    public enum Gender
    {
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2
    }
}