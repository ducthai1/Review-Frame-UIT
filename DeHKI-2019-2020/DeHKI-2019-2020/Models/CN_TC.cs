using System;
namespace DeHkI_2019_2020.Models
{
	public class CN_TC
	{
		string maCongNhan, maTrieuChung;
		public CN_TC()
		{
		}
		// hoi vi sao  ben cong nhan thi k can madcl ma ben cn_tc thi can khai bao 2 thang nay vi ben kia da co san r k can kbao lai
		public CN_TC(string maCongNhan, string maTrieuChung)
		{
			this.maCongNhan = maCongNhan;
			this.maTrieuChung = maTrieuChung;
		}

        public string MaCongNhan
        {
            get => maCongNhan;
            set => maCongNhan = value;
        }

        public string MaTrieuChung
        {
            get => maTrieuChung;
            set => maTrieuChung = value;
        }
    }
}

