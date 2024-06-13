import React, { Component } from 'react';
import './Home.css';
import IMG from './ayano.png';

class Home extends Component {
  render() {
    return (
      <div className="card">
        <div className="container">
          <div className="Titel">
           
          </div>
          <div className="content">
            <h3>Selamat Datang Di Sekolah Tadika Mesra</h3>
            <br></br>
          </div>
          <img src={IMG} alt="gweh banget cuy" /> 
        </div>
      </div>
    );
  }
}

export default Home;
