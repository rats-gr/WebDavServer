﻿// <copyright file="GetETagProperty.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

using FubarDev.WebDavServer.FileSystem;
using FubarDev.WebDavServer.Model;
using FubarDev.WebDavServer.Model.Headers;
using FubarDev.WebDavServer.Props.Converters;
using FubarDev.WebDavServer.Props.Store;

using JetBrains.Annotations;

namespace FubarDev.WebDavServer.Props.Dead
{
    public class GetETagProperty : ITypedReadableProperty<EntityTag>, IDeadProperty
    {
        public static readonly XName PropertyName = WebDavXml.Dav + "getetag";

        [CanBeNull]
        private readonly IPropertyStore _propertyStore;

        private readonly IEntry _entry;

        private XElement _element;

        public GetETagProperty([CanBeNull] IPropertyStore propertyStore, IEntry entry, int? cost = null)
        {
            _propertyStore = propertyStore;
            _entry = entry;
            Name = PropertyName;
            Cost = cost ?? _propertyStore?.Cost ?? 0;
        }

        public XName Name { get; }

        public IReadOnlyCollection<XName> AlternativeNames { get; } = new[] { WebDavXml.Dav + "etag" };

        public int Cost { get; }

        public IPropertyConverter<EntityTag> Converter { get; } = new EntityTagConverter();

        public async Task<XElement> GetXmlValueAsync(CancellationToken ct)
        {
            if (_element == null)
            {
                if (_propertyStore != null)
                {
                    var etag = await _propertyStore.GetETagAsync(_entry, ct).ConfigureAwait(false);
                    _element = Converter.ToElement(Name, etag);
                }
                else
                {
                    _element = new EntityTag(false).ToXml();
                }
            }

            return _element;
        }

        public void Init(XElement initialValue)
        {
            _element = initialValue;
        }

        public async Task<EntityTag> GetValueAsync(CancellationToken ct)
        {
            return Converter.FromElement(await GetXmlValueAsync(ct).ConfigureAwait(false));
        }
    }
}
