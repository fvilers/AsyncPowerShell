using Microsoft.Threading;
using System.Management.Automation;
using System.Threading.Tasks;

namespace AsyncPowerShell
{
    public class AsyncPSCmdlet : PSCmdlet
    {
        protected virtual Task ProcessRecordAsync()
        {
            return Task.Delay(0);
        }

        protected sealed override void ProcessRecord()
        {
            AsyncPump.Run(async delegate
            {
                await ProcessRecordAsync();
            });
        }
    }
}
