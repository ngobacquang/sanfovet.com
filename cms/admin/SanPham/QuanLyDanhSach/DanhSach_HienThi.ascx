<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSach_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyDanhSach_DanhSach_HienThi" %>

<div class="head">
	Các sản phẩm đã tạo
	<div class="action fr">
		<a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=DanhSach&thaotac=ThemMoi" title="Thêm mới sản phẩm"><i class="fa fa-plus-circle" aria-hidden="true"></i></a>
	</div>
	<div class="cb">
	</div>
</div>
<div class="wapp">
	<table class="tb tbDanhMuc">
		<tr>
			<th class="cotMa">Mã</th>
			<th class="cotTen">Tên sản phẩm</th>
			<th class="cotAnh">Ảnh đại diện</th>
			<th class="cotSoLuong">Số lượng</th>
			<th class="cotDonGia">Đơn giá</th>
			<th class="cotNgayTao">Ngày tạo</th>
			<th class="cotCongCu">Công cụ</th>
		</tr>
		<asp:Literal ID="lrtDanhSach" runat="server"></asp:Literal>
	</table>
</div>
<script>
	function XoaSanPham(MaSP) {
		if (confirm("Bạn có chắc chắn muốn xóa sản phẩm có ID là: "+ MaSP +" ?")) {
			// viết code xóa danh mục tại đây
			$.post("cms/admin/SanPham/QuanLyDanhSach/Ajax/SanPham.aspx",
			{
				"ThaoTac": "XoaSanPham",
				"MaSP": MaSP
			},
			function(data, status){
				if(data == 1){ 
					$("#maDong_" + MaSP).slideUp();
				}
			});
		}
	}
</script>