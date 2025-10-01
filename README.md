**PHẦN MỀM QUẢN QUÁN CAFE**

**Lời mở đầu**

Với sự phát triển nhanh chóng của công nghệ thông tin đã ra đời nhiều công cụ hữu ích giúp chúng ta tiết kiệm rất nhiều thời gian và chi phí. Nhiều phần mềm trong lĩnh vực công nghệ thông tin nhanh chóng ra đời đã góp phần đáng kể. Chính vì vậy, mỗi công ty, mỗi cơ quan đều muốn xây dựng riêng cho mình một phần mềm quản lý.

Để xây dựng một phần mềm có năng suất hoạt động tốt, cần có sự phối hợp về kiến thức cũng như ý tưởng và các yêu cầu trong dự án thay đổi thường xuyên. Vì vậy cần có một hệ thống quản lý phiên bản phân tán cho phép lập trình viên có thể quay lại phiên bản source code cũ hơn giúp lập trình viên dễ dàng xây dựng phần mềm.

Xuất phát từ những nhu cầu đó, em xây dựng một phần mềm “Quản lý quán cafe” trên nền tảng ngôn ngữ lập trình VB .NET, hệ quản trị cơ sở dữ liệu SQL và được xây dựng theo hướng phần mềm mã nguồn mở với các phiên bản được quản lý trên kho Github – một hệ thống quản lý phiên bản phân tán.

Mục tiêu là nhằm tạo ra phần mềm Quản lý quán cafe với các chức năng cơ bản của một phần mềm quản lý, đồng thời nắm bắt được cách tổ chức mã nguồn theo mô hình 3 lớp cũng như tài liệu xây dựng trên môi trường Github.

Qua đó tạo điều kiện cho các nhà phát triển có thể fix các lỗi và phát triển phần mềm tối ưu hơn, có thể áp dụng vào trong quá trình thực tế. Bởi lẽ do kiến thức còn hạn chế, ý tưởng chưa có nhiều nên phần mềm chưa được hoàn thiện.

**Lập trình viên thực hiện**  
Vũ Bích Ngân  
SĐT: 0968754534  
Email: [vubichngan10t@gmail.com](mailto:vubichngan10t@gmail.com)

**Thông tin tổ chức mã nguồn**  
<img width="529" height="221" alt="Screenshot 2025-09-25 194617" src="https://github.com/user-attachments/assets/35e39ea8-0f53-456f-bf3c-fbca0e98745d" />
<img width="402" height="797" alt="Screenshot 2025-09-25 193954" src="https://github.com/user-attachments/assets/f38978c3-9204-4c13-ab1d-46443c30db08" />

**Mã nguồn được phân chia theo 3 Tầng như sau:**

* Tầng DAO chứa các module xử lý các sự kiện của đối tượng trong từng Form giao diện, file DataProvider.vb chứa kết nối đến CSDL.

* Tầng DTO chứa các module dữ liệu của đối tượng được lấy từ CSDL.

* Tầng GUI chứa các Form giao diện, frmMain.vb trong tầng này sẽ là chương trình chính gọi tất cả các Form khác khi click sự kiện.

**Nền tảng xây dựng**  
[VB.NET](https://en.wikipedia.org/wiki/Visual_Basic_(.NET)) \- **Nền tảng hệ thống phần mềm**

* Visual Basic (VB), đôi khi được gọi là Visual Basic cổ điển, là ngôn ngữ lập trình thế hệ thứ ba dựa trên BASIC, cũng như môi trường phát triển tích hợp (IDE) liên quan.

* Visual Basic được Microsoft phát triển cho Windows và được biết đến với khả năng hỗ trợ phát triển ứng dụng nhanh (RAD) của các ứng dụng giao diện người dùng đồ họa (GUI), lập trình hướng sự kiện và cả việc sử dụng và phát triển các thành phần thông qua công nghệ Mô hình đối tượng thành phần (COM).

* VB được phát hành lần đầu tiên vào năm 1991\. Phiên bản cuối cùng là phiên bản 6 (VB6) vào năm 1998\. Vào ngày 8 tháng 4 năm 2008, Microsoft ngừng hỗ trợ IDE VB6, đưa nó trở lại trạng thái cũ.

#### **Ngôn ngữ ra đời cùng với .NET**

* VB.NET là viết tắt của Visual Basic.NET, là ngôn ngữ lập trình đa mô hình được phát triển bởi Microsoft trên khung .NET. 

* VB.NET được ra mắt vào năm 2002 với tư cách là sự kế thừa cho ngôn ngữ Visual Basic (VB6) nhưng có nhiều cải tiến mạnh mẽ nhờ nền tảng .NET Framework (sau này là .NET Core và .NET 5/6/7…)...

* VB.NET là ngôn ngữ lập trình hướng đối tượng, hỗ trợ các tính năng của lập trình hướng đối tượng bao gồm đóng gói, đa hình, trừu tượng hóa và kế thừa.

* VB.NET được thiết kế sao cho dễ hiểu đối với cả người lập trình mới và người lập trình nâng cao. Các chương trình được viết bằng ngôn ngữ này chạy với độ tin cậy và khả năng mở rộng cao, phù hợp cho phát triển ứng dụng Windows lẫn Web.

[MS SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2019) **\- Nền tảng cơ sở dữ liệu**

* SQL Server là một hệ quản trị cơ sở dữ liệu quan hệ (Relational Database Management System (RDBMS) ) sử dụng câu lệnh SQL (Transact-SQL) để trao đổi dữ liệu giữa máy Client và máy cài SQL Server. Một RDBMS bao gồm databases, database engine và các ứng dụng dùng để quản lý dữ liệu và các bộ phận khác nhau trong RDBMS.

* SQL Server được tối ưu để có thể chạy trên môi trường cơ sở dữ liệu rất lớn (Very Large Database Environment) lên đến Tera-Byte và có thể phục vụ cùng lúc cho hàng ngàn user. SQL Server có thể kết hợp “ăn ý” với các server khác như Microsoft Internet Information Server (IIS), E-Commerce Server, Proxy Server…

**Tài liệu cho người dùng cuối**

* Để xem tài liệu cho người dùng cuối, Vui lòng tham khảo [tại đây](https://github.com/vubichngan/QLQC/blob/main/Document/T%C3%A0i%20li%E1%BB%87u%20cho%20ng%C6%B0%E1%BB%9Di%20d%C3%B9ng%20cu%E1%BB%91i.md)

**Tài liệu cho nhà phát triển**

* Để xem tài liệu cho nhà phát triển, Vui lòng tham khảo [tại đây](https://github.com/vubichngan/QLQC/blob/main/Document/T%C3%A0i%20Li%E1%BB%87u%20D%C3%A0nh%20Cho%20Nh%C3%A0%20Ph%C3%A1t%20Tri%E1%BB%83n.md)

**Tài liệu thiết kế**

* Để xem tài liệu thiết kế, Vui lòng tham khảo [tại đây](https://github.com/vubichngan/QLQC/blob/main/Document/T%C3%A0i%20li%E1%BB%87u%20thi%E1%BA%BFt%20k%E1%BA%BF.md)

**Danh sách lỗi**

* Giao diện chưa đẹp,

* Thiết kế dữ liệu chưa hợp lý. Phần mềm chưa được hoàn thiện, hy vọng các bạn đóng góp ý kiến hay update danh sách các lỗi tại đây để nhóm hay các nhà phát triển khác có thể hoàn thiện sản phẩm hơn. 
