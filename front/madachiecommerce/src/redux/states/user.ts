import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import { UserInfo } from "../../models";

export const EmptyUserState: UserInfo = {
    id: 0,
    name: ""
}

export const userSlice = createSlice({
    name: "user",
    initialState: EmptyUserState,
    reducers: {
        createUser: (state, action: PayloadAction<UserInfo>) => {state.id = action.payload.id; state.name = action.payload.name},
        updateUser: (state, action) => ({ ...state, ...action.payload}),
        resetUser: () =>  EmptyUserState
    }
});

export const { createUser, updateUser, resetUser} = userSlice.actions;

export default userSlice.reducer;