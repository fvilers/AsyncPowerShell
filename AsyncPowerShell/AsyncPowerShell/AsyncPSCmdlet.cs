using Nito.AsyncEx;
using System.Management.Automation;
using System.Threading.Tasks;

namespace AsyncPowerShell
{
    public abstract class AsyncPSCmdlet : PSCmdlet
    {
        protected virtual Task ProcessRecordAsync()
        {
            return Task.Delay(0);
        }

        protected sealed override void ProcessRecord()
        {
            AsyncContext.Run(async () => await ProcessRecordAsync());
        }
    }
}
