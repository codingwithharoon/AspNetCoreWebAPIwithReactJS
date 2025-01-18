import { useEffect, useState } from 'react';
import './App.css';
import Tile from './Components/Tile/Tile';
import { PropertyListing } from './dataType';

function App() {
  const [PropertyListingsResult, setPropertyListingsResult] = useState<PropertyListing[]>([]);

  const fetchPropertyListings = async () => {
    try {
      const response = await fetch('https://localhost:7207/api/PropertyListings');
      if (!response.ok) {
        throw new Error(`HTTP error! Status: ${response.status}`);
      }
      const data: PropertyListing[] = await response.json();
      setPropertyListingsResult(data); // Update state with fetched data
    } catch (error) {
      console.error('Error fetching property listings:', error);
    }
  };

  useEffect(() => {
    fetchPropertyListings();
  }, []);

  return (
    <>
      {PropertyListingsResult.length > 0 ? (
        PropertyListingsResult.map((result) => (
          <Tile 
            key={result.id} // Add a unique key for each Tile component
            type={result.propertyType} 
            value={`PKR ${result.propertyValue}`} 
            info={result.propertyInfo} 
          />
        ))
      ) : (
        <p>No Results</p>
      )}
    </>
  );
}

export default App;
