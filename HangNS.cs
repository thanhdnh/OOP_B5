public class HangNS : IHangHoa
{
    private string ten;
    private float gia;
    public void NhapHang(string ten, float gia, float thue = 0)
    {
        this.ten = ten;
        this.gia = gia;
    }

    public void XuatHoaDon()
    {
        Console.WriteLine($"Hang: {ten}, Gia: {gia}");
    }
}