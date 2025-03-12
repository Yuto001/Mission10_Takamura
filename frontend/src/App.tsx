import './App.css';
import BowlerList from './BowlerList';

function Header() {
  return (
    <>
      <h1>Bowler Informtion List</h1>
      <p>
        This page shows bowlers' information from Marlines or Sharks team! So,
        if you want to practice with them, you can contact them!
      </p>
    </>
  );
}

function App() {
  return (
    <>
      <Header />
      <BowlerList />
    </>
  );
}

export default App;
