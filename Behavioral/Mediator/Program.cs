using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Button submitButton = new Button();
            Checkbox clientType = new Checkbox();

            new RegisterClientView(clientType, submitButton);


            submitButton.Click();

            clientType.Select();

        }
    }
}
