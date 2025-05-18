using System;
using System.Drawing;
using System.Windows.Forms;

public class ModernComboBox : ComboBox
{
    private Color selectedBackgroundColor = SystemColors.Highlight;
    private Color selectedItemTextColor = SystemColors.HighlightText;
    private ContentAlignment itemTextAlignment = ContentAlignment.MiddleLeft;

    public ModernComboBox()
    {
        DoubleBuffered = true;
        DrawMode = DrawMode.OwnerDrawFixed;
        DrawItem += OnDrawItem;
        SelectedIndexChanged += OnSelectedIndexChanged;
    }

    public Color SelectedBackgroundColor
    {
        get { return selectedBackgroundColor; }
        set { selectedBackgroundColor = value; }
    }

    public Color SelectedItemTextColor
    {
        get { return selectedItemTextColor; }
        set { selectedItemTextColor = value; }
    }

    public ContentAlignment ItemTextAlignment
    {
        get { return itemTextAlignment; }
        set { itemTextAlignment = value; }
    }

    private void OnDrawItem(object sender, DrawItemEventArgs e)
    {
        if (e.Index >= 0 && e.Index < Items.Count)
        {
            e.DrawBackground();

            Color backgroundColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? selectedBackgroundColor
                : BackColor;

            using (Brush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            string text = Items[e.Index].ToString();
            Color textColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? selectedItemTextColor
                : ForeColor;

            using (Brush brush = new SolidBrush(textColor))
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = GetHorizontalAlignment(itemTextAlignment);
                stringFormat.LineAlignment = GetVerticalAlignment(itemTextAlignment);

                e.Graphics.DrawString(text, Font, brush, e.Bounds, stringFormat);
            }

            e.DrawFocusRectangle();
        }
    }

    private void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        Invalidate();
    }

    private StringAlignment GetHorizontalAlignment(ContentAlignment alignment)
    {
        switch (alignment)
        {
            case ContentAlignment.TopLeft:
            case ContentAlignment.MiddleLeft:
            case ContentAlignment.BottomLeft:
                return StringAlignment.Near;

            case ContentAlignment.TopCenter:
            case ContentAlignment.MiddleCenter:
            case ContentAlignment.BottomCenter:
                return StringAlignment.Center;

            case ContentAlignment.TopRight:
            case ContentAlignment.MiddleRight:
            case ContentAlignment.BottomRight:
                return StringAlignment.Far;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private StringAlignment GetVerticalAlignment(ContentAlignment alignment)
    {
        switch (alignment)
        {
            case ContentAlignment.TopLeft:
            case ContentAlignment.TopCenter:
            case ContentAlignment.TopRight:
                return StringAlignment.Near;

            case ContentAlignment.MiddleLeft:
            case ContentAlignment.MiddleCenter:
            case ContentAlignment.MiddleRight:
                return StringAlignment.Center;

            case ContentAlignment.BottomLeft:
            case ContentAlignment.BottomCenter:
            case ContentAlignment.BottomRight:
                return StringAlignment.Far;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
