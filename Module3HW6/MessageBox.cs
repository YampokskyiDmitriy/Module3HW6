using System;
using System.Threading.Tasks;

namespace Module3HW6
{
    public class MessageBox
    {
        private readonly Random _random;
        public MessageBox()
        {
            _random = new Random();
        }

        public event Action<State> WindowClose;

        public async void Open()
        {
            System.Console.WriteLine("Open window");
            await Task.Delay(3000);
            System.Console.WriteLine("Close window");
            WindowClose.Invoke((State)_random.Next(0, 1));
        }
    }
}
