public class HangDT : IHangHoa, IComparable, ICloneable
{
  private string ten;
  private float gia;
  private float thue;

  public float Gia { get => gia; set => gia = value; }

  public object Clone()
  {
    HangDT hang = new HangDT();
    hang.ten = ten;
    hang.gia = gia;
    hang.thue = thue;
    return hang;
  }

  public int CompareTo(object obj)
  {
    float g = (obj is HangDT) ? ((HangDT)obj).gia : ((HangNS)obj).Gia;
    if (gia > g)
      return 1;
    else if (gia < g)
      return -1;
    else
      return 0;
  }

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

  public override string ToString()
  {
    return ten;
  }
}