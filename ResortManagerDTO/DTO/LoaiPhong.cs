using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortManagerDTO.DTO
{
    public class LoaiPhong
    {
        public String MALOAI { get; set; }//lã loại
        public String HINHTHUC { get; set; }// hình thức(1 người)
        public int GIA {get; set;} //giá
        public String HANG { get; set; } //hạng phòng (Vip, thường,...)
    }
}
