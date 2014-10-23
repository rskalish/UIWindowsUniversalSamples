using System.Collections.Generic;
using GalaSoft.MvvmLight;

namespace MyTelerikSamples.AutoCompleteBoxSample.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string _value;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value
        {
            get { return _value; }
            set { Set(() => Value, ref _value, value); }
        }

        /// <summary>
        /// Gets the suggestions.
        /// </summary>
        /// <value>The suggestions.</value>
        public IEnumerable<string> Suggestions
        {
            get
            {
                return new List<string>
                {
                     "Apple",
                     "Babaco",
                     "Bacupari",
                     "Bacuri",
                     "Black cherry",
                     "Pineapples",
                     "Orange",
                     "Tomato",
                };
            }
        }
    }
}