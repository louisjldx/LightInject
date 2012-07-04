﻿//#define NET
//using System;
//#if NET
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.IO;
//#endif
//#if SILVERLIGHT
//using System.Collections;
//using System.Collections.Generic;
//using System.Windows;
//using System.Windows.Resources;
//using Expression = System.Linq.Expressions.Expression;
//#endif
//using System.Linq;
//using System.Linq.Expressions;
//using System.Reflection;
//using System.Reflection.Emit;
//using System.Runtime.CompilerServices;
//using System.Text.RegularExpressions;

//namespace LightInject
//{


//    /// <summary>
//    /// Represents a service container.
//    /// </summary>
//    public interface IServiceContainer
//    {
//        /// <summary>
//        /// Register services from the given <paramref name="assembly"/>.
//        /// </summary>
//        /// <param name="assembly">The <see cref="Assembly"/> for which to scan for services.</param>
//        /// <param name="shouldLoad">A function delegate that determines if the current type should 
//        /// be loaded into the target <see cref="IServiceContainer"/> instance.</param>
//        void Register(Assembly assembly, Func<Type, bool> shouldLoad);

//#if !SILVERLIGHT
//        /// <summary>
//        /// Loads service from the current directory.
//        /// </summary>
//        /// <param name="searchPattern">The search pattern used to filter the assembly files.</param>
//        /// /// <param name="shouldLoad">A function delegate that determines if the current type should 
//        /// be loaded into the target <see cref="IServiceContainer"/> instance.</param>
//        void Register(string searchPattern, Func<Type, bool> shouldLoad);
//#endif
//        /// <summary>
//        /// Registers the <paramref name="serviceType"/> with the <paramref name="implementingType"/>.
//        /// </summary>
//        /// <param name="serviceType">The service type to register.</param>
//        /// <param name="implementingType">The implementing type.</param>
//        void Register(Type serviceType, Type implementingType);

//        /// <summary>
//        /// Registers the <paramref name="serviceType"/> with the <paramref name="implementingType"/> as a singleton service.
//        /// </summary>
//        /// <param name="serviceType">The service type to register.</param>
//        /// <param name="implementingType">The implementing type.</param>
//        void RegisterAsSingleton(Type serviceType, Type implementingType);

//        /// <summary>
//        /// Registers the <paramref name="serviceType"/> with the <paramref name="implementingType"/> as a singleton service.
//        /// </summary>
//        /// <param name="serviceType">The service type to register.</param>
//        /// <param name="implementingType">The implementing type.</param>
//        /// <param name="serviceName">The name of the service.</param>
//        void RegisterAsSingleton(Type serviceType, Type implementingType, string serviceName);

//        /// <summary>
//        /// Registers the <paramref name="serviceType"/> with the <paramref name="implementingType"/>.
//        /// </summary>
//        /// <param name="serviceType">The service type to register.</param>
//        /// <param name="implementingType">The implementing type.</param>
//        /// <param name="serviceName">The name of the service.</param>
//        void Register(Type serviceType, Type implementingType, string serviceName);

//        /// <summary>
//        /// Registers a factory delegate used to create an instance of <typeparamref name="TService"/>.
//        /// </summary>
//        /// <typeparam name="TService">The type of service for which to register a factory delegate.</typeparam>
//        /// <param name="factory">The delegate used to create a instance of <typeparamref name="TService"/>.</param>
//        void Register<TService>(Expression<Func<IServiceContainer, TService>> factory);

//        /// <summary>
//        /// Registers a factory delegate used to create an instance of <typeparamref name="TService"/>. 
//        /// </summary>
//        /// <typeparam name="TService">The type of service for which to register a factory delegate.</typeparam>
//        /// <param name="factory">The delegate used to create a instance of <typeparamref name="TService"/>.</param>
//        void RegisterAsSingleton<TService>(Expression<Func<IServiceContainer, TService>> factory);

//        /// <summary>
//        /// Registers a factory delegate used to create an instance of <typeparamref name="TService"/>.
//        /// </summary>
//        /// <typeparam name="TService">The type of service for which to register a factory delegate.</typeparam>
//        /// <param name="factory">The delegate used to create a instance of <typeparamref name="TService"/>.</param>
//        /// <param name="serviceName">The name of the service.</param>
//        void Register<TService>(Expression<Func<IServiceContainer, TService>> factory, string serviceName);

//        /// <summary>
//        /// Registers a factory delegate used to create an instance of <typeparamref name="TService"/>. 
//        /// </summary>
//        /// <typeparam name="TService">The type of service for which to register a factory delegate.</typeparam>
//        /// <param name="factory">The delegate used to create a instance of <typeparamref name="TService"/>.</param>
//        /// <param name="serviceName">The name of the service.</param>
//        void RegisterAsSingleton<TService>(Expression<Func<IServiceContainer, TService>> factory, string serviceName);

//        /// <summary>
//        /// Gets an instance of the given <paramref name="serviceType"/>.
//        /// </summary>
//        /// <param name="serviceType">The type of the requested service.</param>
//        /// <returns>The requested service instance.</returns>
//        object GetInstance(Type serviceType);

//        /// <summary>
//        /// Gets an instance of the given <typeparamref name="TService"/> type.
//        /// </summary>
//        /// <typeparam name="TService">The type of the requested service.</typeparam>
//        /// <returns>The requested service instance.</returns>
//        TService GetInstance<TService>();

//        /// <summary>
//        /// Gets a named instance of the given <typeparamref name="TService"/>.
//        /// </summary>
//        /// <typeparam name="TService">The type of the requested service.</typeparam>
//        /// <param name="serviceName">The name of the requested service.</param>
//        /// <returns>The requested service instance.</returns>    
//        TService GetInstance<TService>(string serviceName);

//        /// <summary>
//        /// Gets a named instance of the given <paramref name="serviceType"/>.
//        /// </summary>
//        /// <param name="serviceType">The type of the requested service.</param>
//        /// <param name="serviceName">The name of the requested service.</param>
//        /// <returns>The requested service instance.</returns>
//        object GetInstance(Type serviceType, string serviceName);

//        /// <summary>
//        /// Gets all instances of the given <paramref name="serviceType"/>.
//        /// </summary>
//        /// <param name="serviceType">The type of services to resolve.</param>
//        /// <returns>A list that contains all implementations of the <paramref name="serviceType"/>.</returns>
//        IEnumerable<object> GetAllInstances(Type serviceType);

//        /// <summary>
//        /// Gets all instances of type <typeparamref name="TService"/>.
//        /// </summary>
//        /// <typeparam name="TService">The type of services to resolve.</typeparam>
//        /// <returns>A list that contains all implementations of the <typeparamref name="TService"/> type.</returns>
//        IEnumerable<TService> GetAllInstances<TService>();
//    }





//    /// <summary>
//    /// An ultra lightweight service container.
//    /// </summary>
//    public class ServiceContainer : IServiceContainer
//    {
//        private readonly ThreadSafeDictionary<Type, ThreadSafeDictionary<string, ImplementationInfo>> _availableServices
//            =
//            new ThreadSafeDictionary<Type, ThreadSafeDictionary<string, ImplementationInfo>>();

//        private readonly ThreadSafeDictionary<Type, Lazy<Func<List<object>, object>>> _defaultFactories =
//            new ThreadSafeDictionary<Type, Lazy<Func<List<object>, object>>>();

//        private readonly ThreadSafeDictionary<Tuple<Type, string>, Lazy<Func<List<object>, object>>> _namedFactories =
//            new ThreadSafeDictionary<Tuple<Type, string>, Lazy<Func<List<object>, object>>>();

//        private readonly ParameterExpression _constantsParameterExpression = Expression.Parameter(typeof(List<object>), "c");

//        private static readonly MethodInfo getInstanceMethod;

//        private readonly MethodCallRewriter _methodCallRewriter;

//        private readonly List<object> _constants = new List<object>();

//        static ServiceContainer()
//        {
//            getInstanceMethod = typeof(IFactory).GetMethod("GetInstance");
//        }

//        /// <summary>
//        /// Initializes a new instance of the <see cref="ServiceContainer"/> class.
//        /// </summary>
//        public ServiceContainer()
//        {
//            //AssemblyScanner = new AssemblyScanner(this);
//            _methodCallRewriter = new MethodCallRewriter(GetBodyExpression);
//        }

//        /// <summary>
//        /// Gets or sets the <see cref="IAssemblyScanner"/> instance that is responsible 
//        /// for registration of services based on types contained with an <see cref="Assembly"/>.
//        /// </summary>
//        public IAssemblyScanner AssemblyScanner { get; set; }

//        /// <summary>
//        /// Gets an instance of the given <typeparamref name="TService"/> type.
//        /// </summary>
//        /// <typeparam name="TService">The type of the requested service.</typeparam>
//        /// <returns>The requested service instance.</returns>
//        public TService GetInstance<TService>()
//        {
//            return (TService)GetInstance(typeof(TService));
//        }

//        /// <summary>
//        /// Gets a named instance of the given <typeparamref name="TService"/>.
//        /// </summary>
//        /// <typeparam name="TService">The type of the requested service.</typeparam>
//        /// <param name="serviceName">The name of the requested service.</param>
//        /// <returns>The requested service instance.</returns>    
//        public TService GetInstance<TService>(string serviceName)
//        {
//            return (TService)GetInstance(typeof(TService), serviceName);
//        }

//        /// <summary>
//        /// Gets a named instance of the given <paramref name="serviceType"/>.
//        /// </summary>
//        /// <param name="serviceType">The type of the requested service.</param>
//        /// <param name="serviceName">The name of the requested service.</param>
//        /// <returns>The requested service instance.</returns>
//        public object GetInstance(Type serviceType, string serviceName)
//        {
//            return _namedFactories.GetOrAdd(Tuple.Create(serviceType, serviceName), s => new Lazy<Func<List<object>, object>>(() => CreateDelegate(serviceType, serviceName))).Value(_constants);
//        }

//        /// <summary>
//        /// Gets all instances of the given <paramref name="serviceType"/>.
//        /// </summary>
//        /// <param name="serviceType">The type of services to resolve.</param>
//        /// <returns>A list that contains all implementations of the <paramref name="serviceType"/>.</returns>
//        public IEnumerable<object> GetAllInstances(Type serviceType)
//        {
//            return (IEnumerable<object>)GetInstance(typeof(IEnumerable<>).MakeGenericType(serviceType));
//        }

//        /// <summary>
//        /// Gets all instances of type <typeparamref name="TService"/>.
//        /// </summary>
//        /// <typeparam name="TService">The type of services to resolve.</typeparam>
//        /// <returns>A list that contains all implementations of the <typeparamref name="TService"/> type.</returns>
//        public IEnumerable<TService> GetAllInstances<TService>()
//        {
//            return GetInstance<IEnumerable<TService>>();
//        }

//        /// <summary>
//        /// Register services from the given <paramref name="assembly"/>.
//        /// </summary>
//        /// <param name="assembly">The <see cref="Assembly"/> for which to scan for services.</param>
//        /// <param name="shouldLoad">A function delegate that determines if the current type should 
//        /// be loaded into the target <see cref="IServiceContainer"/> instance.</param>
//        public void Register(Assembly assembly, Func<Type, bool> shouldLoad)
//        {
//            //AssemblyScanner.Scan(assembly, shouldLoad);
//        }

//#if !SILVERLIGHT
//        /// <summary>
//        /// Loads service from the current directory.
//        /// </summary>
//        /// <param name="searchPattern">The search pattern used to filter the assembly files.</param>
//        /// /// <param name="shouldLoad">A function delegate that determines if the current type should 
//        /// be loaded into the target <see cref="IServiceContainer"/> instance.</param>
//        public void Register(string searchPattern, Func<Type, bool> shouldLoad)
//        {
//            string directory = Path.GetDirectoryName(new Uri(typeof(ServiceContainer).Assembly.CodeBase).LocalPath);
//            if (directory != null)
//            {
//                string[] searchPatterns = searchPattern.Split('|');
//                foreach (string file in searchPatterns.SelectMany(sp => Directory.GetFiles(directory, sp)))
//                    Register(Assembly.LoadFrom(file), shouldLoad);
//            }
//        }
//#endif

//        /// <summary>
//        /// Registers the <paramref name="serviceType"/> with the <paramref name="implementingType"/>.
//        /// </summary>
//        /// <param name="serviceType">The service type to register.</param>
//        /// <param name="implementingType">The implementing type.</param>
//        public void Register(Type serviceType, Type implementingType)
//        {
//            Register(serviceType, implementingType, string.Empty);
//        }

//        /// <summary>
//        /// Registers the <paramref name="serviceType"/> with the <paramref name="implementingType"/> as a singleton service.
//        /// </summary>
//        /// <param name="serviceType">The service type to register.</param>
//        /// <param name="implementingType">The implementing type.</param>
//        public void RegisterAsSingleton(Type serviceType, Type implementingType)
//        {
//            RegisterAsSingleton(serviceType, implementingType, string.Empty);
//        }

//        /// <summary>
//        /// Registers the <paramref name="serviceType"/> with the <paramref name="implementingType"/> as a singleton service.
//        /// </summary>
//        /// <param name="serviceType">The service type to register.</param>
//        /// <param name="implementingType">The implementing type.</param>
//        /// <param name="serviceName">The name of the service.</param>
//        public void RegisterAsSingleton(Type serviceType, Type implementingType, string serviceName)
//        {
//            if (implementingType == null)
//            {
//                ImplementationInfo implementationInfo = TryResolveImplementationForUnknownService(serviceType, serviceName);

//                var singletonImplementationInfo = new ImplementationInfo(null,
//                                                                         () =>
//                                                                         CreateSingletonExpression(
//                                                                             () =>
//                                                                             implementationInfo.FactoryExpression.Value));
//                Register(serviceType, serviceName, singletonImplementationInfo);
//            }
//            else
//            {
//                Register(serviceType, serviceName, CreateSingletonImplementationInfo(serviceType, implementingType));
//            }
//        }

//        /// <summary>
//        /// Registers the <paramref name="serviceType"/> with the <paramref name="implementingType"/>.
//        /// </summary>
//        /// <param name="serviceType">The service type to register.</param>
//        /// <param name="implementingType">The implementing type.</param>
//        /// <param name="serviceName">The name of the service.</param>
//        public void Register(Type serviceType, Type implementingType, string serviceName)
//        {
//            if (IsFactory(serviceType))
//                RegisterAsSingleton(serviceType, implementingType, serviceName);
//            else
//            {
//                ImplementationInfo implementationInfo = CreateImplementationInfo(implementingType);
//                Register(serviceType, serviceName, implementationInfo);
//            }
//        }

//        /// <summary>
//        /// Registers a factory delegate used to create an instance of <typeparamref name="TService"/>. 
//        /// </summary>
//        /// <typeparam name="TService">The type of service for which to register a factory delegate.</typeparam>
//        /// <param name="factory">The delegate used to create a instance of <typeparamref name="TService"/>.</param>
//        public void Register<TService>(Expression<Func<IServiceContainer, TService>> factory)
//        {
//            Register(factory, string.Empty);
//        }

//        /// <summary>
//        /// Registers a factory delegate used to create an instance of <typeparamref name="TService"/>. 
//        /// </summary>
//        /// <typeparam name="TService">The type of service for which to register a factory delegate.</typeparam>
//        /// <param name="factory">The delegate used to create a instance of <typeparamref name="TService"/>.</param>
//        public void RegisterAsSingleton<TService>(Expression<Func<IServiceContainer, TService>> factory)
//        {
//            RegisterAsSingleton(factory, string.Empty);
//        }

//        /// <summary>
//        /// Registers a factory delegate used to create an instance of <typeparamref name="TService"/>. 
//        /// </summary>
//        /// <typeparam name="TService">The type of service for which to register a factory delegate.</typeparam>
//        /// <param name="factory">The delegate used to create a instance of <typeparamref name="TService"/>.</param>
//        /// <param name="serviceName">The name of the service.</param>
//        public void Register<TService>(Expression<Func<IServiceContainer, TService>> factory, string serviceName)
//        {
//            var implementationInfo = new ImplementationInfo(typeof(Func<TService>), () => factory.Body);
//            Register(typeof(TService), serviceName, implementationInfo);
//        }

//        /// <summary>
//        /// Registers a factory delegate used to create an instance of <typeparamref name="TService"/>. 
//        /// </summary>
//        /// <typeparam name="TService">The type of service for which to register a factory delegate.</typeparam>
//        /// <param name="factory">The delegate used to create a instance of <typeparamref name="TService"/>.</param>
//        /// <param name="serviceName">The name of the service.</param>
//        public void RegisterAsSingleton<TService>(Expression<Func<IServiceContainer, TService>> factory, string serviceName)
//        {
//            var implementationInfo = new ImplementationInfo(
//                typeof(Func<TService>),
//                () => CreateSingletonExpression(() => _methodCallRewriter.Visit(factory.Body)));
//            Register(typeof(TService), serviceName, implementationInfo);
//        }

//        /// <summary>
//        /// Gets an instance of the given <paramref name="serviceType"/>.
//        /// </summary>
//        /// <param name="serviceType">The type of the requested service.</param>
//        /// <returns>The requested service instance.</returns>
//        public object GetInstance(Type serviceType)
//        {
//            return _defaultFactories.GetOrAdd(
//                serviceType,
//                t =>
//                new Lazy<Func<List<object>, object>>(() => CreateDelegate(serviceType, string.Empty))).Value(_constants);
//        }

//        private static bool IsLazy(Type serviceType)
//        {
//            return serviceType.IsGenericType && serviceType.GetGenericTypeDefinition() == typeof(Lazy<>);
//        }

//        private static bool IsEnumerableOfT(Type serviceType)
//        {
//            return serviceType.IsGenericType && serviceType.GetGenericTypeDefinition() == typeof(IEnumerable<>);
//        }

//        private static bool IsFactory(Type type)
//        {
//            return typeof(IFactory).IsAssignableFrom(type);
//        }

//        private static bool IsFunc(Type serviceType)
//        {
//            return serviceType.IsGenericType && serviceType.GetGenericTypeDefinition() == typeof(Func<>);
//        }

//        private static bool IsClosedGeneric(Type serviceType)
//        {
//            return serviceType.IsGenericType && !serviceType.IsGenericTypeDefinition;
//        }

//        private static bool IsReadOnly(PropertyInfo propertyInfo)
//        {
//            return propertyInfo.GetSetMethod(false) == null;
//        }

//        private static ConstructorInfo GetConstructorInfo(Type concreteType)
//        {
//            return concreteType.GetConstructors().OrderBy(c => c.GetParameters().Count()).LastOrDefault();
//        }

//        private static T Compile<T>(Expression<T> lambdaExpression)
//        {
//            var t = lambdaExpression.Compile();
//            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("DynamicAssembly"), AssemblyBuilderAccess.RunAndSave);
//            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("DynamicModule");
//            TypeBuilder typeBuilder = moduleBuilder.DefineType("DynamicType", TypeAttributes.Public);
//            MethodBuilder methodBuilder = typeBuilder.DefineMethod("MethodDelegate", MethodAttributes.Public | MethodAttributes.Static);
//            lambdaExpression.CompileToMethod(methodBuilder);
//            Type type = typeBuilder.CreateType();
//            assemblyBuilder.Save("test.dll");
//            var test = (T)(object)Delegate.CreateDelegate(lambdaExpression.Type, type.GetMethod("MethodDelegate"), true);
//            return test;
//        }
//#if SILVERLIGHT
//        private static IEnumerable<Assembly> GetAssemblies()
//        {
//            var assemblies = new List<Assembly>();
//            foreach (AssemblyPart part in Deployment.Current.Parts)
//            {
//                StreamResourceInfo resourceStream = Application.GetResourceStream(new Uri(part.Source, UriKind.Relative));
//                if (resourceStream != null)
//                {
//                    Assembly item = part.Load(resourceStream.Stream);
//                    assemblies.Add(item);
//                }
//            }
//        return assemblies;
//        }
//#endif
//#if !SILVERLIGHT

//        private static IEnumerable<Assembly> GetAssemblies()
//        {
//            return AppDomain.CurrentDomain.GetAssemblies().Where(a => !a.GlobalAssemblyCache);
//        }
//#endif

//        private ServiceRequest CreateServiceRequest(Type serviceType, string serviceName, Expression proceedExpression)
//        {
//            var serviceRequest = new ServiceRequest
//            {
//                ServiceType = serviceType,
//                ServiceName = serviceName,
//                Proceed = CreateProceedFunctionDelegate(proceedExpression)
//            };
//            return serviceRequest;
//        }

//        private Func<object> CreateProceedFunctionDelegate(Expression proceedExpression)
//        {
//            if (proceedExpression == null)
//                return null;
//            var func = Compile(Expression.Lambda<Func<List<object>, object>>(proceedExpression, _constantsParameterExpression));
//            return () => func(_constants);
//        }

//        private IEnumerable<Expression> GetParameterExpressions(ConstructorInfo constructorInfo)
//        {
//            return constructorInfo.GetParameters().Select(
//                parameterInfo =>
//                Expression.Convert(GetBodyExpression(parameterInfo.ParameterType, HasMultipleImplementations(parameterInfo.ParameterType) ? parameterInfo.Name : string.Empty), parameterInfo.ParameterType)).ToList();
//        }

//        private void Register(Type serviceType, string serviceName, ImplementationInfo implementationInfo)
//        {
//            GetImplementations(serviceType).AddOrUpdate(serviceName, s => implementationInfo, (s, i) => implementationInfo);
//        }

//        private void RegisterFromAppDomain()
//        {
//            foreach (Assembly assembly in GetAssemblies())
//            {
//                Register(assembly, t => true);
//            }
//        }

//        private Expression CreateSingletonExpression(Type serviceType, Type implementingType)
//        {
//            Expression newExpression = CreateNewExpression(implementingType);
//            object singletonInstance =
//                Compile(Expression.Lambda<Func<List<object>, object>>(newExpression, _constantsParameterExpression))(_constants);

//            return CreateConstantExpression(serviceType, singletonInstance);
//        }

//        private Expression CreateSingletonExpression(Func<Expression> expressionFactory)
//        {
//            object singletonInstance =
//                Compile(Expression.Lambda<Func<List<object>, object>>(expressionFactory(), _constantsParameterExpression))(_constants);
//            return CreateConstantExpression(singletonInstance.GetType(), singletonInstance);
//        }

//        private Expression CreateConstantExpression(Type serviceType, object value)
//        {
//            int index = GetConstantIndex(value);
//            MethodInfo method = typeof(List<object>).GetMethod("get_Item");
//            return Expression.Convert(Expression.Call(_constantsParameterExpression, method, Expression.Constant(index)), serviceType);
//        }

//        private NewArrayExpression CreateNewArrayExpression(Type enumerableType)
//        {
//            Type serviceType = enumerableType.GetGenericArguments().First();

//            List<Expression> newExpressions = GetImplementations(serviceType)
//                .Select(implementation => GetBodyExpression(serviceType, implementation.Key)).ToList();

//            NewArrayExpression newArrayExpression = Expression.NewArrayInit(serviceType, newExpressions);
//            return newArrayExpression;
//        }

//        private ThreadSafeDictionary<string, ImplementationInfo> GetImplementations(Type serviceType)
//        {
//            return _availableServices.GetOrAdd(serviceType, s => new ThreadSafeDictionary<string, ImplementationInfo>(StringComparer.InvariantCultureIgnoreCase));
//        }

//        private Expression CreateNewExpression(Type implementingType)
//        {
//            ConstructorInfo constructorInfo = GetConstructorInfo(implementingType);
//            IEnumerable<Expression> parameterExpressions = GetParameterExpressions(constructorInfo);
//            NewExpression newExpression = Expression.New(constructorInfo, parameterExpressions);
//            if (HasInjectableProperties(implementingType))
//                return Expression.MemberInit(newExpression, GetMemberBindingExpressions(GetInjectableProperties(implementingType)));
//            return newExpression;
//        }

//        private IEnumerable<MemberBinding> GetMemberBindingExpressions(IEnumerable<PropertyInfo> properties)
//        {
//            return properties.Select(p => Expression.Bind(p, GetBodyExpression(p.PropertyType, HasMultipleImplementations(p.PropertyType) ? p.Name : string.Empty)));
//        }

//        private bool HasInjectableProperties(Type implementingType)
//        {
//            return !IsFactory(implementingType) && implementingType.GetProperties().Any(IsInjectable);
//        }

//        private IEnumerable<PropertyInfo> GetInjectableProperties(Type implementingType)
//        {
//            var properties = implementingType.GetProperties().Where(IsInjectable).ToList();
//            return properties;
//        }

//        private bool IsInjectable(PropertyInfo propertyInfo)
//        {
//            return !IsReadOnly(propertyInfo) && CanGetInstance(propertyInfo.PropertyType, propertyInfo.Name);
//        }

//        private bool CanGetInstance(Type serviceType, string serviceName)
//        {
//            return GetImplementationInfo(serviceType, HasMultipleImplementations(serviceType) ? serviceName : string.Empty) != null;
//        }

//        private bool HasMultipleImplementations(Type serviceType)
//        {
//            return GetImplementations(serviceType).Count > 1;
//        }

//        private Expression GetBodyExpression(Type serviceType, string serviceName)
//        {
//            ImplementationInfo implementationInfo = GetImplementationInfo(serviceType, serviceName);
//            if (implementationInfo == null)
//            {
//                throw new InvalidOperationException(
//                    string.Format("Unable to resolve an implementation based on request (Type = {0}, Name = {1}", serviceType, serviceName));
//            }

//            try
//            {
//                Expression expression = implementationInfo.FactoryExpression.Value;
//                if (!implementationInfo.IsCustomFactory)
//                {
//                    IFactory factory = GetCustomFactory(serviceType, serviceName);
//                    if (factory != null)
//                        expression = CreateCustomFactoryExpression(factory, serviceType, serviceName, expression);
//                }

//                return _methodCallRewriter.Visit(expression);
//            }
//            catch (InvalidOperationException)
//            {
//                throw new InvalidOperationException(
//                    string.Format("An recursive dependency has been detected while resolving (Type = {0}, Name = {1}", serviceType, serviceName));
//            }
//        }

//        private Expression CreateFuncExpression(Type serviceType, string serviceName)
//        {
//            Type actualServiceType = serviceType.GetGenericArguments().First();

//            var methodInfo = typeof(ServiceContainer).GetMethod(
//                "CreateFuncExpression", BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { typeof(string) }, null);

//            return (Expression)methodInfo.MakeGenericMethod(actualServiceType).Invoke(this, new object[] { serviceName });
//        }

//        private Expression CreateFuncExpression<TServiceType>(string serviceName)
//        {
//            Expression bodyExression = GetBodyExpression(typeof(TServiceType), serviceName);
//            var lambda = Expression.Lambda<Func<List<object>, TServiceType>>(bodyExression, _constantsParameterExpression);
//            var compiled = Compile(lambda);
//            Func<TServiceType> func = () => compiled(_constants);
//            return CreateConstantExpression(typeof(Func<TServiceType>), func);
//        }

//        private ImplementationInfo GetImplementationInfo(Type serviceType, string serviceName)
//        {
//            ImplementationInfo implementationInfo;
//            GetImplementations(serviceType).TryGetValue(serviceName, out implementationInfo);
//            if (implementationInfo != null)
//            {
//                return implementationInfo;
//            }

//            implementationInfo = TryResolveImplementationForUnknownService(serviceType, serviceName);
//            if (implementationInfo != null)
//            {
//                GetImplementations(serviceType).TryAdd(serviceName, implementationInfo);
//            }

//            return implementationInfo;
//        }

//        private ImplementationInfo CreateImplementationInfo(Type implementingType)
//        {
//            return new ImplementationInfo(implementingType, () => CreateNewExpression(implementingType));
//        }

//        private ImplementationInfo CreateSingletonImplementationInfo(Type serviceType, Type implementingType)
//        {
//            return new ImplementationInfo(implementingType, () => CreateSingletonExpression(serviceType, implementingType))
//                   {
//                       IsSingleton = true
//                   };
//        }

//        private ImplementationInfo TryResolveImplementationForUnknownService(Type serviceType, string serviceName)
//        {
//            if (IsEnumerableOfT(serviceType))
//                return CreateEnumerableImplementationInfo(serviceType);
//            if (IsFunc(serviceType))
//                return CreateFuncImplementationInfo(serviceType, serviceName);
//            if (IsLazy(serviceType))
//                return CreateLazyImplementationInfo(serviceType, serviceName);
//            if (CanRedirectRequestForDefaultServiceToSingleNamedService(serviceType, serviceName))
//                return CreateImplementationInfoBasedOnFirstNamedInstance(serviceType);
//            if (IsClosedGeneric(serviceType))
//                return CreateClosedGenericImplementationInfo(serviceType, serviceName);

//            IFactory factory = GetCustomFactory(serviceType, serviceName);
//            if (factory != null)
//                return CreateCustomFactoryImplementationInfo(serviceType, serviceName, factory);

//            return null;
//        }

//        private bool CanRedirectRequestForDefaultServiceToSingleNamedService(Type serviceType, string serviceName)
//        {
//            return string.IsNullOrEmpty(serviceName) && GetImplementations(serviceType).Count == 1;
//        }

//        private ImplementationInfo CreateImplementationInfoBasedOnFirstNamedInstance(Type serviceType)
//        {
//            return GetImplementationInfo(serviceType, GetImplementations(serviceType).First().Key);
//        }

//        private ImplementationInfo CreateCustomFactoryImplementationInfo(Type serviceType, string serviceName, IFactory factory)
//        {
//            return new ImplementationInfo(null, () => CreateCustomFactoryExpression(factory, serviceType, serviceName, null))
//                   {
//                       IsCustomFactory = true
//                   };
//        }

//        private Expression CreateCustomFactoryExpression(IFactory customFactory, Type serviceType, string serviceName, Expression proceedExpression)
//        {
//            ServiceRequest serviceRequest = CreateServiceRequest(serviceType, serviceName, proceedExpression);
//            var getFactoryExpression = CreateConstantExpression(typeof(IFactory), customFactory);
//            var getServiceRequestExpression = CreateConstantExpression(typeof(ServiceRequest), serviceRequest);
//            return Expression.Convert(Expression.Call(getFactoryExpression, getInstanceMethod, new[] { getServiceRequestExpression }), serviceType);
//        }

//        [MethodImpl(MethodImplOptions.Synchronized)]
//        private int GetConstantIndex(object value)
//        {
//            if (!_constants.Contains(value))
//                _constants.Add(value);
//            return _constants.IndexOf(value);
//        }

//        private IFactory GetCustomFactory(Type serviceType, string serviceName)
//        {
//            if (IsFactory(serviceType) ||
//                (IsEnumerableOfT(serviceType) && IsFactory(serviceType.GetGenericArguments().First())))
//                return null;
//            return GetInstance<IEnumerable<IFactory>>().Where(f => f.CanGetInstance(serviceType, serviceName)).FirstOrDefault();
//        }

//        private ImplementationInfo CreateFuncImplementationInfo(Type serviceType, string serviceName)
//        {
//            return new ImplementationInfo(null, () => CreateFuncExpression(serviceType, serviceName));
//        }

//        private ImplementationInfo CreateEnumerableImplementationInfo(Type serviceType)
//        {
//            return new ImplementationInfo(null, () => CreateNewArrayExpression(serviceType));
//        }

//        private ImplementationInfo CreateLazyImplementationInfo(Type serviceType, string serviceName)
//        {
//            return new ImplementationInfo(null, () => CreateLazyExpression(serviceType, serviceName));
//        }

//        private Expression CreateLazyExpression(Type serviceType, string serviceName)
//        {
//            Type actualServiceType = serviceType.GetGenericArguments().First();
//            Type lazyType = typeof(Lazy<>).MakeGenericType(actualServiceType);
//            ConstructorInfo ctor = lazyType.GetConstructor(new[] { typeof(Func<>).MakeGenericType(actualServiceType) });
//            Expression bodyExression = GetBodyExpression(actualServiceType, serviceName);
//            Type funcType = typeof(Func<>).MakeGenericType(actualServiceType);
//            LambdaExpression lambdaExpression = Expression.Lambda(funcType, bodyExression, null);
//            Expression newExpression = Expression.New(ctor, lambdaExpression);
//            return newExpression;
//        }

//        private ImplementationInfo CreateClosedGenericImplementationInfo(Type serviceType, string serviceName)
//        {
//            Type openGenericServiceType = serviceType.GetGenericTypeDefinition();
//            ImplementationInfo openGenericImplementationInfo = GetImplementationInfo(openGenericServiceType, serviceName);
//            if (openGenericImplementationInfo == null)
//                return null;
//            Type closedGenericImplementingType =
//                openGenericImplementationInfo.ImplementingType.MakeGenericType(serviceType.GetGenericArguments());
//            if (openGenericImplementationInfo.IsSingleton)
//                return CreateSingletonImplementationInfo(serviceType, closedGenericImplementingType);
//            return CreateImplementationInfo(closedGenericImplementingType);
//        }

//        private Func<List<object>, object> CreateDelegate(Type serviceType, string serviceName)
//        {
//            EnsureServiceContainerIsConfigured();
//            Expression expression = GetBodyExpression(serviceType, serviceName);
//            return Compile(Expression.Lambda<Func<List<object>, object>>(expression, _constantsParameterExpression));
//        }


//        private Func<List<object>, object> CreateDynamicMethodDelegate(Type serviceType, string serviceName)
//        {
//            ImplementationInfo implementationInfo = GetImplementationInfo(serviceType, serviceName);
//            ConstructorInfo constructorInfo = GetConstructorInfo(implementationInfo.ImplementingType);
//            var dynamicMethod = CreateDynamicMethod();
//            ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
//            ilGenerator.Emit(OpCodes.Newobj, constructorInfo);
//            ilGenerator.Emit(OpCodes.Ret);
//            return (Func<List<object>, object>)dynamicMethod.CreateDelegate(typeof(Func<List<object>, object>));

//        }

//        private DynamicMethod CreateDynamicMethod()
//        {
//            DynamicMethod dynamicMethod = new DynamicMethod(
//                "DynamicMethod", typeof(object), new[] { typeof(List<object>) }, typeof(ServiceContainer).Module, false);
//            return dynamicMethod;
//        }

//        private void EnsureServiceContainerIsConfigured()
//        {
//            if (_availableServices.Count == 0)
//                RegisterFromAppDomain();
//        }

//        /// <summary>
//        /// Replaces a <see cref="MethodCallExpression"/> that represents the GetInstance/GetAllInstances method 
//        /// with their resolved body expression.        
//        /// </summary>
//        public class MethodCallRewriter : ExpressionVisitor
//        {
//            private readonly Func<Type, string, Expression> _getBodyExpression;

//            /// <summary>
//            /// Initializes a new instance of the <see cref="MethodCallRewriter"/> class.
//            /// </summary>
//            /// <param name="getBodyExpression">The function delegate used to retrieve a body expression for a given service type.</param>
//            public MethodCallRewriter(Func<Type, string, Expression> getBodyExpression)
//            {
//                _getBodyExpression = getBodyExpression;
//            }

//            /// <summary>
//            /// Visits the children of the <see cref="T:System.Linq.Expressions.MethodCallExpression"/>.
//            /// </summary>
//            /// <returns>
//            /// The modified expression, if it or any subexpression was modified; otherwise, returns the original expression.
//            /// </returns>
//            /// <param name="node">The expression to visit.</param>
//            protected override Expression VisitMethodCall(MethodCallExpression node)
//            {
//                if (RepresentsGetInstanceMethod(node))
//                    return RewriteGetInstanceMethod(node);
//                if (RepresentsGetNamedInstanceMethod(node))
//                    return RewriteGetNamedInstanceMethod(node);
//                if (RepresentsGetAllInstancesMethod(node))
//                    return RewriteGetAllInstancesMethod(node);
//                return base.VisitMethodCall(node);
//            }

//            private static bool RepresentsGetAllInstancesMethod(MethodCallExpression node)
//            {
//                return IsGetAllInstancesMethod(node.Method);
//            }

//            private static bool RepresentsGetNamedInstanceMethod(MethodCallExpression node)
//            {
//                return IsGetInstanceMethod(node.Method) && HasOneArgumentRepresentingServiceName(node);
//            }

//            private static bool HasOneArgumentRepresentingServiceName(MethodCallExpression node)
//            {
//                return HasOneArgument(node) && IsStringConstantExpression(node.Arguments[0]);
//            }

//            private static bool IsStringConstantExpression(Expression argument)
//            {
//                return argument.NodeType == ExpressionType.Constant && argument.Type == typeof(string);
//            }

//            private static bool HasOneArgument(MethodCallExpression node)
//            {
//                return node.Arguments.Count == 1;
//            }

//            private static bool IsGetInstanceMethod(MethodInfo methodInfo)
//            {
//                return typeof(IServiceContainer).IsAssignableFrom(methodInfo.DeclaringType) && methodInfo.Name == "GetInstance";
//            }

//            private static bool IsGetAllInstancesMethod(MethodInfo methodInfo)
//            {
//                return typeof(IServiceContainer).IsAssignableFrom(methodInfo.DeclaringType) && methodInfo.Name == "GetAllInstances";
//            }

//            private static bool RepresentsGetInstanceMethod(MethodCallExpression node)
//            {
//                return IsGetInstanceMethod(node.Method) && node.Arguments.Count == 0;
//            }

//            private Expression RewriteGetInstanceMethod(MethodCallExpression methodCallExpression)
//            {
//                return _getBodyExpression(methodCallExpression.Method.GetGenericArguments().First(), string.Empty);
//            }

//            private Expression RewriteGetNamedInstanceMethod(MethodCallExpression methodCallExpression)
//            {
//                return _getBodyExpression(methodCallExpression.Method.GetGenericArguments().First(), (string)((ConstantExpression)methodCallExpression.Arguments[0]).Value);
//            }

//            private Expression RewriteGetAllInstancesMethod(MethodCallExpression methodCallExpression)
//            {
//                Type enumerableType = typeof(IEnumerable<>).MakeGenericType(methodCallExpression.Method.GetGenericArguments().First());
//                return _getBodyExpression(enumerableType, string.Empty);
//            }
//        }

//        private class ImplementationInfo
//        {
//            public ImplementationInfo(Type implementingType, Func<Expression> factory)
//            {
//                ImplementingType = implementingType;
//                FactoryExpression = new Lazy<Expression>(factory);
//            }

//            public Type ImplementingType { get; private set; }

//            public Lazy<Expression> FactoryExpression { get; private set; }

//            public bool IsSingleton { get; set; }

//            public bool IsCustomFactory { get; set; }
//        }
//#if NET

//        private class ThreadSafeDictionary<TKey, TValue> : ConcurrentDictionary<TKey, TValue>
//        {
//            public ThreadSafeDictionary()
//            {
//            }

//            public ThreadSafeDictionary(IEqualityComparer<TKey> comparer)
//                : base(comparer)
//            {
//            }
//        }
//#endif
//#if SILVERLIGHT

//        private class ThreadSafeDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
//        {

//            private readonly Dictionary<TKey, TValue> _dictionary;
//            private readonly object _syncObject = new object();

//            public ThreadSafeDictionary() {_dictionary = new Dictionary<TKey, TValue>();}            

//            public ThreadSafeDictionary(IEqualityComparer<TKey> comparer)
//            {
//                _dictionary = new Dictionary<TKey, TValue>(comparer);
//            }

//            public TValue GetOrAdd(TKey key, Func<TKey,TValue> valuefactory)
//            {
//                lock (_syncObject)
//                {
//                    TValue value;
//                    if (!_dictionary.TryGetValue(key, out value))
//                    {
//                        value = valuefactory(key);
//                        _dictionary.Add(key, value);
//                    }
//                    return value;
//                }
//            }    

//            public int Count
//            {
//                get { return _dictionary.Count; }
//            }

//            public void AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
//            {
//                lock (_syncObject)
//                {
//                    TValue value;
//                    if (!_dictionary.TryGetValue(key, out value))
//                        _dictionary.Add(key, addValueFactory(key));
//                    else
//                        _dictionary[key] = updateValueFactory(key, value);
//                }
//            }


//            public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
//            {
//                lock (_syncObject)
//                    return _dictionary.ToDictionary(kvp => kvp.Key, kvp => kvp.Value).GetEnumerator();
//            }

//            IEnumerator IEnumerable.GetEnumerator()
//            {
//                return GetEnumerator();
//            }
//        }        
//#endif
//    }




//}