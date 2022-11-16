
namespace SerenTest.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieGenreDialog extends Serenity.EntityDialog<MovieGenreRow, any> {
        protected getFormKey() { return MovieGenreForm.formKey; }
        protected getIdProperty() { return MovieGenreRow.idProperty; }
        protected getLocalTextPrefix() { return MovieGenreRow.localTextPrefix; }
        protected getService() { return MovieGenreService.baseUrl; }
        protected getDeletePermission() { return MovieGenreRow.deletePermission; }
        protected getInsertPermission() { return MovieGenreRow.insertPermission; }
        protected getUpdatePermission() { return MovieGenreRow.updatePermission; }

        protected form = new MovieGenreForm(this.idPrefix);

    }
}