using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDTO.DTO
{
    public class GiaoDich
    {
        public String MaDoan { get; set; }

        public int SoNguoi { get; set; }

        public int SoPhong { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public int TongTien { get; set; }

        public String CMND { get; set; }

        public String TrangThai { get; set; }
    }
}
