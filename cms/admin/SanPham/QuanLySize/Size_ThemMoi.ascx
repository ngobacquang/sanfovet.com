<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Size_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySize_Size_ThemMoi" %>
<div class="head">
	Thêm mới, chỉnh sửa Size
</div>
<div class="wapp formThemMoi">
	<asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
	<div class="thongTin">
		<asp:HiddenField ID="hfSizeID" runat="server" />
		<div class="tenTruong">
			Tên Size
		</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTenSize" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:CheckBox ID="cbThemNhieuSize" Text="Nhập thêm nhiều Size" runat="server" />
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click"/>
			<asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false"/>
		</div>
	</div>
</div>