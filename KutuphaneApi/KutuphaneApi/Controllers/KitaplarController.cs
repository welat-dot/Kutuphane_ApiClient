using KutuphaneDataAccess.DatabaseIslemleri.Abstract;
using KutuphaneDataAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitaplarController : ControllerBase
    {
        private IKitap kitapManager;
        public KitaplarController(IKitap kitapManager)
        {
            this.kitapManager = kitapManager;
        }
        [Route("kitapGetir"),HttpGet]
        public IActionResult Getir()
        {
            try
            {
                return Ok(kitapManager.GetKitaps());
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
        [Route("kitapEkle"),HttpPost]
        public IActionResult Ekle(Kitap kitap)
        {
            try
            {
                return Ok(kitapManager.Ekle(kitap));
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
        [Route("kitapDuzenle"), HttpPost]
        public IActionResult Duzenle(Kitap kitap)
        {
            try
            {
                return Ok(kitapManager.Duzenle(kitap));
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
        [Route("kitapSil"), HttpPost]
        public IActionResult Sil(Kitap kitap)
        {
            try
            {
                return Ok(kitapManager.Sil(kitap));
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
    }
}
