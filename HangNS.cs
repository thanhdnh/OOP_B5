public class HangNS : IHangHoa, IComparable, ICloneable
{
  private string ten;
  private float gia;

  public float Gia { get => gia; set => gia = value; }

  public object Clone()
  {
    HangNS hang = new HangNS();
    hang.ten = ten;
    hang.gia = Gia;
    return hang;
  }

  public int CompareTo(object? obj)
  {
    float g = (obj as HangDT != null) ? ((obj as HangDT).Gia) : ((obj as HangNS).gia);
    if (gia > g)
      return 1;
    else if (gia < g)
      return -1;
    else
      return 0;
  }

  public void NhapHang(string ten, float gia, float thue = 0)
  {
    this.ten = ten;
    this.gia = gia;
  }

  public void XuatHoaDon()
  {
    Console.WriteLine($"Hang: {ten}, Gia: {gia}");
  }

  public override string ToString()
  {
    return ten;
  }
}