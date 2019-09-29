using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDTO.DTO
{
    public class DatChoRecord
    {
        public int STT { get; set; }
        public int MaCT { get; set; }
        public String MaDoan { get; set; }
        public String HoTen { get; set; }
        public String CMND { get; set; }
        public String MaPhong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int Gia { get; set; }
        public int ThanhTien { get; set; }

    }
}
