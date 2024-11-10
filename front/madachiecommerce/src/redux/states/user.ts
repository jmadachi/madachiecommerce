import { createSlice } from "@reduxjs/toolkit";
import { User } from "../../models";
import { deleteLocalStorage, saveLocalStorage } from "../../tools";

export const EmptyUserState: User = {
    id: 0,
    name: ""
}

export const userKey = 'user';

export const userSlice = createSlice({
    name: "user",
    initialState: localStorage.getItem('user') ? JSON.parse(localStorage.getItem('user') as string) : EmptyUserState,
    reducers: {
        createUser: (state, action) => {
            console.log(state);
            saveLocalStorage<User>(userKey, action.payload);
            return action.payload;
        },
        updateUser: (state, action) => {
            const result = { ...state, ...action.payload};
            saveLocalStorage(userKey, result);
            return result;
        },
        resetUser: () =>  {
            deleteLocalStorage(userKey);
            return EmptyUserState;
        }
    }
});

export const { createUser, updateUser, resetUser} = userSlice.actions;

export default userSlice.reducer;