using System;
using System.Text.RegularExpressions;

namespace eAudStuffCSharp.Util
{
    public static class TextFunctions
    {
        private static Regex Sanitizacao = new Regex(@"[^\w\.@-\[\]\(\)\{\}]", RegexOptions.None, TimeSpan.FromSeconds(1.5));
        //private static Regex Sanitizacao = new Regex(@"[^\w\.@-]", RegexOptions.None, TimeSpan.FromSeconds(1.5));

        private static Regex EspacosDuplos = new Regex(@"\s\s+", RegexOptions.None, TimeSpan.FromSeconds(1.5));

        public static string SanitizaTexto(string input) =>
            String.IsNullOrEmpty(input)
                ? null
                : EspacosDuplos.Replace(Sanitizacao.Replace(input, " "), " ").Trim();

        public static string PreparaTextoParaComparacao(string input) =>
            String.IsNullOrEmpty(input)
                ? null
                : SanitizaTexto(input).Replace(" ", "").ToUpper();
    }
}