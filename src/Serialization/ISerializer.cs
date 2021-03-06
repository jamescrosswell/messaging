﻿using System;

namespace Serialization
{
    /// <summary>
    /// A simple serialization abstraction
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// Serializes T to byte array
        /// </summary>
        /// <param name="object">The object to serialize</param>
        /// <typeparam name="T">The type of the object being serialized</typeparam>
        /// <returns>Serialized object</returns>
        byte[] Serialize<T>(T @object);

        /// <summary>
        /// Deserializes the byte array into an instance of an object
        /// </summary>
        /// <param name="bytes">The data to deserialize</param>
        /// <typeparam name="T">The type to instantiate</typeparam>
        /// <returns>The deserialized object</returns>
        object Deserialize(Type type, byte[] bytes);
    }
}