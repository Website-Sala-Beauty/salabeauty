using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class web_module_web_ChonMenuDichVu : System.Web.UI.Page
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
            Response.Redirect("/web_module/web_DangNhap.aspx");
        }

    }
    protected void loadData()
    {
        var getData = from ldv in db.tb_LoaiSanPhams
                      where ldv.loaisanpham_hinhthuc == "dichvu"
                      select ldv;
        rpNhomDichVu.DataSource = getData;
        rpNhomDichVu.DataBind();
    }

    protected void rpNhomDichVu_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Repeater rpDichVuItem = e.Item.FindControl("rpDichVuItem") as Repeater;
        string loaidichvu_id = DataBinder.Eval(e.Item.DataItem, "loaisanpham_id").ToString();
        var getIDKhachHang = from kh in db.tb_Users where kh.user_Phone == Request.Cookies["UserNail"].Value select kh;
        var getDataDV = from d in db.tb_SanPhams
                        join l in db.tb_LoaiSanPhams on d.loaisanpham_id equals l.loaisanpham_id
                        where d.loaisanpham_id == Convert.ToInt32(loaidichvu_id)
                        select new
                        {
                            d.sanpham_id,
                            d.sanpham_name,
                            
                            l.loaisanpham_id,
                            l.loaisanpham_name,
                           

                        };
        rpDichVuItem.DataSource = getDataDV;
        rpDichVuItem.DataBind();

    }

    protected void btnChonSanPham_ServerClick(object sender, EventArgs e)
    {

    }
}