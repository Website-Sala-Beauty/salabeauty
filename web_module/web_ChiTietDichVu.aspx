<%@ Page Title="" Language="C#" MasterPageFile="~/AppMasterPage.master" AutoEventWireup="true" CodeFile="web_ChiTietDichVu.aspx.cs" Inherits="web_module_web_ChiTietDichVu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="navabar">
        <div class="tieude"><span>DỊCH VỤ</span></div>
        <div class="icon-infor">
        </div>
    </div>
     <div class="base">
        <div class="container_form">
            <asp:Repeater ID="rpNews" runat="server">
                <ItemTemplate>
                    <div class="list-1">
                        <div class="img">
                            <img src="../../<%#Eval("news_image") %>"/>
                        </div>
                        <div class="nd">
                            <h4 class="name_dvu"><%#Eval("news_title") %></h4>
                            <span><%#Eval("news_summary") %> </span>
                            <a class="text_dvu" href="/thong-tin-dich-vu-<%#Eval("news_id") %>">Xem thêm
                            </a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

