﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Xunit;
using Nustache;
using Nustache.Core;
using Refit;
using Refit.Generator;
using Task =  System.Threading.Tasks.Task;
using System.Net;
using System.Reactive.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RichardSzalay.MockHttp;
using static System.Math;
using SomeType =  CollisionA.SomeType;
using CollisionB;
using System.Reflection;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIAmARefitInterfaceButNobodyUsesMe : IAmARefitInterfaceButNobodyUsesMe
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIAmARefitInterfaceButNobodyUsesMe(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task RefitMethod()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["RefitMethod"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task AnotherRefitMethod()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["AnotherRefitMethod"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task NoConstantsAllowed()
        {
            throw new NotImplementedException("Either this method has no Refit HTTP method attribute or you've used something other than a string literal for the 'path' argument.");
        }

        /// <inheritdoc />
        public virtual Task SpacesShouldntBreakMe()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["SpacesShouldntBreakMe"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task ReservedWordsForParameterNames(int @int,string @string,float @long)
        {
            var arguments = new object[] { @int,@string,@long };
            return (Task) methodImpls["ReservedWordsForParameterNames"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIAmHalfRefit : IAmHalfRefit
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIAmHalfRefit(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task Post()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Post"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Get()
        {
            throw new NotImplementedException("Either this method has no Refit HTTP method attribute or you've used something other than a string literal for the 'path' argument.");
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIBoringCrudApi<T, TKey> : IBoringCrudApi<T, TKey>
        where T : class
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIBoringCrudApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task<T> Create(T paylod)
        {
            var arguments = new object[] { paylod };
            return (Task<T>) methodImpls["Create"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<T>> ReadAll()
        {
            var arguments = new object[] {  };
            return (Task<List<T>>) methodImpls["ReadAll"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<T> ReadOne(TKey key)
        {
            var arguments = new object[] { key };
            return (Task<T>) methodImpls["ReadOne"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Update(TKey key,T payload)
        {
            var arguments = new object[] { key,payload };
            return (Task) methodImpls["Update"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Delete(TKey key)
        {
            var arguments = new object[] { key };
            return (Task) methodImpls["Delete"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIBrokenWebApi : IBrokenWebApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIBrokenWebApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task<bool> PostAValue(string derp)
        {
            var arguments = new object[] { derp };
            return (Task<bool>) methodImpls["PostAValue"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIGitHubApi : IGitHubApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIGitHubApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task<User> GetUser(string userName)
        {
            var arguments = new object[] { userName };
            return (Task<User>) methodImpls["GetUser"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserObservable(string userName)
        {
            var arguments = new object[] { userName };
            return (IObservable<User>) methodImpls["GetUserObservable"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<User> GetUserCamelCase(string userName)
        {
            var arguments = new object[] { userName };
            return (IObservable<User>) methodImpls["GetUserCamelCase"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<List<User>> GetOrgMembers(string orgName)
        {
            var arguments = new object[] { orgName };
            return (Task<List<User>>) methodImpls["GetOrgMembers"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<UserSearchResult> FindUsers(string q)
        {
            var arguments = new object[] { q };
            return (Task<UserSearchResult>) methodImpls["FindUsers"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> GetIndex()
        {
            var arguments = new object[] {  };
            return (Task<HttpResponseMessage>) methodImpls["GetIndex"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual IObservable<string> GetIndexObservable()
        {
            var arguments = new object[] {  };
            return (IObservable<string>) methodImpls["GetIndexObservable"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task NothingToSeeHere()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["NothingToSeeHere"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIHttpBinApi<TResponse, TParam, THeader> : IHttpBinApi<TResponse, TParam, THeader>
        where TResponse : class
        where THeader : struct
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIHttpBinApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task<TResponse> Get(TParam param,THeader header)
        {
            var arguments = new object[] { param,header };
            return (Task<TResponse>) methodImpls["Get"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> GetQuery(TParam param)
        {
            var arguments = new object[] { param };
            return (Task<TResponse>) methodImpls["GetQuery"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<TResponse> GetQueryWithIncludeParameterName(TParam param)
        {
            var arguments = new object[] { param };
            return (Task<TResponse>) methodImpls["GetQueryWithIncludeParameterName"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIHttpContentApi : IHttpContentApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIHttpContentApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task<HttpContent> PostFileUpload(HttpContent content)
        {
            var arguments = new object[] { content };
            return (Task<HttpContent>) methodImpls["PostFileUpload"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedINamespaceCollisionApi : INamespaceCollisionApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedINamespaceCollisionApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task<SomeType> SomeRequest()
        {
            var arguments = new object[] {  };
            return (Task<SomeType>) methodImpls["SomeRequest"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedINpmJs : INpmJs
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedINpmJs(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task<RootObject> GetCongruence()
        {
            var arguments = new object[] {  };
            return (Task<RootObject>) methodImpls["GetCongruence"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIRequestBin : IRequestBin
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIRequestBin(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task Post()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Post"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIRunscopeApi : IRunscopeApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIRunscopeApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadStream(Stream stream)
        {
            var arguments = new object[] { stream };
            return (Task<HttpResponseMessage>) methodImpls["UploadStream"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadStreamPart(StreamPart stream)
        {
            var arguments = new object[] { stream };
            return (Task<HttpResponseMessage>) methodImpls["UploadStreamPart"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadBytes(byte[] bytes)
        {
            var arguments = new object[] { bytes };
            return (Task<HttpResponseMessage>) methodImpls["UploadBytes"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadBytesPart(ByteArrayPart bytes)
        {
            var arguments = new object[] { bytes };
            return (Task<HttpResponseMessage>) methodImpls["UploadBytesPart"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadString(string someString)
        {
            var arguments = new object[] { someString };
            return (Task<HttpResponseMessage>) methodImpls["UploadString"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadFileInfo(IEnumerable<FileInfo> fileInfos,FileInfo anotherFile)
        {
            var arguments = new object[] { fileInfos,anotherFile };
            return (Task<HttpResponseMessage>) methodImpls["UploadFileInfo"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<HttpResponseMessage> UploadFileInfoPart(IEnumerable<FileInfoPart> fileInfos,FileInfoPart anotherFile)
        {
            var arguments = new object[] { fileInfos,anotherFile };
            return (Task<HttpResponseMessage>) methodImpls["UploadFileInfoPart"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIStreamApi : IStreamApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIStreamApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task<Stream> GetRemoteFile(string filename)
        {
            var arguments = new object[] { filename };
            return (Task<Stream>) methodImpls["GetRemoteFile"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    /// <inheritdoc />
    [Preserve]
    public partial class AutoGeneratedIUseOverloadedMethods : IUseOverloadedMethods
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIUseOverloadedMethods(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        /// <inheritdoc />
        public virtual Task Get()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Get"](Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task Get(int id)
        {
            var arguments = new object[] { id };
            return (Task) methodImpls["Get"](Client, arguments);
        }

    }
}
