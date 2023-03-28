using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_page_module_function_module_LoaiDichVu : System.Web.UI.Page
{
    dbcsdlDataContext db = new dbcsdlDataContext();
    cls_Alert alert = new cls_Alert();
    private int _id;
    private string image;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Kiểm trả session login nếu khác null thì vào form xử lý
        // edtnoidung.Toolbars.Add(HtmlEditorToolbar.CreateStandardToolbar1());
        if (Request.Cookies["UserNail"].Value != null)
        {
            if (!IsPostBack)
            {
                Session["_id"] = 0;
            }
            loadData();
        }
        // nếu session = null thì trả về trang login
        else
        {
            Response.Redirect("/web_module/web_DangNhap.aspx");
        }
    }

    private void loadData()
    {
        // load data đổ vào var danh sách(grv)
        var getData = from nc in db.tb_LoaiSanPhams
                      //where nc. loaisanpham_hi == "dichvu"
                      orderby nc.loaisanpham_id descending
                      select new
                      {
                          nc.loaisanpham_id,
                          nc.loaisanpham_name,
                          nc.loaisanpham_image,
                          hidden = nc.loaisanpham_hidden == false ? "Còn" : "Không còn",
                          //nc.loaisanpham_hinhthuc
                      };
        // đẩy dữ liệu vào gridivew
        
        grvList.DataSource = getData;
        grvList.DataBind();
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {

    }

    protected void btnChiTiet_Click(object sender, EventArgs e)
    {

    }

    protected void btnXoa_Click(object sender, EventArgs e)
    {

    }

    protected void btnLuu_Click(object sender, EventArgs e)
    {

    }
}