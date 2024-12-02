using System.ComponentModel;

namespace Weather_Rider
{
    public partial class RotablePictureBox : Control
    {
        private Image? _image;
        private float _angle;

        [Browsable(false), ReadOnly(true), EditorBrowsable(EditorBrowsableState.Never)]
        public Image? Image { get; set; }

        [Browsable(false), ReadOnly(true), EditorBrowsable(EditorBrowsableState.Never)]
        public new string? Text { get; set; }

        [Browsable(true), ReadOnly(false), EditorBrowsable(EditorBrowsableState.Always)]
        public new Image? BackgroundImage
        {
            get => _image;
            set
            {
                _image = value;
                base.BackgroundImage = RotateImage(_image, _angle);
            }
        }

        [Browsable(true), ReadOnly(false), EditorBrowsable(EditorBrowsableState.Always), DefaultValue(0)]
        public float Angle
        {
            get => _angle;
            set
            {
                _angle = value;
                base.BackgroundImage = RotateImage(_image, _angle);
            }
        }

        [DisplayName("ImageLayout")]
        public new ImageLayout BackgroundImageLayout
        {
            get => base.BackgroundImageLayout;
            set => base.BackgroundImageLayout = value;
        }

        public RotablePictureBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public static Image? RotateImage(Image? image, float angle)
        {
            if (image is null)
                return null;

            Bitmap rotatedBmp = new(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                g.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-(float)image.Width / 2, -(float)image.Height / 2);
                g.DrawImage(image, new Point(0, 0));
            }

            return rotatedBmp;
        }
    }
}
