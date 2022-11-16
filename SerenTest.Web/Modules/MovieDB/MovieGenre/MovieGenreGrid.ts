
namespace SerenTest.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieGenreGrid extends Serenity.EntityGrid<MovieGenreRow, any> {
        protected getColumnsKey() { return MovieGenreColumns.columnsKey; }
        protected getDialogType() { return MovieGenreDialog; }
        protected getIdProperty() { return MovieGenreRow.idProperty; }
        protected getInsertPermission() { return MovieGenreRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieGenreRow.localTextPrefix; }
        protected getService() { return MovieGenreService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}