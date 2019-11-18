<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChatLieu_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyChatLieu_ChatLieu_ThemMoi" %>

<div class="head">
	Thêm mới, chỉnh sửa chất liệu sản phẩm
</div>
<div class="wapp formThemMoi">
	<asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
	<div class="thongTin">
		<div class="tenTruong">Tên chất liệu</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTenChatLieu" runat="server"></asp:TextBox>
		</div>
		<asp:HiddenField ID="hdfChatLieuID" runat="server" />
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:CheckBox ID="cbThemNhieuChatLieu" runat="server" Text="Tiếp tục thêm chất liệu" />
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:Button ID="btThemMoi" runat="server" Text="Thêm Mới" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
			<asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
		</div>
	</div>
</div>