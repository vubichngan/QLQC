# **Tài liệu thiết kế**

Đây là tài liệu phân tích thiết kế hệ thống trước khi bắt tay và xây dựng phần mềm

## **Đặc tả hệ thống**

* Hệ thống quản lý quán cafe này dành cho hai lớp người sử dụng (quản lý và nhân viên) nên thực hiện chức năng phân quyền.  
* Hệ thống thực hiện các chức năng Đăng nhập, Quản lý hóa đơn theo bàn, Tách bàn, Chuyển bàn, Thanh toán, Quản lý loại thức uống, Quản lý thức uống, Quản lý bàn, Quản lý nhân viên, Thống kê.  
* Tất cả những thay đổi tác động qua từng chức năng đều ảnh hưởng đến Cơ sở dữ liệu.

## **Sơ đồ phân rã phần mềm**

<img width="745" height="421" alt="Screenshot 2025-09-27 093246" src="https://github.com/user-attachments/assets/4775e82c-a551-45ba-aaf2-889cb577ef35" />


## **Sơ đồ phân rã chức năng (BFD)**

Sơ đồ phân rã chức năng của quản lý  
<img width="1212" height="575" alt="Screenshot 2025-09-27 103747" src="https://github.com/user-attachments/assets/416582dd-5c60-400e-8a0c-49ff4b3f51c0" />


Sơ đồ phân rã chức năng của nhân viên  
<img width="794" height="540" alt="Screenshot 2025-09-27 212105" src="https://github.com/user-attachments/assets/d248c856-d930-48a3-a845-645c60b81d06" />

## **Sơ đồ thực thể \- quan hệ (ERD)**

<img width="1195" height="663" alt="Screenshot 2025-09-28 103219" src="https://github.com/user-attachments/assets/d2e6ded9-c14a-4b90-b644-a1fcf1e27a03" />

## **Thiết kế và mô tả mô hình dữ liệu vật lý**

### **1) Bảng Account**

<img width="428" height="132" alt="Screenshot 2025-09-27 212946" src="https://github.com/user-attachments/assets/287c8c42-948a-48d2-89bf-d31bfc8b4656" />

**Mô tả:**

* id: Mã tài khoản người dùng

* userName: Tên người dùng

* passWord: Mật khẩu

* type: Phân quyền người dùng (1: Quản lý/ 0: Nhân viên)


### **2) Bảng DrinkTable**

<img width="437" height="109" alt="Screenshot 2025-09-28 080934" src="https://github.com/user-attachments/assets/40543f70-1164-45ea-9511-ee87ccdc8900" />

**Mô tả:**

* id: Mã bàn

* name: Tên bàn

* status: Trạng thái (Trống/ Có người)


### **3) Bảng DrinkCategory**

<img width="405" height="83" alt="Screenshot 2025-09-28 082636" src="https://github.com/user-attachments/assets/67b9a867-b75b-45b5-8044-e73f9f8e649b" />

**Mô tả:**

* id: Mã loại thức uống

* name: Tên loại thức uống

### **4) Bảng Drinks**

<img width="445" height="163" alt="Screenshot 2025-09-28 083013" src="https://github.com/user-attachments/assets/60f17d10-5769-4039-bf1f-702eb57bd804" />

**Mô tả:**

* id: Mã thức uống

* name: Tên thức uống

* idCategory: Mã loại thức uống

* price: Giá một ly thức uống

* quantity: Số lượng thức uống trong kho

### **5) Bảng Bill**

<img width="457" height="192" alt="Screenshot 2025-09-28 105141" src="https://github.com/user-attachments/assets/5adcc966-5562-4e0d-9de6-61ca1a941c09" />

**Mô tả:**

* id: Mã hóa đơn

* dateCheckIn: Ngày lập hóa đơn

* dateCheckOut: Ngày hóa đơn được thanh toán

* idTable:  Mã bàn

* idAccount: Mã tài khoản người dùng lập hóa đơn

* status: Trạng thái hóa đơn (1: đã thanh toán/ 0: chưa thanh toán)

### **6) Bảng BillInFo**

<img width="423" height="136" alt="Screenshot 2025-09-28 110538" src="https://github.com/user-attachments/assets/8ae4f997-be03-4a5f-826c-fc2198a95935" />

**Mô tả:**

* id: Mã thông tin chi tiết hóa đơn

* idBill: Mã hóa đơn

* idDrink: Mã thức uống

* count: số lượng từng thức uống có trong hóa đơn
