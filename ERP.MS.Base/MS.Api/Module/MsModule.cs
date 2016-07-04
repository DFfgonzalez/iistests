using ERP.Defontana.Bll.Interface;
using ERP.Defontana.Cpl.Dto;
using ERP.Defontana.Cpl.Exceptions;
using ERP.Defontana.Cpl.Util;
using Nancy;
using Nancy.ModelBinding;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MS.Api.Module
{
    public class MsModule : NancyModule
    {

        private IService service;

        public MsModule(IService service) : base("/")
        {

            this.service = service;

            Get["/", runAsync: true] = async (param, token) => await HelloWorldAsync(param, token);

        }

        private async Task<dynamic> HelloWorldAsync(dynamic param, CancellationToken token)
        {

            var response = await Task.Run(() => "Hello world!");

            return response;

        }
    }
}