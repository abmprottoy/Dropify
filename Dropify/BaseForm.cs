using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class BaseForm : Form
{
    internal int TitlebarColorInt { get; set; }
    internal int BorderColorInt { get; set; }
    internal int WindowCorner { get; set; }

    /// <summary>
    /// Sets a DWM window attribute through Win32 API.
    /// </summary>
    /// <param name="hwnd">The handle to the window from which the attribute value is to be retrieved.</param>
    /// <param name="attr">The DWM attribute code.</param>
    /// <param name="attrValue">An array of attribute values.</param>
    /// <param name="attrSize">The size of the attribute value.</returns>
    /// <seealso href="link">https://learn.microsoft.com/en-us/windows/win32/api/dwmapi/nf-dwmapi-dwmgetwindowattribute</seealso>
    /// <seealso href="link">https://learn.microsoft.com/en-us/windows/win32/api/dwmapi/ne-dwmapi-dwmwindowattribute</seealso>

    [DllImport("dwmapi.dll")]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);


    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);

        if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
            DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4); // Non-Client area customization activation

        DwmSetWindowAttribute(Handle, 33, new[] { WindowCorner }, 4);      // Window Corners
        DwmSetWindowAttribute(Handle, 38, new[] { 1 }, 4);      // Background Material Enum
        DwmSetWindowAttribute(Handle, 34, new[] { BorderColorInt }, sizeof(int)); // Border Color
        DwmSetWindowAttribute(Handle, 35, new[] { TitlebarColorInt }, sizeof(int)); // Titlebar background color
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        DialogResult result = MessageBox.Show("Do you really want to close?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        switch (result)
        {
            case DialogResult.Yes:
                // User clicked 'Yes,' allow the form to close
                Application.Exit();
                break;

            case DialogResult.No:
                // User clicked 'No,' prevent the form from closing
                e.Cancel = true;
                break;

            case DialogResult.Cancel:
                // User clicked 'Cancel,' prevent the form from closing
                e.Cancel = true;
                break;
        }

        
    }
}
