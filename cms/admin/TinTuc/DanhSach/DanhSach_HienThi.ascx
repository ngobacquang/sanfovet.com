<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSach_HienThi.ascx.cs" Inherits="cms_admin_TinTuc_DanhSach_DanhSach_HienThi" %>

<div class="head">
	Các tin đã tạo
	<div class="action fr">
		<a class="btThemMoi" href="/Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&thaotac=ThemMoi" title="Thêm mới danh mục"><i class="fa fa-plus-circle" aria-hidden="true"></i></a>
	</div>
	<div class="cb">
	</div>
</div>
<div class="wapp">
	<table class="tb tbSach">
		<tr>
			<th class="cotMa">Mã</th>
			<th class="cotTen">Tiêu đề</th>
			<th class="cotAnh">Ảnh đại diện</th>
			<th class="cotLuotXem">Lượt xem</th>
			<th class="cotNgayDang">Ngày đăng</th>
			<th class="cotThuTu">Thứ tự</th>
			<th class="cotCongCu">Công cụ</th>
		</tr>
		<asp:Literal ID="ltrDanhSach" runat="server"></asp:Literal>
	</table>
</div>
<script>
	function XoaDanhSach(TinTucID) {
		if (confirm("Bạn có chắc chắn muốn xóa tin tức có ID là: " + TinTucID + "?")) {
			// viết code xóa danh mục tại đây
			$.post("cms/admin/TinTuc/DanhSach/Ajax/DanhSach.aspx",
			{
				"ThaoTac": "XoaDanhSach",
				"TinTucID": TinTucID
			},
			function(data, status){
				if(data == 1){ 
					$("#maDong_" + TinTucID).slideUp();
				}
			});
		}
	}
</script>