<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Nhom_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyNhom_Nhom_ThemMoi" %>
<div class="head">
	Thêm mới, chỉnh sửa Nhóm sản phẩm
</div>
<div class="wapp formThemMoi">
	<asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
	<div class="thongTin">
		<%--Chứa Nhóm ID--%>
		<asp:HiddenField ID="hfNhomID" runat="server" /> 
		<div class="tenTruong">Tên Nhóm</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTenNhom" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Ảnh đai diện</div>
		<div class="oNhap">
			<asp:HiddenField ID="hdTenAnhDaiDienCu" runat="server" />
			<div>
				<asp:Literal ID="ltrAnhDaiDien" runat="server"></asp:Literal>
			</div>
			<asp:FileUpload ID="flAnhDaiDien" runat="server" />
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Thứ tự</div>
		<div class="oNhap">
			<asp:TextBox ID="tbThuTu" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Số SP hiển thị</div>
		<div class="oNhap">
			<asp:TextBox ID="tbSSPHT" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:CheckBox ID="cbThemNhieuNhom" runat="server" Text="Tiếp tục tạo danh mục khác sau khi tạo danh mục này." />
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