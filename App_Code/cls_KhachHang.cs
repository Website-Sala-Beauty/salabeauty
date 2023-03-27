using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for cls_MaGiamGia
/// </summary>
public class cls_KhachHang
{
    dbcsdlDataContext db = new dbcsdlDataContext();
    public cls_KhachHang()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public bool Them_KhachHang(string tenkhachhang, string gmail, string matkhau, string sodienthoai, DateTime ngaysinh)
    {
        tb_User insert = new tb_User();
        insert.user_FullName = tenkhachhang;
        insert.user_Email = gmail;
        insert.user_Password = matkhau;
        insert.user_Phone = sodienthoai;
        insert.user_Active = true;
        insert.groupuser_id = 4;
        db.tb_Users.InsertOnSubmit(insert);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }

    }
    public bool Sua_KhachHang(int id, string tenkhachhang, string gmail, string matkhau, string sodienthoai, DateTime ngaysinh)
    {
        tb_User update = db.tb_Users.Where(x => x.user_Id == id).FirstOrDefault();
        update.user_FullName = tenkhachhang;
        update.user_Email = gmail;
        update.user_Password = matkhau;
        update.user_Phone = sodienthoai;
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool Xoa_KhachHang(int id)
    {
        tb_User delete = db.tb_Users.Where(x => x.user_Id == id).FirstOrDefault();
        db.tb_Users.DeleteOnSubmit(delete);
        try
        {
            db.SubmitChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool Check_KhachHang(string phone)
    {
        var checkTaiKhoan = from tk in db.tb_Users
                            where tk.user_Phone == phone && tk.user_Active == true
                            select tk;
        if (checkTaiKhoan.Count()> 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}