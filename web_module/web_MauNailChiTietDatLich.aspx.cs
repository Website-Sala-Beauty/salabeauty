﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class web_module_web_MauNailChiTietDatLich : System.Web.UI.Page
{
    dbcsdlDataContext db = new dbcsdlDataContext();
    cls_Alert alert = new cls_Alert();

    protected void Page_Load(object sender, EventArgs e)
    {
        cls_KhachHang cls = new cls_KhachHang();
        if (cls.Check_KhachHang(Request.Cookies["UserNail"].Value))
        {
            loadData();
        }
        else
        {
            Response.Redirect("/app-login");
        }
    }
    private void loadData()
    {
        var getkh = (from kh in db.tb_Users
                     where kh.user_Phone == Request.Cookies["UserNail"].Value || kh.user_Email == Request.Cookies["UserNail"].Value
                     select kh).FirstOrDefault();
        int id = Convert.ToInt32(RouteData.Values["id"]);
        var getData = from nb in db.tb_SanPhams
                      where nb.loaisanpham_id == id
                      select new
                      {
                          nb.sanpham_id,
                          nb.sanpham_name,
                          nb.sanpham_image,
                          nailbox_new = nb.sanpham_new == true ? "display:block" : "display:none",
                          tinhtrang = (from gh in db.tb_HoaDonChiTiets
                                       join hd in db.tb_HoaDons on gh.hoadon_id equals hd.hoadon_id
                                       where hd.khachhang_id == getkh.user_Id && gh.sanpham_id == nb.sanpham_id
                                       && hd.hoadon_tinhtrang == "Order"
                                       select gh).Count() > 0 ? "Đã thêm" : "Đặt lịch",
                          heart = (from h in db.tb_Hearts
                                   join kh in db.tb_Users on h.khachhang_id equals kh.user_Id
                                   join sp in db.tb_SanPhams on h.sanpham_id equals sp.sanpham_id
                                   where h.khachhang_id == getkh.user_Id && h.sanpham_id == nb.sanpham_id
                                   select h).Count() > 0 ? "fa-heart" : "fa-heart-o"
                      };
        rpNailBox.DataSource = getData;
        rpNailBox.DataBind();
    }
    protected void btnLuuYeuThich_ServerClick(object sender, EventArgs e)
    {
        var getkh = (from kh in db.tb_Users
                     where kh.user_Phone == Request.Cookies["UserNail"].Value
                     select kh).FirstOrDefault();
        tb_Heart checkSanPhamYeuThich = (from h in db.tb_Hearts
                                         where h.sanpham_id == Convert.ToInt32(txtSanPhamYeuThich.Value) && h.khachhang_id == getkh.user_Id
                                         select h).FirstOrDefault();

        if (checkSanPhamYeuThich != null)
        {
            db.tb_Hearts.DeleteOnSubmit(checkSanPhamYeuThich);
            db.SubmitChanges();
        }
        else
        {
            tb_Heart insert = new tb_Heart();
            insert.sanpham_id = Convert.ToInt32(txtSanPhamYeuThich.Value);
            insert.khachhang_id = getkh.user_Id;
            db.tb_Hearts.InsertOnSubmit(insert);
            db.SubmitChanges();

        }
        loadData();
    }

    protected void btnChonSanPham_ServerClick(object sender, EventArgs e)
    {
        cls_TaoBill taoBill = new cls_TaoBill();
        if (taoBill.tao_Bill(Convert.ToInt32(txtSanPham.Value), Request.Cookies["UserNail"].Value))
        {
            alert.alert_Success(Page, "Đã lưu vào đặt lịch", "");
        }
        else
        {
            alert.alert_Error(Page, "Dịch vụ này đã có trong đặt lịch", "");
        }
        loadData();
    }
}