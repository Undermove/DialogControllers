using System;

namespace DialogControllers
{
    public class Dialog
    {
        public static DialogBuilder CreateDialog()
        {
            return new DialogBuilder();
        }

        public static StepBuilder Step()
        {
            throw new NotImplementedException();
        }

        public void Process(string empty)
        {
            throw new NotImplementedException();
        }
    }

    public class StepBuilder
    {
        public StepBuilder WithText(string helloPressAnyButtonOrEnterCommand)
        {
            return this;
        }

        public StepBuilder WithButton(string faq, Step faqStep)
        {
            return this;
        }

        public StepBuilder WithInputText(Step inputTextStep)
        {
            return this;
        }

        public StepBuilder WithCondition(Func<object, object> func)
        {
            return this;
        }

        public Step Please()
        {
            throw new NotImplementedException();
        }
    }

    public class DialogBuilder
    {
        
        public DialogBuilder WithTrigger(string start, object startStep)
        {
            return this;
        }

        public Dialog Please()
        {
            return new Dialog();
        }
    }
}