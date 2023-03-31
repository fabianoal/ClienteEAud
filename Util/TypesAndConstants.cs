using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Globalization;

namespace eAudStuffCSharp.Util
{
    public class Constantes
    {
        public const string SITUACAO_CONCLUIDA = "Concluída";
        public const string SITUACAO_CANCELADA = "Cancelada";
        public const string SITUACAO_AUTORIZADA = "Autorizada";
        public const string SITUACAO_EM_EDICAO = "Em Edição";
        public const string SITUACAO_EM_EXECUCAO = "Em Execução";
        public const string SITUACAO_EM_SUPERVISAO = "Em Supervisão";
        public const string SITUACAO_SUSPENSA = "Suspensa";
        public static string DIR_DADOS =  "./Dados";

        //public static string EXCEL_CONNECTION_TEMPLATE = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";
        public static string EXCEL_CONNECTION_TEMPLATE = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)}; DBQ=#fileName";

        public static string CGUDATA_EAUD_CONNECTION = "Data Source=sdh-die-bd.cgu.local; Initial Catalog=db_EAUD; Integrated Security=true;";

    }
}

