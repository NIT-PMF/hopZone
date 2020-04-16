import React, { Component } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { Navbar, Homepage, AboutPage, Contact, Account } from './components';
// import { renderRoutes } from 'react-router-config';
//import './App.scss';
import './App.css';

const loading = () => <div className="animated fadeIn pt-3 text-center">Loading...</div>;

// Containers
const DefaultLayout = React.lazy(() => import('./AdminPage/containers/DefaultLayout'));

// Pages
const Login = React.lazy(() => import('./AdminPage/views/Pages/Login'));
const Register = React.lazy(() => import('./AdminPage/views/Pages/Register'));
const Page404 = React.lazy(() => import('./AdminPage/views/Pages/Page404'));
const Page500 = React.lazy(() => import('./AdminPage/views/Pages/Page500'));

const App = () => {
  const isHeaderRoute = (!window.location.pathname.includes('admin'))

  return (
    < BrowserRouter >
      <div className="App">
        { isHeaderRoute && <Navbar /> }
          
        <React.Suspense fallback={loading()}>
          <Switch>
            <Route path="/" exact component={Homepage} />
            <Route path="/about" component={AboutPage} />
            <Route path="/account" component={Account} />
            <Route path="/contact" exact component={Contact}></Route>
            <Route exact path="/admin/login" name="Login Page" render={props => <Login {...props} />} />
            <Route exact path="/admin/register" name="Register Page" render={props => <Register {...props} />} />
            <Route exact path="/404" name="Page 404" render={props => <Page404 {...props} />} />
            <Route exact path="/500" name="Page 500" render={props => <Page500 {...props} />} />
            <Route path="/admin" name="Home" render={props => <DefaultLayout {...props} />} />
          </Switch>
        </React.Suspense>
      </div>
    </BrowserRouter >
  )
}

export default App;
