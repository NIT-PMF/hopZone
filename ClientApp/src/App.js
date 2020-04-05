import React from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import { Navbar, Homepage, AboutPage, Footer, Account } from './components';
import './App.css';

//@material-ui/core za stil (kao bootstrap)

const App = () => {
    return (
        <Router>
            <div className="App">
                <Navbar />
                <Switch>
                    <Route path="/" exact component={Homepage} />
                    <Route path="/about" component={AboutPage} />
                    <Route path="/account" component={Account} />
                </Switch>
            </div>
        </Router>
    )
}

export default App;