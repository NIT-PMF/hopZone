import React, { useState, useEffect } from "react";
import ReactMapGL, { Marker, Popup } from "react-map-gl";
import '../index.css'
import gql from 'graphql-tag';
import { useMutation } from '@apollo/react-hooks';

const ADD_SPOT = gql` 
mutation ($spot: SpotInputType!) {
  createSpot(spot: $spot) {
    description
    logitude
    latitude
  }
}
`;


export default function Spot(props) {

  const [addSpot, { loading,error }] = useMutation(ADD_SPOT);
  const [newSpot, setNewSpot] = useState({ description: "", logitude: "", latitude: "" });
  const handleChange = (e) => {
    const { name, value } = e.target;
    console.log(name, value);
    console.log(props.latitude)
    setNewSpot({
      "description": value,
      "latitude": props.latitude,
      "logitude": props.langitude
    });

  };

  const submitChange = e => {
    

    let s = {
      "description": newSpot.description,
      "latitude": props.latitude.toString(),
      "logitude": props.langitude.toString()
    };

    
    addSpot({ variables: { spot: s } });
    setNewSpot({})
  }

    return (

        <div className="overlay-form">

        <div className="FormCenter-map">


          <form className="FormFields-map" onSubmit={submitChange}>
                            <div className="FormField-map">
              <label className="FormField__Label-map">Description:</label>
              <textarea id="email" className="FormField__Input-map" placeholder="Write something about your spot" name="description" onChange={handleChange} required />
                            </div>

                            <div className="FormField-map">
                                <label className="FormField__Label-map">Image for spot</label>
              <input type="file" id="file" className="FormField__Input-map" placeholder="Upload your picture here" name="image" />
                            </div>


                        <div className="FormField-map-lnglat">
              <label className="FormField__Label-map-lnglat">Longitude</label>
              <input type="text" id="file" className="FormField__Input-map-lnglat" value={props.langitude} name="logitude" readOnly />
                        </div>

                        <div className="FormField-map-lnglat">
                            <label className="FormField__Label-map-lnglat">Latitude</label>
              <input type="text" id="file" className="FormField__Input-map-lnglat" value={props.latitude} name="latitude" readOnly />
                        </div>
            <div className="FormField-map">
              <button className="FormField__Button-map mr-20" type="submit"> {loading ? "Loading" : "Post"} </button>
                         </div>
                    </form>

            </div>
        </div>
    );
}
