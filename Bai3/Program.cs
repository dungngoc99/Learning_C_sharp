using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write()
            //Console.Write("Kteam");//In ra màn hình dòng chữ Kteam
            //Console.Write(10);//In ra màn hình số 10
            //Console.Write(10.9f);//In ra màn hình số 10.9 (f biểu thị cho kiểu dữ liệu float)
            //Console.Write(true);//In ra màn hình chữ true của kiểu dữ liệu boolean
            //Đóng/mở note: Ctrl + K + C/U


            //Các cách viết xuống dòng
            //Console.Write("KTeam \n"); // \n có ý nghĩa xuống dòng
            //Console.WriteLine("KTeam \n"); // \n có ý nghĩa xuống dòng
            //Console.WriteLine(5);//Sử dụng lệnh in ra màn hình + có xuống dòng
            //Console.Write(Environment.NewLine);//để cách 1 dòng trắng
            //Console.Write(true);
            //Console.ReadLine();//dùng để dừng màn hình,đánh enter để tiếp tục

            //int a = 5;//khai báo biến kiểu số nguyên có tên a, khởi tạo giá trị là 5
            //Console.WriteLine("a= {0}", a);//in ra màn hình giá trị
            ////Console.Write(a);//in ra màn hình giá trị của
            //Console.Write("{0},{1},{2},{3}",9,2,3,"howKTeam.com");
            //Console.ReadKey();//dùng với mục đích dừng màn hình để xem kết quả

            //Đọc ký tự đầu tiên từ bàn phím bằng lệnh Console.Read() sau đó in ra ký tự vừa đọc bằng kiểu số nguyên (mã ascii), lệnh này không đọc được các phím chức năng
            //Console.WriteLine(Console.Read());

            ////Đọc dữ liệu từ bàn phím cho đến khi enter xuống dòng thì dừng, sau đó in giá trị đã nhập ra màn hình
            //Console.WriteLine(Console.ReadLine());

            
            //Trả về kiểu dữ liệu consoleKeyInfor
            Console.ReadKey();//Không truyền tham số vào thì mặc định là false
            Console.ReadKey(false);//hiển thị phím ấn lên màn hình
            Console.ReadKey(true);//không hiển thị phím ấn lên màn hình

        }
    }
}
