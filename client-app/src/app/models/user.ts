export interface User {
    username: string;
    displayName: string;
    token: string;
    image?: string;
}

export interface UserFormValues {
    email?: string;
    emailOrUsername?: string;
    password: string;
    displayName?: string;
    username?: string;
}