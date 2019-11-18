<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSach_ThemMoi.ascx.cs" Inherits="cms_admin_QuangCao_DanhSach_DanhSach_ThemMoi" %>

<%-- đăng kí plugin ckediter --%>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="head">
	Thêm mới, chỉnh sửa sản phẩm
</div>
<div class="wapp formThemMoi">
	<asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
	<div class="thongTin">
		<div class="tenTruong">Chọn nhóm QC</div>
		<div class="oNhap">
			<asp:DropDownList ID="ddlNhomQC" runat="server"></asp:DropDownList>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Tên quảng cáo</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTenQC" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTenQC" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Ảnh đai diện</div>
		<div class="oNhap">
			<div>
				<asp:HiddenField ID="hdTenAnhDaiDienCu" runat="server" />
				<asp:Literal ID="ltrAnhDaiDien" runat="server"></asp:Literal>
			</div>
			<asp:FileUpload ID="flAnhDaiDien" runat="server" />
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
			<asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click" CausesValidation="false" />
			<asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
		</div>
	</div>
</div>