using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControlApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryPage : ContentPage
	{
		public static readonly BindableProperty TitleProperty =
			BindableProperty.Create(nameof(Title), typeof(string), typeof(EntryPage), null);
		public static readonly BindableProperty DescriptionProperty =
			BindableProperty.Create(nameof(Description), typeof(string), typeof(EntryPage), null);
		public string Title
		{
			get { return (string)base.GetValue(TitleProperty); }
			set { base.SetValue(TitleProperty, value); }
		}

		public string Description
		{
			get { return (string)base.GetValue(DescriptionProperty); }
			set { base.SetValue(DescriptionProperty, value); }
		}

		public EntryPage()
		{
			InitializeComponent();
			BindingContext = this;
		}

		public Command PostCommand => new Command(() =>
		{
			Title = TitleEntry.Text;
			Description = DescriptionEntry.Text;
			base.Navigation.PushAsync(new ViewPage());

		});

	}
}