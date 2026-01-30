// See https://aka.ms/new-console-template for more information

/*
    Biến (Variable): giống Java
        - lưu trữ dữ liệu, dữ liệu được nhập từ bàn phím hoặc được trả về từ chương trình
        - Đặc điểm:
            + Biến là duy nhất
            + Mỗi biến có 1 kiểu dữ liệu
            + Giá trị của biến có thể thay đổi
        - Khai báo biến:
            + Khai báo biến mà không gán giá trị
                data_type variable_name;
            + Khai báo biến và gán giá trị
                data_type variable_name = value;
        - Quy tắc đặt tên biến:
            + Tên biến không chứa ký tự đặc biệt
            + Tên biến chỉ được chứa chữ cái, số, _
            + Tên biến không được bắt đầu bằng số
            + Tên biến phân biệt hoa thường
            + Tên biến không trùng từ khóa
    Kiểu dữ liệu (data type): giống Java
        - Là kiểu mà giá trị của biến phải tuân theo
        - 1 số kiểu dữ liệu cơ bản
            + Số nguyên: int
            + Số thực: float, double
            + Ký tự: char
            + Chuỗi: string
    Toán tử (Operator): giống java
        - Ký hiệu thể hiện các phép toán
        - 1 số loại toán tử
            + Toán tử số học: +, -, *, /, %
            + Toán tử quan hệ: >, <, >=, <=, ==, !=
            + Toán tử logic: &&, ||, !
            + Toán tử gán: =, +=, -=, *=, /=, %=
    Từ khóa (Keyword):
        - Từ xây dựng sẵn trong ngôn ngữ lập trình
        - Mỗi từ có 1 chức năng, không thể thay đổi chức năng
    Cấu trúc điều khiển rẽ nhánh (Condition): giống Java
        - Thực hiện 1 khối lệnh khi 1 điều kiện nào đó được thỏa mãn
        
        if(condition){
            code block;
        }
        
        if(condition){
            code block 1;
        } else {
            code block 2;
        }
        
        if(condition 1){
            code block 1;
        } else if(condition 2){
            code block 2;
        } else if(condition 3){
            code block 3;
        } ...
        else {
            code block n;
        }
        
        if(condition 1){
            if(condition 2){
                code block;
            }
        } else if(condition 3){
            if(condition 4){
                code block 2;
            } else if(condition 5){
                code block 3;
            } else {
                code block 4;
            }
        } else {
            if(condition 6){
                code block 5;
            }
        }
    Cấu trúc lựa chọn (switch - case): giống java
        - Khi tất cả các điều kiện đều là so sánh == với 1 biến
        - Khi gặp case thỏa mãn: thực hiện code block trong case đó và những case được viết sau case thỏa mãn
        
        switch(variable){
            case value_1:
                code block 1;
                break;
            case value_2:
                code block 2;
                break;
            ...
            default:
                code block n;
                break;
    Nhập, xuất dữ liệu:
        - Nhập:
            Console.Read(): Cho phép nhập 1 ký tự, lưu dưới dạng số quy chiếu từ bảng mã ASCII
            Console.ReadLine(): cho phép nhập 1 chuỗi, nhập sao lưu vậy
        - Xuất:
            Console.Write(): Hien thi xong khong xuong dong
            Console.WriteLine(): Hien thi xong xuong dong
    Ép kiểu (Casting):
        Ép sang kiểu nguyên: Int.Parse()
        Ép sang số thực: Double.Parse()
        Ép sang chuỗi: .toString()
*/

/*
    1. Nhap 2 so thuc a, b. Tinh tong, hieu, tich, thuong
*/

//Khai bao a, b
double a, b;
//Nhap a, b
Console.Write("a = ");
a = Double.Parse(Console.ReadLine());
Console.Write("b = ");
b = Double.Parse(Console.ReadLine());
//Tinh tong
double tong = a + b;
Console.WriteLine("a + b = " + tong);
//Tinh hieu
double hieu = a - b;
Console.WriteLine("a - b = " + hieu);
//Tinh tich
double tich = a * b;
Console.WriteLine("a * b = " + tich);
//Tinh thuong
if (b != 0)
{
    double thuong = a / b;
    Console.WriteLine("a / b = " + thuong);
}
else
{
    Console.WriteLine("Khong chia duoc cho 0");
}

/*
    2. Nhap so nguyen n. Kiem tra n la so am hay duong
*/

//Khai bao n
int n;
//Nhap n
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
//Kiem tra
if (n < 0)
{
    Console.WriteLine("n la so am");
} else if (n > 0)
{
    Console.WriteLine("n la so duong");
}
else
{
    Console.WriteLine("n khong am khong duong");
}