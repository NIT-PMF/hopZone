import React from 'react';
import '../index.css';


const SignupForm = () => {
    
    return (
        <div className="FormCenter">
            <form className="FormFields">
                <div className="FormField">
                    <label className="FormField__Label" htmlFor="name">Full Name</label>
                    <input type="text" id="name" className="FormField__Input" placeholder="Enter your full name" name="name" />
                </div>
                <div className="FormField">
                    <label className="FormField__Label" htmlFor="password">Password</label>
                    <input type="password" id="password" className="FormField__Input" placeholder="Enter your password" name="password" />
                </div>
                <div className="FormField">
                    <label className="FormField__Label" htmlFor="email">E-Mail Address</label>
                    <input type="email" id="email" className="FormField__Input" placeholder="Enter your email" name="email" />
                </div>

                <div className="FormField">
                    <label className="FormField__CheckboxLabel">
                        <input className="FormField__Checkbox" type="checkbox" name="hasAgreed"/> I agree all statements in <a href="" className="FormField__TermsLink">terms of service</a>
                    </label>
                </div>

                <div className="FormField">
                    <button className="FormField__Button mr-20">Sign Up</button>
                </div>
            </form>
        </div>
        )
}

export default SignupForm;