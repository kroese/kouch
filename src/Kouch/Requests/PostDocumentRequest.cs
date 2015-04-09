﻿using System;
using EnsureThat;

namespace MyCouch.Requests
{
#if !PCL
    [Serializable]
#endif
    public class PostDocumentRequest : Request
    {
        public bool Batch { get; set; }
        public string Content { get; set; }

        public PostDocumentRequest(string content)
        {
            Ensure.That(content, "content").IsNotNullOrWhiteSpace();

            Batch = false;
            Content = content;
        }
    }
}