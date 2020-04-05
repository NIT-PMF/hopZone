import React from 'react';
import './index.css';
import { HashRouter as Router, Route, Link, NavLink } from 'react-router-dom';
import SignUpForm from './Singup/Singup';
import SignInForm from './Singin/Singin';


const Sing = () => {

    return (
        <div>
        <div className="make-div-app"></div>
        <div className="Apps">
            <div className="App__Aside"></div>
                <div className="App__Form">
                    <div className="PageSwitcher">
                        <NavLink to="/account/sign-in" activeClassName="PageSwitcher__Item--Active" className="PageSwitcher__Item">Sign In</NavLink>
                        <NavLink exact to="/account" activeClassName="PageSwitcher__Item--Active" className="PageSwitcher__Item">Sign Up</NavLink>
                    </div>


                    <div className="FormTitle">
                        <NavLink to="/account/sign-in" activeClassName="FormTitle__Link--Active" className="FormTitle__Link">Sign In</NavLink> or <NavLink exact to="/account" activeClassName="FormTitle__Link--Active" className="FormTitle__Link">Sign Up</NavLink>
                    </div>

                    <Route  path="/account" exact component={SignUpForm}>
                    </Route>
                    <Route path="/account/sign-in" component={SignInForm}>
                    </Route>
                </div>
            </div>
        </div>
    

    )
}

export default Sing;