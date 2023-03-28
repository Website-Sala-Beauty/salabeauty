<%@ Page Title="" Language="C#" MasterPageFile="~/AppMasterPage.master" AutoEventWireup="true" CodeFile="web_ChonMenuDichVu.aspx.cs" Inherits="web_module_web_ChonMenuDichVu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/css_chonmenudichvu.css" rel="stylesheet" />
    <link href="../../css/footer.css" rel="stylesheet" />
    <style>
        .search-wrapper {
    border-radius: 10;
    background-color: white;
    padding-right: 12px;
    height: 64px;
    font-size: 20px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    width: 100%;
    max-width: 93%;
    color:  black;
    box-shadow: 0 2px 6px 0 rgb(136 148 171 / 20%), 0 24px 20px -24px rgb(71 82 107 / 10%);
    overflow: hidden;
    z-index: 100;
    margin: 4%;
    /* margin-right: 55%; */
}
        input {
    width: 100%;
    height: 100%;
    border: none;
    padding-left: 3%;
    font-size: 20px;
}
    </style>
    <script>
      
        function searchText() {
            //debugger;
                // Lấy đoạn văn bản cần tìm kiếm
                var text = document.getElementsByTagName('span')[0].innerHTML;

                // Lấy từ khóa tìm kiếm từ input
                var keyword = document.getElementById('txtSearch').value;

                // Tìm kiếm và thay thế từ khóa bằng cách in đậm
                var newText = text.replace(new RegExp(keyword, 'gi'), '<strong>$&</strong>');

                // Hiển thị kết quả tìm kiếm
                document.getElementsByTagName('span')[0].innerHTML = newText;
            }
        
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="navabar">
        <a href="Default.aspx"><i class="fa fa-chevron-left" aria-hidden="true"></i></a>
        <div class="tieude"><span>DỊCH VỤ</span></div>
    </div>

    <div class="base">
        
        <div class="container_form">
            <div class="search-wrapper">
                <%--// sự kiện thay đổi giá trị của textbox--%>
                <input class="search-input" type="text" id="txtSearch" placeholder="Search" onkeyup="searchText()">
            <%--<input class="search-input" type="text" id="txtSearch" runat="server" placeholder="Search" >--%>
            <i class="fa fa-search" aria-hidden="true" onclick="searchText()"></i>
            <!-- <a href="#" id="btnSearch" runat="server" onserverclick="btnSearch_ServerClick"  style="display: none;"></a> -->
        </div>
            <div class="block-dichvu">

                <div class="list">
                    <asp:Repeater runat="server" ID="rpNhomDichVu" OnItemDataBound="rpNhomDichVu_ItemDataBound">
                        <ItemTemplate>
                            <div class="block-tilte">
                                <img src="../../app_image/MenuDichVu/menudichvu-1.png" />
                                <h4 class="txt-nd"><%#Eval("loaisanpham_name") %></h4>
                            </div>
                            <div style="width: 95%; margin: 0 3%; height: 11px; background: pink;">
                            </div>
                            <asp:Repeater runat="server" ID="rpDichVuItem">
                                <ItemTemplate>
                                    <a class="block-menu">
                                        <span><%#Eval("sanpham_name") %></span>
                                        <span><%#Eval("gia") %></span>
                                    </a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

