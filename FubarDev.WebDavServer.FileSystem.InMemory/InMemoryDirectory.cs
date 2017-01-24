﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using FubarDev.WebDavServer.Model;

namespace FubarDev.WebDavServer.FileSystem.InMemory
{
    public class InMemoryDirectory : InMemoryEntry, ICollection
    {
        private readonly Dictionary<string, InMemoryEntry> _children = new Dictionary<string, InMemoryEntry>(StringComparer.OrdinalIgnoreCase);

        public InMemoryDirectory(IFileSystem fileSystem, InMemoryDirectory parent, Uri path, string name)
            : base(fileSystem, parent, path, name)
        {
        }

        public override Task<DeleteResult> DeleteAsync(CancellationToken cancellationToken)
        {
            var result = !InMemoryParent.Remove(Name)
                ? new DeleteResult(WebDavStatusCodes.NotFound, this)
                : new DeleteResult(WebDavStatusCodes.OK, null);
            return Task.FromResult(result);
        }

        public Task<IEntry> GetChildAsync(string name, CancellationToken ct)
        {
            InMemoryEntry entry;
            _children.TryGetValue(name, out entry);
            return Task.FromResult<IEntry>(entry);
        }

        public Task<IReadOnlyCollection<IEntry>> GetChildrenAsync(CancellationToken ct)
        {
            return Task.FromResult<IReadOnlyCollection<IEntry>>(_children.Values.ToList());
        }

        public Task<IDocument> CreateDocumentAsync(string name, CancellationToken ct)
        {
            if (_children.ContainsKey(name))
                throw new IOException("Document or collection with the same name already exists");
            var newItem = new InMemoryFile(FileSystem, this, Path.Append(name), name);
            _children.Add(newItem.Name, newItem);
            return Task.FromResult<IDocument>(newItem);
        }

        public Task<ICollection> CreateCollectionAsync(string name, CancellationToken ct)
        {
            if (_children.ContainsKey(name))
                throw new IOException("Document or collection with the same name already exists");
            var newItem = new InMemoryDirectory(FileSystem, this, Path.Append(name), name);
            _children.Add(newItem.Name, newItem);
            return Task.FromResult<ICollection>(newItem);
        }

        internal bool Remove(string name)
        {
            return _children.Remove(name);
        }
    }
}