<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Nhom_ThemMoi.ascx.cs" Inherits="cms_admin_QuangCao_Nhom_Nhom_ThemMoi" %>


<div class="head">
	Thêm mới, chỉnh sửa Nhóm Quảng Cáo
</div>
<div class="wapp formThemMoi">
	<asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
	<div class="thongTin">
		<div class="tenTruong">Tên nhóm</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTenNhom" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Vị trí QC</div>
		<div class="oNhap">
			<asp:TextBox ID="tbViTri" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Ảnh đai diện</div>
		<div class="oNhap">
			<div>
				<asp:HiddenField ID="hfAnhDaiDienCu" runat="server" />
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