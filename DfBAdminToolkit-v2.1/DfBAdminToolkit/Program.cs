namespace DfBAdminToolkit {

    using DfBAdminToolkit.Common.Utils;
    using DfBAdminToolkit.Model;
    using DfBAdminToolkit.Presenter;
    using DfBAdminToolkit.View;
    using Microsoft.Win32;
    using System;
    using System.Windows.Forms;

    internal static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bind();

            // check legal acceptance status
            // if user hasn't accepted license term yet, force user to land on legal page first.
            bool userPreviouslyAcceptedLegalTerm = false;
            RegistryKey key = RegistryUtils.FindKey(ApplicationResource.RegistryEntryPoint);
            if (key != null) {
                // check acceptance status
                string value = RegistryUtils.GetKeyValue(key, ApplicationResource.RegistryKey);
                bool.TryParse(value, out userPreviouslyAcceptedLegalTerm);
            }
            if (userPreviouslyAcceptedLegalTerm) {
                IMainView appView = new MainView();
                IMainModel appModel = new MainModel();
                IMainPresenter presenter = SimpleResolver.Instance.Get<IMainPresenter>(
                    new object[] { appModel, appView }
                );
                Application.Run(appView as MainView);
            } else {
                // show legal view
                ILegalView legalView = new LegalView();
                ILegalModel legalModel = new LegalModel();
                ILegalPresenter presenter = SimpleResolver.Instance.Get<ILegalPresenter>(
                    new object[] { legalModel, legalView }
                );
                Application.Run(legalView as LegalView);
            }
            Unbind();
        }

        private static void Bind() {
            SimpleResolver.Instance.Bind<IMainPresenter>(typeof(MainPresenter));
            SimpleResolver.Instance.Bind<ILegalPresenter>(typeof(LegalPresenter));
            SimpleResolver.Instance.Bind<ITextSearchPresenter>(typeof(TextSearchPresenter));
            SimpleResolver.Instance.Bind<IDumpUserContentPresenter>(typeof(DumpUserContentPresenter));
            SimpleResolver.Instance.Bind<IProvisioningPresenter>(typeof(ProvisioningPresenter));
            SimpleResolver.Instance.Bind<IDevicesPresenter>(typeof(DevicesPresenter));
            SimpleResolver.Instance.Bind<IDataMigrationPresenter>(typeof(DataMigrationPresenter));
            SimpleResolver.Instance.Bind<ISettingsPresenter>(typeof(SettingsPresenter));
        }

        private static void Unbind() {
            SimpleResolver.Instance.Dispose();
        }
    }
}