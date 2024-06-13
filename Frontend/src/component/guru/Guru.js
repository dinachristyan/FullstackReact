import React, { useState, useEffect } from "react";
import "./Guru.css";
import axios from "axios";
import DataTable from "react-data-table-component";
import "/node_modules/bootstrap/dist/css/bootstrap.min.css";

function DataGuru() {
  //define state
  const [dataguru, setDataguru] = useState([]);
  //useEffect hook
  useEffect(() => {
    //panggil method "fetchData"
    fectData();
  }, []);
  //function "fetchData"
  const fectData = async () => {
    //fetching
    const response = await axios.get("https://localhost:7190/api/Guru");
    //get response data
    const data = await response.data;
    //assign response data to state "datamahasiswa"
    setDataguru(data);
    console.log(data);
  };
  const columns = [
    {
      name: "NIP",
      selector: (row) => row.nip,
      sortable: true,
    },
    {
      name: "Nama Guru",
      selector: (row) => row.nama_guru,
      sortable: true,
    },
    // {
    //   name: 'Ubaah',
    //   selector: row => <Link to={"/datamahasiswa_edit/"+row.mhs_nim}
      
    //   className="btn btn-primary">Edit</Link>,
      
    //   sortable: true
    //   },
    //   {
    //   name: 'Hapus',
    //   selector: row => <Link to={"/datamahasiswa_delete/"+row.mhs_nim}
      
    //   className="btn btn-danger">Delete</Link>,
      
    //   sortable: true
    //   },
  ];
  return (
    <div className="card">
      <div className="container">
        <div className="Titel"></div>
        <div className="conten">
          <h2>Data Guru</h2>
          {/* <Link to="/datamahasiswa_add" className="btn btn-primary">+ Data Mahasiswa</Link> */}
          <DataTable columns={columns} data={dataguru.data} pagination />
        </div>
      </div>
    </div>
  );
}
export default DataGuru;
