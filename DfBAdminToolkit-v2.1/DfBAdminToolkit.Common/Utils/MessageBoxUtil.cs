namespace DfBAdminToolkit.Common.Utils {

    using DfBAdminToolkit.Common.Component;
    using System.Windows.Forms;

    public static class MessageBoxUtil {

        public static void ShowInfo(
                    IWin32Window owner,
                    string msg) {
            MessageBoxEx.Show(
                owner,
                msg,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public static DialogResult ShowConfirm(
            IWin32Window owner,
            string msg) {
            return MessageBoxEx.Show(owner,
                msg,
                "Please Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
            );
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="msg"></param>
        public static void ShowError(IWin32Window owner, string msg, string title = "Critical Error") {
            MessageBoxEx.Show(owner,
                msg,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}