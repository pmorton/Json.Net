#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;

namespace Newtonsoft.Json.Serialization
{
  /// <summary>
  /// Maps a JSON property to a .NET member.
  /// </summary>
  public class JsonProperty
  {
    /// <summary>
    /// Gets the name of the property.
    /// </summary>
    /// <value>The name of the property.</value>
    public string PropertyName { get; set; }

    /// <summary>
    /// Gets the <see cref="IValueProvider"/> that will get and set the <see cref="JsonProperty"/> during serialization.
    /// </summary>
    /// <value>The <see cref="IValueProvider"/> that will get and set the <see cref="JsonProperty"/> during serialization.</value>
    public IValueProvider ValueProvider { get; set; }

    /// <summary>
    /// Gets or sets the type of the property.
    /// </summary>
    /// <value>The type of the property.</value>
    public Type PropertyType { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="JsonConverter" /> for the property.
    /// If set this converter takes presidence over the contract converter for the property type.
    /// </summary>
    /// <value>The converter.</value>
    public JsonConverter Converter { get; set; }

    /// <summary>
    /// Gets a value indicating whether this <see cref="JsonProperty"/> is ignored.
    /// </summary>
    /// <value><c>true</c> if ignored; otherwise, <c>false</c>.</value>
    public bool Ignored { get; set; }

    /// <summary>
    /// Gets a value indicating whether this <see cref="JsonProperty"/> is readable.
    /// </summary>
    /// <value><c>true</c> if readable; otherwise, <c>false</c>.</value>
    public bool Readable { get; set; }

    /// <summary>
    /// Gets a value indicating whether this <see cref="JsonProperty"/> is writable.
    /// </summary>
    /// <value><c>true</c> if writable; otherwise, <c>false</c>.</value>
    public bool Writable { get; set; }

    /// <summary>
    /// Gets the member converter.
    /// </summary>
    /// <value>The member converter.</value>
    public JsonConverter MemberConverter { get; set; }

    /// <summary>
    /// Gets the default value.
    /// </summary>
    /// <value>The default value.</value>
    public object DefaultValue { get; set; }

    /// <summary>
    /// Gets a value indicating whether this <see cref="JsonProperty"/> is required.
    /// </summary>
    /// <value>A value indicating whether this <see cref="JsonProperty"/> is required.</value>
    public Required Required { get; set; }

    /// <summary>
    /// Gets a value indicating whether this property preserves object references.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is reference; otherwise, <c>false</c>.
    /// </value>
    public bool? IsReference { get; set; }

    /// <summary>
    /// Gets the property null value handling.
    /// </summary>
    /// <value>The null value handling.</value>
    public NullValueHandling? NullValueHandling { get; set; }

    /// <summary>
    /// Gets the property default value handling.
    /// </summary>
    /// <value>The default value handling.</value>
    public DefaultValueHandling? DefaultValueHandling { get; set; }

    /// <summary>
    /// Gets the property reference loop handling.
    /// </summary>
    /// <value>The reference loop handling.</value>
    public ReferenceLoopHandling? ReferenceLoopHandling { get; set; }

    /// <summary>
    /// Gets the property object creation handling.
    /// </summary>
    /// <value>The object creation handling.</value>
    public ObjectCreationHandling? ObjectCreationHandling { get; set; }

    public Predicate<object> ShouldSerialize { get; set; }

    public TypeNameHandling? TypeNameHandling { get; set; }

    /// <summary>
    /// Returns a <see cref="String"/> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="String"/> that represents this instance.
    /// </returns>
    public override string ToString()
    {
      return PropertyName;
    }
  }
}