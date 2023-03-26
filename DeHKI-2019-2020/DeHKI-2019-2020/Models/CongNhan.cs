using System;
namespace DeHkI_2019_2020.Models
{
	public class CongNhan
	{
		string maCongNhan;
		string tenCongNhan;
		bool gioiTinh;
		int namSinh;
		string nuocVe;
		string maDiemCachLy;

		public CongNhan() { }

		public CongNhan(string maCongNhan, string tenCongNhan, bool gioiTinh, int namSinh, string nuocVe)
		{
			this.maCongNhan = maCongNhan;
			this.tenCongNhan = tenCongNhan;
			this.gioiTinh = gioiTinh;
			this.namSinh = namSinh;
			this.nuocVe = nuocVe;
		}

		public string MaCongNhan
		{
			get => maCongNhan;
			set => maCongNhan = value;
		}

        public string TenCongNhan
        {
            get => tenCongNhan;
            set => tenCongNhan = value;
        }

        public bool GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public string NuocVe
        {
            get => nuocVe;
            set => nuocVe = value;
        }
    }
}

