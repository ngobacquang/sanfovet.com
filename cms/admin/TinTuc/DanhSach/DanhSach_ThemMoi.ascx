<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSach_ThemMoi.ascx.cs" Inherits="cms_admin_TinTuc_DanhSach_DanhSach_ThemMoi" %>

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
		<div class="tenTruong">Tiêu đề</div>
		<div class="oNhap">
			<asp:TextBox ID="tbTieuDe" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTieuDe" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
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
		<div class="tenTruong">Mô tả</div>
		<div class="oNhap">
			<asp:TextBox ID="tbMoTa" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Ngày đăng</div>
		<div class="oNhap">
			<asp:TextBox ID="tbNgayDang" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Lượt xem</div>
		<div class="oNhap">
			<asp:TextBox ID="tbLuotXem" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Thứ tự</div>
		<div class="oNhap">
			<asp:TextBox ID="tbThuTu" runat="server"></asp:TextBox>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">Chi tiết</div>
		<div class="oNhap">
			<CKEditor:CKEditorControl ID="tbChiTiet" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder.aspx?type=Images&path=pic"></CKEditor:CKEditorControl>
		</div>
	</div>
	<div class="thongTin">
		<div class="tenTruong">&nbsp</div>
		<div class="oNhap">
			<asp:CheckBox ID="cbThemNhieuTinTuc" runat="server" Text="Tiếp tục tạo sản phẩm khác sau khi tạo sản phẩm này." />
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