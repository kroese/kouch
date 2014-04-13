﻿using System.Net.Http;
using MyCouch.EnsureThat;
using MyCouch.Responses.Factories.Materializers;
using MyCouch.Serialization;

namespace MyCouch.Responses.Factories
{
    public class ContinuousChangesResponseFactory : ResponseFactoryBase<ContinuousChangesResponse>
    {
        protected readonly FailedResponseMaterializer FailedResponseMaterializer;

        public ContinuousChangesResponseFactory(ISerializer serializer)
        {
            Ensure.That(serializer, "serializer").IsNotNull();

            FailedResponseMaterializer = new FailedResponseMaterializer(serializer);
        }

        protected override ContinuousChangesResponse CreateResponseInstance()
        {
            return new ContinuousChangesResponse();
        }

        protected override void OnMaterializationOfSuccessfulResponseProperties(ContinuousChangesResponse response, HttpResponseMessage httpResponse) { }

        protected override void OnMaterializationOfFailedResponseProperties(ContinuousChangesResponse response, HttpResponseMessage httpResponse)
        {
            FailedResponseMaterializer.Materialize(response, httpResponse);
        }
    }
}