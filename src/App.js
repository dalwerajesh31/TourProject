
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import {Routes, Route} from 'react-router-dom'

import International from './Component/InternationalComp';
import Home from './Pages/Home';








function App() {
  return (
    <>
    


<Routes>
 <Route  path='/' element={<Home/>} >
  <Route path='internatinal' element={<International/>}/>
  
 </Route>

</Routes>
    </>



  );
}

export default App;
