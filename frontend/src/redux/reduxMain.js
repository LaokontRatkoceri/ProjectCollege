import { createSlice, configureStore } from "@reduxjs/toolkit";
import userReducer from "./userSlice";
import tokenReducer from "./tokenSlice";

export const rootReducer = configureStore({
  reducer: {
    user: userReducer,
    token: tokenReducer,
  },
});
