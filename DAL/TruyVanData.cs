using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TruyVanData : CL_QLSVContext
    {
        public List<NguoiDung> LoadNhanVien()
        {
            var query = from nd in context.NguoiDungs 
                        select new {
                            nd.SDT,nd.Email, nd.MatKhau, nd.Ten, nd.Ho, nd.GhiChu, nd.ViTriCV, nd.DiaChi, nd.CMND
                        };
            var kq = query.ToList().ConvertAll(t => new NguoiDung{
                SDT = t.SDT, Email = t.Email,MatKhau =t.MatKhau,Ten = t.Ten, Ho = t.Ho, 
                GhiChu = t.GhiChu,ViTriCV = t.ViTriCV, DiaChi = t.DiaChi,CMND = t.CMND 
            });
            return kq.ToList<NguoiDung>();
        }
        public List<PhanQuyen> LoadNhanVienPQ()
        {
            return context.PhanQuyens.Select(t => t).ToList();
        }
        public string GetSDT(string sdt)
        {
            PhanQuyen check = context.PhanQuyens.Where(t => t.SDT.Equals(sdt)).FirstOrDefault();
            return check.SDT.ToString();
        }
    }
}
