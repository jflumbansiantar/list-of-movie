﻿using Serenity.ComponentModel;
using System;

namespace SerenTest.Administration.Forms
{
    [ColumnsScript("Administration.Language")]
    [BasedOnRow(typeof(Entities.LanguageRow), CheckNames = true)]
    public class LanguageColumns
    {
        [EditLink]
        public String LanguageId { get; set; }
        [EditLink]
        public String LanguageName { get; set; }
    }
}