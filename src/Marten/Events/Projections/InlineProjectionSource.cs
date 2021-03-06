using System.Collections.Generic;
using Marten.Events.Daemon;
using Marten.Storage;

namespace Marten.Events.Projections
{
    internal class InlineProjectionSource: IProjectionSource
    {
        private readonly IProjection _projection;

        public InlineProjectionSource(IProjection projection)
        {
            _projection = projection;

            // TODO -- this probably gets fancier later
            ProjectionName = projection.GetType().FullName;
        }

        public string ProjectionName { get; }
        public IProjection Build(DocumentStore store)
        {
            return _projection;
        }

        public IReadOnlyList<IAsyncProjectionShard> AsyncProjectionShards(IDocumentStore store, ITenancy tenancy)
        {
            throw new System.NotImplementedException();
        }
    }
}
