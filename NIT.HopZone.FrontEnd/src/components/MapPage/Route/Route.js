import React, { useState, useEffect, Component } from "react";
import ReactMapGL, { Marker, Popup } from "react-map-gl";


export default function Route(props) {

    return (
        <div>
            <div className="overlay-form-route">

                <div className="FormCenter-map">
                    <div className="FormFildes-component-row-direction">
                        <div className="FormFields-map">
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
                                <button className="FormField__Button-map mr-20" onClick={() => { props.routeHandler() }}> Post </button>
                            </div>

                        </div>
                        <div className="component-route">
                            <label>Your rout</label>

                            {props.addedRouts.map(m => (
                                <div className="component-added-routs">
                                    <p> {m.longitude}</p>
                                    <button className="FormField__Button-map-delete" onClick={() => { props.deleteHandler(m) }}> Delete </button>
                                </div>
                            ))}
                            <button className="FormField__Button-map-submit" onClick={() => { props.submitHandler() }}> Submit </button>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    );
}