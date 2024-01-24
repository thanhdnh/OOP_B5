public class Program
{
  public static void Main(string[] args)
  {
    IHangHoa h1 = new HangDT();
    IHangHoa h2 = new HangNS();
    h1.NhapHang("Điện thoại", 12000000, 10);
    h2.NhapHang("Thịt lợn", 50000);
    h1.XuatHoaDon();
    h2.XuatHoaDon();

    //Sao chép sâu nhờ vào IClonable
    HangDT h3 = (HangDT)((HangDT)h1).Clone();
    HangNS h4 = (HangNS)((HangNS)h2).Clone();

    //So sánh giá 2 mặt hàng nhờ vào IComparable
    if(h3.CompareTo(h4)>0)
      Console.WriteLine($"{h3} gia cao hon {h4}");
    else if(h3.CompareTo(h4)<0)
      Console.WriteLine("{h3} gia thap hon {h4}");
    else
      Console.WriteLine($"{h3} gia bang {h4}");

    Console.ReadLine();
  }
}