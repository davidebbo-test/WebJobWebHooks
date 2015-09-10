using Microsoft.Azure.WebJobs.Extensions.WebHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobWebHooks
{
    public static class MyFunctions
    {
        public static void IssueChanged([WebHookTrigger] string body)
        {
            Console.WriteLine("IssueChanged");
            Console.WriteLine(body);
        }
    }
}
