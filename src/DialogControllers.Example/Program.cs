using System;

namespace DialogControllers.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }

                var faqStep = Dialog
                    .Step()
                    .WithText("Bot for providing infos about pizzerias")
                    .Please();

                var authStep = Dialog
                    .Step()
                    .WithText("Firstly connect your telegram account to Dodo IS")
                    .Please();

                var inputTextStep = Dialog
                    .Step()
                    .WithCondition(context => context != null)
                    .WithInputText(null)
                    .Please();
                
                var startStep = Dialog
                    .Step()
                    .WithText("Hello, press any button, or enter command")
                    .WithButton("FAQ", faqStep)
                    .WithButton("auth", authStep)
                    .WithInputText(inputTextStep)
                    .Please();

                var dialog = Dialog.CreateDialog()
                    .WithTrigger("start", startStep)
                    .WithTrigger("faq", faqStep)
                    .Please();

                dialog.Process("");
            }
        }
    }
}