using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class web_module_web_DangNhap : System.Web.UI.Page
{
    dbcsdlDataContext db = new dbcsdlDataContext();
    cls_Alert cls = new cls_Alert();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDanhNhap_ServerClick(object sender, EventArgs e)
    {
       // cls_security md5 = new cls_security();
        var sdt = txt_SoDienThoai.Value.Trim();
        var mk = txt_taikhoan.Value.Trim();
        //var mkmd5 = md5.HashCode(mk);

        var getData = from u in db.tb_Users
                      where (u.user_Password == mk && u.user_Email == sdt) || (u.user_Password == mk && u.user_Phone == sdt)
                      select u;
        if(getData.Count() > 0)
        {
            Response.Cookies["UserNail"].Expires = DateTime.Now.AddDays(365);
            Response.Cookies["phone"].Value = txt_SoDienThoai.Value.ToString();
            if (getData.FirstOrDefault().groupuser_id == 4)
            {
                 Response.Redirect("/web_TrangChu.aspx");
            }
            else
            {
                Response.Redirect("/Admin_Default.aspx");
            }
           

           
        }
        else
        {
            cls.alert_Error(Page, "Mật khẩu hoặc số điện thoại không đúng!", "");
        }

        

    }
}