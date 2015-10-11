using System.ServiceProcess;

namespace ScanBuddy
{
    public partial class ScanBuddy : ServiceBase
    {
        private OPOSScanner_CCO handHeldScanner;
        
        public ScanBuddy()
        {
            InitializeComponent();


        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
