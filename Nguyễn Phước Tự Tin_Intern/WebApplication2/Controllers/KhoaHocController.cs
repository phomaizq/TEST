using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

public class KhoaHocController : Controller
{
    private readonly MyDbContext _context;

    public KhoaHocController(MyDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var khoaHocs = await _context.KhoaHocs.ToListAsync();
        return View(khoaHocs);
    }

    public async Task<IActionResult> MonHocByKhoaHoc(int khoaHocId)
    {
        var monHocs = await _context.MonHocs
            .Where(m => m.KhoaHocID == khoaHocId)
            .ToListAsync();
        var khoaHoc = await _context.KhoaHocs.FindAsync(khoaHocId);
        ViewBag.CourseName = khoaHoc.TenKhoaHoc;
        return PartialView("_MonHocPartial", monHocs);
    }
}
