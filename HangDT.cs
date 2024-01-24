public class HangDT : IHangHoa
{
    private string ten;
    private float gia;
    private float thue;

    public void NhapHang(string ten, float thue, float gia)
    {
        this.ten = ten;
        this.gia = gia;
        this.thue = thue;
    }

    public void XuatHoaDon()
    {
        Console.Write($"Hang: {ten}, Gia: {gia}, Thue: {thue}");
    }
}