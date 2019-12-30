using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PointOfSalesV2.Common
{
    public static class DependencyInjectionExtension
    {
        internal static IServiceProvider serviceProvider;

        public static IServiceCollection DetecteMockMode(this IServiceCollection services, IConfiguration configuration)
        {
            MockConfiguration mockConfiguration = new MockConfiguration();
            configuration.GetSection("MockConfiguration").Bind(mockConfiguration);
            if (mockConfiguration != null)
                services.AddSingleton(mockConfiguration);


            return services;
        }

        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            IEnumerable<TypeInfo> injectTypes = AppDomain.CurrentDomain.GetReferenceAssemblies()
                .SelectMany(a => a.DefinedTypes)
                .Where(t => Attribute.IsDefined(t, typeof(DependencyAttribute)) && !t.IsAbstract);

            injectTypes.ToList()
                .ForEach(injectType =>
                {
                    DependencyAttribute injectAttribute = injectType.GetCustomAttribute<DependencyAttribute>();
                    Type typeService = injectAttribute.ServiceType ?? injectType;
                    ServiceDescriptor serviceDescriptor = new ServiceDescriptor(
                        typeService,
                        (serviceProvider) =>
                        {
                            return injectType.InstanceFromServiceProvider(serviceProvider);
                        }
                        , injectAttribute.Lifetime);
                    services.Add(serviceDescriptor);
                });
            return services;
        }

        public static IApplicationBuilder UseDependency(this IApplicationBuilder app)
        {
            serviceProvider = app.ApplicationServices;
            return app;
        }

        public static object InstanceFromServiceProvider(this Type injectService, IServiceProvider serviceProvider)
        {
            ConstructorInfo constructorInfo = injectService.GetConstructors()
                .FirstOrDefault();

            object[] constructorParameters = constructorInfo?.GetParameters()
                .Select(p => serviceProvider.GetService(p.ParameterType))
                .ToArray();

            return Activator.CreateInstance(injectService, constructorParameters);
        }

        public static T GetService<T>(this AppDomain appDomain, bool throwExceptionIfNoRegister = false)
        {
            T service = default;
            if (serviceProvider!=null && serviceProvider.IsRegister<T>())
            {
                service = serviceProvider.GetService<T>();
            }
            else if (serviceProvider != null && serviceProvider.CreateScope().ServiceProvider.IsRegister<T>())
            {
                service = serviceProvider.CreateScope().ServiceProvider.GetService<T>();
            }
            else
            {
                if (throwExceptionIfNoRegister && service == null)
                    return default(T);

            }

            return service;
        }

        public static object GetService(this AppDomain appDomain, Type serviceType, bool throwExceptionIfNoRegister = false)
        {

            object service = null;
            if (serviceProvider != null && serviceProvider.IsRegister(serviceType))
            {
                service = serviceProvider.GetService(serviceType);
            }
            else if (serviceProvider != null && serviceProvider.CreateScope().ServiceProvider.IsRegister(serviceType))
            {
                service = serviceProvider.CreateScope().ServiceProvider.GetService(serviceType);
            }
            else
            {
                return null;

            }

            return service;
        }

        public static bool IsRegister(this IServiceProvider serviceProvider, Type typeService)
        {
            bool isRegister = false;
            try
            {
                serviceProvider.GetService(typeService);
                isRegister = true;
            }
            catch (InvalidOperationException)
            {

                isRegister = false;
            }

            catch (Exception)
            {

                isRegister = false;
            }
            return isRegister;
        }

        public static bool IsRegister<T>(this IServiceProvider serviceProvider)
        {
            bool isRegister = false;
            try
            {
                serviceProvider.GetService<T>();
                isRegister = true;
            }
            catch (InvalidOperationException)
            {

                isRegister = false;
            }

            catch (Exception)
            {

                isRegister = false;
            }
            return isRegister;
        }
    }

    public class MockConfiguration
    {
        public bool IsMockMode { get; set; } = false;
    }


}

namespace PointOfSalesV2.Common 
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class DependencyAttribute
             : Attribute
    {
        public DependencyAttribute(ServiceLifetime lifetime = ServiceLifetime.Transient, Type serviceType = null)
        {
            this.ServiceType = serviceType;
            Lifetime = lifetime;
        }

        public Type ServiceType { get; set; }
        public ServiceLifetime Lifetime { get; set; }

    }

    public static class ReflectionExtension
    {

        public static string GetFileNameFromPath(this string path)
        {
            return Path.GetFileName(path);
        }

        public static IEnumerable<Assembly> GetReferenceAssemblies(this AppDomain appDomain)
        {
            List<Assembly> referenceAssemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => !a.IsDynamic && !a.FullName.StartsWith("Microsoft") && !a.FullName.StartsWith("System")).ToList();

            Directory.GetFiles(appDomain.BaseDirectory, "*.dll",
                SearchOption.TopDirectoryOnly)
                .Where(f => !f.GetFileNameFromPath().StartsWith("Microsoft") && !f.GetFileNameFromPath().StartsWith("System"))
                .ToList()
                .ForEach(fileAssembly =>
                {
                    Assembly assemblyBin = Assembly.LoadFrom(fileAssembly);
                    if (!referenceAssemblies.Contains(assemblyBin))
                        referenceAssemblies.Add(assemblyBin);
                });

            return referenceAssemblies;
        }
    }
}
