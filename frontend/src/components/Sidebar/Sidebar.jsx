import React, { Component } from "react";
import { Image, Nav } from "react-bootstrap";
import { useDispatch } from "react-redux";
import { Link, useNavigate } from "react-router-dom";
import { logout } from "../../redux/userSlice";

const img = require("../../assets/img/Ubtlogo.png");
export const Sidebar = (props) => {
  let navigate = useNavigate();
  const dispatch = useDispatch();
  return (
    <Nav
      className=" d-none d-md-block bg-light sidebar"
      activeKey="/home"
      onSelect={(selectedKey) => alert(`selected ${selectedKey}`)}
    >
      <Nav.Item className="flex justify-content-center">
        <Nav.Link onClick={() => navigate("/")}>
          <Image src={img} alt="YFE logo" height={100} width={100} />
        </Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link onClick={() => navigate("/dashboard")}>Dashboard</Nav.Link>
      </Nav.Item>
      <Nav.Item>
        <Nav.Link
          onClick={() => {
            dispatch(logout());
            navigate("/login");
          }}
        >
          Logout
        </Nav.Link>
      </Nav.Item>
    </Nav>
  );
};
