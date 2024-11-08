using System; 
using Microsoft.Extensions.Configuration;

namespace Common.Settings
{
    public class ConfigurationLib : IConfigurationLib
    {
        public IConfiguration Configuration { get; set; }

        public ConfigurationLib(IConfiguration _Configuration)
        {
            Configuration = _Configuration;
        }

        public int CodigoExito => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["CodigoExito"]);
        public string MensajeExitoES => Configuration.GetSection("AppConfiguration")["MensajeExitoES"];
        public string MensajeExitoEN => Configuration.GetSection("AppConfiguration")["MensajeExitoEN"];

        public int CodigoErrorNoDataFound => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["CodigoErrorNoDataFound"]);
        public string NoDataFoundES => Configuration.GetSection("AppConfiguration")["NoDataFoundES"];
        public string NoDataFoundEN => Configuration.GetSection("AppConfiguration")["NoDataFoundEN"];

        public int CodigoParametrosNoValido => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["CodigoParametrosNoValido"]);
        public string MensajeParametrosNoValidoEN => Configuration.GetSection("AppConfiguration")["MensajeParametrosNoValidoEN"];
        public string MensajeParametrosNoValidoES => Configuration.GetSection("AppConfiguration")["MensajeParametrosNoValidoES"];

        public int CodigoErrorBD => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["CodigoErrorBD"]);
        public string MensajeErrorBDEN => Configuration.GetSection("AppConfiguration")["MensajeErrorBDEN"];
        public string MensajeErrorBDES => Configuration.GetSection("AppConfiguration")["MensajeErrorBDES"];


        public int CodigoErrorTimeOut => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["CodigoErrorTimeOut"]);
        public string MensajeErrorTimeOutEN => Configuration.GetSection("AppConfiguration")["MensajeErrorTimeOutEN"];
        public string MensajeErrorTimeOutES => Configuration.GetSection("AppConfiguration")["MensajeErrorTimeOutES"];

        public int CodigoErrorNoEspecificado => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["CodigoErrorNoEspecificado"]);
        public string MensajeErrorNoEspecificadoEN => Configuration.GetSection("AppConfiguration")["MensajeErrorNoEspecificadoEN"];
        public string MensajeErrorNoEspecificadoES => Configuration.GetSection("AppConfiguration")["MensajeErrorNoEspecificadoES"];

        public int CodigoErrorNoFound => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["CodigoErrorNoFound"]);
        public string MensajeErrorNoFoundEN => Configuration.GetSection("AppConfiguration")["MensajeErrorNoFoundEN"];
        public string MensajeErrorNoFoundES => Configuration.GetSection("AppConfiguration")["MensajeErrorNoFoundES"];

        public int CodigoErrorNoAuthorized => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["CodigoErrorNoAuthorized"]);
        public string MensajeErrorNoAuthorizedEN => Configuration.GetSection("AppConfiguration")["MensajeErrorNoAuthorizedEN"];
        public string MensajeErrorNoAuthorizedES => Configuration.GetSection("AppConfiguration")["MensajeErrorNoAuthorizedES"];


        public int SecondsTimeOutBD => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["SecondsTimeOutBD"]);

        public int CodigoDataExists => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["CodigoDataExists"]);
        public string MensajeDataExistsEN => Configuration.GetSection("AppConfiguration")["MensajeDataExistsEN"];
        public string MensajeDataExistsES => Configuration.GetSection("AppConfiguration")["MensajeDataExistsES"];

        public int CodigoMissingParameters => Convert.ToInt16(Configuration.GetSection("AppConfiguration")["CodigoMissingParameters"]);
        public string MensajeMissingParametersEN => Configuration.GetSection("AppConfiguration")["MensajeMissingParametersEN"];
        public string MensajeMissingParametersES => Configuration.GetSection("AppConfiguration")["MensajeMissingParametersES"];
    }
}
