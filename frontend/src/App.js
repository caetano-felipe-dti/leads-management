import React from 'react';
import { BrowserRouter as Router, Route, Routes, Navigate } from 'react-router-dom';
import Tabs from './components/Tabs';
import Invited from './pages/Invited';
import Accepted from './pages/Accepted';

const App = () => {
return (
  <Router>
    <Tabs />
    <Routes>
      <Route path="/" element={<Navigate to="/invited" />} />
      <Route path="/invited" element={<Invited />} />
      <Route path="/accepted" element={<Accepted />} />
    </Routes>
  </Router>
);
};

export default App;