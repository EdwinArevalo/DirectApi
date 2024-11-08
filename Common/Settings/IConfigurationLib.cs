using Microsoft.Extensions.Configuration;

namespace Common.Settings
{
    public interface IConfigurationLib
    {
        int CodigoDataExists { get; }
        int CodigoErrorBD { get; }
        int CodigoErrorNoAuthorized { get; }
        int CodigoErrorNoDataFound { get; }
        int CodigoErrorNoEspecificado { get; }
        int CodigoErrorNoFound { get; }
        int CodigoErrorTimeOut { get; }
        int CodigoExito { get; }
        int CodigoMissingParameters { get; }
        int CodigoParametrosNoValido { get; }
        IConfiguration Configuration { get; set; }
        string MensajeDataExistsEN { get; }
        string MensajeDataExistsES { get; }
        string MensajeErrorBDEN { get; }
        string MensajeErrorBDES { get; }
        string MensajeErrorNoAuthorizedEN { get; }
        string MensajeErrorNoAuthorizedES { get; }
        string MensajeErrorNoEspecificadoEN { get; }
        string MensajeErrorNoEspecificadoES { get; }
        string MensajeErrorNoFoundEN { get; }
        string MensajeErrorNoFoundES { get; }
        string MensajeErrorTimeOutEN { get; }
        string MensajeErrorTimeOutES { get; }
        string MensajeExitoEN { get; }
        string MensajeExitoES { get; }
        string MensajeMissingParametersEN { get; }
        string MensajeMissingParametersES { get; }
        string MensajeParametrosNoValidoEN { get; }
        string MensajeParametrosNoValidoES { get; }
        string NoDataFoundEN { get; }
        string NoDataFoundES { get; }
        int SecondsTimeOutBD { get; }
    }
}