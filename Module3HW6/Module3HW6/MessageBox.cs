namespace Module3HW6
{
    public class MessageBox
    {
        public enum State
        {
            Ok,
            Cancel
        }

        private event Action<State> OnWindowClosed;

        public MessageBox(Action<State> IsClosedHandler)
        {
            OnWindowClosed += IsClosedHandler;
        }

        public async void Open()
        {
            State state = (State)new Random().Next(0, 2);

            Console.WriteLine("Window is open");

            await Task.Delay(3000);

            Console.WriteLine("Window was closed by a user");

            OnWindowClosed(state);
        }
    }
}
