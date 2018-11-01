using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using UsingEventAggregator.Core;

namespace ModuleA.ViewModels
{
    /// <summary>
    ///     Class MessageViewModel.
    ///     Implements the <see cref="BindableBase" />
    /// </summary>
    /// <seealso cref="BindableBase" />
    public class MessageViewModel : BindableBase
    {
        /// <summary>
        ///     The event aggregator interface
        /// </summary>
        private readonly IEventAggregator _ea;

        /// <summary>
        ///     The message
        /// </summary>
        private string _message = "Message to Send";

        /// <summary>
        ///     Initializes a new instance of the <see cref="MessageViewModel" /> class.
        /// </summary>
        /// <param name="ea">The <see cref="IEventAggregator" />.</param>
        public MessageViewModel(IEventAggregator ea)
        {
            _ea = ea;
            SendMessageCommand = new DelegateCommand(SendMessage);
        }

        /// <summary>
        ///     Gets the send message command.
        /// </summary>
        /// <value>The send message command.</value>
        public DelegateCommand SendMessageCommand { get; }

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        /// <summary>
        ///     Sends the message.
        /// </summary>
        private void SendMessage()
        {
            _ea.GetEvent<MessageSentEvent>().Publish(Message);
        }
    }
}