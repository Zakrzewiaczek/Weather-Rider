using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Weather_Rider
{
    public partial class ReadOnlyRichTextBox : RichTextBox
    {
        #region Pola
        #pragma warning disable CA1822 // Pola designera nie mogą być static

        [DefaultValue(true), Browsable(false), EditorBrowsable(EditorBrowsableState.Never), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool ReadOnly => true;

        [DefaultValue(true), Browsable(false), EditorBrowsable(EditorBrowsableState.Never), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool Multiline => true;

        [DefaultValue(true), Browsable(true), EditorBrowsable(EditorBrowsableState.Always), ReadOnly(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new bool WordWrap => true;

        [DefaultValue(-1), Browsable(false), EditorBrowsable(EditorBrowsableState.Never), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int TabIndex => -1;

        [DefaultValue(""), Browsable(false), EditorBrowsable(EditorBrowsableState.Never), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Rtf => string.Empty;

        [DefaultValue(true), Browsable(false), EditorBrowsable(EditorBrowsableState.Never), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string[] Lines => [];

        [DefaultValue(""), Browsable(false), EditorBrowsable(EditorBrowsableState.Always), ReadOnly(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string? Text
        {
            get => base.Text;
            set
            {
                base.ReadOnly = false;
                base.Text = value;
                base.ReadOnly = true;
            }
        }

        #pragma warning restore CA1822 // Pola designera nie mogą być static
        #endregion
        public ReadOnlyRichTextBox() => InitializeComponent();


        [LibraryImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool HideCaret(nint hWnd);
        protected override void WndProc(ref Message m)
        {
            const int WM_SETFOCUS = 0x0007;
            const int WM_KILLFOCUS = 0x0008;
            const int WM_LBUTTONDOWN = 0x0201;
            const int WM_LBUTTONUP = 0x0202;
            const int WM_LBUTTONDBLCLK = 0x0203;
            const int WM_RBUTTONDOWN = 0x0204;
            const int WM_RBUTTONUP = 0x0205;
            const int WM_MOUSEMOVE = 0x0200;

            if (m.Msg == WM_SETFOCUS || m.Msg == WM_KILLFOCUS || m.Msg == WM_LBUTTONDOWN || m.Msg == WM_LBUTTONUP || m.Msg == WM_LBUTTONDBLCLK || m.Msg == WM_RBUTTONDOWN || m.Msg == WM_RBUTTONUP || m.Msg == WM_MOUSEMOVE)
            {
                HideCaret(Handle);
                return;
            }

            base.WndProc(ref m);
        }
        
        protected override void OnPaint(PaintEventArgs pe) => base.OnPaint(pe);
    }
}
