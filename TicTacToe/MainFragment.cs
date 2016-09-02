using Android.App;
using Android.OS;
using Android.Views;
using System;
using TicTacToe;
public class MainFragment : Fragment
{
    private AlertDialog mDialog;
    public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
        View rootView =
        inflater.Inflate(Resource.Layout.fragment_main, container, false);

        // Set up to handle the about button
        View aboutButton = rootView.FindViewById(Resource.Id.about_button);
        aboutButton.Click += aboutButton_Click;

        // TODO: Set up to handle creating a new game

        // TODO: Set up to handle continuing an old game.
        
        return rootView;
    }
    private void aboutButton_Click(object sender, EventArgs e)
    {
        AlertDialog.Builder builder = new AlertDialog.Builder(Activity);
        builder.SetMessage(Resource.String.about_text);
        // clicking outside the dialog box will not cancel it
        builder.SetCancelable(false);
        builder.SetNegativeButton(Resource.String.ok_label, (senderAlert, args) => { });
        mDialog = builder.Show();
    }

    public override void OnPause()
    {
        base.OnPause();

        // Get rid of the about dialog if it's still up
        if (mDialog != null)
            mDialog.Dismiss();
    }
}