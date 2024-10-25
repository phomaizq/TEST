
namespace WebApplication2.Models
{
    public class KhoaHoc
    {
        public int ID { get; set; }

        public string TenKhoaHoc { get; set; }

        public ICollection<MonHoc> MonHocs { get; set; }
    }
}
