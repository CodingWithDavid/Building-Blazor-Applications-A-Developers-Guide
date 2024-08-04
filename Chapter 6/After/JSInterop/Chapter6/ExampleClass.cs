using Microsoft.JSInterop;

namespace Chapter6
{
    // ExampleClass.cs
    public static class ExampleClass
    {
        [JSInvokable]
        public static string GetWelcomeMessage(string name)
        {
            return $"Welcome, {name}!";
        }
    }
}
