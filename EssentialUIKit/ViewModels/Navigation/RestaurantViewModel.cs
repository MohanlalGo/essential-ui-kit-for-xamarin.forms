﻿using EssentialUIKit.Models.Navigation;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace EssentialUIKit.ViewModels.Navigation
{
    /// <summary>
    /// ViewModel for the Restaurant list .
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class RestaurantViewModel
    {
        #region Fields

        private Command<object> itemTappedCommand;

        private Command<object> backButtonCommand;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref=RestaurantViewModel"/> class.
        /// </summary>
        public RestaurantViewModel()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the command that will be executed when an item is selected.
        /// </summary>
        public Command<object> ItemTappedCommand
        {
            get
            {
                return this.itemTappedCommand ?? (this.itemTappedCommand = new Command<object>(this.NavigateToNextPage));
            }
        }

        /// <summary>
        /// Gets the command that will be executed when an back button is clicked.
        /// </summary>
        public Command<object> BackButtonCommand
        {
            get
            {
                return this.backButtonCommand ?? (this.backButtonCommand = new Command<object>(this.BackButtonClicked));
            }
        }

        /// <summary>
        /// Gets or sets a collection of values to be displayed in the Restaurant page.
        /// </summary>
        [DataMember(Name = "navigationList")]
        public ObservableCollection<Restaurant> NavigationList { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when an item is selected from the navigation list.
        /// </summary>
        /// <param name="selectedItem">Selected item from the list view.</param>
        private void NavigateToNextPage(object selectedItem)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the back button is clicked.
        /// </summary>
        /// <param name="obj">The sender.</param>
        private void BackButtonClicked(object obj)
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }

        #endregion
    }
}
