using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Common.CustomException;
using Common.Settings;

namespace Common.HttpHelpers
{
    public class UtilitariesResponse<T> where T : class, new()
    {
        private readonly IConfigurationLib ConfigurationLib;

        public UtilitariesResponse(IConfigurationLib _configurationLib)
        {
            ConfigurationLib = _configurationLib;
        }

        public EResponseBase<T> setResponseBaseForExecuteSQLCommand(int result)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            if (result >= 0)
            {
                response.Code = ConfigurationLib.CodigoExito;
                response.Message = ConfigurationLib.MensajeExitoES;
                response.MessageEN = ConfigurationLib.MensajeExitoEN;
            }
            else
            {
                response.Code = ConfigurationLib.CodigoErrorNoDataFound;
                response.Message = ConfigurationLib.NoDataFoundES;
                response.MessageEN = ConfigurationLib.NoDataFoundEN;
            }
            return response;
        }
        public EResponseBase<T> setResponseBaseForList(IQueryable<T> query)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            if (query == null)
            {
                response.Code = ConfigurationLib.CodigoErrorNoDataFound;
                response.Message = ConfigurationLib.NoDataFoundES;
                response.MessageEN = ConfigurationLib.NoDataFoundEN;
            }
            else
            {
                if (query.Any())
                {
                    response.Code = ConfigurationLib.CodigoExito;
                    response.Message = ConfigurationLib.MensajeExitoES;
                    response.MessageEN = ConfigurationLib.MensajeExitoEN;
                    response.Listado = query.ToList();
                    response.IsResultList = true;
                }
                else
                {
                    response.Code = ConfigurationLib.CodigoErrorNoDataFound;
                    response.Message = ConfigurationLib.NoDataFoundES;
                    response.MessageEN = ConfigurationLib.NoDataFoundEN;
                }
            }
            return response;
        }

        public EResponseBase<T> setResponseBaseForList(List<T> query)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            if (query == null)
            {
                response.Code = ConfigurationLib.CodigoErrorNoDataFound;
                response.Message = ConfigurationLib.NoDataFoundES;
                response.MessageEN = ConfigurationLib.NoDataFoundEN;
            }
            else
            {
                if (query.Any())
                {
                    response.Code = ConfigurationLib.CodigoExito;
                    response.Message = ConfigurationLib.MensajeExitoES;
                    response.MessageEN = ConfigurationLib.MensajeExitoEN;
                    response.Listado = query;
                    response.IsResultList = true;
                }
                else
                {
                    response.Code = ConfigurationLib.CodigoErrorNoDataFound;
                    response.Message = ConfigurationLib.NoDataFoundES;
                    response.MessageEN = ConfigurationLib.NoDataFoundEN;
                }
            }
            return response;
        }


        public EResponseBase<T> setResponseBaseForObj(T obj)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            if (obj != null)
            {
                response.Code = ConfigurationLib.CodigoExito;
                response.Message = ConfigurationLib.MensajeExitoES;
                response.MessageEN = ConfigurationLib.MensajeExitoEN;
                response.Objeto = obj;
            }
            else
            {
                response.Code = ConfigurationLib.CodigoErrorNoDataFound;
                response.Message = ConfigurationLib.NoDataFoundES;
                response.MessageEN = ConfigurationLib.NoDataFoundEN;
            }
            return response;
        }

        public EResponseBase<T> setResponseBaseForObj(string obj)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            if (obj != null)
            {
                response.Code = ConfigurationLib.CodigoExito;
                response.Message = ConfigurationLib.MensajeExitoES;
                response.MessageEN = ConfigurationLib.MensajeExitoEN;
                response.Dato = obj;
            }
            else
            {
                response.Code = ConfigurationLib.CodigoErrorNoDataFound;
                response.Message = ConfigurationLib.NoDataFoundES;
                response.MessageEN = ConfigurationLib.NoDataFoundEN;
            }
            return response;
        }

        public EResponseBase<T> setResponseBaseForValidationExceptionString(IList<string> errors)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = ConfigurationLib.CodigoParametrosNoValido;
            response.Message = ConfigurationLib.MensajeParametrosNoValidoES;
            response.MessageEN = ConfigurationLib.MensajeParametrosNoValidoEN;
            response.FunctionalErrors = errors.ToList();
            return response;
        }
        public EResponseBase<T> setResponseBaseForOK()
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = ConfigurationLib.CodigoExito;
            response.Message = ConfigurationLib.MensajeExitoES;
            response.MessageEN = ConfigurationLib.MensajeExitoEN;
            return response;
        }
        public EResponseBase<T> setResponseBaseForOK(T obj)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = ConfigurationLib.CodigoExito;
            response.Message = ConfigurationLib.MensajeExitoES;
            response.MessageEN = ConfigurationLib.MensajeExitoEN;
            if (obj != null) response.Objeto = obj;
            return response;
        }
        public EResponseBase<T> setResponseBaseForOK(IEnumerable<T> obj)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = ConfigurationLib.CodigoExito;
            response.Message = ConfigurationLib.MensajeExitoES;
            response.MessageEN = ConfigurationLib.MensajeExitoEN;
            if (obj.Any()) { response.Listado = obj; response.IsResultList = true; }
            return response;
        }
        public EResponseBase<T> setResponseBaseForExceptionUnexpected()
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = ConfigurationLib.CodigoErrorNoEspecificado;
            response.Message = ConfigurationLib.MensajeErrorNoEspecificadoES;
            response.MessageEN = ConfigurationLib.MensajeErrorNoEspecificadoEN;
            return response;
        }
        public EResponseBase<T> setResponseBaseForException(Exception ex)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            if (ex is TimeoutException)
            {
                response.Code = ConfigurationLib.CodigoErrorTimeOut;
                response.Message = ConfigurationLib.MensajeErrorTimeOutES;
                response.MessageEN = ConfigurationLib.MensajeErrorTimeOutEN;
            }
            else if (ex is HttpRequestException)
            {
                response.Code = ConfigurationLib.CodigoErrorTimeOut;
                response.Message = ConfigurationLib.MensajeErrorTimeOutES;
                response.MessageEN = ConfigurationLib.MensajeErrorTimeOutEN;
            }
            else if (ex is NotAuthorizeResourceException)
            {
                response.Code = ConfigurationLib.CodigoErrorNoAuthorized;
                response.Message = ConfigurationLib.MensajeErrorNoAuthorizedES;
                response.MessageEN = ConfigurationLib.MensajeErrorNoAuthorizedEN;
            }
            else
            {
                response.Code = ConfigurationLib.CodigoErrorNoEspecificado;
                response.Message = ConfigurationLib.MensajeErrorNoEspecificadoES;
                response.MessageEN = ConfigurationLib.MensajeErrorNoEspecificadoEN;
            }
            //response.TechnicalErrors = ex;
            return response;
        }
        public EResponseBase<T> setResponseBaseForNoAuthorized()
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = ConfigurationLib.CodigoErrorNoAuthorized;
            response.Message = ConfigurationLib.MensajeErrorNoAuthorizedES;
            response.MessageEN = ConfigurationLib.MensajeErrorNoAuthorizedEN;
            response.Listado = new List<T>();
            return response;
        }

        public EResponseBase<T> setResponseBaseForNoDataFound()
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = ConfigurationLib.CodigoErrorNoDataFound;
            response.Message = ConfigurationLib.NoDataFoundES;
            response.MessageEN = ConfigurationLib.NoDataFoundEN;
            response.Listado = new List<T>();
            return response;
        }
        public EResponseBase<T> setResponseBaseForParameterNoValid()
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = ConfigurationLib.CodigoParametrosNoValido;
            response.Message = ConfigurationLib.MensajeParametrosNoValidoES;
            response.MessageEN = ConfigurationLib.MensajeParametrosNoValidoEN;
            response.Listado = new List<T>();
            return response;
        }
        public EResponseBase<T> setResponseBaseForDuplicatedData(T obj)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = ConfigurationLib.CodigoDataExists;
            response.Message = ConfigurationLib.MensajeDataExistsES;
            response.MessageEN = ConfigurationLib.MensajeDataExistsEN;
            if (obj != null) response.Objeto = obj;
            return response;
        }
        public EResponseBase<T> setResponseBaseForMissingParameters(T obj)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = ConfigurationLib.CodigoMissingParameters;
            response.Message = ConfigurationLib.MensajeMissingParametersES;
            response.MessageEN = ConfigurationLib.MensajeMissingParametersEN;
            if (obj != null) response.Objeto = obj;
            return response;
        }

        public EResponseBase<T> setResponseBaseErrorInsertData(T obj)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = -1001;
            response.Message = "Error al insertar datos";
            response.MessageEN = "Error inserting data";
            if (obj != null) response.Objeto = obj;
            return response;
        }

        public EResponseBase<T> setResponseBaseErrorUpdateData(T obj)
        {
            EResponseBase<T> response = new EResponseBase<T>();
            response.Code = -1001;
            response.Message = "Error al actualizar datos";
            response.MessageEN = "Error updating data";
            if (obj != null) response.Objeto = obj;
            return response;
        }
    }
}
