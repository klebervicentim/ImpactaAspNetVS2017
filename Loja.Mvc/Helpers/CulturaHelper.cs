using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Loja.Mvc.Helpers
{
    public class CulturaHelper
    {
        private const string _LinguagemPadrao = "pt-BR";
        private string _LinguagemSelecionada = _LinguagemPadrao;
        private List<string> LinguagensSuportadas = new List<string> { "pt-BR", "en-US", "es-ES"};

        public CulturaHelper()
        {
            DefinirLinguagemPadrao();
            ObterRegionInfo();
        }

        private void DefinirLinguagemPadrao()
        {
            var request = HttpContext.Current.Request;
            if (request.Cookies["linguagemSelecionada"]!=null)
            {
                _LinguagemSelecionada = request.Cookies["linguagemSelecionada"].Value;
                return;
            }

            if (request.UserLanguages != null && LinguagensSuportadas.Contains(request.UserLanguages[0]))
            {
                _LinguagemSelecionada = request.UserLanguages[0];
            }

            var cookie = new HttpCookie("lingugemSelecionada", _LinguagemSelecionada);
            cookie.Expires = DateTime.MaxValue;

            HttpContext.Current.Response.Cookies.Add(cookie);

        }

        internal static CultureInfo ObterCultureInfo()
        {
            var linguagemSelecionada = HttpContext.Current.Request.Cookies["linguagemSelecionada"];
            var linguagem = linguagemSelecionada?.Value ?? _LinguagemPadrao;
            return CultureInfo.CreateSpecificCulture(linguagem);

        }

        private void ObterRegionInfo()
        {
            var cultura = CultureInfo.CreateSpecificCulture(_LinguagemSelecionada);
            var regiao = new RegionInfo(cultura.LCID);

            NomeNativo = regiao.NativeName;
            Abreviacao = regiao.TwoLetterISORegionName.ToLower();
        }

        public string NomeNativo { get; set; }
        public string Abreviacao { get; set; }
    }
}