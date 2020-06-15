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

const GET_SPOTS = gql`
{
  spots{
    id
    description
    logitude
    latitude
  }
}`;



const MAPBOX_TOKEN = 'pk.eyJ1IjoidGFyaWsxMjMiLCJhIjoiY2s4cHY2czYxMGs0ZTNlbmxhcXhlOGZoYiJ9.aulPYqQ5WMIpgqa3w-eXhg'; // Set your mapbox token here




const mapAccess = {
  mapboxApiAccessToken: MAPBOX_TOKEN
};


const queryParams = {

};

const MyInput = (props) => <input {...props} placeholder="Search city here" />





export default function MapPage() {

  const { loading, error, data } = useQuery(GET_SPOTS);


  const markerStyle = {
    transform: 'translate(-50%, -100%)',
    width: '30px'
  }

  const [viewport, setViewport] = useState({
    latitude: 43.8563,
    longitude: 18.4131,
    width: "100vw",
    height: "100vh",
    zoom: 10
  });

  const [oldMarkers, setOldMarkers] = useState([{ key: "0", langitude: 43, latitude: 17 }, { key: "1", langitude: 43, latitude: 18 }])

  const [event, setEvent] = useState({});

  //const oldMarkers = [{ key: 0, langitude: 43, latitude: 17 }, { key: 1, langitude: 43, latitude: 18\
    if (data != null) {
      for (var i = 0; i < data.spots.length; i++) {
        var e = { key: i, latitude: parseFloat(data.spots[i].logitude), langitude: parseFloat(data.spots[i].latitude) };
        oldMarkers.push(e);
        console.log()
      }
    }
 
  const oldRoutMarkers = [
    { key: 0, longitude: 43.89292808086501, latitude: 18.478331323240063 }, { key: 1, longitude: 43.945356108950406, latitude: 18.595747705076015 },

    { key: 2, longitude: 43.98637599443554, latitude: 18.39730715331789 }, { key: 3, longitude: 43.98637599443554, latitude: 18.269591088864743 }
  ];
  const polylineGeoJSON = {
    'type': 'Feature',
    'properties': {},
    'geometry': {
      'type': 'LineString',
      'coordinates': [
        [18.478331323240063, 43.89292808086501],
        [18.595747705076015, 43.945356108950406],
        [18.39730715331789, 43.98637599443554],
        [18.269591088864743, 43.98637599443554]
      ]
    }
  }

  const [markers, setMarkers] = useState([]);

  const [count, setCount] = useState([0, 0]);

  const [routeMarkers, setRoutMarkers] = useState([]);


  useEffect(() => {
  }, [count]);
  useEffect(() => {

  }, [event]);


  const _onClick = (event) => {
    console.log(event);
    setCount(event.lngLat);
    let newElement = {
      key: oldMarkers[oldMarkers.length - 1].key + 1,
      longitude: event.lngLat[1],
      latitude: event.lngLat[0]
    }
    setEvent(event);
    setMarkers([newElement]);
    console.log(markers);
  }

  const onSelected = (viewport, item) => {
    setViewport({
      latitude: viewport.latitude,
      longitude: viewport.longitude,
      width: viewport.width,
      height: viewport.height,
      zoom: 10
    });
    console.log('Selected: ', item, viewport);
  };

  const makeRoute = () => {
    let newElement = {
      key: routeMarkers.length + 1,
      longitude: event.lngLat[1],
      latitude: event.lngLat[0]
    };
    setRoutMarkers([...routeMarkers, newElement]);


  };

  const handler = (marker) => {
    console.log(marker);
    setOldMarkers([...oldMarkers, marker]);

    console.log(oldMarkers);

  }


  const deleteSpotOnRoute = (m) => {
    const key = m.key;

    setRoutMarkers(routeMarkers.filter(item => item.key !== key));
  }

  const submitRoute = () => {
    setRoutMarkers(routeMarkers.filter(item => item.key === 0));
  }


  return (
    <div className="conteiner">


      <ReactMapGL
        {...viewport}
        width="100vw"
        height="100vh"
        mapStyle="mapbox://styles/tarik123/ck8pw5r7917r61iqjvn5knhrt"
        onViewportChange={setViewport}
        mapboxApiAccessToken={MAPBOX_TOKEN}
        doubleClickZoom={false}
        onClick={_onClick}
        className="map"
      >

        <Source id='polylineLayer' type='geojson' data={polylineGeoJSON}>
          <Layer
            id='lineLayer'
            type='line'
            source='my-data'

            paint={{
              'line-color': 'rgba(3, 170, 238, 0.5)',
              'line-width': 5,
            }}
          />
        </Source>

        {oldMarkers.map(m => (
          <Marker key={m.key} latitude={m.langitude} longitude={m.latitude}>

            <input type="image" src={marker_blue} style={markerStyle} />
          </Marker>
        ))}

        {markers.map(m => (
          <Marker key={m.key} latitude={m.longitude} longitude={m.latitude}>

            <input type="image" src={marker_red} style={markerStyle} />
          </Marker>
        ))}


        {routeMarkers.map(m => (
          <Marker key={m.key} latitude={m.longitude} longitude={m.latitude}>

            <input type="image" src={marker_red} style={markerStyle} />
          </Marker>
        ))}


        {oldRoutMarkers.map(m => (
          <Marker key={m.key} latitude={m.longitude} longitude={m.latitude}>

            <input type="image" src={marker_red} style={markerStyle} />
          </Marker>
        ))}

      </ReactMapGL>
      <div className="overlay-nav">
        <div className="PageSwitcher-map">
          <NavLink exact to="/mappage" activeClassName="PageSwitcher__Item-map--Active" className="PageSwitcher__Item-map">Map</NavLink>
          <NavLink to="/mappage/spot" activeClassName="PageSwitcher__Item-map--Active" className="PageSwitcher__Item-map">Spot</NavLink>
          <NavLink to="/mappage/route" activeClassName="PageSwitcher__Item-map--Active" className="PageSwitcher__Item-map">Route</NavLink>

        </div>

      </div>
      <RouteDom path="/mappage/spot/" exact
        render={(props) => <Spot {...props} langitude={count[0]} latitude={count[1]} handler={handler} />}>
      </RouteDom>
      <RouteDom path="/mappage/route" render={(props) => <Route {...props} langitude={count[0]} latitude={count[1]}
        routeHandler={makeRoute} addedRouts={routeMarkers} deleteHandler={deleteSpotOnRoute} submitHandler={submitRoute} />}>
      </RouteDom>

      <Geocoder
        {...mapAccess} onSelected={onSelected} viewport={viewport} hideOnSelect={true}
        queryParams={queryParams} reverseGeocode="true" inputComponent={MyInput}
      />

    </div>


  );

}



