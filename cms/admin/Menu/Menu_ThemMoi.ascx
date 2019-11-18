<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu_ThemMoi.ascx.cs" Inherits="cms_admin_Menu_Menu_ThemMoi" %>


<div class="head">
	Thêm mới, chỉnh sửa Menu
</div>
<div class="wapp formThemMoi">
	<asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
	<div class="thongTin">
		<div class="tenTruong">Menu cha</div>
		<div class="oNhap">
			<asp:DropDownList ID="ddlMenuCha" runat="server"></asp:DropDownList>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Tên menu</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTenMenu" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Liên kết</div>
		<div class="oNhap">
			<asp:TextBox ID="tbLienKet" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Thứ tự</div>
		<div class="oNhap">
			<asp:TextBox ID="tbThuTu" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:CheckBox ID="cbThemNhieu" runat="server" Text="Tiếp tục tạo." />
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
			<asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
		</div>
	</div>
</div>