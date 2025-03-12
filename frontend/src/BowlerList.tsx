import { useEffect, useState } from 'react';
import { bowler } from './types/bowler';

function BowlerList() {
  const [bowlers, setBowlers] = useState<bowler[]>([]);

  useEffect(() => {
    const fetchBowler = async () => {
      const response = await fetch('https://localhost:5000/BowlingLeague');
      const data = await response.json();
      setBowlers(data);
    };

    fetchBowler();
  }, []);

  return (
    <>
      <table>
        <thead>
          <tr>
            <th>First Name</th>
            <br />
            <th>Middle Name</th>
            <br />
            <th>Last Name</th>
            <br />
            <th>Team</th>
            <br />
            <th>Address</th>
            <br />
            <th>City</th>
            <br />
            <th>State</th>
            <br />
            <th>Zip code</th>
            <br />
            <th>Phone number</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((b) => (
            <tr key={b.bowlerID}>
              <td>{b.bowlerFirstName}</td>
              <br />
              <td>{b.bowlerMiddleInit}</td>
              <br />
              <td>{b.bowlerLastName}</td>
              <br />
              <td>{b.teamName}</td>
              <br />
              <td>{b.bowlerAddress}</td>
              <br />
              <td>{b.bowlerCity}</td>
              <br />
              <td>{b.bowlerState}</td>
              <br />
              <td>{b.bowlerZip}</td>
              <br />
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
