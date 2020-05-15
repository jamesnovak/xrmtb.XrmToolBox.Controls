using Microsoft.Xrm.Sdk;
using System;

namespace xrmtb.XrmToolBox.Controls
{
    public class CDSRecordEventArgs : EventArgs
    {
        public CDSRecordEventArgs(Entity entity, string attribute)
        {
            Entity = entity;
            Attribute = attribute;
        }

        public Entity Entity { get; }

        public string Attribute { get; }

        public object Value { get { return Entity != null && Entity.Contains(Attribute) ? Entity[Attribute] : null; } }

        public void OnRecordEvent(object sender, CDSRecordEventHandler RecordEventHandler)
        {
            RecordEventHandler?.Invoke(sender, this);
        }
    }

    public delegate void CDSRecordEventHandler(object sender, CDSRecordEventArgs e);
}
