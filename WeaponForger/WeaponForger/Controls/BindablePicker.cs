// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/04/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

// This is a custom xamarin control. The native picker control does not allow binding to a collection.
// Because I needed this functionality, I had to create my own control that could in fact be bound to.

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using WeaponForger.Extensions;
using Xamarin.Forms;

namespace WeaponForger.Controls
{
    public class BindablePicker : Picker
    {
        /// <summary>
        ///     Builds a new bindable picker.
        /// </summary>
        public BindablePicker()
        {
            SelectedIndexChanged += OnSelectedIndexChanged;
        }

        #region Fields

        //Bindable property for the items source
        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create<BindablePicker, IEnumerable>(p => p.ItemsSource, null,
                propertyChanged: OnItemsSourcePropertyChanged);

        //Bindable property for the selected item
        public static readonly BindableProperty SelectedItemProperty =
            BindableProperty.Create<BindablePicker, object>(p => p.SelectedItem, null, BindingMode.TwoWay,
                propertyChanged: OnSelectedItemPropertyChanged);

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the items source.
        /// </summary>
        /// <value>
        ///     The items source.
        /// </value>
        public IEnumerable ItemsSource
        {
            get { return (IEnumerable) GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        /// <summary>
        ///     Gets or sets the selected item.
        /// </summary>
        /// <value>
        ///     The selected item.
        /// </value>
        public object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Called when [items source property changed].
        /// </summary>
        /// <param name="bindable">The bindable.</param>
        /// <param name="value">The value.</param>
        /// <param name="newValue">The new value.</param>
        private static void OnItemsSourcePropertyChanged(BindableObject bindable, IEnumerable value,
            IEnumerable newValue)
        {
            var picker = (BindablePicker) bindable;
            var notifyCollection = newValue as INotifyCollectionChanged;
            if (notifyCollection != null)
            {
                notifyCollection.CollectionChanged += (sender, args) =>
                {
                    if (args.Action == NotifyCollectionChangedAction.Reset)
                    {
                        picker.Items.Clear();

                        return;
                    }
                    if (args.NewItems != null)
                    {
                        foreach (var newItem in args.NewItems)
                        {
                            picker.Items.Add((newItem ?? "").ToString());
                        }
                    }
                    if (args.OldItems != null)
                    {
                        foreach (var oldItem in args.OldItems)
                        {
                            picker.Items.Remove((oldItem ?? "").ToString());
                        }
                    }
                };
            }

            if (newValue == null)
                return;

            picker.Items.Clear();

            foreach (var item in newValue)
                picker.Items.Add((item ?? "").ToString());
        }

        /// <summary>
        ///     Called when [selected item property changed].
        /// </summary>
        /// <param name="bindable">The bindable.</param>
        /// <param name="value">The value.</param>
        /// <param name="newValue">The new value.</param>
        private static void OnSelectedItemPropertyChanged(BindableObject bindable, object value, object newValue)
        {
            var picker = (BindablePicker) bindable;
            if (picker.ItemsSource != null)
                picker.SelectedIndex = picker.ItemsSource.IndexOf(picker.SelectedItem);
        }

        private void OnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            if (ItemsSource != null)
            {
                if (SelectedIndex != -1)
                {
                    SelectedItem = ItemsSource.Cast<object>().ElementAt(SelectedIndex);
                }
            }
        }

        #endregion
    }
}