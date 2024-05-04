using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMvcBooksWithDb.Data;
using WebMvcBooksWithDb.Models;
using WebMvcBooksWithDb.ViewModelsForBook;

namespace WebMvcBooksWithDb.Controllers
{
    public class YeniKitapAdminController : Controller
    {
        public ApplicationDbContext _context;
        public IWebHostEnvironment _environment;

        public YeniKitapAdminController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public async Task<IActionResult> Index()
        {
            List<YeniKitap> kitapListesi = new List<YeniKitap>();
            kitapListesi = await _context.YeniKitap.ToListAsync(); //select * from Kitap 
            return View(kitapListesi);
        }

        //bu metod ekranı oluşturan metod 
        public IActionResult Create()
        {
            return View();
        }

        //bu metodda ekrandan girilen değerleri alıp işleyecek metodumuz
        [HttpPost]
        public async Task<IActionResult> Create(YeniKitapViewModel model)
        {
            try
            {
                //if(ModelState.IsValid)
                //{
                string yuklenenResimAdi = ResimYukle(model);
                YeniKitap kitap = new YeniKitap
                {
                    KitapAdi = model.KitapAdi,
                    Fiyat = model.Fiyat,
                    SayfaSayisi = model.SayfaSayisi,
                    KitapResmi = yuklenenResimAdi,
                    YayinlanmaTarihi = model.YayinlanmaTarihi
                };

                _context.Add(kitap); //insert into
                await _context.SaveChangesAsync(); // oluşturulan insert kodunu sqlserver execute edecek
                return RedirectToAction(nameof(Index));
                // }
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction(nameof(Index));
        }
        private string ResimYukle(YeniKitapViewModel model)
        {
            string dosyaAdi = "";
            string dosyaninYuklenecegiKlasorYolu = Path.Combine(_environment.WebRootPath, "Uploads");

            if (!Directory.Exists(dosyaninYuklenecegiKlasorYolu))
            {
                Directory.CreateDirectory(dosyaninYuklenecegiKlasorYolu);
            }

            if (model.KitapResimFile.FileName != null)
            {
                dosyaAdi = model.KitapResimFile.FileName;
                string filePath = Path.Combine(dosyaninYuklenecegiKlasorYolu, dosyaAdi);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    //seçilen resim ilgili klasörü ilgili ismi ile birlikte oluşturulur
                    model.KitapResimFile.CopyTo(fileStream);
                }

            }
            return dosyaAdi;
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitapDetay = await _context.YeniKitap.FindAsync(id);

            YeniKitapViewModel kitapViewModel = new()
            {
                KitapAdi = kitapDetay.KitapAdi,
                Fiyat = kitapDetay.Fiyat,
                YayinlanmaTarihi = kitapDetay.YayinlanmaTarihi,
                SayfaSayisi = kitapDetay.SayfaSayisi,
                KitapResmiUrl = kitapDetay.KitapResmi
            };
            return View(kitapViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, YeniKitapViewModel model)
        {
            var kitap = await _context.YeniKitap.FindAsync(model.Id);
            
            //düzenleme sayfasında bir başka resim seçtiysem kontrolünü yapmam gerekiyro
            if (model.KitapResimFile != null)
            {
                //resmini değiştirmek istediğim ürünün database deki kitapResim kolonundaki adına göre
                // git wwwroot klasörü altındaki Uploads klasöründeki ilgili resmi bul ve sil
                string filePath = Path.Combine(_environment.WebRootPath, "Uploads", kitap.KitapResmi);
                System.IO.File.Delete(filePath);

                kitap.KitapAdi = model.KitapAdi;
                kitap.Fiyat = model.Fiyat; 
                kitap.YayinlanmaTarihi = model.YayinlanmaTarihi;
                kitap.SayfaSayisi = model.SayfaSayisi;
                string guncellenenYuklenenResimAdi = ResimYukle(model); //=model.KitapResimFile.FileName
                kitap.KitapResmi = guncellenenYuklenenResimAdi;

                //YeniKitap guncellencekKitap = new YeniKitap();
                ////guncellencekKitap.Id = model.Id;
                //guncellencekKitap.Fiyat = model.Fiyat;
                //guncellencekKitap.YayinlanmaTarihi = model.YayinlanmaTarihi;
                //guncellencekKitap.SayfaSayisi = model.SayfaSayisi;
                //string guncellenenYuklenenResimAdi = ResimYukle(model);
                //guncellencekKitap.KitapAdi = model.KitapAdi;
                //guncellencekKitap.KitapResmi = guncellenenYuklenenResimAdi;

                _context.Entry(kitap).State = EntityState.Modified;
                //_context.YeniKitap.Update(guncellencekKitap);
                try
                {
                    await _context.SaveChangesAsync(); //update 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString()
                        );
                }


            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //select * from Kitap where Id=id
            var kitap = await _context.YeniKitap
                .FirstOrDefaultAsync(m => m.Id == id);

            string filePath = Path.Combine(_environment.WebRootPath, "Uploads", kitap.KitapResmi);
            System.IO.File.Delete(filePath);
            _context.YeniKitap.Remove(kitap);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
