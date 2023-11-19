
using AkilliTicaretWebShare;
using AkilliTicaretWebShare.CO;
using Libraries.Services.UrunIslemleri;
using Microsoft.AspNetCore.Mvc;

namespace AkilliTicaretWebApp.Controllers
{
    [Route("Urun")]
    public class UrunController : ControllerBase
    {
        private readonly IUrunService _urunService;
        public UrunController(IUrunService urunService)
        {
            _urunService = urunService;
        }

        [HttpPost("UrunListesiGetir")]
        public GenericResult UrunListesiGetir([FromBody] UrunListesiCO kriter)
        {
            GenericResult genericResult = new GenericResult();
            try
            {
                genericResult.Value = _urunService.UrunListesiGetir(kriter);
            }
            catch (Exception ex)
            {
                genericResult.AddError(ex.Message);
            }
            return genericResult;
        }

        [HttpGet("UrunGetir")]
        public GenericResult UrunGetir(long urunId)
        {
            GenericResult genericResult = new GenericResult();
            try
            {
                genericResult.Value = _urunService.UrunGetir(urunId);
            }
            catch (Exception ex)
            {
                genericResult.AddError(ex.Message);
            }
            return genericResult;
        }
    }
}
