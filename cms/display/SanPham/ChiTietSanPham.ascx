<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChiTietSanPham.ascx.cs" Inherits="cms_display_SanPham_ChiTietSanPham" %>

<link href="../../../css/chi-tiet-san-pham.css" rel="stylesheet" />

    <div class="chitietsp">
        <div class="baosp">
			<asp:Literal ID="ltrAnhSanPham" runat="server"></asp:Literal>
        </div>
        <div class="baochitiet">
            <div class="product-title">
                <h1><asp:Literal ID="ltrTenSanPham" runat="server"></asp:Literal></h1>
            </div>
            <div class="product-price">
                <span><asp:Literal ID="ltrGiaSanPham" runat="server"></asp:Literal>đ</span>
            </div>
            <div class="thongso">
                <div class="size">
                    <label>Kích thước</label> <asp:Literal ID="ltrKichThuoc" runat="server"></asp:Literal>
                </div>
                <div class="mausac">
                    <label>Màu sắc</label> <asp:Literal ID="ltrMau" runat="server"></asp:Literal>
                </div>
                <div class="chatlieu">
                    <label>Chất liệu</label> <asp:Literal ID="ltrChatLieu" runat="server"></asp:Literal>
                </div>
                <div class="soluong">
                    <label>Số lượng</label>
                    <input id="quantity" type="number" name="quantity" min="1" value="1" class="tc item-quantity">
                </div>
            </div>
            <div class="row">
                <div class="giohangsp">
                    <a id="add-to-cart" class="btn-detail btn-color-add" href="javascript:ThemVaoGioHang()">Thêm vào giỏ</a>
                </div>
                <div class="muangay">
                    <a id="buy-now" class="btn-detail btn-color-buy" href="javascript:MuaNgay()">Mua ngay</a>
                </div>
            </div>
        </div>
		<div style="clear:both"></div>
		<div class="thongTinChiTietSanPham">
			<asp:Literal ID="ltrThongTinChiTiet" runat="server"></asp:Literal>
		</div>
    </div>
<%--Sản phẩm liên quan--%>
    <div class="sanphamlienquan" style="display: none">
        <div id="sanphamnoibat">
            <div class="title-line">
                <a class="groupname" href="#">
                    <span class="ten">SẢN PHẨM LIÊN QUAN</span>
                    <span class="xemchitiet">Xem tất cả [+]</span>
                </a>
            </div>
            <div class="sp_noibat">
                <div class="item">
                    <a href="#" title="yếm bò">
                        <img src="../js/full-width-slider.slider/img/sanpham/ao2.jpg" alt="yếm bò" />
                    </a>
                    <a class="title-sp" href="#" title="yếm bò">
                        Yếm bò sooc
                    </a>
                    <div class="desc">
                        yếm sooc bò nữ
                    </div>
                </div>
                <div class="item">
                    <a href="#" title="yếm bò">
                        <img src="../js/full-width-slider.slider/img/sanpham/ao2.jpg" alt="yếm bò" />
                    </a>
                    <a class="title-sp" href="#" title="yếm bò">
                        Yếm bò sooc
                    </a>
                    <div class="desc">
                        yếm sooc bò nữ
                    </div>
                </div>
                <div class="item">
                    <a href="#" title="yếm bò">
                        <img src="../js/full-width-slider.slider/img/sanpham/ao2.jpg" alt="yếm bò" />
                    </a>
                    <a class="title-sp" href="#" title="yếm bò">
                        Yếm bò sooc
                    </a>
                    <div class="desc">
                        yếm sooc bò nữ
                    </div>
                </div>
            </div>
            <div class="sp_noibat">
                <div class="item">
                    <a href="#" title="yếm bò">
                        <img src="../js/full-width-slider.slider/img/sanpham/ao2.jpg" alt="yếm bò" />
                    </a>
                    <a class="title-sp" href="#" title="yếm bò">
                        Yếm bò sooc
                    </a>
                    <div class="desc">
                        yếm sooc bò nữ
                    </div>
                </div>
                <div class="item">
                    <a href="#" title="yếm bò">
                        <img src="../js/full-width-slider.slider/img/sanpham/ao2.jpg" alt="yếm bò" />
                    </a>
                    <a class="title-sp" href="#" title="yếm bò">
                        Yếm bò sooc
                    </a>
                    <div class="desc">
                        yếm sooc bò nữ
                    </div>
                </div>
                <div class="item">
                    <a href="#" title="yếm bò">
                        <img src="../js/full-width-slider.slider/img/sanpham/ao2.jpg" alt="yếm bò" />
                    </a>
                    <a class="title-sp" href="#" title="yếm bò">
                        Yếm bò sooc
                    </a>
                    <div class="desc">
                        yếm sooc bò nữ
                    </div>
                </div>
            </div>
            <div class="sp_noibat">
                <div class="item">
                    <a href="#" title="yếm bò">
                        <img src="../js/full-width-slider.slider/img/sanpham/ao2.jpg" alt="yếm bò" />
                    </a>
                    <a class="title-sp" href="#" title="yếm bò">
                        Yếm bò sooc
                    </a>
                    <div class="desc">
                        yếm sooc bò nữ
                    </div>
                </div>
                <div class="item">
                    <a href="#" title="yếm bò">
                        <img src="../js/full-width-slider.slider/img/sanpham/ao2.jpg" alt="yếm bò" />
                    </a>
                    <a class="title-sp" href="#" title="yếm bò">
                        Yếm bò sooc
                    </a>
                    <div class="desc">
                        yếm sooc bò nữ
                    </div>
                </div>
                <div class="item">
                    <a href="#" title="yếm bò">
                        <img src="../js/full-width-slider.slider/img/sanpham/ao2.jpg" alt="yếm bò" />
                    </a>
                    <a class="title-sp" href="#" title="yếm bò">
                        Yếm bò sooc
                    </a>
                    <div class="desc">
                        yếm sooc bò nữ
                    </div>
                </div>
            </div>
        </div>
    </div>
<%--Các scrip xử lý giỏ hàng--%>
<script>
	function ThemVaoGioHang() {
		//lấy ra id của sản phẩm
		var id = "<%=id%>";
		var soluong = $("#quantity").val();

		$.post("cms/display/SanPham/Ajax/XuLyGioHang.aspx",
		{
			"ThaoTac": "ThemVaoGioHang",
			"id": id,
			"soluong": soluong
		},
		function (data, status) {
			if (data == "") {
				// Thực hiện thành công thì thông báo
				alert("Đã thêm sản phẩm vào thành công");
			}
			else {
				// Thực hiện không thành công thì thông báo
				alert(data);
			}
		});
	}
	function MuaNgay() {
		//lấy ra id của sản phẩm
		var id = "<%=id%>";
		var soluong = $("#quantity").val();

		$.post("cms/display/SanPham/Ajax/XuLyGioHang.aspx",
		{
			"ThaoTac": "ThemVaoGioHang",
			"id": id,
			"soluong": soluong
		},
		function (data, status) {
			if (data == "") {
				// Thực hiện thành công thì thông báo
				alert("Đã thêm sản phẩm vào thành công");

				// Đây về trang giở hàng
				location.href = "/Default.aspx?modul=SanPham&modulphu=GioHang";
			}
			else {
				// Thực hiện không thành công thì thông báo
				alert(data);
			}
		});
	}

</script>