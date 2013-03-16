using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Localization;
using Orchard.Messaging.Services;
using Orchard.Workflows.Services;

namespace DarkSky.Messaging.Activities
{
    public class TemplatedMessageTask : Task
    {
        private readonly IMessageManager _messageManager;
        public TemplatedMessageTask(IMessageManager messageManager)
        {
            _messageManager = messageManager;
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        public override string Name
        {
            get { return "TemplatedMessageTask"; }
        }

        public override Orchard.Localization.LocalizedString Category
        {
            get { return T("Messaging"); }
        }

        public override Orchard.Localization.LocalizedString Description
        {
            get { return T("Send Templated Messages"); }
        }

        public override IEnumerable<Orchard.Localization.LocalizedString> GetPossibleOutcomes(Orchard.Workflows.Models.WorkflowContext workflowContext, Orchard.Workflows.Models.ActivityContext activityContext)
        {
            yield return T("Sent");
        }

        public override IEnumerable<Orchard.Localization.LocalizedString> Execute(Orchard.Workflows.Models.WorkflowContext workflowContext, Orchard.Workflows.Models.ActivityContext activityContext)
        {
            throw new NotImplementedException();
        }
    }
}