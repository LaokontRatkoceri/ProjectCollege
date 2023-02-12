import { createSlice, configureStore } from "@reduxjs/toolkit";
var defaultUser = {
  id: 0,
  name: "",
  lastName: "",
  email: "",
};

const userSlice = createSlice({
  name: "user",
  initialState: {
    user: defaultUser,
  },
  reducers: {
    saveUser: (state, action) => {
      const user = action.payload;
      state.user = user;
    },
    logout: (state) => {
      state.user = defaultUser;
    },
  },
});
export const { saveUser, logout } = userSlice.actions;
export default userSlice.reducer;
