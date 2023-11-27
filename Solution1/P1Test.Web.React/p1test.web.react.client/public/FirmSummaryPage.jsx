import React from 'react';

class FirmSummaryPage extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            firmSummaries: [], // Initialize an empty array to store FirmSummary objects
        };
    }

    // Fetch data when the component mounts
    componentDidMount() {
        // Replace the URL with the actual endpoint to fetch FirmSummary data
        fetch('api/Summary')
            .then(response => response.json())
            .then(data => this.setState({ firmSummaries: data }));
    }

    render() {
        return (
            <div>
                <h2>Firm Summary</h2>
                <table border="1">
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
                        {this.state.firmSummaries.map(firm => (
                            <tr key={firm.firmId}>
                                <td>{firm.firmId}</td>
                                <td>{firm.name}</td>
                                <td>{firm.currency}</td>
                                <td>{firm.status}</td>
                                <td>{firm.clientType}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>
        );
    }
}

export default FirmSummaryPage;
