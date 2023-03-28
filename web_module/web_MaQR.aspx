<%@ Page Title="" Language="C#" MasterPageFile="~/AppMasterPage.master" AutoEventWireup="true" CodeFile="web_MaQR.aspx.cs" Inherits="web_module_web_MaQR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/css_MaQR.css" rel="stylesheet" />
    <link href="../../css/style.css" rel="stylesheet" />
    <link href="../../css/footer.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Great Vibes' rel='stylesheet'>
    <style>
        container_form {
    background-image: url('../images/a46f39377fd070b66cb6e7836906df62.png');
    position: absolute;
    width: 100%;
    height: 100%;
    background-repeat: no-repeat;
    background-position: center center;
    background-size: cover;
    top: -0.3%;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="navabar">
        <a href="/trang-chu"><i class="fa fa-chevron-left" aria-hidden="true"></i></a>
        <div class="tieude"><span>MÃ QR</span></div>
       
    </div>
    <div class="base">
        <div class="container_form">
            
            <div class="block_Content">
                <div class="box_contain">
                    <div class="content_Qr">
                        <div class="content_share_now">
                        <p>CHIA SẺ NGAY</p>
                    </div>
                        <div class="content_QR_code">
                            <div class="images">
                                <img src="../images/Nhóm%201.png" />
                            </div>
                            <span style="font-weight: 700; color: #e85677; margin-left: 22%; margin-top: 19px;"><span style="font-family: 'Great Vibes'; font-size: 75px; margin-left: -6%;">Sala</span><span style="margin-left: 25px; font-size: 42px;">NAILS & BEAUTY</span></span>
                            
                        </div>

                    </div>
                </div>
        </div>
    </div>
    </div>
</asp:Content>

