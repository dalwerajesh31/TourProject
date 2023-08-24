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
import SubSector from './Component/SubSector';
import SubCatName from './Component/SubCatName';
import PackageMaster from './Component/PackageMaster';



const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>

    <BrowserRouter>

      <Routes>
         < Route path='/' element={<App />} >
          <Route path='/' element={<Home />} />
          <Route path='/about' element={<About />} />
          <Route path='/registration' element={<RegFormComp />} />
          <Route path='/mylink' element={<About />} />
          <Route path="/bycatId/:catId" element={<SubSector />} /> 
          <Route path="/bysubcatId/:subCatId" element={<SubCatName />} /> 
          <Route path="/bypkgId/:catMasterId" element={<PackageMaster />} /> 
        
          
        </Route>

          
         
      

       
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);


reportWebVitals();
