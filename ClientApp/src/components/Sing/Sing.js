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
                        <NavLink to="/sing/sing-in" activeClassName="PageSwitcher__Item--Active" className="PageSwitcher__Item">Sign In</NavLink>
                        <NavLink exact to="/sing" activeClassName="PageSwitcher__Item--Active" className="PageSwitcher__Item">Sign Up</NavLink>
                    </div>


                    <div className="FormTitle">
                        <NavLink to="/sing/sing-in" activeClassName="FormTitle__Link--Active" className="FormTitle__Link">Sign In</NavLink> or <NavLink exact to="/sing" activeClassName="FormTitle__Link--Active" className="FormTitle__Link">Sign Up</NavLink>
                    </div>

                    <Route  path="/sing" exact component={SignUpForm}>
                    </Route>
                    <Route path="/sing/sing-in" component={SignInForm}>
                    </Route>
                </div>
            </div>
        </div>
    

    )
}

export default Sing;