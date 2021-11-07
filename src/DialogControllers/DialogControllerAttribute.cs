using System;
using System.Threading.Tasks;

namespace DialogControllers
{
    public abstract class DialogController
    {
        public abstract Task<string> OnEnterAsync();
    }

    public class TriggerAttribute : Attribute
    {
        public TriggerAttribute(string triggerName)
        {
            
        }
    }
}