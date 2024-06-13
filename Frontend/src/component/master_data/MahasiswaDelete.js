import "./Mahasiswa.css";
import axios from "axios";
import React from "react";
import { useParams } from "react-router-dom";
function MahasiswaDelete() {
  const { mhs_nim } = useParams();
  //define state
  const [formValue, setformValue] = React.useState({
    mhsNim: "",
    mhsNama: "",
  });
  //useEffect hook
  React.useEffect(() => {
    //panggil method "fetchData"
    fectData();
  }, []);
  //function "fetchData"
  const fectData = async () => {
    try {
      //fetching
      const response = await axios.get(
        "https://localhost:7190/apiMahasiswa/Mahasiswa-By-Nim?mhs_nim=" + mhs_nim
      );

      //get response data
      const data = await response.data;
      //assign response data to state "formValue"
      setformValue(data);
      console.log(data);
    } catch (error) {
      console.log(error);
      // alert("Data tmhs_nimak ditemukan atau sudah dihapus!");
    }
  };
  const handleChange = (event) => {
    setformValue({
      ...formValue,
      [event.target.name]: event.target.value,
    });
  };
  const handleSubmit = async () => {
    // store the states in the form data
    const FormDataInput = new FormData();
    FormDataInput.append("mhsNim", formValue.mhsNim);
    FormDataInput.append("mhsNama", formValue.mhsNama);
    alert("Data berhasil dihapus");
    try {
      // make axios post request
      const response = await axios({
        method: "delete",
        url: "https://localhost:7190/apiMahasiswa/Delete-Mahasiswa?mhs_nim="+ mhs_nim,
        headers: { "Content-Type": "application/json" },
      });
      console.log(response);
    } catch (error) {
      console.log(error);
      alert(error);
    }
  };
  return (
    <div className="card">
      <div className="container">
        <div className="Titel">Hapus Data Mahasiswa {mhs_nim}</div>
        <div className="conten">
          <form onSubmit={handleSubmit}>
            <input
              type="text"
              name="mhsNim"
              placeholder="enter NIM"
              value={formValue.mhsNim}
              onChange={handleChange}
            />
            <br />
            <br />
            <input
              type="text"
              name="mhsNama"
              placeholder="enter a Nama"
              value={formValue.mhsNama}
              onChange={handleChange}
            />
            <br />
            <br />
            <button type="submit" className="btn btn-danger">
              {" "}
              Hapus
            </button>
          </form>
        </div>
      </div>
    </div>
  );
}
export default MahasiswaDelete;
