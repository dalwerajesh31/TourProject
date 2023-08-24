
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Slider from './Component/Slider';
import { Outlet } from 'react-router-dom';
import Header from './Component/Header';
import Footer from './Component/Footer';
import Crawling from './Component/Crawling';


<<<<<<< HEAD


=======
>>>>>>> 7f1fb131005e3d3bb380152f65649f3d6d75db10
function App() {
  return (
    <>
      <Header />
      <Slider />
      <div> <Crawling/></div>
      
     
      <Outlet />
      <Footer />
      
    </>



  );
}

export default App;
