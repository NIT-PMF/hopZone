import React from 'react';
import './index.css';
import { Route, Switch } from 'react-router-dom';
import SignUpForm from './Signup/Signup';
import LoginForm from './Login/Login';
import ProfilePage from './ProfilePage/ProfilePage';

const AccountPage = () => {

    return (
        <div>
            <div className="make-div-app"></div>
            <div className="Apps">
                <Switch>
                    <Route path="/account/signup" exact component={SignUpForm}>
                    </Route>
                    <Route path="/account/login" exact component={LoginForm}>
                    </Route>
                    <Route path="/account/:userID" component={ProfilePage}>
                    </Route>
                </Switch>
            </div>
        </div>
    )
}

export default AccountPage;