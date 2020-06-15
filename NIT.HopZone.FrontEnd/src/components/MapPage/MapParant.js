import React, { useState, useEffect } from "react";
import ReactMapGL, { Marker, Popup, Source, Layer } from "react-map-gl";
import Geocoder from 'react-mapbox-gl-geocoder';
import { HashRouter as Router, Route as RouteDom, Link, NavLink } from 'react-router-dom';
import Spot from './Spot/spot';
import Route from './Route/Route';
import './index.css';
import marker_blue from '../../assets/images/marker.svg';
import marker_red from '../../assets/images/marker_red.svg';
import gql from 'graphql-tag';
import { useQuery } from '@apollo/react-hooks';
import { useOktaAuth } from '@okta/okta-react';
import MapPage from './MapPage';


export default function MapParant() {

  const { authState, authService } = useOktaAuth();
  const [userInfo, setUserInfo] = useState("");


  useEffect(() => {
    if (!authState.isAuthenticated) {
      // When user isn't authenticated, forget any user info
      setUserInfo("");
    } else {
      authService.getUser().then((info) => {
        setUserInfo(info);
      });
    }
  }, [authState, authService]); // Update if authState changes

  return (
    <MapPage name={userInfo.name} />
    )
}
