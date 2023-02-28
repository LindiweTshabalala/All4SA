export interface User {
    userID: number,
    firstName: string | undefined,
    surname: string | undefined,
    idNumber: string | undefined,
    token: string | undefined,
    isDeleted: boolean | undefined
}