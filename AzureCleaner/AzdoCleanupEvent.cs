﻿using Tingle.EventBus;

namespace AzureCleaner;

internal class AzdoCleanupEvent
{
    public required List<int> Ids { get; init; }
    public required string Url { get; init; }
}

internal class ProcessAzdoCleanupEventConsumer(AzureResourceCleaner cleaner) : IEventConsumer<AzdoCleanupEvent>
{
    public async Task ConsumeAsync(EventContext<AzdoCleanupEvent> context, CancellationToken cancellationToken)
    {
        var evt = context.Event;
        await cleaner.HandleAsync(ids: evt.Ids,
                                  url: evt.Url,
                                  cancellationToken: cancellationToken);
    }
}
