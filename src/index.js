import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import 'bootstrap/dist/css/bootstrap.min.css';
import { BrowserRouter } from 'react-router-dom';
import { Routes, Route } from 'react-router-dom'
import Home from './Pages/Home';
import About from './Pages/About';
import RegFormComp from './Component/RegFormComp';
<<<<<<< HEAD
import SubSector from './Component/SubSector';
import SubCatName from './Component/SubCatName';
import PackageMaster from './Component/PackageMaster';

=======
import Login from './Component/Login';
import PlaceDetailsComponent from './Component/PlaceDetailsComponent';
>>>>>>> 7f1fb131005e3d3bb380152f65649f3d6d75db10


const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>

    <BrowserRouter>

      <Routes>
         < Route path='/' element={<App />} >
          <Route path='/' element={<Home />} />
          <Route path='/about' element={<About />} />
          <Route path='/registration' element={<RegFormComp />} />
<<<<<<< HEAD
          <Route path='/mylink' element={<About />} />
          <Route path="/bycatId/:catId" element={<SubSector />} /> 
          <Route path="/bysubcatId/:subCatId" element={<SubCatName />} /> 
          <Route path="/bypkgId/:catMasterId" element={<PackageMaster />} /> 
        
          
=======
          <Route path='international' element={<International />} />
          <Route path='domestic' element={<Domestic />} />
          <Route path='Login' element={<Login/>} />
          <Route path='PlacedetailsComponent' element={<PlaceDetailsComponent/>} />
>>>>>>> 7f1fb131005e3d3bb380152f65649f3d6d75db10
        </Route>

          
         
      

       
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);


reportWebVitals();
