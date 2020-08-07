using Hearthstone_Deck_Tracker.Utility;
using System.Windows.Controls;

namespace Hearthstone_Deck_Tracker.Controls.Overlay
{
    public partial class BannedTribe : UserControl
	{
        public BannedTribe()
        {
            InitializeComponent();
        }

		internal void UpdateTribe(string bannedTribe)
		{
			BannedTribeText.Text = string.Format("Banned: {0}", bannedTribe);
		}
	}
}
