<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Size_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySize_Size_HienThi" %>
<div class="head">
	Các Size đã có của sản phẩm
	<div class="action fr">
		<a href="/Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ThemMoi" class="btThemMoi"><i class='fa fa-plus-square-o' aria-hidden='true'></i></a>
	</div>
</div>
<div class="wapp">
	<table class="tb">
		<tr>
			<th class="cotStt">STT</th>
			<th class="cotMa">Size ID</th>
			<th class="cotTen">Tên Size</th>
			<th class="cotCongCu">Công Cụ</th>
		</tr>
		<asp:Literal ID="ltrSize" runat="server"></asp:Literal>
	</table>
</div>
<script>
	function XoaSize(SizeID) {
		if (confirm("Bạn có chắc chắn muốn xóa Size có ID là: " + SizeID + " ?")) {
			// viết code xóa danh mục tại đây
			$.post("cms/admin/SanPham/QuanLySize/Ajax/Size.aspx",
			{
				"ThaoTac": "XoaSize",
				"SizeID": SizeID
			},
			function (data, status) {
				if (data == 1) {
					$("#maDong_" + SizeID).slideUp();
				}
			});
		}
	}
</script>