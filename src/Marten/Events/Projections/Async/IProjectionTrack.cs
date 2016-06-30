using System;
using System.Threading.Tasks;

namespace Marten.Events.Projections.Async
{
    public interface IProjectionTrack : IDisposable
    {
        long LastEncountered { get; set; }
        Type ViewType { get; }
        void Start(DaemonLifecycle lifecycle);
        Task Stop();
        Task<long> WaitUntilEventIsProcessed(long sequence);
        Task<long> RunUntilEndOfEvents();
    }
}