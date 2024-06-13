import "./Trainer.css";
import axios from "axios";
import React from "react";
import { useParams } from "react-router-dom";
import { Link } from "react-router-dom";
function TrainerDelete() {
  const { id } = useParams();
  //define state
  const [formValue, setformValue] = React.useState({
    id: "",
    nama: "",
    email: "",
    password: "",
    no_hp: "",
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
        "https://localhost:7190/api/Trainer/Trainer-by-Id?id=" + id
      );

      //get response data
      const data = await response.data;
      //assign response data to state "formValue"
      setformValue(data);
      console.log(data);
    } catch (error) {
      console.log(error);
      alert("Data tidak ditemukan atau sudah dihapus!");
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
    FormDataInput.append("id", formValue.id);
    FormDataInput.append("nama", formValue.nama);
    FormDataInput.append("email", formValue.email);
    FormDataInput.append("password", formValue.password);
    FormDataInput.append("no_hp", formValue.no_hp);
    alert("Data berhasil dihapus");
    try {
      // make axios post request
      const response = await axios({
        method: "delete",
        url: "https://localhost:7190/api/Trainer/Delete-Trainer?id=" + id,
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
        <div className="Titel">Hapus Data Mahasiswa {id}</div>
        <div className="conten">
          <form onSubmit={handleSubmit}>
          <input
              type="text"
              name="id"
              placeholder="enter ID"
              value={formValue.id}
              onChange={handleChange}
            />
            <br />
            <br />
            <input
              type="text"
              name="nama"
              placeholder="enter a Nama"
              value={formValue.nama}
              onChange={handleChange}
            />
            <br />
            <br />
            <input
              type="text"
              name="email"
              placeholder="enter a Email"
              value={formValue.email}
              onChange={handleChange}
            />
            <br />
            <br />
            <input
              type="text"
              name="password"
              placeholder="enter a Password"
              value={formValue.password}
              onChange={handleChange}
            />
            <br />
            <br />
            <input
              type="text"
              name="no_hp"
              placeholder="enter a Nomor"
              value={formValue.no_hp}
              onChange={handleChange}
            />
            <br />
            <br />
            <button type="submit" className="btn btn-danger">
              {" "}
              Hapus
            </button>
            <Link to="/trainer" className="btn btn-secondary">
              Back
            </Link>
          </form>
        </div>
      </div>
    </div>
  );
}
export default TrainerDelete;
