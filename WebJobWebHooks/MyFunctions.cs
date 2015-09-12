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
        public static void IssueChanged([WebHookTrigger] Issue issue)
        {
            Console.WriteLine(issue.ID);
            Console.WriteLine(issue.Description);
        }
    }

    public class Issue
    {
        public int ID { get; set; }
        public string Description { get; set; }
    }
}
