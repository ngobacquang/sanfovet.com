<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Mau_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyMau_Mau_ThemMoi" %>

<div class="head">
	Thêm mới, chỉnh sửa Màu sản phẩm
</div>
<div class="wapp formThemMoi">
	<%--<asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>--%>
	<div class="thongTin">
		<div class="tenTruong">Màu ID</div>
		<div class="oNhap">
			<asp:TextBox ID="tbMauID" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Tên Màu</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTenMau" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:CheckBox ID="cbThemNhieuMau" runat="server" Text="Tiếp tục tạo màu khác sau khi tạo màu này." />
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:Button ID="btThemMoi" Text="Thêm mới" CssClass="btThemMoi" runat="server" OnClick="btThemMoi_Click" />
			<asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" CausesValidation="false" OnClick="btHuy_Click" />
		</div>
	</div>
</div>