using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace ClosePrompt64
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("Close Prompt 64", "Shows confirmation prompt message to confirm exit", "ClosePrompt64.a8122488-8cbb-4840-9507-db1bb93d9387")]
    [Guid(PackageGuidString)]
    [ProvideAutoLoad(UIContextGuids80.NoSolution, PackageAutoLoadFlags.BackgroundLoad)]
    public sealed class ClosePrompt64Package : AsyncPackage
    {
        public const string PackageGuidString = "fd83dd97-5a28-48db-83e5-6ee0b1ba805c";

        protected override int QueryClose(out bool canClose)
        {
            canClose = MessageBox.Show("Do you want to close Visual Studio?", "Close Prompt Extension", MessageBoxButtons.OKCancel) == DialogResult.OK;
            return 0;
        }
    }
}
