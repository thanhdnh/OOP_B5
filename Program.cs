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
    
    Console.ReadLine();
  }
}