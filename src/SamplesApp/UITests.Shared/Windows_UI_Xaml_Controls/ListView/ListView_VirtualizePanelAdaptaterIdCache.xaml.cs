﻿using Uno;
using Uno.UI.Samples.Controls;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Uno.UI.Sample.Views.Helper;
using System;
using System.Collections.Generic;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace SamplesApp.Windows_UI_Xaml_Controls.ListView
{
	[SampleControlInfo("ListView", "ListView_VirtualizePanelAdaptaterCache", description: "Demonstrates the Id Items Cache When ItemSource Lenght change")]
	public sealed partial class ListView_VirtualizePanelAdaptaterIdCache : UserControl
	{
		public List<int> LotsOfNumbers { get; } = Enumerable.Range(0, 500).ToList();

		public ListView_VirtualizePanelAdaptaterIdCache()
		{
			this.InitializeComponent();
			MyListView.ItemsSource = LotsOfNumbers;
			MyButton.Click += (sender, e) =>
			{
				UpdateItemSource();
			};
		}

		private void UpdateItemSource()
		{
			try
			{
				LotsOfNumbers.RemoveRange(10, 20);
				MyListView.ItemsSource = LotsOfNumbers;
				TextResult.Text = "Success";
			}
			catch (Exception ex)
			{
				TextResult.Text = "ItemSource Update Fails " + ex.Message;
			}
		}

	}
}
