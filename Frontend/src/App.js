import './App.css';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Menu from './component/menu/Menu';
import Profile from './component/profile/Profile';
import Home from './component/home/Home';
import UserList from './views/UserList'
import DataMahasiswa from './component/master_data/Mahasiswa'
import DataMahasiswaAdd from './component/master_data/MahasiswaAdd'
import DataTrainerAdd from './component/trainer/TrainerAdd'
import DataMahasiswaEdit from './component/master_data/MahasiswaEdit'
import DataTrainerEdit from './component/trainer/TrainerEdit'
import DataMahasiswaDelete from './component/master_data/MahasiswaDelete'
import DataTrainerDelete from './component/trainer/TrainerDelete'
import DataTrainer from './component/trainer/Trainer'
import Guru from './component/guru/Guru'
import Kelas from './component/kelas/Kelas'
import Mapel from './component/mapel/Mapel'


function App() {
  return (
    <Router >
 
    <div className="app-header">
          <Menu />
    </div>
    <div  className="app-content">
<Routes>
  <Route path="/" element={<Home/>}> </Route>
  <Route path="/profile" element={<Profile/>}  />
  <Route path="/userlist" element={<UserList/>}  />
  <Route path="/master_data" element={<DataMahasiswa/>} />
  <Route path="/datamahasiswa_add" element={<DataMahasiswaAdd/>} />
  <Route path="/datatrainer_add" element={<DataTrainerAdd/>} />
  <Route path="/datamahasiswa_edit/:mhs_nim" element={<DataMahasiswaEdit/>} />
  <Route path="/datatrainer_edit/:id" element={<DataTrainerEdit/>} />
  <Route path="/datamahasiswa_delete/:mhs_nim" element={<DataMahasiswaDelete/>} />
  <Route path="/datatrainer_delete/:id" element={<DataTrainerDelete/>} />
  <Route path="/trainer" element={<DataTrainer/>} />
  <Route path="/guru" element={<Guru/>} />
  <Route path="/kelas" element={<Kelas/>} />
  <Route path="/mapel" element={<Mapel/>} />
</Routes>


    </div>
    </Router>

  );
}
export default App;