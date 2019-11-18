<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSach_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySanPham_SanPham_ThemMoi" %>

<%-- đăng kí plugin ckediter --%>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<div class="head">
	Thêm mới, chỉnh sửa sản phẩm
</div>
<div class="wapp formThemMoi">
	<asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
	<div class="thongTin">
		<div class="tenTruong">Chọn danh mục</div>
		<div class="oNhap">
			<asp:DropDownList ID="ddlDanhMucCha" runat="server"></asp:DropDownList>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Tên sản phẩm</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTenSanPham" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTenSanPham" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
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
		<div class="tenTruong">Số lượng</div>
		<div class="oNhap">
			<asp:TextBox ID="tbSoLuong" runat="server"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Phải nhập kiểu số" ControlToValidate="tbSoLuong" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" ForeColor="Red" ></asp:RegularExpressionValidator>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Giá bán</div>
		<div class="oNhap">
			<asp:TextBox ID="tbGiaBan" runat="server"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Phải nhập kiểu số" ControlToValidate="tbGiaBan" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" ForeColor="Red" ></asp:RegularExpressionValidator>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Ngày tạo</div>
		<div class="oNhap">
			<asp:TextBox ID="tbNgayTao" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Ngày hủy</div>
		<div class="oNhap">
			<asp:TextBox ID="tbNgayHuy" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Chọn màu</div>
		<div class="oNhap">
			<asp:DropDownList ID="ddlMau" runat="server"></asp:DropDownList>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Chọn size</div>
		<div class="oNhap">
			<asp:DropDownList ID="ddlSize" runat="server"></asp:DropDownList>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Chọn chất liệu</div>
		<div class="oNhap">
			<asp:DropDownList ID="ddlChatLieu" runat="server"></asp:DropDownList>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Chọn nhóm</div>
		<div class="oNhap">
			<asp:DropDownList ID="ddlNhom" runat="server"></asp:DropDownList>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Mô tả</div>
		<div class="oNhap">
			<CKEditor:CKEditorControl ID="tbMoTa" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder.aspx?type=Images&path=pic"></CKEditor:CKEditorControl>
		</div>
	</div>

	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:CheckBox ID="cbThemNhieuSanPham" runat="server" Text="Tiếp tục tạo sản phẩm khác sau khi tạo sản phẩm này." />
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