<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Nhom_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyNhom_Nhom_HienThi" %>
<div class="head">
	Các nhóm hiện có của sản phẩm
	<div class="action fr">
		<a href="/Admin.aspx?modul=SanPham&modulphu=Nhom&thaotac=ThemMoi" class="btThemMoi"><i class='fa fa-plus-square-o' aria-hidden='true'></i></a>
	</div>
</div>
<div class="wapp">
	<table class="tb tbDanhMuc">
		<tr>
			<th class="cotMa">Nhóm ID</th>
			<th class="cotTen">Tên Nhóm</th>
			<th class="cotAnh">Ảnh đại diện</th>
			<th class="cotThuTu">Thứ tự</th>
			<th class="cotSSP">Số SPHT</th>
			<th class="cotCongCu">Công cụ</th>
		</tr>
		<asp:Literal ID="ltrNhom" runat="server"></asp:Literal>
	</table>
</div>
<script>
	function XoaNhom(NhomID) {
		if (confirm("Bạn có chắc chắn muốn xóa Nhóm có ID là: " + NhomID  + " ?")) {
			// viết code xóa danh mục tại đây
			$.post("cms/admin/SanPham/QuanLyNhom/Ajax/Nhom.aspx",
			{
				"ThaoTac": "XoaNhom",
				"NhomID": NhomID
			},
			function(data, status){
				if(data == 1){ 
					$("#maDong_" + NhomID).slideUp();
				}
			});
		}
	}
</script>