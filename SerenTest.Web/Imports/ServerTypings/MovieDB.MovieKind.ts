namespace SerenTest.MovieDB {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'SerenTest.MovieDB.MovieKind', 'MovieDB.MovieKind');
}
