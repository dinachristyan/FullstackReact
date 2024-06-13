using System.Data;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

public class DbManager
{
    private readonly string connectionString;
    private readonly MySqlConnection _connection;
    public DbManager(IConfiguration configuration)
    {
        connectionString = configuration.GetConnectionString("DefaultConnection");
        _connection = new MySqlConnection(connectionString);
    }
    
    public List<Guru> GetAllgurus()
    {
        List<Guru> guruList = new List<Guru>();
        try{
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM guru";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Guru guru = new Guru
                        {
                            
                             nip = Convert.ToInt32(reader["nip"]),
                            nama_guru = reader["nama_guru"].ToString(),
                            
                        };
                        guruList.Add(guru);
                    }
                }
            }
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        } return guruList;
    }
    public List<Kelas> GetAllKelas()
    {
        List<Kelas> kelasList = new List<Kelas>();
        try{
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM kelas";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kelas kelas = new Kelas
                        {
                            
                             id_kelas = Convert.ToInt32(reader["id_kelas"]),
                            nama_kelas = reader["nama_Kelas"].ToString(),
                            
                        };
                        kelasList.Add(kelas);
                    }
                }
            }
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        } return kelasList;
    }
     public List<Mapel> GetAllMapel()
    {
        List<Mapel> mapelList = new List<Mapel>();
        try{
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT id_mapel, nama_mapel, nip  FROM mapel";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Mapel Mapel = new Mapel
                        {
                            
                             id_mapel = Convert.ToInt32(reader["id_Mapel"]),
                            nama_mapel = reader["nama_Mapel"].ToString(),
                            nip = Convert.ToInt32(reader["nip"]),
                        };
                        mapelList.Add(Mapel);
                    }
                }
            }
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        } return mapelList;
    }
    // public List<Mahasiswa> GetAllMahasiswas()
    // {
    //     List<Mahasiswa> mahasiswaList = new List<Mahasiswa>();
    //     try{
    //         using (MySqlConnection connection = new MySqlConnection(connectionString))
    //         {
    //             string query = "SELECT * FROM ms_mahasiswa";
    //             MySqlCommand command = new MySqlCommand(query, connection);
    //             connection.Open();
    //             using (MySqlDataReader reader = command.ExecuteReader())
    //             {
    //                 while (reader.Read())
    //                 {
    //                     Mahasiswa mahasiswa = new Mahasiswa
    //                     {
                            
    //                         mhs_nim = reader["mhs_nim"].ToString(),
    //                         mhs_nama = reader["mhs_nama"].ToString(),
                            
    //                     };
    //                     mahasiswaList.Add(mahasiswa);
    //                 }
    //             }
    //         }
    //     } catch (Exception ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //     } return mahasiswaList;
    // }
    // public List<Trainer> GetAllTrainer()
    // {
    //     List<Trainer> trainerList = new List<Trainer>();
    //     try{
    //         using (MySqlConnection connection = new MySqlConnection(connectionString))
    //         {
    //             string query = "SELECT * FROM trainer";
    //             MySqlCommand command = new MySqlCommand(query, connection);
    //             connection.Open();
    //             using (MySqlDataReader reader = command.ExecuteReader())
    //             {
    //                 while (reader.Read())
    //                 {
    //                     Trainer trainer = new Trainer
    //                     {
    //                          id = Convert.ToInt32(reader["Id"]),
    //                         nama = reader["nama"].ToString(),
    //                         email = reader["email"].ToString(),
    //                         password = reader["password"].ToString(),
    //                         no_hp = reader["no_hp"].ToString(),
                            
    //                     };
    //                     trainerList.Add(trainer);
    //                 }
    //             }
    //         }
    //     } catch (Exception ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //     } return trainerList;
    // }

    // public class IndeksMahasiswaInfo
    // {
    //     public string? mhs_nim { get; set; }
    //     public string? mhs_nama { get; set; }
    // }
    // public List<IndeksMahasiswaInfo> GetIndeksMahasiswaByNim(string mhs_nim)
    // {
    //     List<IndeksMahasiswaInfo> indeksMahasiswaList = new List<IndeksMahasiswaInfo>();
    //     try
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "SELECT * FROM ms_mahasiswa WHERE mhs_nim = ?";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@mhs_nim", mhs_nim);
    //                 connection.Open();
    //                 using (MySqlDataReader reader = command.ExecuteReader())
    //                 {
    //                     while (reader.Read())
    //                     {
    //                         IndeksMahasiswaInfo info = new IndeksMahasiswaInfo
    //                         {
    //                             mhs_nim = reader["mhs_nim"].ToString(),
    //                             mhs_nama = reader["mhs_nama"].ToString()
    //                         };
    //                         indeksMahasiswaList.Add(info);
    //                     }
    //                 }
    //             }
    //         }
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //     }
    //     return indeksMahasiswaList;
    // }
    // public class IndeksTrainerInfo
    // {
    //      public int id { get; set; }
    // public string? nama { get; set; } 
    // public string? email { get; set; } 
    // public string? password { get; set; } 
    // public string? no_hp { get; set; }
    // }
    // public List<IndeksTrainerInfo> GetIndeksTrainerById(int id)
    // {
    //     List<IndeksTrainerInfo> indeksTrainerList = new List<IndeksTrainerInfo>();
    //     try
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "SELECT * FROM trainer WHERE id = ?";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@id", id);
    //                 connection.Open();
    //                 using (MySqlDataReader reader = command.ExecuteReader())
    //                 {
    //                     while (reader.Read())
    //                     {
    //                         IndeksTrainerInfo info = new IndeksTrainerInfo
    //                         {
    //                             id = Convert.ToInt32(reader["id"]),
    //                         nama = reader["nama"].ToString(),
    //                         email = reader["email"].ToString(),
    //                         password = reader["password"].ToString(),
    //                         no_hp = reader["no_hp"].ToString(),
                            
    //                         };
    //                         indeksTrainerList.Add(info);
    //                     }
    //                 }
    //             }
    //         }
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //     }
    //     return indeksTrainerList;
    // }
    //     public int CreateMahasiswa(Mahasiswa mahasiswa)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "INSERT INTO ms_mahasiswa (mhs_nim, mhs_nama) VALUES (@mhs_nim, @mhs_nama)";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@mhs_nim", mahasiswa.mhs_nim);
    //                  command.Parameters.AddWithValue("@mhs_nama", mahasiswa.mhs_nama);
                     

    //                     connection.Open();
    //                     return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //  public int UpdateMahasiswa(string mhs_nim, Mahasiswa mahasiswa)
    // {
    //     using (MySqlConnection connection = _connection)
    //     {
    //         string query = "UPDATE ms_mahasiswa SET mhs_nama = @mhs_nama WHERE mhs_nim = @mhs_nim";

            
    //         using (MySqlCommand command = new MySqlCommand(query, connection))
    //         {
    //             command.Parameters.AddWithValue("@mhs_nama", mahasiswa.mhs_nama);
    //             command.Parameters.AddWithValue("@mhs_nim", mhs_nim);

    //                 connection.Open();
    //                 return command.ExecuteNonQuery();
    //         }
    //     }
    // }
    // public int DeleteMahasiswa(string mhs_nim)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "DELETE FROM ms_mahasiswa WHERE mhs_nim = @mhs_nim";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@mhs_nim", mhs_nim);
    //                 connection.Open();
    //                 return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //     ///trainerr
    //     public int CreateTrainer(Trainer trainer)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "INSERT INTO trainer (id, nama, email, password, no_hp) VALUES (@id, @nama, @email, @password, @no_hp)";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                         command.Parameters.AddWithValue("@id", trainer.id);
    //                         command.Parameters.AddWithValue("@nama", trainer.nama);
    //                         command.Parameters.AddWithValue("@email", trainer.email);
    //                         command.Parameters.AddWithValue("@password", trainer.password);
    //                         command.Parameters.AddWithValue("@no_hp", trainer.no_hp);
                            
                     

    //                     connection.Open();
    //                     return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //  public int UpdateTrainer(int id, Trainer trainer)
    // {
    //     using (MySqlConnection connection = _connection)
    //     {
    //         string query = "UPDATE trainer SET nama = @nama, email = @email, password = @password, no_hp = @no_hp WHERE id = @Id";

            
    //         using (MySqlCommand command = new MySqlCommand(query, connection))
    //         {

    //                       command.Parameters.AddWithValue("@nama", trainer.nama);
    //                         command.Parameters.AddWithValue("@email", trainer.email);
    //                         command.Parameters.AddWithValue("@password", trainer.password);
    //                         command.Parameters.AddWithValue("@no_hp", trainer.no_hp);
    //                         command.Parameters.AddWithValue("@Id", id);
    //                 connection.Open();
    //                 return command.ExecuteNonQuery();
    //         }
    //     }
    // }
    // public int DeleteTrainer(int id)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "DELETE FROM trainer WHERE id = @id";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@id", id);
    //                 connection.Open();
    //                 return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
   
    //     public int CreateMahasiswa(Mahasiswa trainer)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "INSERT INTO trainer (nama, email, password, nohp, status) VALUES (@Nama, @Email, @Password, @NoHp, @Status)";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@Nama", trainer.nama);
    //                  command.Parameters.AddWithValue("@Email", trainer.email);
    //                   command.Parameters.AddWithValue("@Password", trainer.password);
    //                    command.Parameters.AddWithValue("@NoHp", trainer.nohp);
    //                     command.Parameters.AddWithValue("@Status", trainer.status);

    //                     connection.Open();
    //                     return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //     public int UpdateTrainer(int id, Trainer trainer)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "UPDATE trainer SET nama = @Nama, email = @Email, password = @Password, nohp = @NoHp,status =  @Status WHERE id = @Id";

    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@Nama", trainer.nama);
    //                  command.Parameters.AddWithValue("@Email", trainer.email);
    //                   command.Parameters.AddWithValue("@Password", trainer.password);
    //                    command.Parameters.AddWithValue("@NoHp", trainer.nohp);
    //                     command.Parameters.AddWithValue("@Status", trainer.status);
    //                 command.Parameters.AddWithValue("@Id", id);

    //                     connection.Open();
    //                     return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //     public int DeleteTrainer(int id)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "DELETE FROM trainer WHERE id = @Id";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@Id", id);
    //                 connection.Open();
    //                 return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //     public List<Peserta> GetAllPesertas()
    //     {
    //         List<Peserta> PesertaList = new List<Peserta>();
    //         try{
    //             using (MySqlConnection connection = new MySqlConnection(connectionString))
    //             {
    //                 string query = "SELECT * FROM peserta";
    //                 MySqlCommand command = new MySqlCommand(query, connection);
    //                 connection.Open();
    //                 using (MySqlDataReader reader = command.ExecuteReader())
    //                 {
    //                     while (reader.Read())
    //                     {
    //                         Peserta Peserta = new Peserta
    //                         {
    //                             id = Convert.ToInt32(reader["Id"]),
    //                             nama = reader["Nama"].ToString(),
    //                             asal = reader["Asal"].ToString(),
    //                             tanggal_lahir = reader.GetDateTime(reader.GetOrdinal("tanggal_lahir")),
    //                             email = reader["Email"].ToString(),
    //                             password = reader["Password"].ToString(),

    //                             status = Convert.ToInt32(reader["Status"])
    //                         };
    //                         PesertaList.Add(Peserta);
    //                     }
    //                 }
    //             }
    //         } catch (Exception ex)
    //         {
    //             Console.WriteLine(ex.Message);
    //         } return PesertaList;
    //     }
    //     public int CreatePeserta(Peserta Peserta)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "INSERT INTO Peserta (nama, asal, tanggal_lahir, email, password, status) VALUES (@Nama, @Asal, @tanggal_lahir, @Email, @Password, @Status)";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@Nama", Peserta.nama);
    //                 command.Parameters.AddWithValue("@Asal", Peserta.asal);
    //                  command.Parameters.AddWithValue("@tanggal_lahir", Peserta.tanggal_lahir);
    //                   command.Parameters.AddWithValue("@Email", Peserta.email);
    //                    command.Parameters.AddWithValue("@Password", Peserta.password);
    //                     command.Parameters.AddWithValue("@Status", Peserta.status);

    //                     connection.Open();
    //                     return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //     public int UpdatePeserta(int id, Peserta Peserta)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "UPDATE Peserta SET nama = @Nama, asal = @Asal, tanggal_lahir = @Tanggal_lahir, email = @Email, password = @Password, status =  @Status WHERE id = @Id";

    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@Nama", Peserta.nama);
    //                  command.Parameters.AddWithValue("@Asal", Peserta.asal);
    //                   command.Parameters.AddWithValue("@tanggal_lahir", Peserta.tanggal_lahir);
    //                    command.Parameters.AddWithValue("@Email", Peserta.email);
    //                     command.Parameters.AddWithValue("@Password", Peserta.password);
    //                 command.Parameters.AddWithValue("@Status", Peserta.status);
    //                 command.Parameters.AddWithValue("@Id", id);

    //                     connection.Open();
    //                     return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //     public int DeletePeserta(int id)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "DELETE FROM Peserta WHERE id = @Id";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@Id", id);
    //                 connection.Open();
    //                 return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //     public List<Materi> GetAllMateris()
    //     {
    //         List<Materi> MateriList = new List<Materi>();
    //         try{
    //             using (MySqlConnection connection = new MySqlConnection(connectionString))
    //             {
    //                 string query = "SELECT * FROM materi";
    //                 MySqlCommand command = new MySqlCommand(query, connection);
    //                 connection.Open();
    //                 using (MySqlDataReader reader = command.ExecuteReader())
    //                 {
    //                     while (reader.Read())
    //                     {
    //                         Materi materi = new Materi
    //                         {
    //                             id = Convert.ToInt32(reader["Id"]),
    //                             nama = reader["nama"].ToString(),
    //                             deskripsi = reader["deskripsi"].ToString(),
    //                             trainer = Convert.ToInt32(reader["trainer"])


    //                         };
    //                         MateriList.Add(materi);
    //                     }
    //                 }
    //             }
    //         } catch (Exception ex)
    //         {
    //             Console.WriteLine(ex.Message);
    //         } return MateriList;
    //     }
    //     public int CreateMateri(Materi materi)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "INSERT INTO Materi (nama, deskripsi, trainer) VALUES (@Nama, @Deskripsi, @Trainer)";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@nama", materi.nama);
    //                 command.Parameters.AddWithValue("@deskripsi", materi.deskripsi);

    //                 command.Parameters.AddWithValue("@trainer", materi.trainer);


    //                     connection.Open();
    //                     return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //     public int UpdateMateri(int id, Materi materi)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "UPDATE materi SET nama = @nama, deskripsi = @deskripsi, trainer = @trainer  WHERE id = @Id";

    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@nama", materi.nama);
    //                  command.Parameters.AddWithValue("@deskripsi", materi.deskripsi);
    //                   command.Parameters.AddWithValue("@trainer", materi.trainer);

    //                 command.Parameters.AddWithValue("@Id", id);

    //                     connection.Open();
    //                     return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //     public int DeleteMateri(int id)
    //     {
    //         using (MySqlConnection connection = _connection)
    //         {
    //             string query = "DELETE FROM materi WHERE id = @Id";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@Id", id);
    //                 connection.Open();
    //                 return command.ExecuteNonQuery();
    //             }
    //         }
    //     }
    //     public List<Nilai> GetAllNilai()
    //     {
    //         List<Nilai> nilaiList = new List<Nilai>();
    //         try {
    //             using (MySqlConnection connection = new MySqlConnection(connectionString))
    //             {
    //                 string query = "SELECT * FROM Nilai";
    //                 MySqlCommand command = new MySqlCommand(query, connection);
    //                 connection.Open();
    //                 using (MySqlDataReader reader = command.ExecuteReader())
    //                 {
    //                     while (reader.Read())
    //                     {
    //                         Nilai nilai = new Nilai
    //                         {
    //                             id = Convert.ToInt32(reader["Id"]),
    //                             peserta = Convert.ToInt32(reader["peserta"]),
    //                             materi = Convert.ToInt32(reader["materi"]),
    //                             nilai = Convert.ToInt32(reader["nilai"]),
    //                             indeks = reader["indeks"].ToString(),
    //                         };
    //                         nilaiList.Add(nilai);
    //                     }
    //                 }
    //             }
    //         }catch (Exception ex)
    //         {
    //             Console.WriteLine(ex.Message);
    //         }
    //         return nilaiList;
    //     }
    //     public class IndeksNilaiInfo
    //     {
    //         public string? Nama { get; set; }
    //         public string? Indeks { get; set; }
    //     }

    //     public List<IndeksNilaiInfo> GetIndeksNilaiByMateri(int materiId)
    //     {
    //         List<IndeksNilaiInfo> indeksNilaiList = new List<IndeksNilaiInfo>();
    //         try
    //         {
    //             using (MySqlConnection connection = _connection)
    //             {
    //                 string query = @"SELECT peserta.Nama AS NamaPeserta, nilai.indeks 
    //                                 FROM nilai 
    //                                 INNER JOIN peserta ON nilai.peserta = peserta.id 
    //                                 WHERE nilai.materi = @MateriId";
    //                 using (MySqlCommand command = new MySqlCommand(query, connection))
    //                 {
    //                     command.Parameters.AddWithValue("@MateriId", materiId);
    //                     connection.Open();
    //                     using (MySqlDataReader reader = command.ExecuteReader())
    //                     {
    //                         while (reader.Read())
    //                         {
    //                             IndeksNilaiInfo info = new IndeksNilaiInfo
    //                             {
    //                                 Nama = reader["NamaPeserta"].ToString(),
    //                                 Indeks = reader["indeks"].ToString()
    //                             };
    //                             indeksNilaiList.Add(info);
    //                         }
    //                     }
    //                 }
    //             }
    //         }
    //         catch (Exception ex)
    //         {
    //             Console.WriteLine(ex.Message);
    //         }
    //         return indeksNilaiList;
    //     }

    //     public List<IndeksNilaiInfo> GetIndeksNilaiByPeserta(int pesertaId)
    //     {
    //         List<IndeksNilaiInfo> indeksNilaiList = new List<IndeksNilaiInfo>();
    //         try
    //         {
    //             using (MySqlConnection connection = _connection)
    //             {
    //                 string query = @"SELECT materi.Nama AS NamaMateri, nilai.indeks 
    //                                 FROM nilai 
    //                                 INNER JOIN materi ON nilai.materi = materi.id 
    //                                 WHERE nilai.peserta = @PesertaId";
    //                 using (MySqlCommand command = new MySqlCommand(query, connection))
    //                 {
    //                     command.Parameters.AddWithValue("@PesertaId", pesertaId);
    //                     connection.Open();
    //                     using (MySqlDataReader reader = command.ExecuteReader())
    //                     {
    //                         while (reader.Read())
    //                         {
    //                             IndeksNilaiInfo info = new IndeksNilaiInfo
    //                             {
    //                                 Nama = reader["NamaMateri"].ToString(),
    //                                 Indeks = reader["indeks"].ToString()
    //                             };
    //                             indeksNilaiList.Add(info);
    //                         }
    //                     }
    //                 }
    //             }
    //         }
    //         catch (Exception ex)
    //         {
    //             Console.WriteLine(ex.Message);
    //         }
    //         return indeksNilaiList;
    //     }
    //     public int CreateNilai(Nilai nilai)
    //     {
    //        using (MySqlConnection connection = new MySqlConnection(connectionString))
    //         {
    //             if (nilai.nilai >= 85)
    //             {
    //                 nilai.indeks = "A";
    //             } else if (nilai.nilai >= 70)
    //             {
    //               nilai.indeks = "B";
    //             } else if (nilai.nilai >= 60)
    //             {
    //               nilai.indeks = "C";
    //             } else if (nilai.nilai >= 40)
    //             {
    //               nilai.indeks = "D";
    //             } else if (nilai.nilai >= 0)
    //             {
    //               nilai.indeks = "E";
    //             } else {
    //                 nilai.indeks = "NA";
    //             }
    //             string query = "INSERT INTO nilai (peserta, materi, nilai, indeks) VALUES (@peserta, @materi, @nilai, @indeks)";
    //             using (MySqlCommand command = new MySqlCommand (query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@peserta", nilai.peserta);
    //                 command.Parameters.AddWithValue("@materi", nilai.materi);
    //                 command.Parameters.AddWithValue("@nilai", nilai.nilai);
    //                 command.Parameters.AddWithValue("@indeks", nilai.indeks);
    //            connection.Open();
    //             return command.ExecuteNonQuery();
    //             }

    //          }
    //     }
    //     public int GetNilai(Nilai nilai)
    //     {
    //         int count = 0;
    //        using (MySqlConnection connection = new MySqlConnection(connectionString))
    //         {
    //             string query = "SELECT count(*) AS count FROM Nilai WHERE peserta = @Peserta AND materi = @Materi";
    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@Peserta", nilai.peserta);
    //                 command.Parameters.AddWithValue("@Materi", nilai.materi);
    //                 connection.Open();
    //                 using (MySqlDataReader reader = command.ExecuteReader())
    //                 {
    //                     while (reader.Read())
    //                     {
    //                         count = Convert.ToInt32(reader["count"]);
    //                     }
    //                 }
    //             }
    //         } return count;
    //     }
    //      public int UpdateNilai(Nilai nilai)
    //     {
    //        using (MySqlConnection connection = new MySqlConnection(connectionString))
    //         {
    //             if (nilai.nilai >= 85)
    //             {
    //                 nilai.indeks = "A";
    //             } else if (nilai.nilai >= 70)
    //             {
    //               nilai.indeks = "B";
    //             } else if (nilai.nilai >= 60)
    //             {
    //               nilai.indeks = "C";
    //             } else if (nilai.nilai >= 40)
    //             {
    //               nilai.indeks = "D";
    //             } else if (nilai.nilai >= 0)
    //             {
    //               nilai.indeks = "E";
    //             } else {
    //                 nilai.indeks = "NA";
    //             }
    //             string query = "UPDATE nilai SET nilai = @Nilai, indeks = @Indeks WHERE peserta = @Peserta AND materi = @Materi";

    //             using (MySqlCommand command = new MySqlCommand(query, connection))
    //             {
    //                 command.Parameters.AddWithValue("@Peserta", nilai.peserta);
    //                 command.Parameters.AddWithValue("@Materi", nilai.materi);
    //                 command.Parameters.AddWithValue("@Nilai", nilai.nilai);
    //                 command.Parameters.AddWithValue("@Indeks", nilai.indeks);
    //            connection.Open();
    //            try {
    //             return command.ExecuteNonQuery();
    //            } catch (MySqlException ex)
    //            {
    //             Console.WriteLine($"Error updating nilai: {ex.Message}");
    //             return -1;
    //            }
    //             }

    //          }

    //     }


}
