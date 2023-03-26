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
            var checkTaiKhoan = from tk in db.khachhangs where tk.sdt == txtSoDienThoai.Value select tk;
            if (checkTaiKhoan.Count() > 0)
            {
                alert.alert_Error(Page, "Số điện thoại này đã tồn tại", "");
            }
            else
            {
                khachhang insert = new khachhang();
                insert.sdt = txtSoDienThoai.Value;
                insert.ten = txtHoTen.Value;
                insert.email = txtEmail.Value;
                db.khachhangs.InsertOnSubmit(insert);
                db.SubmitChanges();
                
            }
        }
    }
}