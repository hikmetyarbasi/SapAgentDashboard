using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using BackgroundProcess;
using CheckDumps;
using CheckLocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SapAgent.ExternalServices.Abstract;
using SapAgent.ExternalServices.Concrete;
using SystemList;
using SystemUsages;
using AutoMapper;
using SapAgent.API.Helper;
using UserSession;

namespace SapAgent.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Sap Agent API Service", Version = "v1.0", Description = "Sap Ajan Api Servisi" });
            });

            var sapEndPoint = "http://aygerptest.aygsapdom.local:8000/sap/bc/srt/rfc/sap/zaygsdmdb_mob/400/zaygsdmdb_mob/zaygsdmdb_mob"; //Configuration.GetSection("SapClientBackGroundProcessEndpointAddress").Value;
            services.AddScoped<IBackgroundProcessClientWrapper, BackgroundProcessClientWrapper>();
            services.AddScoped<IBackgroundProcessClientWrapper, BackgroundProcessClientWrapperWithMockData>();
            services.AddScoped<ICheckDumpsClientWrapper, CheckDumpsClientWrapper>();
            services.AddScoped<ICheckDumpsClientWrapper, CheckDumpsClientWrapperWithMockData>();
            services.AddScoped<IUserSessionClientWrapper, UserSessionClientWrapper>();
            services.AddScoped<IUserSessionClientWrapper, UserSessionClientWrapperWithMockData>();
            services.AddScoped<ISystemUsageClientWrapper, SystemUsageClientWrapper>();
            services.AddScoped<ISystemUsageClientWrapper, SystemUsageClientWrapperWithMockData>();
            services.AddScoped<ICheckLocksClientWrapper, CheckLocksClientWrapper>();
            services.AddScoped<ICheckLocksClientWrapper, CheckLocksClientWrapperWithMockData>();
            services.AddScoped<ISystemListClientWrapper, SystemListClientWrapper>();
            services.AddScoped<ISystemListClientWrapper, SystemListClientWrapperWithMockData>();

            services.AddSingleton<zaygbcsys_ws_systlst>(new zaygbcsys_ws_systlstClient(new CustomBinding()
            {
                SendTimeout = new TimeSpan(0, 0, 2, 30),
                CloseTimeout = new TimeSpan(0, 0, 2, 30),
                OpenTimeout = new TimeSpan(0, 0, 2, 30),
                ReceiveTimeout = new TimeSpan(0, 0, 2, 30),
                Name = "test",
                Namespace = "SapAgentApi.UserSession",
                Elements = { new TextMessageEncodingBindingElement() { WriteEncoding = Encoding.UTF8, MessageVersion = MessageVersion.Soap11, ReaderQuotas = XmlDictionaryReaderQuotas.Max }, new HttpTransportBindingElement() { MaxBufferSize = int.MaxValue, MaxReceivedMessageSize = int.MaxValue } }
            }, new EndpointAddress(new Uri(sapEndPoint))));

            services.AddSingleton<zaygbcsys_ws_chklocks>(new zaygbcsys_ws_chklocksClient(new CustomBinding()
            {
                SendTimeout = new TimeSpan(0, 0, 2, 30),
                CloseTimeout = new TimeSpan(0, 0, 2, 30),
                OpenTimeout = new TimeSpan(0, 0, 2, 30),
                ReceiveTimeout = new TimeSpan(0, 0, 2, 30),
                Name = "test",
                Namespace = "SapAgentApi.UserSession",
                Elements = { new TextMessageEncodingBindingElement() { WriteEncoding = Encoding.UTF8, MessageVersion = MessageVersion.Soap11, ReaderQuotas = XmlDictionaryReaderQuotas.Max }, new HttpTransportBindingElement() { MaxBufferSize = int.MaxValue, MaxReceivedMessageSize = int.MaxValue } }
            }, new EndpointAddress(new Uri(sapEndPoint))));

            services.AddSingleton<zaygbcsys_ws_sysusage>(new zaygbcsys_ws_sysusageClient(new CustomBinding()
            {
                SendTimeout = new TimeSpan(0, 0, 2, 30),
                CloseTimeout = new TimeSpan(0, 0, 2, 30),
                OpenTimeout = new TimeSpan(0, 0, 2, 30),
                ReceiveTimeout = new TimeSpan(0, 0, 2, 30),
                Name = "test",
                Namespace = "SapAgentApi.UserSession",
                Elements = { new TextMessageEncodingBindingElement() { WriteEncoding = Encoding.UTF8, MessageVersion = MessageVersion.Soap11, ReaderQuotas = XmlDictionaryReaderQuotas.Max }, new HttpTransportBindingElement() { MaxBufferSize = int.MaxValue, MaxReceivedMessageSize = int.MaxValue } }
            }, new EndpointAddress(new Uri(sapEndPoint))));

            services.AddSingleton<zaygbcsys_ws_userses>(new zaygbcsys_ws_usersesClient(new CustomBinding()
            {
                SendTimeout = new TimeSpan(0, 0, 2, 30),
                CloseTimeout = new TimeSpan(0, 0, 2, 30),
                OpenTimeout = new TimeSpan(0, 0, 2, 30),
                ReceiveTimeout = new TimeSpan(0, 0, 2, 30),
                Name = "test",
                Namespace = "SapAgentApi.UserSession",
                Elements = { new TextMessageEncodingBindingElement() { WriteEncoding = Encoding.UTF8, MessageVersion = MessageVersion.Soap11, ReaderQuotas = XmlDictionaryReaderQuotas.Max }, new HttpTransportBindingElement() { MaxBufferSize = int.MaxValue, MaxReceivedMessageSize = int.MaxValue } }
            }, new EndpointAddress(new Uri(sapEndPoint))));

            services.AddSingleton<zaygbcsys_ws_bckgprc>(new zaygbcsys_ws_bckgprcClient(new CustomBinding()
            {
                SendTimeout = new TimeSpan(0, 0, 2, 30),
                CloseTimeout = new TimeSpan(0, 0, 2, 30),
                OpenTimeout = new TimeSpan(0, 0, 2, 30),
                ReceiveTimeout = new TimeSpan(0, 0, 2, 30),
                Name = "test",
                Namespace = "SapAgentApi.BackgroundProcess",
                Elements = { new TextMessageEncodingBindingElement() { WriteEncoding = Encoding.UTF8, MessageVersion = MessageVersion.Soap11, ReaderQuotas = XmlDictionaryReaderQuotas.Max }, new HttpTransportBindingElement() { MaxBufferSize = int.MaxValue, MaxReceivedMessageSize = int.MaxValue } }
            }, new EndpointAddress(new Uri(sapEndPoint))));

            services.AddSingleton<zaygbcsys_ws_chkdumps>(new zaygbcsys_ws_chkdumpsClient(new CustomBinding()
            {
                SendTimeout = new TimeSpan(0, 0, 2, 30),
                CloseTimeout = new TimeSpan(0, 0, 2, 30),
                OpenTimeout = new TimeSpan(0, 0, 2, 30),
                ReceiveTimeout = new TimeSpan(0, 0, 2, 30),
                Name = "test",
                Namespace = "SapAgentApi.CheckDumps",
                Elements = { new TextMessageEncodingBindingElement() { WriteEncoding = Encoding.UTF8, MessageVersion = MessageVersion.Soap11, ReaderQuotas = XmlDictionaryReaderQuotas.Max }, new HttpTransportBindingElement() { MaxBufferSize = int.MaxValue, MaxReceivedMessageSize = int.MaxValue } }
            }, new EndpointAddress(new Uri(sapEndPoint))));

            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
            {
                builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowAnyOrigin();
            }));
            services.AddSignalR();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            app.UseSignalR(routes =>
            {
                routes.MapHub<AlertHub>("/notify");
            });

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sap Agent Api Service v1.0");
            });
        }
    }
}
