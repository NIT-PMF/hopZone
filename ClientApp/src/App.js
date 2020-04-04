import React from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import { Navbar, Homepage, AboutPage, Footer } from './components';
import './App.css';

//@material-ui/core za stil (kao bootstrap)

const App = () => {
    return (
        <Router>
            <div className="App">
                <Navbar />
                <Switch>
                    <Route path="/" exact component={Homepage} />
                    <Route path="/About" component={AboutPage} />
                </Switch>
            </div>
        </Router>
    )
}

export default App;