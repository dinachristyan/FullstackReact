import React, { Component } from 'react';
import { Link } from "react-router-dom";
import './Menu.css';

class Menu extends Component {
  render() {
    return (
      <div>
        <header className="header">
          <a href="https://www.akscoding.com" className="logo">Kelompok 1</a>
          <input className="menu-btn" type="checkbox" id="menu-btn" />
          <label className="menu-icon" htmlFor="menu-btn">
            <span className="navicon"></span>
          </label>
          <ul className="menu">
           <li><Link to="/">Home</Link></li>
           <li><Link to="/profile">Profile</Link></li>
           <li><Link to="/guru">Data Guru</Link></li>
           <li><Link to="/kelas">Kelas</Link></li>
           <li><Link to="/mapel">Mapel</Link></li>
           {/* <li><Link to="/contact">Contact</Link></li>
           <li><Link to="/dok">Dokumentasi</Link></li>
           <li><Link to="/userlist">List User</Link></li>
           <li><Link to="/master_data">Master Data</Link></li>
           <li><Link to="/trainer">Data Trainer</Link></li> */}
          </ul>
        </header>
      </div>
    );
  }
}

export default Menu;
