using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            builder.RegisterType<BayrakManager>().As<IBayrakService>();
            builder.RegisterType<EfBayraklarDal>().As<IBayraklarDal>();

            builder.RegisterType<BlokManager>().As<IBloklarService>();
            builder.RegisterType<EfBloklarDal>().As<IBloklarDal>();

            builder.RegisterType<CalisanManager>().As<ICalisanService>();
            builder.RegisterType<EfCalisanDal>().As<ICalisanDal>();

            builder.RegisterType<DengeManager>().As<IDengeService>();
            builder.RegisterType<EfDengeDal>().As<IDengeDal>();

            builder.RegisterType<GemilerManager>().As<IGemilerService>();
            builder.RegisterType<EfGemilerDal>().As<IGemilerDal>();

            builder.RegisterType<GemiTipleriManager>().As<IGemiTipleriService>();
            builder.RegisterType<EfGemiTipleriDal>().As<IGemiTipleriDal>();

            builder.RegisterType<HazMatManager>().As<IHazMatService>();
            builder.RegisterType<EfHazMatDal>().As<IHazMatDal>();

            builder.RegisterType<HazMatTipiManager>().As<IHazMatTipiService>();
            builder.RegisterType<EfHazMatTipiDal>().As<IHazMatTipiDal>();

            builder.RegisterType<IHMRapolariManager>().As<IIHMRapolariService>();
            builder.RegisterType<EfIHMRaporlariDal>().As<IIHMRporlariDal>();

            builder.RegisterType<KaldırmaOperasyonuPlanlariManager>().As<IKaldırmaOperasyonuPlanlariService>();
            builder.RegisterType<EfKaldirmaOperasyonuPlanlariDal>().As<IKaldırmaOperasyonuPlanlariDal>();

            builder.RegisterType<KaldirmaOperasyonalariManager>().As<IKaldirmaOperasyonalariService>();
            builder.RegisterType<EfKaldirmaOperasyonlariDal>().As<IKaldirmaOperasyonalariDal>();

            builder.RegisterType<KazanDoldurmaOperasyonlariManager>().As<IKazanDoldurmaOPerasyonlariService>();
            builder.RegisterType<EfKazanDoldurmaOperasyonlariDal>().As<IKazanDoldurmaOPerasyonlariDal>();

            builder.RegisterType<KazanlarManager>().As<IKazanlarService>();
            builder.RegisterType<EfKazanlarDal>().As<IKazanlarDal>();

            builder.RegisterType<MalzemelerManager>().As<IMalzemelerService>();
            builder.RegisterType<EfMalzemelerDal>().As<IMalzemelerDal>();

            builder.RegisterType<MateryalIcerikleriManager>().As<IMateryalIcerikleriService>();
            builder.RegisterType<EfMateryalIcerikleriDal>().As<IMateryalIcerikleriDal>();

            builder.RegisterType<MeslekManager>().As<IMeslekService>();
            builder.RegisterType<EfMeslekDal>().As<IMeslekDal>();

            builder.RegisterType<OlcuBirimiManager>().As<IOlcuBirimiService>();
            builder.RegisterType<EfOlcuBirimiDal>().As<IOlcuBirimiDal>();

            builder.RegisterType<ParaBirimleriManager>().As<IParaBirimleriService>();
            builder.RegisterType<EfParaBirimleriDal>().As<IParaBirimleriDal>();

            builder.RegisterType<ResimlerManager>().As<IResimlerService>();
            builder.RegisterType<EfResimlerDal>().As<IResimlerDal>();

            builder.RegisterType<UygunmuManager>().As<IUygunmuService>();
            builder.RegisterType<EfUygunmuDal>().As<IUygunmuDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
