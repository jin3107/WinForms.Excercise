> Thực hiện: **Huỳnh Tấn Chương**
>
> Cập nhật lần cuối: **00/00/0000**

# Bài tập Winform bằng ngôn ngữ C#

### Mực lục

[Bài 2 - trang 33](#2-33)
[Bài 3 - trang 33](#3-33)
[Bài 4 - trang 34](#4-34)
[Bài 5 - trang 34](#5-34)
[Bài 6 - trang 35](#6-35)
[Bài 7 - trang 36](#7-36)
[Bài 8 - trang 37](#8-37)
[Bài 9 - trang 38](#9-38)
[Bài 10 - trang 39](#10-39)

# Bài tập Chương 2

<a name="2-33"></a>
### Bài 2 - trang 33
- Thiết kế form như hình bên dưới:
![Hình minh họa](./images/2-33.png)
- Khi người dùng nhập vào các thông tin trên các TextBox: Họ tên, ngày sinh sở thích và nhấn nút **Xác nhận** thì sẽ xuất hiện một hộp thoại xác nhận lại những thông tin đã nhập.

<a name="3-33"></a>
### Bài 3 - trang 33
- Thiết kế form thực hiện các chức năng sau:
![Hình minh họa](./images/3-33-1.png)
- Yêu cầu: 
    + Khi nhấn Laptop, USB, Mouse sẽ hiển thị tên các loại sản phẩm tương ứng trên ListBox và các hình thể hiện minh họa trên các PictureBox.
    + Khi nhấn trên ListBox, chỉ hiển thị duy nhất 1 hình của sản phẩm đang chọn.
    ![Hình minh họa](./images/3-33-2.png)

<a name="4-34"></a>
### Bài 4 - trang 34
- Thiết kế giao diện bằng ListBox có các giá trị: Việt Nam, Nhật Bản, Hàn Quốc, Trung Quốc. Khi người dùng nhập nội dung vào TextBox và nhấn nút Thêm nội dung sẽ hiển thị trên TextBox. Nếu người dùng chỉnh sửa nội dung trên TextBox và nhấn nút Cập nhật thì nội dung sẽ được cập nhật vào ListBox, nếu chọn Xóa thì nội dung sẽ được xóa khỏi ListBox.
![Hình minh họa](./images/4-34.png)

<a name="5-34"></a>
### Bài 5 - trang 34
- Thiết kế giao diện như hình bên dưới:
![Hình minh họa](./images/5-34.png)
- Yêu cầu:
    + Thiết kế giao diện.
    + Khi người dùng nhập thông tin vào TextBox Tên món và chọn Nước uống hoặc Món ăn và nhấn nút Thêm thì thông tin món ăn sẽ được thêm vào ListBox tương ứng.
    + Chọn 1 Món ăn và nhấn nút `>>` thì dòng dữ liệu được chọn bên Món ăn sẽ được xóa khỏi ListBox Món ăn và thêm vào ListBox Nước uống.
    + Chọn 1 Nước uống và nhấn nút `<<` thì dòng dữ liệu được chọn bên Nước uống sẽ được xóa khỏi ListBox Nước uống và thêm vào ListBox Món ăn.

<a name="6-35"></a>
### Bài 6 - trang 35
- Thiết giao diện như hình bên dưới:
![Hình minh họa](./images/6-35.png)
- Yêu cầu:
    + Thiết kế giao diện.
    + Combobox loại xe gồm các loại xe: Vision, Click, SH mode. Khi chọn 1 loại xe sẽ hiển thị thông tin tương ứng như bảng bên dưới.
    
    | *Loại xe*  | *Màu*    | *Đơn giá*    |
    |:----------:|:--------:|:------------:| 
    |  Vision    | Xanh     | 35.000.000   |
    |  Click     | Trắng    | 42.000.000   |
    |  SH mode   | Đỏ       | 50.000.000   |
    
    + Khi người dùng chọn số lượng và nhấn nút *Tính tiền* thì giá tiền hinể thị trong Label Thành tiền.

<a name="7-36"></a>
### Bài 7 - trang 36
- Thiết kế giao diện như hình bên dưới: 
![Hình minh họa](./images/7-36.png)
- Yêu cầu:
    + Thiết kế giao diện, Combobox Lớp gồm có 2 lớp là: Cao đẳng 17 và Cao đẳng 18.
    + Khi chọn lớp **Cao đẳng 17** sẽ hiển thị các thông tin tương ứng như sau:

    | **Họ tên**      | **Lập trình GD** | **Mạng MT** | **CSDL SQL** |
    |:---------------:|:----------------:|:-----------:|:------------:|
    | Anh Tuấn        | 9                | 8           | 9            |
    | Hoàng Giang     | 10               | 7           | 9            |
    | Trâm Anh        | 8                | 7           | 10           |

    + Khi chọn lớp **Cao đẳng 18** sẽ hiển thị các thông tin tương ứng như sau: 

    | **Họ tên**      | **Lập trình GD** | **Mạng MT** | **CSDL SQL** |
    |:---------------:|:----------------:|:-----------:|:------------:|
    | Hữu Tiến        | 7                | 8           | 9            |
    | Thanh Lâm       | 5                | 4           | 6            |
    | Yến Như         | 4                | 7           | 7            |

    + Khi chọn 1 dòng ListView danh sách lớp thì thông tin chi tiết của sinh viên sẽ được hinể thị lên các đối tượng: Họ tên, Lập trình GD, Mạng MT, CSDL SQL. Đồng thời điểm trung bình của sinh viên đang được chọn sẽ hiển thị bên dưới ListView như hình trên.
    + Khi người dùng chỉnh sửa nội dung các đối tượng Họ tên, Lập trình GD, Mạng MT, CSDL SQL của dòng đang chọn trên ListView và nhấn nút **Cập nhật** thì thông tin chi tiết của sinh viên sẽ được cập nhật trên ListView.
    + Khi người dùng thêm nội dung các đối tượng Họ tên, Lập trình GD, Mạng MT, CSDL SQL của dòng đang chọn trên ListView và nhấn nút **Thêm** thông tin của sinh viên sẽ được thêm vào ListView.

<a name="8-37"></a>
### Bài 8 - trang 37


<a name="9-38"></a>
### Bài 8 - trang 38


<a name="10-39"></a>
### Bài 10 - trang 39