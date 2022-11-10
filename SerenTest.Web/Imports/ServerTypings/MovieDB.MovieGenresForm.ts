﻿namespace SerenTest.MovieDB {
    export interface MovieGenresForm {
        Title: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Storyline: Serenity.StringEditor;
        Year: Serenity.IntegerEditor;
        ReleaseDate: Serenity.DateEditor;
        Runtime: Serenity.IntegerEditor;
        Kind: Serenity.IntegerEditor;
        GenreId: Serenity.IntegerEditor;
    }

    export class MovieGenresForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.MovieGenres';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieGenresForm.init)  {
                MovieGenresForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(MovieGenresForm, [
                    'Title', w0,
                    'Description', w0,
                    'Storyline', w0,
                    'Year', w1,
                    'ReleaseDate', w2,
                    'Runtime', w1,
                    'Kind', w1,
                    'GenreId', w1
                ]);
            }
        }
    }
}
