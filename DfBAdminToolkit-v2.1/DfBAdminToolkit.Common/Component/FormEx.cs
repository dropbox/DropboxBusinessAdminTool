using System.Drawing;
using System.Windows.Forms;

namespace DfBAdminToolkit.Common.Component {

    public class FormEx : Form {
        private FormExStyle m_settings;

        private const int CP_NOCLOSE_BUTTON = 0x200;

        public enum FormExStyle : int {
            CENTERED_WINDOW = 0x1,
            IGNORE_USER_CLOSING = 0x2,
        }

        public FormEx() {
        }

        public FormEx(FormExStyle settings)
            : base() {
            m_settings = settings;
        }

        protected override void OnLoad(System.EventArgs e) {
            if ((m_settings & FormExStyle.CENTERED_WINDOW) == FormExStyle.CENTERED_WINDOW) {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(
                    this.Owner.Location.X + (this.Owner.Width - this.Width) / 2,
                    this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2
                );
            }
            base.OnLoad(e);
        }

        protected override void OnVisibleChanged(System.EventArgs e) {
            if ((m_settings & FormExStyle.CENTERED_WINDOW) == FormExStyle.CENTERED_WINDOW) {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(
                    this.Owner.Location.X + (this.Owner.Width - this.Width) / 2,
                    this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2
                );
            }
            base.OnVisibleChanged(e);
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams myCp = base.CreateParams;
                if ((m_settings & FormExStyle.IGNORE_USER_CLOSING) == FormExStyle.IGNORE_USER_CLOSING) {
                    myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                }
                return myCp;
            }
        }
    }
}