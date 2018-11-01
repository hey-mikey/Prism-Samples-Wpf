using Prism.Events;

namespace UsingEventAggregator.Core
{
    /// <summary>
    ///     Class MessageSentEvent.
    ///     Implements the <see cref="string" />
    /// </summary>
    /// <seealso cref="string" />
    public class MessageSentEvent : PubSubEvent<string>
    {
    }
}