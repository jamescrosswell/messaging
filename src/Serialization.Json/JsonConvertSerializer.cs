﻿using System;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Serialization.Json
{
    /// <inheritdoc />
    public class JsonConvertSerializer : ISerializer
    {
        private readonly JsonOptions _options;

        public JsonConvertSerializer(IOptions<JsonOptions> options)
        {
            _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
        }

        /// <inheritdoc />
        public byte[] Serialize<T>(T @object)
        {
            var @string = JsonConvert.SerializeObject(@object);
            return _options.Encoding.GetBytes(@string);
        }

        /// <inheritdoc />
        public object Deserialize(Type type, byte[] bytes)
        {
            var @string = _options.Encoding.GetString(bytes);
            return JsonConvert.DeserializeObject(@string, type);
        }
    }
}