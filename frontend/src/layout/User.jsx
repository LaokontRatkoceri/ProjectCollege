import React, { Component } from "react";
import { Route, Routes } from "react-router-dom";
import NotificationSystem from "react-notification-system";
import routes from "../routes.js";
import { Header } from "../components/Navbars/UserNavBar";
import { Footer } from "../components/Footer/Footer";
import { Sidebar } from "../components/Sidebar/Sidebar.jsx";
import { Container, Row, Col } from "react-bootstrap";

class UserLayout extends Component {
  constructor(props) {
    super(props);
    this.state = {
      _notificationSystem: null,
      color: "black",
      hasImage: true,
      fixedClasses: "dropdown show-dropdown open",
      resized: false,
      resizedForComponents: false,
      deviceWidth: 0,
    };
  }

  showAddButton = () => {};

  getRoutes = (routes) => {
    return routes.map((prop, key) => {
      return (
        <Route
          path={prop.layout + prop.path}
          element={prop.element}
          key={key}
        />
      );
    });
  };

  handleImageClick = (image) => {
    this.setState({ image: image });
  };
  handleColorClick = (color) => {
    this.setState({ color: color });
  };
  handleHasImage = (hasImage) => {
    this.setState({ hasImage: hasImage });
  };
  handleFixedClick = () => {
    if (this.state.fixedClasses === "dropdown") {
      this.setState({ fixedClasses: "dropdown show-dropdown open" });
    } else {
      this.setState({ fixedClasses: "dropdown" });
    }
  };

  setResponsiveDesign = () => {
    var deviceWidth = window.innerWidth;
    var notification = this.notificationSystem.current;
    if (deviceWidth == this.state.deviceWidth) {
      return;
    }

    this.setState({
      deviceWidth: deviceWidth,
      resized: true,
      resizedForComponents: false,
    });
  };

  checkToken = () => {
    // if (tokenExists()) {
    //   this.checkToken();
    // } else {
    // }
  };

  logout = () => {
    // deleteToken();
    // this.setState({ loggedIn: false });
  };

  componentDidMount() {
    this.setResponsiveDesign();
    this.checkToken();
    window.addEventListener("resize", this.setResponsiveDesign);
    this.setState({ _notificationSystem: this.refs.notificationSystem });
    var _notificationSystem = this.refs.notificationSystem;
    var color = Math.floor(Math.random() * 4 + 1);
    var level;
    switch (color) {
      case 1:
        level = "success";
        break;
      case 2:
        level = "warning";
        break;
      case 3:
        level = "error";
        break;
      case 4:
        level = "info";
        break;
      default:
        break;
    }
  }

  componentDidUpdate(e) {}

  notificationSystem = React.createRef();
  render() {
    return (
      <div className="wrapper">
        <NotificationSystem ref={this.notificationSystem} />
        <Container fluid>
          <Row>
            <Col xs={2} lg={2} md={2} className="p-0">
              <Sidebar />
            </Col>
            <Col xs={10} md={10} lg={10} className="p-0">
              <Header />
              <Routes>{this.getRoutes(routes)}</Routes>
              <Footer />
            </Col>
          </Row>
        </Container>
      </div>
    );
  }
}

export default UserLayout;
