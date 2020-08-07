using Hearthstone_Deck_Tracker.Utility;
using System.Windows.Controls;

namespace Hearthstone_Deck_Tracker.Controls.Overlay
{
    public partial class BannedType : UserControl
	{
        public BannedType()
        {
            InitializeComponent();
        }

		internal void UpdateType(string bannedType)
		{
			BannedText.Text = string.Format("Banned: {0}", bannedType);
		}
	}
}
