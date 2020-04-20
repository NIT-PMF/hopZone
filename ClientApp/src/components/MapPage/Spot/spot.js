import React, { useState, useEffect } from "react";
import ReactMapGL, { Marker, Popup } from "react-map-gl";
import '../index.css'

export default function Spot(props) {


    return (

        <div className="overlay-form">

            <div className="FormCenter-map">

                    <form className="FormFields-map">
                            <div className="FormField-map">
                                <label className="FormField__Label-map">Description:</label>
                                <textarea id="email" className="FormField__Input-map" placeholder="Write something about your spot" name="email" />
                            </div>

                            <div className="FormField-map">
                                <label className="FormField__Label-map">Image for spot</label>
                                <input type="file" id="file" className="FormField__Input-map" placeholder="Uplode your picture here" name="image" />
                            </div>


                        <div className="FormField-map-lnglat">
                            <label className="FormField__Label-map-lnglat">Longitude</label>
                            <input type="text" id="file" className="FormField__Input-map-lnglat" value={props.langitude} name="longitude" readOnly />
                        </div>

                        <div className="FormField-map-lnglat">
                            <label className="FormField__Label-map-lnglat">Latitude</label>
                            <input type="text" id="file" className="FormField__Input-map-lnglat" value={props.latitude} name="latitude" readOnly />
                        </div>
                        <div className="FormField-map">
                        <button className="FormField__Button-map mr-20"> Post </button>
                         </div>
                    </form>

            </div>
        </div>
    );
}