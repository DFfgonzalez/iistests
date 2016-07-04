using System;
using System.Collections.Generic;

namespace ERP.Defontana.Cpl.Util
{

    public class ResponseStatus
    {

        public enum StatusNumber
        {
            OK = 0,
            ERROR = 1,
            VALIDATION = 2
        }

        /// <summary>
        /// 0 Response OK, 1 Error.
        /// </summary>

        public byte Status { set; get; }

        /// <summary>
        /// In case of error, an error description will be here.
        /// </summary>

        public string Message { set; get; }

        public object ResponseContainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ResponseStatus()
        {
            this.Status = (byte)StatusNumber.OK;
            this.Message = string.Empty;
        }

        /// <summary>
        /// Utility method to create an error response status.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static ResponseStatus ErrorResponse(string message)
        {
            var response = new ResponseStatus();

            response.Status = (byte)StatusNumber.ERROR;
            response.Message = message;

            return response;
        }


        /// <summary>
        /// Utility method to create a validation response status.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static ResponseStatus ValidationResponse(string message)
        {
            var response = new ResponseStatus();

            response.Status = (byte)StatusNumber.VALIDATION;
            response.Message = message;

            return response;
        }


        /// <summary>
        /// Utility method to create a validation response status.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static ResponseStatus ValidationResponse(Exception exception)
        {
            var response = new ResponseStatus();

            response.Status = (byte)StatusNumber.VALIDATION;
            response.Message = exception.GetExceptionMessages();

            return response;
        }


        /// <summary>
        /// Utility method to create an error response status.
        /// </summary>
        /// <param name="exception">The exception</param>
        /// <returns></returns>
        public static ResponseStatus ErrorResponse(Exception exception)
        {
            var response = new ResponseStatus();

            response.Status = (byte)StatusNumber.ERROR;
            response.Message = exception.GetExceptionMessages();

            return response;
        }


        /// <summary>
        /// Utility method to create an error response status.
        /// </summary>
        /// <param name="exception">The exception</param>
        /// <param name="container">The container</param>
        /// <returns></returns>
        public static ResponseStatus ErrorResponse(object container, Exception exception)
        {
            var response = new ResponseStatus();

            response.Status = (byte)StatusNumber.ERROR;
            response.Message = exception.GetExceptionMessages();
            response.ResponseContainer = container;

            return response;
        }

        /// <summary>
        /// Utility method to create a validation response status.
        /// </summary>
        /// <param name="exception">The exception</param>
        /// <param name="container">The container</param>
        /// <returns></returns>
        public static ResponseStatus ValidationResponse(object container, Exception exception)
        {
            var response = new ResponseStatus();

            response.Status = (byte)StatusNumber.VALIDATION;
            response.Message = exception.GetExceptionMessages();
            response.ResponseContainer = container;

            return response;
        }


        /// <summary>
        /// Utility method to create an error response status.
        /// </summary>       
        /// <returns></returns>
        public static ResponseStatus OkResponse()
        {
            var response = new ResponseStatus();

            response.Status = (byte)StatusNumber.OK;

            return response;
        }


        /// <summary>
        /// Utility method to create an error response status.
        /// </summary>        
        /// <param name="container">The container</param>
        /// <returns></returns>
        public static ResponseStatus OkResponse(object container)
        {
            var response = new ResponseStatus();
            response.Status = (byte)StatusNumber.OK;
            response.ResponseContainer = container;

            return response;
        }
    }


    public class ResponseBase
    {
        public ResponseStatus ResponseStatus { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public ResponseBase()
        {
            this.ResponseStatus = new ResponseStatus();
        }

    }


    public class DocumentStatus
    {
        public string WorkflowCode { set; get; }


        public string WorkflowDescription { set; get; }


        public string StatusCode { set; get; }


        public string StatusDescription { set; get; }


        public DateTime ChangedDate { set; get; }


        public string Comment { set; get; }

    }


    public class ResponseDocument
    {
        public string DocumentID { set; get; }

        public DateTime ReceivedDate { set; get; }

        public IDictionary<string, DocumentStatus> CurrentStatuses { set; get; }

        public IDictionary<string, string> Properties { set; get; }
    }


    public class DocumentDetails
    {
        public ResponseDocument Document { set; get; }

        public IDictionary<string, DocumentStatus[]> StatusesHistory { set; get; }
    }


    public class ResponseWithIdentifier : ResponseBase
    {
        public string ID { set; get; }
    }


    public class ResponseWithData : ResponseBase
    {
        public byte[] Data { set; get; }
    }


    public class ResponseWithDocuments : ResponseBase
    {
        public ResponseDocument[] Documents { set; get; }
    }


    public class ResponseWithDocumentsPaged : ResponseBase
    {
        public int CurrentPage { set; get; }

        public int PageSize { set; get; }

        public int Total { set; get; }


        public ResponseDocument[] Documents { set; get; }

    }


    public class ResponseWithDocumentDetails : ResponseBase
    {
        public DocumentDetails DocumentDetails { set; get; }
    }


    public class ResponseWithBoolean : ResponseBase
    {
        public bool Value { set; get; }
    }

}
