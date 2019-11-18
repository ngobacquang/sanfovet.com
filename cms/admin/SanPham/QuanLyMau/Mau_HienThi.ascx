<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Mau_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyMau_Mau_HienThi" %>

<div class="head">
	Các Màu của sản phẩm
	<div class="action fr">
		<a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=Mau&thaotac=ThemMoi" title="Thêm mới màu"><i class="fa fa-plus-circle" aria-hidden="true"></i></a>
	</div>
	<div class="cb">
	</div>
</div>
<div class="wapp">
	<table class="tb">
		<tr>
			<th class="cotStt">STT</th>
			<th class="cotMa">Màu ID</th>
			<th class="cotTen">Tên Màu</th>
			<th class="cotCongCu">Tên Màu</th>
		</tr>
		<asp:Literal ID="ltrMau" runat="server"></asp:Literal>
	</table>
</div>

<script>
	function XoaMau(MauID) {
		if (confirm("Bạn có chắc chắn muốn xóa màu này?")) {
			// viết code xóa danh mục tại đây
			$.post("cms/admin/SanPham/QuanLyMau/Ajax/Mau.aspx",
			{
				"ThaoTac": "XoaMau",
				"MauID": MauID
			},
			function(data, status){
				if(data == 1){ 
					$("#maDong_" + MauID).slideUp();
				}
			});
		}
	}
</script>