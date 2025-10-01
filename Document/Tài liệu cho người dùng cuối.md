# **Tài liệu cho người dùng cuối**

Đây là hướng dẫn sử dụng phần mềm cho người dùng

***Để sử dụng phần mềm, bước đầu tiên bạn phải tạo một cơ sở dữ liệu (Sử dụng SQL Server) và dùng [SQL Query](https://github.com/vubichngan/QLQC/blob/main/data.sql) này để tạo các table và các proceduce cần thiết cho phần mềm.***

## **1) Giao diện đăng nhập**

### **Khi bạn mở phần mềm sẽ đi tới giao diện đăng nhập của chương trình**

<img width="290" height="275" alt="Screenshot 2025-09-26 144228" src="https://github.com/user-attachments/assets/2e6a24a5-2530-46fe-b05b-69ff34d677d5" />

* Chức năng: Đăng nhập tài khoản để vào giao diện chính thực hiện các chức năng khác theo phân quyền tài khoản

* Hướng dẫn: 

  * Nhập các thông tin tên người dùng, Mật khẩu vào các ô tương ứng

  * Click chọn nút Đăng nhập để di chuyển đến giao diện chính

## **2) Giao diện chính**

<img width="587" height="461" alt="Screenshot 2025-09-26 150205" src="https://github.com/user-attachments/assets/16925f76-d60a-4f3e-ba9c-7f79dfbc4f56" />

* Chức năng: Hiển thị các bàn có trong quán, với các bàn có hóa đơn chưa thanh toán sẽ có màu vàng và hiển thị tổng số tiền cần thanh toán.

* Hướng dẫn: Click chọn bàn để thực hiện các chức năng.

## **Sau đây là các chức năng của chương trình**

## **3) Quản lý hóa đơn cho bàn**

<img width="684" height="443" alt="Screenshot 2025-09-26 153347" src="https://github.com/user-attachments/assets/6f8558d5-5bb4-43d2-8dbb-c90e42032186" />

* Chức năng: Quản lý các thức uống trong 1 bàn, bạn có thể Thêm/Sửa/Xóa số lượng các thức uống có trong hóa đơn của bàn.

* Hướng dẫn:

  * Thêm các thức uống từ thực đơn bên trái.
  * Sửa số lượng thức uống sau khi thêm được hiển thị bên phải bằng các nút \+ / \-.  
  * Xóa thức uống đã thêm bằng nút <img width="24" height="24" alt="trash-can" src="https://github.com/user-attachments/assets/d6e53035-9672-429d-a907-37792d519255" />
 bên cạnh thức uống.

## **4) Chuyển bàn**

<img width="683" height="468" alt="Screenshot 2025-09-26 155440" src="https://github.com/user-attachments/assets/fc95ae9c-259a-4005-a0b5-51cf20d4f0a7" />

* Chức năng: Chuyển hóa đơn từ bàn này sang bàn khác.

* Hướng dẫn:

  * Chọn bàn cần di chuyển hóa đơn

  * Chọn nút <img width="24" height="24" alt="menu" src="https://github.com/user-attachments/assets/418c7911-4f7f-46b6-9975-61f78ae2ffe8" /> và chọn Chuyển bàn

  * Giao diện tất cả các bàn sẽ được hiển thị như hình bên dưới

<img width="590" height="465" alt="Screenshot 2025-09-26 160057" src="https://github.com/user-attachments/assets/29c460ef-1218-4cb6-8c0d-3db072f0993d" />

  * Chọn bàn cần chuyển đến

  * Thông báo xác nhận chuyển bàn được hiển thị

<img width="588" height="463" alt="Screenshot 2025-09-26 160359" src="https://github.com/user-attachments/assets/49110414-67d1-4046-bc60-342ab78f8fc3" />

  * Chọn OK, giao diện hóa đơn bàn cần di chuyển được hiển thị và làm mới.

<img width="686" height="447" alt="Screenshot 2025-09-26 160635" src="https://github.com/user-attachments/assets/debefb99-659f-4bdb-b758-b28ed85075dd" />

  * Thoát khỏi giao diện quản lý hóa đơn theo bàn.

  * Hiển thị giao diện chính và hóa đơn bàn cần di chuyển đã chuyển sang bàn mới.

<img width="589" height="465" alt="Screenshot 2025-09-26 160919" src="https://github.com/user-attachments/assets/0646b52b-eff2-4665-bd40-db5d084c35af" />

## **5) Tách bàn**

<img width="685" height="468" alt="Screenshot 2025-09-26 162700" src="https://github.com/user-attachments/assets/10dde377-aa9f-420b-8b34-4c79f78a1bf3" />

* Chức năng: Tách hóa đơn từ bàn này sang bàn khác.

* Hướng dẫn:

  * Chọn bàn cần tách hóa đơn

  * Chọn nút <img width="24" height="24" alt="menu" src="https://github.com/user-attachments/assets/2c34592d-32c2-43a4-b4dc-678aa443d4ac" />
 và chọn Tách bàn

  * Giao diện tách bàn sẽ được hiển thị như hình bên dưới

<img width="690" height="449" alt="Screenshot 2025-09-26 170950" src="https://github.com/user-attachments/assets/f278cd24-ea6c-4705-bdb7-5a5c1bf2dce0" />

  * Chọn thức uống và số lượng muốn tách sang bàn khác

  * Nhấn nút Chuyển, giao diện tất cả các bàn sẽ được hiển thị như hình bên dưới

<img width="589" height="465" alt="Screenshot 2025-09-26 160919" src="https://github.com/user-attachments/assets/0646b52b-eff2-4665-bd40-db5d084c35af" />

  * Chọn bàn cần chuyển đến

  * Thông báo xác nhận chuyển bàn được hiển thị

<img width="596" height="465" alt="Screenshot 2025-09-26 171319" src="https://github.com/user-attachments/assets/a63b5534-efce-4155-8f9f-f7e53018101a" />

  * Chọn OK, giao diện hóa đơn bàn cần tách được hiển thị và làm mới.

<img width="687" height="448" alt="Screenshot 2025-09-26 171500" src="https://github.com/user-attachments/assets/a6faa74f-69d0-4c75-a72c-237618358cac" />

  * Thoát khỏi giao diện quản lý hóa đơn theo bàn.

  * Hiển thị giao diện chính đã tách bàn thành công.

<img width="592" height="465" alt="Screenshot 2025-09-26 171754" src="https://github.com/user-attachments/assets/d5b78f95-a298-4a66-8671-fd7bbab703bf" />

## **6) Thanh toán**

<img width="688" height="444" alt="Screenshot 2025-09-26 172058" src="https://github.com/user-attachments/assets/e8fc51f9-077b-4f60-849b-d927615a1381" />

* Chức năng: Thanh toán hóa đơn

* Hướng dẫn:

  * Chọn nút Thanh toán

  * Thông báo xác nhận thanh toán được hiển thị

  * Chọn OK, thanh toán thành công.

  * Hóa đơn chi tiết của bàn thanh toán được hiển thị

<img width="685" height="449" alt="Screenshot 2025-09-26 172347" src="https://github.com/user-attachments/assets/26a5304e-e487-4cea-b7f8-2dc76c4b214b" />

<img width="685" height="479" alt="Screenshot 2025-09-26 193549" src="https://github.com/user-attachments/assets/a275886c-8966-40b7-b47f-a6b8fd00442b" />

## **7) Quản lý loại thức uống**

<img width="588" height="461" alt="Screenshot 2025-09-26 194808" src="https://github.com/user-attachments/assets/feee2138-d826-475d-b604-2604b1b3cbde" />

* Chức năng: Quản lý thông tin các Loại thức uống, bạn có thể Thêm/Sửa/Xóa/Tìm kiếm thông tin các Loại thức uống.

* Hướng dẫn:

  * Nhập thông tin Tên loại thức uống/ Tìm kiếm ở ô tương ứng

  * Click lựa chọn các nút chức năng muốn thực hiện

  * Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh

8) **Quản lý thức uống**

<img width="589" height="460" alt="Screenshot 2025-09-26 195417" src="https://github.com/user-attachments/assets/ea88892a-702a-4872-a736-5f036d28ad78" />

* Chức năng: Quản lý thông tin các Thức uống, bạn có thể Thêm/Sửa/Xóa/Tìm kiếm thông tin các Thức uống.

* Hướng dẫn:

  * Nhập thông tin Tên, Loại thức uống, Giá, Số lượng/ Tìm kiếm ở ô tương ứng

  * Click lựa chọn các nút chức năng muốn thực hiện

  * Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh

9) **Quản lý bàn**

<img width="594" height="460" alt="Screenshot 2025-09-26 195738" src="https://github.com/user-attachments/assets/7091588b-fb37-4241-89b4-2756977530d4" />

* Chức năng: Quản lý thông tin các Bàn, bạn có thể Thêm/Sửa/Xóa/Tìm kiếm thông tin các Bàn.

* Hướng dẫn:

  * Nhập thông tin Tên, Trạng thái/ Tìm kiếm ở ô tương ứng

  * Click lựa chọn các nút chức năng muốn thực hiện

  * Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh

10) **Quản lý nhân viên**

<img width="590" height="464" alt="Screenshot 2025-09-26 195939" src="https://github.com/user-attachments/assets/4656bd2d-60bf-42d4-aba9-40db3bb0e6fa" />

* Chức năng: Quản lý thông tin các Nhân viên, bạn có thể Thêm/Sửa/Xóa/Tìm kiếm thông tin các Nhân viên.

* Hướng dẫn:

  * Nhập thông tin Tên đăng nhập, Mật khẩu, Phân quyền/ Tìm kiếm ở ô tương ứng

  * Click lựa chọn các nút chức năng muốn thực hiện

  * Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên cạnh

11) **Thống kê**

<img width="590" height="466" alt="Screenshot 2025-09-26 200159" src="https://github.com/user-attachments/assets/5d5dfae4-9c19-4ab9-95e5-b7cbffe87c2b" />

* Chức năng: Thống kê thông tin các hóa đơn, bạn có thể thống kê thông tin các hóa đơn theo khoảng thời gian.

* Hướng dẫn:

  * Chọn khoảng thời gian cần thống kê

  * Click lựa chọn các nút Thống kê

  * Các thông tin bạn vừa xử lý sẽ được hiển thị tại bảng DataGridView bên dưới
