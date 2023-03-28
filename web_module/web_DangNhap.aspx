<%@ Page Language="C#" AutoEventWireup="true" CodeFile="web_DangNhap.aspx.cs" Inherits="web_module_web_DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/web_login.css" rel="stylesheet" />
    <script src="../js/sweetalert.min.js"></script>
    <style>
        .block_erorr {
            margin-top: 3%;
        }

        #errorNullSDT, #errorNullMK {
            color: orangered;
            display: none;
        }

        .inputText {
            padding: 3% 10% 3% 10%;
            display: flex;
            flex-direction: column;
        }

        .text_login{
            display: flex;
            flex-direction: row;
            justify-content: space-between;
            margin: 5%;
        }
    </style>
</head>
<body>
    <div class="container_form">
        <div class="container_login">
            <div class="form_logo">
                <img src="../../app_image/Longin/longin_logo.png" />
            </div>
            <form class="form_login" runat="server">
                <div class="inputText">
                    <div>
                        <label>Số điện thoại</label>
                    </div>
                    <div>
                        <input type="text" id="txt_SoDienThoai" runat="server" />
                    </div>
                    <div class="block_erorr"><span id="errorNullSDT">Vui lòng nhập số điện thoại</span></div>
                </div>
                <div class="inputText">
                    <div>
                        <label>Mật khẩu</label></div>
                    <div>
                        <input runat="server" type="text" id="txt_taikhoan" /></div>
                    <div class="block_erorr"><span id="errorNullMK">Vui lòng nhập mật khẩu</span></div>
                </div>
                <a href="#" class="btn_DangNhap" id="btnDanhNhap" runat="server" onclick=" return checkNull()" onserverclick="btnDanhNhap_ServerClick">ĐĂNG NHẬP</a>
                <div class="text_login">
                    <a href="/web_DangKy.aspx">Đăng ký</a>
                    <a href="/dang-ki">Quên mật khẩu</a>
                </div>
            </form>
        </div>
        </div>
    </div>
    <script>
        function checkNull() {
            var user = document.getElementById("<%=txt_SoDienThoai.ClientID%>").value;
            var mk = document.getElementById("<%=txt_taikhoan.ClientID%>").value;
            if (user == "") {
                document.getElementById("errorNullSDT").style.display = 'block';
                return false;
            }
            if (mk == "") {
                document.getElementById("errorNullMK").style.display = 'block';
                return false;
            }
            return true;
        }
    </script>
</body>
</html>
