namespace DfBAdminToolkit.Common.Component {

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public partial class ButtonEx : Button {

        #region Fields

        private Theme _theme = Theme.MSOffice2010_Blue;

        private enum MouseState {
            None = 1,
            Down = 2,
            Up = 3,
            Enter = 4,
            Leave = 5,
            Move = 6
        }

        private MouseState _mouseState = MouseState.None;

        #endregion Fields

        #region Constructor

        public ButtonEx() {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                      ControlStyles.Opaque |
                      ControlStyles.ResizeRedraw |
                      ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.CacheText, // We gain about 2% in painting by avoiding extra GetWindowText calls
                      true);

            this._colorTable = new ColorTable();
        }

        #endregion Constructor

        #region Events

        #region Paint Transparent Background

        protected void PaintTransparentBackground(Graphics g, Rectangle clipRect) {
            // check if we have a parent
            if (this.Parent != null) {
                // convert the clipRects coordinates from ours to our parents
                clipRect.Offset(this.Location);

                PaintEventArgs e = new PaintEventArgs(g, clipRect);
                GraphicsState state = g.Save();

                try {
                    // move the graphics object so that we are drawing in
                    // the correct place
                    g.TranslateTransform((float)-this.Location.X, (float)-this.Location.Y);

                    // draw the parents background and foreground
                    this.InvokePaintBackground(this.Parent, e);
                    this.InvokePaint(this.Parent, e);

                    return;
                } finally {
                    // reset everything back to where they were before
                    g.Restore(state);
                    clipRect.Offset(-this.Location.X, -this.Location.Y);
                }
            }

            // we don't have a parent, so fill the rect with
            // the default control color
            g.FillRectangle(SystemBrushes.Control, clipRect);
        }

        #endregion Paint Transparent Background

        #region Mouse Events

        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);
            _mouseState = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e) {
            base.OnMouseEnter(e);
            _mouseState = MouseState.Enter;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent) {
            base.OnMouseUp(mevent);
            _mouseState = MouseState.None;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs mevent) {
            base.OnMouseMove(mevent);
            _mouseState = MouseState.Move;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e) {
            base.OnMouseLeave(e);
            _mouseState = MouseState.Leave;
            Invalidate();
        }

        protected override void OnClick(EventArgs e) {
            base.OnClick(e);
        }

        #endregion Mouse Events

        #region Path

        public static GraphicsPath GetRoundedRect(RectangleF r, float radius) {
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            r = new RectangleF(r.Left, r.Top, r.Width, r.Height);
            if (radius <= 0.0F || radius <= 0.0F) {
                gp.AddRectangle(r);
            } else {
                gp.AddArc((float)r.X, (float)r.Y, radius, radius, 180, 90);
                gp.AddArc((float)r.Right - radius, (float)r.Y, radius - 1, radius, 270, 90);
                gp.AddArc((float)r.Right - radius, ((float)r.Bottom) - radius - 1, radius - 1, radius, 0, 90);
                gp.AddArc((float)r.X, ((float)r.Bottom) - radius - 1, radius - 1, radius, 90, 90);
            }
            gp.CloseFigure();
            return gp;
        }

        #endregion Path

        protected override void OnPaint(PaintEventArgs e) {
            this.PaintTransparentBackground(e.Graphics, this.ClientRectangle);

            #region Painting

            //now let's we begin painting
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            #endregion Painting

            #region Color

            Color tTopColorBegin = this._colorTable.ButtonNormalColor1;
            Color tTopColorEnd = this._colorTable.ButtonNormalColor2;
            Color tBottomColorBegin = this._colorTable.ButtonNormalColor3;
            Color tBottomColorEnd = this._colorTable.ButtonNormalColor4;
            Color Textcol = this._colorTable.TextColor;

            if (!this.Enabled) {
                tTopColorBegin = Color.FromArgb((int)(tTopColorBegin.GetBrightness() * 255),
                    (int)(tTopColorBegin.GetBrightness() * 255),
                    (int)(tTopColorBegin.GetBrightness() * 255));
                tBottomColorEnd = Color.FromArgb((int)(tBottomColorEnd.GetBrightness() * 255),
                    (int)(tBottomColorEnd.GetBrightness() * 255),
                    (int)(tBottomColorEnd.GetBrightness() * 255));
            } else {
                if (_mouseState == MouseState.None || _mouseState == MouseState.Leave) {
                    tTopColorBegin = this._colorTable.ButtonNormalColor1;
                    tTopColorEnd = this._colorTable.ButtonNormalColor2;
                    tBottomColorBegin = this._colorTable.ButtonNormalColor3;
                    tBottomColorEnd = this._colorTable.ButtonNormalColor4;
                    Textcol = this._colorTable.TextColor;
                } else if (_mouseState == MouseState.Down) {
                    tTopColorBegin = this._colorTable.ButtonSelectedColor1;
                    tTopColorEnd = this._colorTable.ButtonSelectedColor2;
                    tBottomColorBegin = this._colorTable.ButtonSelectedColor3;
                    tBottomColorEnd = this._colorTable.ButtonSelectedColor4;
                    Textcol = this._colorTable.SelectedTextColor;
                } else if (_mouseState == MouseState.Move || _mouseState == MouseState.Up) {
                    tTopColorBegin = this._colorTable.ButtonMouseOverColor1;
                    tTopColorEnd = this._colorTable.ButtonMouseOverColor2;
                    tBottomColorBegin = this._colorTable.ButtonMouseOverColor3;
                    tBottomColorEnd = this._colorTable.ButtonMouseOverColor4;
                    Textcol = this._colorTable.HoverTextColor;
                }
            }

            #endregion Color

            #region Theme 2010

            if (_theme == Theme.MSOffice2010_Blue ||
                _theme == Theme.MSOffice2010_Green ||
                _theme == Theme.MSOffice2010_Yellow ||
                _theme == Theme.MSOffice2010_Publisher ||
                _theme == Theme.MSOffice2010_Red ||
                _theme == Theme.MSOffice2010_White ||
                _theme == Theme.MSOffice2010_Pink) {
                PaintCustomBackground(e, g, tTopColorBegin, tTopColorEnd, tBottomColorBegin, tBottomColorEnd);
                TextAndImage(this.ClientRectangle, g, Textcol);
            }

            #endregion Theme 2010
        }

        #region Paint custom background

        protected void PaintCustomBackground(PaintEventArgs e, Graphics g, Color tTopColorBegin, Color tTopColorEnd, Color tBottomColorBegin, Color tBottomColorEnd) {
            int _roundedRadiusX = 6;

            Rectangle r = new Rectangle(this.ClientRectangle.Left, this.ClientRectangle.Top, this.ClientRectangle.Width, this.ClientRectangle.Height);
            Rectangle j = r;
            Rectangle r2 = r;
            r2.Inflate(-1, -1);
            Rectangle r3 = r2;
            r3.Inflate(-1, -1);

            //rectangle for gradient, half upper and lower
            RectangleF halfup = new RectangleF(r.Left, r.Top, r.Width, r.Height);
            RectangleF halfdown = new RectangleF(r.Left, r.Top + (r.Height / 2) - 1, r.Width, r.Height);

            //BEGIN PAINT BACKGROUND
            //for half upper, we paint using linear gradient
            using (GraphicsPath thePath = GetRoundedRect(r, _roundedRadiusX)) {
                LinearGradientBrush lgb = new LinearGradientBrush(halfup, tBottomColorEnd, tBottomColorBegin, 90f, true);

                Blend blend = new Blend(4);
                blend.Positions = new float[] { 0, 0.18f, 0.35f, 1f };
                blend.Factors = new float[] { 0f, .4f, .9f, 1f };
                lgb.Blend = blend;
                g.FillPath(lgb, thePath);
                lgb.Dispose();

                //for half lower, we paint using radial gradient
                using (GraphicsPath p = new GraphicsPath()) {
                    p.AddEllipse(halfdown); //make it radial
                    using (PathGradientBrush gradient = new PathGradientBrush(p)) {
                        gradient.WrapMode = WrapMode.Clamp;
                        gradient.CenterPoint = new PointF(Convert.ToSingle(halfdown.Left + halfdown.Width / 2), Convert.ToSingle(halfdown.Bottom));
                        gradient.CenterColor = tBottomColorEnd;
                        gradient.SurroundColors = new Color[] { tBottomColorBegin };

                        blend = new Blend(4);
                        blend.Positions = new float[] { 0, 0.15f, 0.4f, 1f };
                        blend.Factors = new float[] { 0f, .3f, 1f, 1f };
                        gradient.Blend = blend;

                        g.FillPath(gradient, thePath);
                    }
                }
                //END PAINT BACKGROUND

                //BEGIN PAINT BORDERS
                using (GraphicsPath gborderDark = thePath) {
                    using (Pen p = new Pen(tTopColorBegin, 1)) {
                        g.DrawPath(p, gborderDark);
                    }
                }
                using (GraphicsPath gborderLight = GetRoundedRect(r2, _roundedRadiusX)) {
                    using (Pen p = new Pen(tTopColorEnd, 1)) {
                        g.DrawPath(p, gborderLight);
                    }
                }
                using (GraphicsPath gborderMed = GetRoundedRect(r3, _roundedRadiusX)) {
                    SolidBrush bordermed = new SolidBrush(Color.FromArgb(50, tTopColorEnd));
                    using (Pen p = new Pen(bordermed, 1)) {
                        g.DrawPath(p, gborderMed);
                    }
                }
                //END PAINT BORDERS
            }
        }

        #endregion Paint custom background

        #region Paint TEXT AND IMAGE

        protected void TextAndImage(Rectangle Rec, Graphics g, Color textColor) {
            //BEGIN PAINT TEXT
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            #region Top

            if (this.TextAlign == ContentAlignment.TopLeft) {
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Near;
            } else if (this.TextAlign == ContentAlignment.TopCenter) {
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Center;
            } else if (this.TextAlign == ContentAlignment.TopRight) {
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Far;
            }

            #endregion Top

            #region Middle

              else if (this.TextAlign == ContentAlignment.MiddleLeft) {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Near;
            } else if (this.TextAlign == ContentAlignment.MiddleCenter) {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
            } else if (this.TextAlign == ContentAlignment.MiddleRight) {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Far;
            }

            #endregion Middle

            #region Bottom

              else if (this.TextAlign == ContentAlignment.BottomLeft) {
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Near;
            } else if (this.TextAlign == ContentAlignment.BottomCenter) {
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Center;
            } else if (this.TextAlign == ContentAlignment.BottomRight) {
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Far;
            }

            #endregion Bottom

            if (this.ShowKeyboardCues) {
                sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;
            } else {
                sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Hide;
            }
            g.DrawString(this.Text, this.Font, new SolidBrush(textColor), Rec, sf);
        }

        #endregion Paint TEXT AND IMAGE

        #endregion Events

        #region Properties

        #region ColorTable

        private ColorTable _colorTable = null;

        [DefaultValue(typeof(ColorTable), "Office2010Blue")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ColorTable ColorTable {
            get {
                if (_colorTable == null) {
                    _colorTable = new ColorTable();
                }
                return _colorTable;
            }
            set {
                if (value == null) {
                    value = ColorTable.Office2010Blue;
                }
                _colorTable = (ColorTable)value;
                this.Invalidate();
            }
        }

        public Theme Theme {
            get {
                if (this._colorTable == ColorTable.Office2010Green) {
                    return Theme.MSOffice2010_Green;
                } else if (this._colorTable == ColorTable.Office2010Red) {
                    return Theme.MSOffice2010_Red;
                } else if (this._colorTable == ColorTable.Office2010Pink) {
                    return Theme.MSOffice2010_Pink;
                } else if (this._colorTable == ColorTable.Office2010Yellow) {
                    return Theme.MSOffice2010_Yellow;
                } else if (this._colorTable == ColorTable.Office2010White) {
                    return Theme.MSOffice2010_White;
                } else if (this._colorTable == ColorTable.Office2010Publisher) {
                    return Theme.MSOffice2010_Publisher;
                }

                return Theme.MSOffice2010_Blue;
            }

            set {
                this._theme = value;

                if (_theme == Theme.MSOffice2010_Green) {
                    this._colorTable = ColorTable.Office2010Green;
                } else if (_theme == Theme.MSOffice2010_Red) {
                    this._colorTable = ColorTable.Office2010Red;
                } else if (_theme == Theme.MSOffice2010_Pink) {
                    this._colorTable = ColorTable.Office2010Pink;
                } else if (_theme == Theme.MSOffice2010_White) {
                    this._colorTable = ColorTable.Office2010White;
                } else if (_theme == Theme.MSOffice2010_Yellow) {
                    this._colorTable = ColorTable.Office2010Yellow;
                } else if (_theme == Theme.MSOffice2010_Publisher) {
                    this._colorTable = ColorTable.Office2010Publisher;
                } else {
                    this._colorTable = ColorTable.Office2010Blue;
                }
            }
        }

        #endregion ColorTable

        #region Background Image

        [Browsable(false)]
        public override Image BackgroundImage {
            get {
                return base.BackgroundImage;
            }
            set {
                base.BackgroundImage = value;
            }
        }

        [Browsable(false)]
        public override ImageLayout BackgroundImageLayout {
            get {
                return base.BackgroundImageLayout;
            }
            set {
                base.BackgroundImageLayout = value;
            }
        }

        #endregion Background Image

        #endregion Properties
    }
}