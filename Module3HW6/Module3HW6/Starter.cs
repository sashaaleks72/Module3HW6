namespace Module3HW6
{
    public class Starter
    {
        public void Run()
        {
            MessageBox msgBox = new MessageBox((state) =>
            {
                if (((int)state) == 0)
                {
                    Console.WriteLine("Операция подтверждена");
                }
                else
                {
                    Console.WriteLine("Операция отклонена");
                }
            });

            msgBox.Open();

            Console.ReadLine();
        }
    }
}
