namespace DfBAdminToolkit.Common.Component
{
    using System.ComponentModel;
    using System.Drawing;

    public enum Theme
    {
        MSOffice2010_Blue = 1,
        MSOffice2010_White = 2,
        MSOffice2010_Red = 3,
        MSOffice2010_Green = 4,
        MSOffice2010_Pink = 5,
        MSOffice2010_Yellow = 6,
        MSOffice2010_Publisher = 7
    }

    #region COLOR TABLE

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ColorTable
    {
        #region Static Color Tables

        private static Office2010Blue office2010blu = new Office2010Blue();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static ColorTable Office2010Blue
        {
            get { return office2010blu; }
        }

        private static Office2010Green office2010gr = new Office2010Green();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static ColorTable Office2010Green
        {
            get { return office2010gr; }
        }

        private static Office2010Red office2010rd = new Office2010Red();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static ColorTable Office2010Red
        {
            get { return office2010rd; }
        }

        private static Office2010Pink office2010pk = new Office2010Pink();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static ColorTable Office2010Pink
        {
            get { return office2010pk; }
        }

        private static Office2010Yellow office2010yl = new Office2010Yellow();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static ColorTable Office2010Yellow
        {
            get { return office2010yl; }
        }

        private static Office2010White office2010wt = new Office2010White();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static ColorTable Office2010White
        {
            get { return office2010wt; }
        }

        private static Office2010Publisher office2010pb = new Office2010Publisher();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static ColorTable Office2010Publisher
        {
            get { return office2010pb; }
        }

        #endregion Static Color Tables

        #region Custom Properties

        private Color textColor = Color.White;
        private Color selectedTextColor = Color.FromArgb(30, 57, 91);
        private Color OverTextColor = Color.FromArgb(30, 57, 91);
        private Color borderColor = Color.FromArgb(31, 72, 161);
        private Color innerborderColor = Color.FromArgb(68, 135, 228);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color TextColor
        {
            get { return textColor; }
            set { textColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color SelectedTextColor
        {
            get { return selectedTextColor; }
            set { selectedTextColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color HoverTextColor
        {
            get { return OverTextColor; }
            set { OverTextColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color BorderColor1
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color BorderColor2
        {
            get { return innerborderColor; }
            set { innerborderColor = value; }
        }

        #endregion Custom Properties

        #region Button Normal

        private Color buttonNormalBegin = Color.FromArgb(31, 72, 161);
        private Color buttonNormalMiddleBegin = Color.FromArgb(68, 135, 228);
        private Color buttonNormalMiddleEnd = Color.FromArgb(41, 97, 181);
        private Color buttonNormalEnd = Color.FromArgb(62, 125, 219);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor1
        {
            get { return buttonNormalBegin; }
            set { buttonNormalBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor2
        {
            get { return buttonNormalMiddleBegin; }
            set { buttonNormalMiddleBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor3
        {
            get { return buttonNormalMiddleEnd; }
            set { buttonNormalMiddleEnd = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor4
        {
            get { return buttonNormalEnd; }
            set { buttonNormalEnd = value; }
        }

        #endregion Button Normal

        #region Button Selected

        private Color buttonSelectedBegin = Color.FromArgb(236, 199, 87);
        private Color buttonSelectedMiddleBegin = Color.FromArgb(252, 243, 215);
        private Color buttonSelectedMiddleEnd = Color.FromArgb(255, 229, 117);
        private Color buttonSelectedEnd = Color.FromArgb(255, 216, 107);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonSelectedColor1
        {
            get { return buttonSelectedBegin; }
            set { buttonSelectedBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonSelectedColor2
        {
            get { return buttonSelectedMiddleBegin; }
            set { buttonSelectedMiddleBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonSelectedColor3
        {
            get { return buttonSelectedMiddleEnd; }
            set { buttonSelectedMiddleEnd = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonSelectedColor4
        {
            get { return buttonSelectedEnd; }
            set { buttonSelectedEnd = value; }
        }

        #endregion Button Selected

        #region Button Mouse Over

        private Color buttonMouseOverBegin = Color.FromArgb(236, 199, 87);
        private Color buttonMouseOverMiddleBegin = Color.FromArgb(252, 243, 215);
        private Color buttonMouseOverMiddleEnd = Color.FromArgb(249, 225, 137);
        private Color buttonMouseOverEnd = Color.FromArgb(251, 249, 224);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonMouseOverColor1
        {
            get { return buttonMouseOverBegin; }
            set { buttonMouseOverBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonMouseOverColor2
        {
            get { return buttonMouseOverMiddleBegin; }
            set { buttonMouseOverMiddleBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonMouseOverColor3
        {
            get { return buttonMouseOverMiddleEnd; }
            set { buttonMouseOverMiddleEnd = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonMouseOverColor4
        {
            get { return buttonMouseOverEnd; }
            set { buttonMouseOverEnd = value; }
        }

        #endregion Button Mouse Over
    }

    #endregion COLOR TABLE

    #region Office 2010 Blue

    public class Office2010Blue : ColorTable
    {
        public Office2010Blue()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(31, 72, 161);
            this.ButtonNormalColor2 = Color.FromArgb(68, 135, 228);
            this.ButtonNormalColor3 = Color.FromArgb(41, 97, 181);
            this.ButtonNormalColor4 = Color.FromArgb(62, 125, 219);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Blue";
        }
    }

    #endregion Office 2010 Blue

    #region Office 2010 GREEN

    public class Office2010Green : ColorTable
    {
        public Office2010Green()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(42, 126, 43);
            this.ButtonNormalColor2 = Color.FromArgb(94, 184, 67);
            this.ButtonNormalColor3 = Color.FromArgb(42, 126, 43);
            this.ButtonNormalColor4 = Color.FromArgb(94, 184, 67);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Green";
        }
    }

    #endregion Office 2010 GREEN

    #region Office 2010 Red

    public class Office2010Red : ColorTable
    {
        public Office2010Red()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(227, 77, 45);
            this.ButtonNormalColor2 = Color.FromArgb(245, 148, 64);
            this.ButtonNormalColor3 = Color.FromArgb(227, 77, 45);
            this.ButtonNormalColor4 = Color.FromArgb(245, 148, 64);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Red";
        }
    }

    #endregion Office 2010 Red

    #region Office 2010 Pink

    public class Office2010Pink : ColorTable
    {
        public Office2010Pink()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(175, 6, 77);
            this.ButtonNormalColor2 = Color.FromArgb(222, 52, 119);
            this.ButtonNormalColor3 = Color.FromArgb(175, 6, 77);
            this.ButtonNormalColor4 = Color.FromArgb(222, 52, 119);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Pink";
        }
    }

    #endregion Office 2010 Pink

    #region Office 2010 White

    public class Office2010White : ColorTable
    {
        public Office2010White()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.Black;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(154, 154, 154);
            this.ButtonNormalColor2 = Color.FromArgb(255, 255, 255);
            this.ButtonNormalColor3 = Color.FromArgb(235, 235, 235);
            this.ButtonNormalColor4 = Color.FromArgb(255, 255, 255);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010White";
        }
    }

    #endregion Office 2010 White

    #region Office 2010 Yellow

    public class Office2010Yellow : ColorTable
    {
        public Office2010Yellow()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(252, 161, 8);
            this.ButtonNormalColor2 = Color.FromArgb(251, 191, 45);
            this.ButtonNormalColor3 = Color.FromArgb(252, 161, 8);
            this.ButtonNormalColor4 = Color.FromArgb(251, 191, 45);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Yellow";
        }
    }

    #endregion Office 2010 Yellow

    #region Office 2010 Publisher

    public class Office2010Publisher : ColorTable
    {
        public Office2010Publisher()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(0, 126, 126);
            this.ButtonNormalColor2 = Color.FromArgb(31, 173, 167);
            this.ButtonNormalColor3 = Color.FromArgb(0, 126, 126);
            this.ButtonNormalColor4 = Color.FromArgb(31, 173, 167);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Publisher";
        }
    }

    #endregion Office 2010 Publisher
}