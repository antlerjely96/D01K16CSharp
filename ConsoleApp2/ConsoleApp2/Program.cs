// See https://aka.ms/new-console-template for more information

/*
    Vòng lặp (Loop): Giống Java
        - Thực hiện 1 khối lệnh lặp lại nhiều lần
        - 3 loại vòng lặp: for, while, do - while
            + for
                - Cấu trúc:
                    for(tham số 1; tham số 2; tham số 3){
                        code block;
                    }
                - Tham số 1: Thời điểm bắt đầu vòng lặp, thiếu tham số 1 => lỗi cú pháp
                - Tham số 2: Điều kiện duy trì vòng lặp, thiếu tham số 2 => vòng lặp vô hạn
                - Tham số 3: Bước nhảy của vòng lặp, thiếu tham số 3 => Vòng lặp vô hạn
                - Đặc điểm:
                    => Vòng lặp for kiểm tra trước, thực hiện sau:
                        Kiểm tra tham số 2 trước, sau đó mới thực hiện code block -> Vòng lặp for có thể thực hiện 0 hoặc n lần
                    => Cách sử dụng: được sử dụng khi biết trước được số lần lặp
            + while
                - Cấu trúc:
                    tham số 1;
                    while(tham số 2){
                        code block;
                        tham số 3;
                    }
                - Đặc điểm:
                    => Vòng lặp while kiểm tra trước, thực hiện sau:
                        Kiểm tra tham số 2 trước, sau đó mới thực hiện code block -> Vòng lặp for có thể thực hiện 0 hoặc n lần
                    => Cách sử dụng: được sử dụng khi biết trước hoặc không biết trước được số lần lặp
            + do - while
                - Cấu trúc:
                    tham số 1;
                    do {
                        code block;
                        tham số 3;
                    } while(tham số 2);
                    
                    
                    do {
                        tham số 1;
                        code block;
                        tham số 3;
                    } while(tham số 2);
                - Đặc điểm:
                    => Vòng lặp do - while: Thực hiện trước, kiểm tra sau
                        Thực hiện code block trước, sau đó mới kiểm tra tham số 2 -> vòng lặp do - while luôn thực hiện ít nhất 1 lần
            + Nested if: Vòng lặp lồng nhau (vòng lặp lồng trong vòng lặp - vòng lặp này là khối lệnh của vòng lặp khác)                    
*/

/*
    1. Nhập số nguyên n từ bàn phím. Hiển thị các số từ 1 đến n
*/

//Khai báo n
int n, i;
//Nhập n
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
//Hiển thị
Console.WriteLine("-- for --");
for (i = 1; i <= n; i++)
{
    Console.Write(i + "\t");
}
Console.WriteLine();
Console.WriteLine("-- while --");
i = 1;
while (i <= n)
{
    Console.Write(i + "\t");
    i++;
}
Console.WriteLine();
Console.WriteLine("-- do - while --");
i = 1;
do
{
    Console.Write(i + "\t");
    i++;
} while(i <= n);
Console.WriteLine();
/*
    Mảng (Array): Giống Java
        - Là 1 tập hợp các phần tử có cùng kiểu dữ liệu
        - Các phần tử trong mảng được phân biệt với nhau bằng 1 số nguyên gọi là chỉ số index
        - Chỉ số index luôn bắt đầu từ 0
        - Cách khai báo
            data_type[] array_name = new data_type[number_element];
        - Truy xuất phần tử:
            array_name[index];
        - Truy xuất lần lượt tất cả từng phần tử trong mảng
            Dùng vòng lặp chạy theo chỉ số index => tham số 1 bắt đầu từ 0
        - Mảng được chia làm 2 loại: Mảng 1 chiều, mảng đa chiều
            + Mảng 1 chiều: Mảng có giá trị là 1 giá trị nguyên tử
            + Mảng đa chiều: Mảng có giá trị của 1 phần tử là 1 mảng khác
*/

/*
    2. Nhập mảng số nguyên có m phần tử. Hiển thị mảng đã nhập
*/

//Khai báo m
int m;
//Nhập m
Console.Write("m = ");
m = int.Parse(Console.ReadLine());
//Khai báo mảng
int[] arr = new int[m];
//Nhập mảng
for (i = 0; i < m; i++)
{
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//Hiển thị mảng đã nhập
Console.WriteLine("Mảng đã nhập:");
for (i = 0; i < m; i++)
{
    Console.WriteLine("arr[" + i + "] = " + arr[i]);
}