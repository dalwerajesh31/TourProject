import { useNavigate } from "react-router-dom"

export  const  Home=()=>{
    const navigate = useNavigate()


return(
    <>
    <div> Home Page Bro</div>
   <button onClick={ ()=>{navigate('order-summary',{replace: true})} } > Order Placed</button>
    
    </>
)

}