<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSach_HienThi.ascx.cs" Inherits="cms_admin_QuangCao_DanhSach_DanhSach_HienThi" %>

<div class="head">
	Các quảng cáo đã tạo
	<div class="action fr">
		<a class="btThemMoi" href="/Admin.aspx?modul=QuangCao&modulphu=DanhSach&thaotac=ThemMoi" title="Thêm mới danh mục"><i class="fa fa-plus-circle" aria-hidden="true"></i></a>
	</div>
	<div class="cb">
	</div>
</div>
<div class="wapp">
	<table class="tb tbQuangCao">
		<tr>
			<th class="cotMa">Mã</th>
			<th class="cotTen">Tên QC</th>
			<th class="cotAnh">Ảnh quảng cáo</th>
			<th class="cotThuTu">Thứ tự</th>
			<th class="cotCongCu">Công cụ</th>
		</tr>
		<asp:Literal ID="ltrDanhSach" runat="server"></asp:Literal>
	</table>
</div>
<script>
	function XoaDanhSach(QuangCaoID) {
		if (confirm("Bạn có chắc chắn muốn xóa quảng cáo có ID là: " + QuangCaoID + "?")) {
			// viết code xóa danh mục tại đây
			$.post("cms/admin/QuangCao/DanhSach/Ajax/DanhSach.aspx",
			{
				"ThaoTac": "XoaDanhSach",
				"QuangCaoID": QuangCaoID
			},
			function(data, status){
				if(data == 1){ 
					$("#maDong_" + QuangCaoID).slideUp();
				}
			});
		}
	}
</script>