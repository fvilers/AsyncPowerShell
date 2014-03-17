AsyncPowerShell
===============
A simple commandlet that allows usage of async methods

Installation
------------
To install AsyncPowerShell, run the following command in the Package Manager Console

	PM> Install-Package AsyncPowerShell

Usage
-----
Create a new commandlet that inherits from `AsyncPowerShell.AsyncPSCmdlet`. Overrides the `ProcessRecordAsync` method and implement your commandlet the way you like it!

	[Cmdlet(VerbsCommon.Get, "Something")]
	public class GetSomethingCommand : AsyncPSCmdlet
	{
	    protected async override Task ProcessRecordAsync()
	    {
	        using (var client = new HttpClient())
            {
                var html = await client.GetStringAsync("https://github.com/fvilers/AsyncPowerShell");
				WriteObject(html);
            }
	    }
	}

Release notes
-------------
* Version 1.0: AsyncPSCmdlet released

About the author
------
[Fabian Vilers](http://be.linkedin.com/in/fvilers)  
Twitter: [@fvilers](http://www.twitter.com/fvilers)
