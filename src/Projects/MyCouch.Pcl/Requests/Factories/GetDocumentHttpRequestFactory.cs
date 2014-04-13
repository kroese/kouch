﻿using System.Net.Http;
using MyCouch.EnsureThat;
using MyCouch.Net;

namespace MyCouch.Requests.Factories
{
    public class GetDocumentHttpRequestFactory : DocumentHttpRequestFactoryBase
    {
        public GetDocumentHttpRequestFactory(IDbClientConnection connection) : base(connection) { }

        public virtual HttpRequest Create(GetDocumentRequest request)
        {
            Ensure.That(request, "request").IsNotNull();

            var conflictsParam = request.Conflicts ? new UrlParam("conflicts", "true") : null;
            var httpRequest = CreateFor<GetDocumentRequest>(
                HttpMethod.Get,
                GenerateRequestUrl(request.Id, request.Rev, conflictsParam));

            httpRequest.SetIfMatch(request.Rev);

            return httpRequest;
        }
    }
}