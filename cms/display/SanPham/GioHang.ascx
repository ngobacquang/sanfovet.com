<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GioHang.ascx.cs" Inherits="cms_display_SanPham_GioHang" %>
<link href="../../../css/gio-hang.css" rel="stylesheet" />
<div class="modal-content">
    <div class="modal-header">
        <h4 class="modal-title" id="exampleModalLabel">Bạn có <span class="tongSoSPTrongGioHang"></span> sản phẩm trong giỏ hàng.</h4>

        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
            <a aria-hidden="true"></a>
        </button>

    </div>
    <div id="cartform" style="display: block;">
        <div class="modal-body" id="BangThongTinGioHang">
			<%--Khu vuc chua du lieu gio hang--%>
        </div>
        <div class="modal-footer">
			<div style="clear: both"></div>
			<div class="row">
                <div class="col-12" style="padding-right: 10px;">
                    <div class="total-price-modal">
                        Tổng cộng : <span class="item-total tongTienTrongGioHang">0</span> đ
                    </div>
                </div>
            </div>
			<div class="dienThongTinDatHang">
				<div class="goiY">Quý khách vui lòng điền đầy đủ thông tin vào from để đặt hàng <br>Lưu ý: nếu quý khách điền đầy đủ thông tin thì hệ thống sẽ kiểm tra và tạo cho quý khách một tài khoản chính là email của quý khách</div>
				<div class="row">
					<div class="col-lg-3">
						<div class="modal-title-note">
							Họ tên (*): 
						</div>
					</div>
					<div class="col-lg-4">
						<div class="modal-note">
							<input id="tbHoTen" type="text" value="<%=hoTen%>" />
						</div>
					</div>
				</div>
				<div style="clear: both"></div>
				<div class="row">
					<div class="col-lg-3">
						<div class="modal-title-note">
							Địa chỉ (*):
						</div>
					</div>
					<div class="col-lg-4">
						<div class="modal-note">
							<input id="tbDiaChi" type="text" value="<%=diaChi%>" />
						</div>
					</div>
				</div>
				<div style="clear: both"></div>
				<div class="row">
					<div class="col-lg-3">
						<div class="modal-title-note">
							Số điện thoại (*):
						</div>
					</div>
					<div class="col-lg-4">
						<div class="modal-note">
							<input id="tbSoDienThoai" type="text" value="<%=soDienThoai%>"/>
						</div>
					</div>
				</div>
				<div style="clear: both"></div>
				<div class="row">
					<div class="col-lg-3">
						<div class="modal-title-note">
							Email:
						</div>
					</div>
					<div class="col-lg-4">
						<div class="modal-note">
							<input id="tbEmail" type="text" value="<%=email%>" />
						</div>
					</div>
				</div>
			</div>
			<div style="clear: both"></div>
            <div class="row" style="margin-top:10px;">
                <div class="col-lg-6">
                    <div class="comeback">
                        <a href="/">
                            <img src="../pic/dangnhap/icon-tieptuc.png" />  Tiếp tục mua hàng
                        </a>
                    </div>
                </div>
                <div class="col-lg-6 text-right">
                    <div class="buttons btn-modal-cart">
						<a href="javascript://" onclick="GuiDonHang()" class="button-default">Đặt hàng</a>
                    </div>
                </div>
            </div>

        </div>

    </div>
</div>

<script type="text/javascript">
	//Viết ajax lấy thông tin đựt hàng
	function LayThongTinGioHang() {
		//lấy ra id của sản phẩm

		$.post("cms/display/SanPham/Ajax/XuLyGioHang.aspx",
		{
			"ThaoTac": "LayThongTinGioHang"
		},
		function (data, status) {
			$("#BangThongTinGioHang").html(data);
		});
	}
	function LayTongSoSanPhamTrongGioHang() {
		//lấy ra id của sản phẩm

		$.post("cms/display/SanPham/Ajax/XuLyGioHang.aspx",
		{
			"ThaoTac": "LayTongSoSanPhamTrongGioHang"
		},
		function (data, status) {
			$(".tongSoSPTrongGioHang").html(data);
		});
	}
	function LayTongTienTrongGioHang() {
		//lấy ra id của sản phẩm

		$.post("cms/display/SanPham/Ajax/XuLyGioHang.aspx",
		{
			"ThaoTac": "LayTongTienTrongGioHang"
		},
		function (data, status) {
			$(".tongTienTrongGioHang").html(data);
		});
	}
	$(document).ready(function () {
		LayThongTinGioHang();
		LayTongSoSanPhamTrongGioHang();
		LayTongTienTrongGioHang();
	});

	// Xóa một sản phẩm trong giỏ hàng
	function XoaSPTrongGioHang(idSanPham) {
		//hỏi xác nhận
		if(confirm("Bạn muốn xóa sản phẩm này?"))
		{
			$.post("cms/display/SanPham/Ajax/XuLyGioHang.aspx",
			{
				"ThaoTac": "XoaSPTrongGioHang",
				"idSanPham": idSanPham
			},
			function (data, status) {
				// Nếu không có lỗi thì ẩn dò hiện tại đi
				if (data === "") {
					$("#tr_" + idSanPham).remove();

					LayTongSoSanPhamTrongGioHang();
					LayTongTienTrongGioHang();
				}
			});
		}
		
	}

	// Cập nhật số lượng cho mỗi sản phẩm trong giỏ hàng
	function CapNhatSoLuongVaoGioHang(idSanPham) {

		// Lấy số lượng mới sửa
		var soLuongMoi = $("#quantity_" + idSanPham).val();
		$.post("cms/display/SanPham/Ajax/XuLyGioHang.aspx",
		{
			"ThaoTac": "CapNhatSoLuongVaoGioHang",
			"idSanPham": idSanPham,
			"soLuongMoi": soLuongMoi
		},
		function (data, status) {
			// Nếu không có lỗi thì ẩn dò hiện tại đi
			if (data === "") {
				LayTongSoSanPhamTrongGioHang();
				LayTongTienTrongGioHang();
			}
		});

	}

	// Gửi đơn hàng
	function GuiDonHang() {
		// Kiểm tra xem đã nhập đủ thông tin chưa
		if ($("#tbHoTen").val() !== "" && $("#tbSoDienThoai").val() !== "") {
			$.post("cms/display/SanPham/Ajax/XuLyGioHang.aspx",
			{
				"ThaoTac": "GuiDonHang",
				"hoTen": $("#tbHoTen").val(),
				"diaChi": $("#tbDiaChi").val(),
				"soDienThoai": $("#tbSoDienThoai").val(),
				"email": $("#tbEmail").val()
			},
			function (data, status) {
				// Nếu không có lỗi thì ẩn dò hiện tại đi
				if (data === "") {
					alert("Bạn đã gửi đơn hàng thành công");
					location.href = "/";
				}
			});
		}
		else {
			alert("Vui lòng nhập đủ thông tin để đặt hàng");
		}
	}
</script>
