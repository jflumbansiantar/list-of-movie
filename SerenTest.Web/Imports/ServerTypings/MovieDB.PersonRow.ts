namespace SerenTest.MovieDB {
    export interface PersonRow {
        PersonId?: number;
        FirstName?: string;
        Lastname?: string;
        BirthDate?: string;
        BirthPlace?: string;
        Gender?: Gender;
        Height?: number;
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'FirstName';
        export const localTextPrefix = 'MovieDB.Person';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            PersonId = "PersonId",
            FirstName = "FirstName",
            Lastname = "Lastname",
            BirthDate = "BirthDate",
            BirthPlace = "BirthPlace",
            Gender = "Gender",
            Height = "Height"
        }
    }
}
