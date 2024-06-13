import React, { useState, useEffect } from "react";
import "./Mapel.css";
import axios from "axios";
import DataTable from "react-data-table-component";
import "/node_modules/bootstrap/dist/css/bootstrap.min.css";

function DataMapel() {
  //define state
  const [datamapel, setDataMapel] = useState([]);
  //useEffect hook
  useEffect(() => {
    //panggil method "fetchData"
    fectData();
  }, []);
  //function "fetchData"
  const fectData = async () => {
    //fetching
    const response = await axios.get("https://localhost:7190/api/Mapel");
    //get response data
    const data = await response.data;
    //assign response data to state "datamahasiswa"
    setDataMapel(data);
    console.log(data);
  };
  const columns = [
    {
      name: "Id Mapel",
      selector: (row) => row.id_mapel,
      sortable: true,
    },
    {
      name: "Nama Mapel",
      selector: (row) => row.nama_mapel,
      sortable: true,
    },
    {
      name: "NIP",
      selector: (row) => row.nip,
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
          <h2>Data Mapel</h2>
          {/* <Link to="/datamahasiswa_add" className="btn btn-primary">+ Data Mahasiswa</Link> */}
          <DataTable columns={columns} data={datamapel.data} pagination />
        </div>
      </div>
    </div>
  );
}
export default DataMapel;
