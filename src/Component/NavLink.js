import { NavLink } from "react-router-dom"

export const NavLink1=()=>{
return(
    <div>
        <NavLink to="/">Home </NavLink>
        <NavLink  to="/about"> ABOUT</NavLink>
        <NavLink to="/products">Products</NavLink>
       
    </div>
)

}