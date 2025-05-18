using System;
using System.Drawing;
using System.Windows.Forms;

public class ModernListBox : ListBox
{
    private Color selectedBackgroundColor = SystemColors.Highlight;
    private Color hoverBackgroundColor = Color.LightGray;
    private Color itemTextColor = SystemColors.ControlText; // Default text color for items
    private Color selectedItemTextColor = SystemColors.HighlightText; // Default text color for selected items

    private int hoveredIndex = -1;
    private ContentAlignment itemTextAlignment = ContentAlignment.MiddleLeft;
    private Padding textPadding = new Padding(0);

    public ModernListBox()
    {
        DoubleBuffered = true;
        DrawMode = DrawMode.OwnerDrawFixed;
        MouseMove += OnMouseMove;
        MouseLeave += OnMouseLeave;
        SelectedIndexChanged += OnSelectedIndexChanged;
    }

    public Color SelectedBackgroundColor
    {
        get { return selectedBackgroundColor; }
        set { selectedBackgroundColor = value; }
    }

    public Color HoverBackgroundColor
    {
        get { return hoverBackgroundColor; }
        set { hoverBackgroundColor = value; }
    }

    public Color ItemTextColor
    {
        get { return itemTextColor; }
        set { itemTextColor = value; }
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


    public Padding TextPadding
    {
        get { return textPadding; }
        set { textPadding = value; }
    }


    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        if (e.Index >= 0 && e.Index < Items.Count)
        {
            e.DrawBackground();

            Color backgroundColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? selectedBackgroundColor
                : (e.Index == hoveredIndex ? hoverBackgroundColor : BackColor);

            using (Brush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            string text = Items[e.Index].ToString();
            Color textColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? selectedItemTextColor
                : itemTextColor;

            using (Brush brush = new SolidBrush(textColor))
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = GetHorizontalAlignment(itemTextAlignment);
                stringFormat.LineAlignment = GetVerticalAlignment(itemTextAlignment);

                PointF textPosition = new PointF(e.Bounds.X + TextPadding.Left, e.Bounds.Y + TextPadding.Top);

                e.Graphics.DrawString(text, Font, brush, e.Bounds, stringFormat);
            }

            e.DrawFocusRectangle();
        }
    }



    private void OnMouseMove(object sender, MouseEventArgs e)
    {
        int index = IndexFromPoint(e.Location);
        if (hoveredIndex != index)
        {
            hoveredIndex = index;
            Invalidate();
        }
    }

    private void OnMouseLeave(object sender, EventArgs e)
    {
        if (hoveredIndex != -1)
        {
            hoveredIndex = -1;
            Invalidate();
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
