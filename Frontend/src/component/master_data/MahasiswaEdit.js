import "./Mahasiswa.css";
import axios from "axios";
import React from "react";
import { useParams } from "react-router-dom";
function MahasiswaEdit() {
	const { mhs_nim } = useParams();
	//define state
	const [formValue, setformValue] = React.useState({
		mhs_nim: "",
		mhs_nama: "",
	});
	//useEffect hook
	React.useEffect(() => {
		//panggil method "fetchData"
		fetchData();
	}, []);
	//function "fetchData"
	const fetchData = async () => {
		//fetching
		const response = await axios.get(
			"https://localhost:7190/apiMahasiswa/Mahasiswa-By-Nim?mhs_nim=" + mhs_nim
		);
		//get response data
		const data = await response.data;

		
    const firstData = data[0];
		const secData = data[0];

    const mhsNim = firstData.mhs_nim;
    const mhsNama = secData.mhs_nama;
		//assign response data to state "formValue"
		setformValue({
      mhs_nim: mhsNim,
			mhs_nama: mhsNama,
		});
		console.log(data);
	};
	const handleChange = (event) => {
		setformValue({
			...formValue,
			[event.target.name]: event.target.value,
		});
	};
	const handleSubmit = async (event) => {
		event.preventDefault();
		// store the states in the form data
		const FormDataInput = new FormData();
		FormDataInput.append("mhs_nim", formValue.mhs_nim);
		FormDataInput.append("mhs_nama", formValue.mhs_nama);
		try {
			// make axios post request
			const response = await axios({
				method: "put",
				url: "https://localhost:7190/apiMahasiswa/Update-mahasiswa?mhs_nim="+mhs_nim,

				data: FormDataInput,
				headers: { "Content-Type": "application/json" },
			});
			console.log(response);
			alert("Data berhasil diubah");

			window.location.href = "/datamahasiswa";
		} catch (error) {
			console.log(error);
			alert(error);
		}
	};
	return (
		<div className="card">
			<div className="container">
				<div className="Titel">Edit Data Mahasiswa {mhs_nim}</div>
				<div className="conten">
					<form onSubmit={handleSubmit}>
						<input
							type="text"
							name="mhs_nim"
							placeholder="enter NIM"
							value={formValue.mhs_nim}
							onChange={handleChange}
						/>
						<br />
						<br />
						<input
							type="text"
							name="mhs_nama"
							placeholder="enter a Nama"
							value={formValue.mhs_nama}
							onChange={handleChange}
						/>
						<br />
						<br />
						<button type="submit" className="btn btn-primary">
							Simpan
						</button>
					</form>
				</div>
			</div>
		</div>
	);
}
export default MahasiswaEdit;