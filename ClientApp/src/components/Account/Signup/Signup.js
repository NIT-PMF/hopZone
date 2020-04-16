import React from 'react';
import { NavLink } from 'react-router-dom';
import '../index.css';


const SignupForm = () => {

    document.title = "HopZone | Create Account";

    return (
        <React.Fragment>
            <div className="signup-container">
                <div className="App__Aside">Lets get you set up!
                <div className="App__Aside_Small">
                        It should only take a couple of minutes to create your account. <br />
                        You can add additional info about yourself later in the profile page :)
                        </div>
                </div>
                <div className="App__Form">
                    <div className="PageSwitcher">
                        <NavLink to="/account/login" activeClassName="PageSwitcher__Item--Active" className="PageSwitcher__Item">Login</NavLink>
                        <NavLink exact to="/account/signup" activeClassName="PageSwitcher__Item--Active" className="PageSwitcher__Item">Sign Up</NavLink>
                    </div>


                    <div className="FormCenter">
                        <form className="FormFields">
                            <div className="FormField">
                                <label className="FormField__Label" htmlFor="name">Username</label>
                                <input type="text" className="FormField__Input" placeholder="Enter your username" />
                            </div>
                            <div className="FormField Field_first_last_name">
                                <div className="Form_Name">
                                <label className="FormField__Label" htmlFor="name">First Name</label>
                                    <input type="text" className="FormField__Input" placeholder="Enter your first name" />
                                </div>
                                <div className="Form_Name">
                                    <label className="FormField__Label" htmlFor="name">Last Name</label>
                                    <input type="text" className="FormField__Input" placeholder="Enter your last name" />
                                </div>
                            </div>
                            <div className="FormField">
                                <label className="FormField__Label" htmlFor="email">E-Mail Address</label>
                                <input type="email" className="FormField__Input" placeholder="Enter your email" name="email" />
                            </div>
                            <div className="FormField">
                                <label className="FormField__Label" htmlFor="password">Password</label>
                                <input type="password" className="FormField__Input" placeholder="Enter your password" name="password" />
                            </div>
                            <div className="FormField">
                                <label className="FormField__Label" htmlFor="password">Repeat Password</label>
                                <input type="password" className="FormField__Input" placeholder="Repeat your password" name="password" />
                            </div>

                            <div className="FormField">
                                <div className="FormField__CheckboxLabel">
                                    <input className="FormField__Checkbox" type="checkbox" name="hasAgreed" />
                                    <div className="confirm-checkbox">
                                        I agree all statements in <a href="" className="FormField__TermsLink">terms of service</a>
                                    </div>
                                </div>
                            </div>

                            <div className="FormField">
                                <button className="FormField__Button mr-20">Sign Up</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </React.Fragment>
    )
}

export default SignupForm;