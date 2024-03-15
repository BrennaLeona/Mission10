import React from 'react';
import './App.css';
import Header from './header';
import BowlerList from './BowlerList';
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <div>
      <Header title="Bowling League" />
      <BowlerList />
    </div>
  );
}

export default App;
