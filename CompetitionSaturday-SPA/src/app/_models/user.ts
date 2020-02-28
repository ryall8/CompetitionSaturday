export interface User {
    id: number;
    username: string;
    knownAs: string;
    age: number;
    creted: Date;
    lastActive: Date;
    photoUrl: string;
    introduction?: string;
}
