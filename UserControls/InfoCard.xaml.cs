using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.IconPacks;

namespace CoolMegaUI.UserControls
{
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();
        }

        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(string), typeof(InfoCard));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(InfoCard));

        public bool IsActive
        {
            get { return (bool)GetValue(isActiveProperty); }
            set { SetValue(isActiveProperty, value); }
        }

        public static readonly DependencyProperty isActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(InfoCard));

        public bool IsTechnical
        {
            get { return (bool)GetValue(isTechnicalProperty); }
            set { SetValue(isTechnicalProperty, value); }
        }

        public static readonly DependencyProperty isTechnicalProperty =
            DependencyProperty.Register("IsTechnical", typeof(bool), typeof(InfoCard));
    }
}
