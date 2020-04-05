import React from 'react';
import './index.css';
import { HashRouter as Router, Route, Link, NavLink } from 'react-router-dom';
import SignUpForm from './Signup/Signup';
import LoginForm from './Login/Login';


const Sing = () => {

    return (
        <div>
        <div className="make-div-app"></div>
        <div className="Apps">
            <div className="App__Aside"></div>
                <div className="App__Form">
                    <div className="PageSwitcher">
                        <NavLink to="/account/login" activeClassName="PageSwitcher__Item--Active" className="PageSwitcher__Item">Login</NavLink>
                        <NavLink exact to="/account/signup" activeClassName="PageSwitcher__Item--Active" className="PageSwitcher__Item">Sign Up</NavLink>
                    </div>


                    <div className="FormTitle">
                        <NavLink to="/account/login" activeClassName="FormTitle__Link--Active" className="FormTitle__Link">Login</NavLink> or <NavLink exact to="/account/signup" activeClassName="FormTitle__Link--Active" className="FormTitle__Link">Sign Up</NavLink>
                    </div>

                    <Route  path="/account/signup" exact component={SignUpForm}>
                    </Route>
                    <Route path="/account/login" component={LoginForm}>
                    </Route>
                </div>
            </div>
        </div>
    

    )
}

export default Sing;