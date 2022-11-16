namespace SerenTest.MovieDB {
    export interface MovieGenreForm {
        MovieId: Serenity.IntegerEditor;
        GenreId: Serenity.IntegerEditor;
    }

    export class MovieGenreForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.MovieGenre';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieGenreForm.init)  {
                MovieGenreForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;

                Q.initFormType(MovieGenreForm, [
                    'MovieId', w0,
                    'GenreId', w0
                ]);
            }
        }
    }
}
