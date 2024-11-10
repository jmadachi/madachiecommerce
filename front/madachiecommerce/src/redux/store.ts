import { configureStore } from "@reduxjs/toolkit";
import userSliceReducer from "./states/user";
import { User } from "../models";

export interface AppStore{ user: User }

export default configureStore<AppStore>({ reducer: { user: userSliceReducer }});