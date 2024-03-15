import { useEffect, useState } from 'react';
import { Bowlers } from './types/Bowlers';
import { Teams } from './types/Teams';
import { JoinedBowler } from './types/JoinedBowler';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<JoinedBowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5212/bowling');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <br />
        <br />
        <h3 className="text-center">Bowler Info for the Marlins & Sharks</h3>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler First Name</th>
            <th>Bowler Last Name</th>
            <th>Bowler Middle Initial</th>
            <th>Team Name</th>
            <th>Street Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.bowlerID}>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerLastName}</td>
              <td>{b.bowlerMiddleInit}</td>
              <td>{b.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
