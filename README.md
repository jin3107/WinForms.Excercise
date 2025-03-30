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

[Bài tập bổ sung 1](#bs1)

[Bài tập bổ sung 2](#bs2)

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
    + Chọn 1 Món ăn và nhấn nút ` >> ` thì dòng dữ liệu được chọn bên Món ăn sẽ được xóa khỏi ListBox Món ăn và thêm vào ListBox Nước uống.
    + Chọn 1 Nước uống và nhấn nút ` << ` thì dòng dữ liệu được chọn bên Nước uống sẽ được xóa khỏi ListBox Nước uống và thêm vào ListBox Món ăn.

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
    
    + Khi người dùng chọn số lượng và nhấn nút *Tính tiền* thì giá tiền hiển thị trong Label Thành tiền.

<a name="7-36"></a>
### Bài 7 - trang 36
- Thiết kế giao diện như hình bên dưới: 
![Hình minh họa](./images/7-36.png)
- Yêu cầu:
    + Thiết kế giao diện, Combobox Lớp gồm có 2 lớp là: Cao đẳng 17 và Cao đẳng 18.
    + Khi chọn lớp **Cao đẳng 17** sẽ hiển thị các thông tin tương ứng như sau:

        | *Họ tên*      | *Lập trình GD* | *Mạng MT* | *CSDL SQL* |
        |:-------------:|:--------------:|:---------:|:----------:|
        | Anh Tuấn      | 9              | 8         | 9          |
        | Hoàng Giang   | 10             | 7         | 9          |
        | Trâm Anh      | 8              | 7         | 10         |

    + Khi chọn lớp **Cao đẳng 18** sẽ hiển thị các thông tin tương ứng như sau: 

        | *Họ tên*      | *Lập trình GD* | *Mạng MT* | *CSDL SQL* |
        |:-------------:|:--------------:|:---------:|:----------:|
        | Hữu Tiến      | 7              | 8         | 9          |
        | Thanh Lâm     | 5              | 4         | 6          |
        | Yến Như       | 4              | 7         | 7          |

    + Khi chọn 1 dòng ListView danh sách lớp thì thông tin chi tiết của sinh viên sẽ được hinể thị lên các đối tượng: Họ tên, Lập trình GD, Mạng MT, CSDL SQL. Đồng thời điểm trung bình của sinh viên đang được chọn sẽ hiển thị bên dưới ListView như hình trên.
    + Khi người dùng chỉnh sửa nội dung các đối tượng Họ tên, Lập trình GD, Mạng MT, CSDL SQL của dòng đang chọn trên ListView và nhấn nút **Cập nhật** thì thông tin chi tiết của sinh viên sẽ được cập nhật trên ListView.
    + Khi người dùng thêm nội dung các đối tượng Họ tên, Lập trình GD, Mạng MT, CSDL SQL của dòng đang chọn trên ListView và nhấn nút *Thêm* thông tin của sinh viên sẽ được thêm vào ListView.

<a name="8-37"></a>
### Bài 8 - trang 37
- Thiết kế form có dạng như sau:
![Hình minh họa](./images/8-37.png)
- Yêu cầu:
    + Trong menu, hiển thị tất cả danh mục thức uống tương ứng khi người dùng chọn loại thức uống gồm: Nước uống, nước ép, sinh tố.
    + Khi nhấn nút ` > `, thức uống được chọn trong Menu sẽ được thêm vào danh sách các thức uống đã chọn. Số lượng tăng thêm 1, thành tiền tăng theo đơn giá của thức uống.
    + Khi nhấn nút ` < `, thức uống đang chọn trên danh sách thức uống đã chọn sẽ giảm số lượng -1, thành tiền giảm theo đơn giá. Nếu soluong = 0 thì xóa khỏi danh sách.


Khi nhấn nút Tính, tính tổng thành tiền của các thức uống đã chọn.

<a name="9-38"></a>
### Bài 9 - trang 38
- Thiết kế form như hình bên dưới:
![Hình minh họa](./images/9-38.png)
- Mô tả:
    + Combobox **cbLoaiMonAn** danh sách các loại món ăn: Trung hira Quốc, Việt Nam, Hàn Quốc
    + CheckedListBox **listChiTietMonAn** chứa danh sách các món ăn của từng loại món ăn trên
    + Khi chọn **Việt Nam** sẽ hiển thị danh sách các món ăn: **Gỏi cuốn, Bánh Flan, Bún thịt nướng, Gà hấp chao**.
    + Khi chọn **Hàn Quốc** sẽ hiển thị danh sách các món ăn: **Su si, Canh rong biển, Kim chi, Cơm trộn**.
    + Khi chọn **Trung Quốc** sẽ hiển thị danh sách các món ăn: **Mì vịt tiềm, Mì xào giòn, Bánh canh vịt, Hột vịt lộn**.
    + ListView **dsMonAnChon** là danh sách các món ăn được chọn ở CheckedListBox.
    + NumericUpDown là số lượng đặt chọn cho món ăn đã chọn có giá trị mặc định từ 1-100.
- Yêu cầu:
    + Ban đầu cho Enabled *Chi tiết món ăn*. Khi người dùng chọn loại món ăn trong Combobox **LoaiMonAn**, danh sách các món ăn chi tiết sẽ được hiển thị ở dưới CheckedListBox **ChiTietMonAn**.
    + Người dùng chọn **1 hoặc nhiều** món ăn ở CheckedListBox **ChiTietMonAn**, gỡ vào số lượng (mặc định là 1), sau đó nhấn *Button btChon*, các món ăn này sẽ được thêm vào trong ListView **dsMonAnChon**. 
    + Khi nhấn button **Chọn**, nếu món ăn đã có trong danh sách thì sẽ cập nhật lại số lượng của món ăn đó với giá trị số lượng mới (không thêm dữ liệu trùng).
    + Nếu người dùng chọn **1 hoặc nhiều** món ăn ở **dsMonAnChon**, sau đó nhấn Button Bỏ Chọn số lượng sẽ giảm đi -1, nếu sau khi -1 mà số lượng = 0 món ăn này sẽ loại khỏi danh sách **dsMonAnChon**.
    + Khi nhấn Button **Tạo Mới**, sẽ xóa toàn bộ món ăn ở *D*SMonAnChon** (trước khi oMoi, hỏi người dùng có chắc chắn chưa).
    + Khi nhấn **Kết thúc**, kết thúc xử lý Form.

<a name="10-39"></a>
### Bài 10 - trang 39


<a name="bs1"></a>
### Bài tập bổ sung 1
- Thiết kế form như hình bên dưới:
![Hình minh họa](./images/BS1-1.png)
- Yêu cầu:
    + Khi người dùng nhập thời gian trong **textBox** của đèn xanh và đỏ, nhấn nút **Hiển Thị** thì thời gian của 2 đèn đó sẽ hiển thị trên **label**.
    + Nếu người dùng không nhập 1 trong 2 thời gian trên thì sẽ hiện **MessageBox** thông báo lỗi.
    + Màu đèn của mỗi đèn sẽ được cập nhật nếu hết thời gian đèn (Đèn vàng thì set cứng là 5 giây).
        * ![Hình minh họa](./images/BS1-2.png)
    + Lúc Runtime thì 3 pictureBox Xanh, Xàng, Đỏ đều là hình tròn/cầu/bầu dục... 
    + Bấm nút **Thoát** thì form sẽ kết thúc.

<a name="bs2"></a>
### Bài tập bổ sung 2
- Thiết kế form như hình bên dưới:
![Hình mình họa](./images/BS2-1.png)
- Yêu cầu: Công ty Taxi ABC cung cấp dịch vụ với giá cước được quy định bằng bảng giá như sau:
    + Giá cước km đầu tiên là 20000 vnd/km.
    + Giá cước km thứ 2-12 tiếp theo là 16000 vnd/km.
    + Giá cước km thứ 13-25 là 15500 vnd/km.
    + Giá cước từ km 26 trở đi là 13500 vnd/km.
    + ![Hình minh họa](./images/BS2-2.png)
        * Ví dụ: 17.3 -> Số tiền là 287150 vnd/km;
                0.5 -> Số tiền là 20000 vnd/km;
                10 -> Số tiền là 164000 vnd/km.