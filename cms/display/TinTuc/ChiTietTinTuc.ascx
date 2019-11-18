<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChiTietTinTuc.ascx.cs" Inherits="cms_display_TinTuc_ChiTietTinTuc" %>
<link href="../../../css/bai-viet-chi-tiet.css" rel="stylesheet" />

<div id="NewDetail">
    <div class="title">
		<h1>
			<asp:Literal ID="ltrTieuDeTin" runat="server"></asp:Literal>
		</h1>
    </div>
    <div class="tool">
        <div class="date">Ngày đăng: <asp:Literal ID="ltrNgayDang" runat="server"></asp:Literal></div>
        <div class="view">Lượt xem: <asp:Literal ID="ltrLuotXem" runat="server"></asp:Literal></div>               
        <div class="cb"><!----></div>
    </div>
    <div class="contentview TextSize">
        <div class="thongtinChiTietTinTuc">
			<asp:Literal ID="ltrNoiDungChiTiet" runat="server"></asp:Literal>
        </div>
    </div>
    <div class="cb"></div> 
            
</div>
