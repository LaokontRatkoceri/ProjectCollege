import React, { Component } from "react";
import logo from "./logo.svg";
import ReactDOM from "react-dom";
import store from "store";
import "./index.css";
import reportWebVitals from "./reportWebVitals";
import "bootstrap/dist/css/bootstrap.min.css";
import { BrowserRouter, Route, Routes, Navigate } from "react-router-dom";
import "./assets/css/style.css";
import "./assets/css/customStyle.css";
import UserLayout from "./layout/User";

import "./App.css";
import { Login } from "./views/Login";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/login" element={<Login />} />
        <Route path="/*" element={<UserLayout />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
