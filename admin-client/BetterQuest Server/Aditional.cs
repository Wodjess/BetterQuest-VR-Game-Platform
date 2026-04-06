using System;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Input;
namespace BetterQuest_Server
{
    class Client
    {
        const int port = 48657;
        public static void Download(string message, string address = "51.124.219.208")
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient(address, port);
                NetworkStream stream = client.GetStream();
                // ввод сообщения
                if (message != "")
                {
                    message = String.Format(message);
                    // преобразуем сообщение в массив байтов
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    // отправка сообщения
                    stream.Write(data, 0, data.Length);

                    // получаем ответ
                    data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    message = builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    public partial class MainWindow : Window
    {
        void Tasker(object sender, MouseEventArgs e)
        {
            MainGrid.Opacity = 0.8;
            base.DragMove();
            MainGrid.Opacity = 1;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
