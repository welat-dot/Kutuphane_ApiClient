using KutuphaneDataAccess.DatabaseIslemleri.Abstract;
using KutuphaneDataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KutuphaneApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UyeController : ControllerBase
    {
        private IUye uyeManager;
        public UyeController(IUye uyeManager)
        {
            this.uyeManager = uyeManager;
        }
        [Route("uyeGetir"), HttpGet]
        public IActionResult YazarGetir()
        {
            try
            {
                return Ok(uyeManager.GetUyes());
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
        [Route("uyeDuzenle"), HttpPost]
        public IActionResult UyeDuzenle(Uye uye)
        {
            try
            {
                return Ok(uyeManager.Duzenle(uye));
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }

        }
        [Route("uyeEkle"), HttpPost]
        public IActionResult UyeEkle(Uye uye)
        {
            try
            {
                return Ok(uyeManager.Ekle(uye));
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }

        }
        [Route("uyeSil"), HttpPost]
        public IActionResult UyeSil(Uye uye)
        {
            try
            {
                return Ok(uyeManager.Sil(uye));
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }

        }
    }

}
