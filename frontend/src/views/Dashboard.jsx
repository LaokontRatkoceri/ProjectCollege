import React, { Component, useEffect } from "react";
import { useState } from "react";
import { Button, Card, Col, Container, Row, Tab, Table } from "react-bootstrap";
import { useSelector, useDispatch } from "react-redux";
import CanvasJSReact from "../assets/extraScripts/canvasjs.react";
import { applicantsList } from "../temp/users";
import Avatar from "@mui/material/Avatar";
import { Link } from "react-router-dom";

const CanvasJS = CanvasJSReact.CanvasJS;
const CanvasJSChart = CanvasJSReact.CanvasJSChart;
const imageFace1 = require("../assets/img/faces/face1.jpg");
const imageFace2 = require("../assets/img/faces/face2.jfif");
const imageFace3 = require("../assets/img/faces/face3.jpg");
const images = [imageFace1, imageFace2, imageFace3];
export const Dashboard = () => {
  const { user } = useSelector((state) => state.user);
  const [applicants, setApplicants] = useState(applicantsList);
  const options = {
    title: {
      text: "",
    },
    axisY: {
      title: "Numri aplikuesve",
      valueFormatString: "0", // move comma to change formatting
    },
    data: [
      {
        type: "column",
        dataPoints: [
          { label: "2017", y: 50 },
          { label: "2018", y: 110 },
          { label: "2019", y: 170 },
          { label: "2021", y: 180 },
          { label: "2022", y: 200 },
        ],
      },
    ],
  };

  useEffect(() => {
    console.log(123);
    console.log(user);
  }, []);
  return (
    <Container className="mt-5 mb-5">
      <Row className="height-70-vh overflow-hidden">
        <Col md={6} xs={12}>
          <Card>
            <Card.Body className="h-inherit">
              <Card.Title>Registred applicants: 200</Card.Title>
              <CanvasJSChart
                options={options}
                /* onRef = {ref => this.chart = ref} */
              />
            </Card.Body>
          </Card>
        </Col>
        <Col md={6} xs={12} className="h-inherit">
          <Card className="h-inherit">
            <Card.Body className="h-inherit">
              <Card.Title>Applicants in the process: 50</Card.Title>
              <Container className="p-0 h-inherit overflow-auto">
                <Table striped hover className="">
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Aplikuesi</th>
                      <th>Emaili</th>
                      <th>Telefoni</th>
                    </tr>
                  </thead>
                  <tbody>
                    {applicants.map((applicant, index) => {
                      return (
                        <tr key={index}>
                          <td>
                            <Avatar alt="Remy Sharp" src={images[index % 3]} />
                          </td>
                          <td>
                            {applicant.name} {applicant.lastName}
                          </td>
                          <td>{applicant.email}</td>
                          <td>{applicant.phone}</td>
                        </tr>
                      );
                    })}
                  </tbody>
                </Table>
              </Container>
            </Card.Body>
          </Card>
        </Col>
      </Row>
      <Row className="mt-4">
        <Col md={4} xs={4}>
          <Card>
            <Card.Body>
              <Link to={"/manage"} className="btn btn-primary col-12">
                <h4>Menaxho procesin</h4>
              </Link>
            </Card.Body>
          </Card>
        </Col>
        <Col md={4} xs={4}>
          <Card>
            <Card.Body>
              <Link to={"/statistics"} className="col-12 btn btn-primary">
                <h4>Shiko statistikat</h4>
              </Link>
            </Card.Body>
          </Card>
        </Col>
        <Col md={4} xs={4}>
          <Card>
            <Card.Body>
              <Link to={"/"} className="col-12 btn btn-primary">
                <h4>Somrething</h4>
              </Link>
            </Card.Body>
          </Card>
        </Col>
      </Row>
    </Container>
  );
};
