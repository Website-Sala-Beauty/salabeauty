using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class web_module_web_DangKi : System.Web.UI.Page
{
    dbcsdlDataContext db = new dbcsdlDataContext();
    cls_Alert alert = new cls_Alert();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDangki_Click(object sender, EventArgs e)
    {
        if(txtSoDienThoai.Value =="" || txtHoTen.Value == "")
        {
            alert.alert_Error(Page, "Vui lòng nhập đầy đủ thông tin", "");
        }
        else
        {
            var checkTaiKhoan = from tk in db.tb_Users where tk.user_Phone == txtSoDienThoai.Value select tk;
            if (checkTaiKhoan.Count() > 0)
            {
                alert.alert_Error(Page, "Số điện thoại này đã tồn tại", "");
            }
            else
            {
                tb_User insert = new tb_User();
                insert.user_Phone = txtSoDienThoai.Value;
                insert.user_FullName = txtHoTen.Value;
                insert.user_Email = txtEmail.Value;
                insert.user_Password = txtPassword.Value;

                db.tb_Users.InsertOnSubmit(insert);
                db.SubmitChanges();
                Response.Redirect("/web_module/web_DangNhap.aspx");
            }
        }
    }
}