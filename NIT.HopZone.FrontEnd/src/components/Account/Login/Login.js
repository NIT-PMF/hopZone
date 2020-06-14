import React, { useState } from "react";
import { NavLink } from "react-router-dom";
import "../index.css";
import { useLazyQuery } from "@apollo/react-hooks";
import gql from "graphql-tag";
import { css } from "@emotion/core";
import ClipLoader from "react-spinners/ClipLoader";

const override = css`
  display: block;
  margin: 0 auto;
  border-color: white;
`;

const FIND_USER = gql`
  {
    userByUsername(username: $username) {
      username
      password
    }
  }
`;

const LoginForm = () => {
  const [userForm, setUserForm] = useState({ username: "", password: "" });

  const [search, { loading, data, error }] = useLazyQuery(FIND_USER, {
    variables: { username: userForm.username },
  });

  const handleSubmit = (e) => {
    e.preventDefault();
    search();
    console.log(data);
  };

  const handleChange = (e) => {
    const { name, value } = e.target;
    setUserForm({
      ...userForm,
      [name]: value,
    });
  };

  document.title = "HopZone | Login";

  return (
    <React.Fragment>
      <div className="login-container">
        <div className="App__Aside">
          Welcome Back!
          <div className="App__Aside_Small">
            Type in your information to the right and you will be redirected to
            your profile page.
          </div>
        </div>
        <div className="App__Form">
          <div className="PageSwitcher">
            <NavLink
              to="/account/login"
              activeClassName="PageSwitcher__Item--Active"
              className="PageSwitcher__Item"
            >
              Login
            </NavLink>
            <NavLink
              exact
              to="/account/signup"
              activeClassName="PageSwitcher__Item--Active"
              className="PageSwitcher__Item"
            >
              Sign Up
            </NavLink>
          </div>

          {/*
                <div className="FormTitle">
                    <NavLink to="/account/login" activeClassName="FormTitle__Link--Active" className="FormTitle__Link">Login</NavLink> or <NavLink exact to="/account/signup" activeClassName="FormTitle__Link--Active" className="FormTitle__Link">Sign Up</NavLink>
               </div>
                */}
          <div className="FormCenter">
            <form className="FormFields" onSubmit={handleSubmit}>
              <div className="FormField">
                <label className="FormField__Label" htmlFor="username">
                  Username
                </label>
                <input
                  type="text"
                  id="username"
                  className="FormField__Input"
                  placeholder="ex. David Jones"
                  name="username"
                  onChange={handleChange}
                />
              </div>

              <div className="FormField">
                <label className="FormField__Label" htmlFor="password">
                  Password
                </label>
                <input
                  type="password"
                  id="password"
                  className="FormField__Input"
                  placeholder="Enter your password"
                  name="password"
                  onChange={handleChange}
                />
              </div>

              <div className="FormField">
                <button className="FormField__Button mr-20">
                  <ClipLoader
                    css={override}
                    size={20}
                    color={"#000000"}
                    loading={loading}
                  />
                  {!loading && "Login"}
                </button>
              </div>
              {error && <p style={{ color: "white" }}>{error}</p>}
            </form>
          </div>
        </div>
      </div>
    </React.Fragment>
  );
};

export default LoginForm;
