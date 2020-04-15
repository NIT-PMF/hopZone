import React from 'react';
import { NavLink } from 'react-router-dom';
import '../index.css';


const SignupForm = () => {

    document.title = "HopZone | Create Account";

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


                <div className="FormCenter">
                    <form className="FormFields">
                        <div className="FormField">
                            <label className="FormField__Label" htmlFor="name">Full Name</label>
                            <input type="text" id="name" className="FormField__Input" placeholder="Enter your full name" name="name" />
                        </div>
                        <div className="FormField">
                            <label className="FormField__Label" htmlFor="password">Password</label>
                            <input type="password" id="password" className="FormField__Input" placeholder="Enter your password" name="password" />
                        </div>
                        <div className="FormField">
                            <label className="FormField__Label" htmlFor="email">E-Mail Address</label>
                            <input type="email" id="email" className="FormField__Input" placeholder="Enter your email" name="email" />
                        </div>

                        <div className="FormField">
                            <label className="FormField__CheckboxLabel">
                                <input className="FormField__Checkbox" type="checkbox" name="hasAgreed" /> I agree all statements in <a href="" className="FormField__TermsLink">terms of service</a>
                            </label>
                        </div>

                        <div className="FormField">
                            <button className="FormField__Button mr-20">Sign Up</button>
                        </div>
                    </form>
                </div>
            </div>
        </React.Fragment>
    )
}

export default SignupForm;