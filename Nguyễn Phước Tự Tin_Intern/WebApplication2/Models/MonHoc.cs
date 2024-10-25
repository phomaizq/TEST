namespace WebApplication2.Models
{
    public class MonHoc
    {
        public int ID { get; set; }

        public string TenMonHoc { get; set; }

        public string MoTa { get; set; }

        public int KhoaHocID { get; set; }

        public KhoaHoc KhoaHoc { get; set; }
    }
}
