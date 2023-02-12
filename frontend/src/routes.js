import React, { Component } from "react";
import { Dashboard } from "./views/Dashboard";
import { EnrollmentPage } from "./views/EnrollmentPage";
import { Home } from "./views/Home";
import { Login } from "./views/Login";

const dashboardRoutes = [
  {
    path: "",
    name: "Dashboard",
    icon: "pe-7s-graph",
    element: <Home />,
    layout: "/",
  },
  {
    path: "",
    name: "Dashboard",
    icon: "pe-7s-graph",
    element: <Dashboard />,
    layout: "/dashboard",
  },
  {
    path: "",
    name: "Dashboard",
    icon: "pe-7s-graph",
    element: <EnrollmentPage />,
    layout: "/enroll",
  },
  // {
  //   path: "",
  //   name: "Dashboard",
  //   icon: "pe-7s-graph",
  //   element: <PaymentPage />,
  //   layout: "/payment",
  // },
];

export default dashboardRoutes;
