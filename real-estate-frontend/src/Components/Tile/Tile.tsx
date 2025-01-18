import reactLogo from '../../assets/react.svg'

type Props = 
{
  type : string,
  value : string,
  info : string
}
const Tile = ({type,value,info}:Props) => {
  return (
    <div className="tile">
        <img src={reactLogo} alt="img" />
        <div className='info'>
            <h2>{type}</h2>
            <p>{value}</p>
        </div>
        <div className='infoDetail'>
           {info}
        </div>
    </div>
  )
}

export default Tile