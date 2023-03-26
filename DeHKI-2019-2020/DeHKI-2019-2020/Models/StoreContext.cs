using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace DeHkI_2019_2020.Models
{
	public class StoreContext
	{
		public string ConnectionString
		{
			get;
			set;
		}

		public StoreContext(string connectionString)
		{
			this.ConnectionString = connectionString;
		}

		private MySqlConnection GetConnection()
		{
			return new MySqlConnection(ConnectionString);
		}

		public void ThemDCL(DiemCachLy dcl)
		{
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();
				string str = "INSERT INTO DIEMCACHLY VALUES (@MaDiemCachLy,@TenDiemCachLy,@DiaChi)";
				MySqlCommand cmd = new MySqlCommand(str, conn);
				cmd.Parameters.AddWithValue("MaDiemCachLy", dcl.MaDiemCachLy);
				cmd.Parameters.AddWithValue("TenDiemCachLy", dcl.TenDiemCachLy);
				cmd.Parameters.AddWithValue("DiaChi", dcl.DiaChi);
				cmd.ExecuteNonQuery();
            }
		}

		public List<object> LietKeTC(int soTC)
		{
			List<object> list = new List<object>();
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();
				string str = "SELECT C.MaCongNhan, TenCongNhan, NamSinh, NuocVe, COUNT(*) FROM CONGNHAN C, CN_TC T WHERE C.MaCongNhan = T.MaCongNhan GROUP BY C.MaCongNhan, TenCongNhan, NamSinh, NuocVe HAVING COUNT(*) >= @sotc";
				MySqlCommand cmd = new MySqlCommand(str, conn);
				cmd.Parameters.AddWithValue("sotc", soTC);
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var obj = new
						{
							MaCongNhan = reader[0].ToString(),
							TenCongNhan = reader[1].ToString(),
							NamSinh = Convert.ToInt32(reader[2]),
							NuocVe = reader[3].ToString(),
							SoTC = Convert.ToInt32(reader[4])
						};
						list.Add(obj);
					}
				}
			}	
			return list;
		}

        public List<DiemCachLy> getAllDCL()
		{
            List<DiemCachLy> list = new List<DiemCachLy>();
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();
				string str = "SELECT MaDiemCachLy, TenDiemCachLy FROM DIEMCACHLY";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
				{
                    while (reader.Read())
					{
						DiemCachLy dcl = new DiemCachLy()
						{
							MaDiemCachLy = reader[0].ToString(),
							TenDiemCachLy = reader[1].ToString()
						};
						list.Add(dcl);
                    }	
                }
            }	
            return list;
        }

		public List<CongNhan> getCN(string MaDiemCachLy)
		{
            List<CongNhan> list = new List<CongNhan>();
            using (MySqlConnection conn = GetConnection())
			{
				conn.Open();
                string str = "SELECT MaCongNhan, TenCongNhan FROM CongNhan WHERE MaDiemCachLy = @MaDCL";
                MySqlCommand cmd = new MySqlCommand(str, conn);
				cmd.Parameters.AddWithValue("MaDCL", MaDiemCachLy);
                using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						CongNhan cn = new CongNhan()
						{
							MaCongNhan = reader[0].ToString(),
							TenCongNhan = reader[1].ToString()
						};
						list.Add(cn);
					}
                }
            }
            return list;
        }

		public int deleteCN(string MaCongNhan)
		{
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "DELETE FROM CN_TC WHERE MaCongNhan=@macn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macn", MaCongNhan);
                cmd.ExecuteNonQuery();

                str = "DELETE FROM CONGNHAN WHERE MaCongNhan=@macn";
                cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macn", MaCongNhan);
                return(cmd.ExecuteNonQuery());
            }
        }

        public CongNhan viewCN(string MaCongNhan)
        {
            CongNhan cn = new CongNhan();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "SELECT * FROM CongNhan WHERE MaCongNhan = @macn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macn", MaCongNhan);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cn.MaCongNhan = reader[0].ToString();
                        cn.TenCongNhan = reader[1].ToString();
                        cn.GioiTinh = (Boolean)reader[2];
                        cn.NamSinh = Convert.ToInt32(reader[3]);
                        cn.NuocVe = reader[4].ToString();
                    }
                }
            }
            return cn;
        }

    }
}

