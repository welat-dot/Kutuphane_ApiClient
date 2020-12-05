using KutuphaneDataAccess.DatabaseIslemleri.Abstract;
using KutuphaneDataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KutuphaneApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YazarController : ControllerBase
    {
        private IYazar yazarManager;
        public YazarController(IYazar yazarManager)
        {
            this.yazarManager = yazarManager;
        }
        [Route("ekle"),HttpPost]
        public IActionResult YazarEkle (Yazar yazar)
        {
            try
            {
                return Ok(yazarManager.Ekle(yazar));
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
            
        }
        [Route("yazarDuzenle"), HttpPost]
        public IActionResult YazarDuzenle(Yazar yazar)
        {
            try
            {
                return Ok(yazarManager.Duzenle(yazar));
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }

        }
        [Route("yazarGetir"),HttpGet]
        public IActionResult YazarGetir() 
        {
            try
            {
                return Ok(yazarManager.GetYazars());
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
    }
}
