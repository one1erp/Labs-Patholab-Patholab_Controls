using System.Windows.Forms;

public static class CustomMessageBox
{
    public static void Show(string text, MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK, MessageBoxIcon messageBoxIcon = MessageBoxIcon.None)
    {
        MessageBox.Show(text, "Nautilus", messageBoxButtons, messageBoxIcon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
    }
}