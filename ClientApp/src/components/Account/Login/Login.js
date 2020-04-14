import React from 'react';
import { NavLink } from 'react-router-dom';
import '../index.css';

const LoginForm = () => {

    return (
        <React.Fragment>
            <div className="App__Aside">Lets get you set up!
                <span className="App__Aside_Small">
                    It should only take a couple of minutes to create your account. <br />
                        You can add additional info about yourself in the profile page :)
                        </span>
            </div>
            <div className="App__Form">
                <div className="PageSwitcher">
                    <NavLink to="/account/login" activeClassName="PageSwitcher__Item--Active" className="PageSwitcher__Item">Login</NavLink>
                    <NavLink exact to="/account/signup" activeClassName="PageSwitcher__Item--Active" className="PageSwitcher__Item">Sign Up</NavLink>
                </div>

                <div className="FormTitle">
                    <NavLink to="/account/login" activeClassName="FormTitle__Link--Active" className="FormTitle__Link">Login</NavLink> or <NavLink exact to="/account/signup" activeClassName="FormTitle__Link--Active" className="FormTitle__Link">Sign Up</NavLink>
                </div>
                <div className="FormCenter">
                    <form className="FormFields">
                        <div className="FormField">
                            <label className="FormField__Label" htmlFor="email">E-Mail Address</label>
                            <input type="email" id="email" className="FormField__Input" placeholder="Enter your email" name="email" />
                        </div>

                        <div className="FormField">
                            <label className="FormField__Label" htmlFor="password">Password</label>
                            <input type="password" id="password" className="FormField__Input" placeholder="Enter your password" name="password" />
                        </div>

                        <div className="FormField">
                            <button className="FormField__Button mr-20"> Login </button>
                        </div>
                    </form>
                </div>
            </div>
        </React.Fragment>
    )
}

export default LoginForm;