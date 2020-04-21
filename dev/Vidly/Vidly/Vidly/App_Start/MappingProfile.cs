using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using AutoMapper;
using AutoMapper.Features;
using AutoMapper.QueryableExtensions;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile:Profile
    { 


    }
    public class Cofniguration : AutoMapper.IConfigurationProvider
    {
        public Features<IRuntimeFeature> Features => throw new NotImplementedException();

        public Func<Type, object> ServiceCtor => throw new NotImplementedException();

        public bool EnableNullPropagationForQueryMapping => throw new NotImplementedException();

        public int MaxExecutionPlanDepth => throw new NotImplementedException();

        public IExpressionBuilder ExpressionBuilder => throw new NotImplementedException();

        public IEnumerable<IExpressionResultConverter> ResultConverters => throw new NotImplementedException();

        public IEnumerable<IExpressionBinder> Binders => throw new NotImplementedException();

        public void AssertConfigurationIsValid()
        {
            throw new NotImplementedException();
        }

        public void AssertConfigurationIsValid(TypeMap typeMap)
        {
            throw new NotImplementedException();
        }

        public void AssertConfigurationIsValid(string profileName)
        {
            throw new NotImplementedException();
        }

        public void AssertConfigurationIsValid<TProfile>() where TProfile : Profile, new()
        {
            throw new NotImplementedException();
        }

        public LambdaExpression BuildExecutionPlan(Type sourceType, Type destinationType)
        {
            throw new NotImplementedException();
        }

        public LambdaExpression BuildExecutionPlan(MapRequest mapRequest)
        {
            throw new NotImplementedException();
        }

        public void CompileMappings()
        {
            throw new NotImplementedException();
        }

        public IMapper CreateMapper()
        {
            throw new NotImplementedException();
        }

        public IMapper CreateMapper(Func<Type, object> serviceCtor)
        {
            throw new NotImplementedException();
        }

        public IObjectMapper FindMapper(TypePair types)
        {
            throw new NotImplementedException();
        }

        public TypeMap FindTypeMapFor(Type sourceType, Type destinationType)
        {
            throw new NotImplementedException();
        }

        public TypeMap FindTypeMapFor(TypePair typePair)
        {
            throw new NotImplementedException();
        }

        public TypeMap FindTypeMapFor<TSource, TDestination>()
        {
            throw new NotImplementedException();
        }

        public TypeMap[] GetAllTypeMaps()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TypeMap> GetIncludedTypeMaps(IEnumerable<TypePair> includedTypes)
        {
            throw new NotImplementedException();
        }

        public Func<TSource, TDestination, ResolutionContext, TDestination> GetMapperFunc<TSource, TDestination>(TypePair types, IMemberMap memberMap = null)
        {
            throw new NotImplementedException();
        }

        public Func<TSource, TDestination, ResolutionContext, TDestination> GetMapperFunc<TSource, TDestination>(MapRequest mapRequest)
        {
            throw new NotImplementedException();
        }

        public Delegate GetMapperFunc(MapRequest request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IObjectMapper> GetMappers()
        {
            throw new NotImplementedException();
        }

        public Func<object, object, ResolutionContext, object> GetUntypedMapperFunc(MapRequest mapRequest)
        {
            throw new NotImplementedException();
        }

        public void RegisterTypeMap(TypeMap typeMap)
        {
            throw new NotImplementedException();
        }

        public TypeMap ResolveTypeMap(Type sourceType, Type destinationType)
        {
            throw new NotImplementedException();
        }

        public TypeMap ResolveTypeMap(TypePair typePair)
        {
            throw new NotImplementedException();
        }

        public void Validate(ValidationContext context)
        {
            throw new NotImplementedException();
        }
    }
}