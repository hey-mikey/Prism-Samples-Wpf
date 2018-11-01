using Prism.Mvvm;

namespace UsingEventAggregator.ViewModels
{
    /// <summary>
    ///     Class MainWindowViewModel.
    ///     Implements the <see cref="BindableBase" />
    /// </summary>
    /// <seealso cref="BindableBase" />
    public class MainWindowViewModel : BindableBase
    {
        /// <summary>
        ///     The private field backing the public title property
        /// </summary>
        /// <summary>
        ///     The title
        /// </summary>
        private string _title = "Prism Unity Application";

        /// <summary>
        ///     Gets or sets the title for the application.
        /// </summary>
        /// <value>The title.</value>
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}