<%@ Page Language="C#" AutoEventWireup="true" CodeFile="web_DangNhap.aspx.cs" Inherits="web_module_web_DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link href="../css/web_login.css" rel="stylesheet" />

</head>
<body>
     <div class="container_form">
            <div class="container_login">
                <div class="form_logo">
                    <img src="../../app_image/Longin/longin_logo.png" />
                </div>
                <form class="form_login" runat="server">
                    <label>Email</label>
                    <input runat="server" type="text" id="txt_taikhoan" />
                    <label>Số điện thoại</label>
                    <input type="text" id="txt_SoDienThoai" runat="server" />
                   
                    <a href="#" class="btn_DangNhap" id="btnDanhNhap" runat="server" >ĐĂNG NHẬP</a>
                     <div class="text_login">
                        <a href="/dang-ki">Đăng ký</a>
                        <a href="/dang-ki">Quên mật khẩu</a>


                    </div>
                </form>
            </div>
        </div>
</body>
</html>
