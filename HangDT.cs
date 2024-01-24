public class HangDT : IHangHoa
{
    private string ten;
    private float gia;
    private float thue;

    public void NhapHang(string ten, float gia, float thue)
    {
        this.ten = ten;
        this.gia = gia;
        this.thue = thue;
    }

    public void XuatHoaDon()
    {
        Console.WriteLine($"Hang: {ten}, Gia: {gia}, Thue: {thue}");
    }
}