import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [portfolois, setPortfolois] = useState();

    useEffect(() => {
        populatePortfolois();
    }, []);

    const contents = portfolois === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <th>Firm ID</th>
                    <th>Name</th>
                    <th>Currency</th>
                    <th>Status</th>
                    <th>Client Type</th>
                </tr>
            </thead>
            <tbody>
                {portfolois.map(portfolo =>
                    <tr key={portfolo.FirmId}>
                        <td>{portfolo.Name}</td>
                        <td>{portfolo.Currency}</td>
                        <td>{portfolo.Status}</td>
                        <td>{portfolo.ClientType}</td>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <div>
            <h1 id="tabelLabel">Summary Portfolio</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {contents}
        </div>
    );
    
    async function populatePortfolois() {
        const response = await fetch('https://localhost:7169/api/Summary');
        const data = await response.json();
        setPortfolois(data);
    }
}

export default App;