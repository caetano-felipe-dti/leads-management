import React from 'react';
import { NavLink } from 'react-router-dom';

const Tabs = React.memo(() => {
console.log('Componente Tabs renderizado'); // Log para depuração

return (
  <nav className="tabs">
    <NavLink 
      to="/invited" 
      className={({ isActive }) => (isActive ? 'tab active-tab' : 'tab')}
    >
      Invited
    </NavLink>
    <NavLink 
      to="/accepted" 
      className={({ isActive }) => (isActive ? 'tab active-tab' : 'tab')}
    >
      Accepted
    </NavLink>
  </nav>
);
});

export default Tabs;