using System.Windows;
namespace BetterQuest_Server
{
    public partial class MainWindow : Window
    {
        sbyte temp;
        sbyte temp1 = 1;
        string password;
        System.Windows.Media.Effects.BlurEffect blurEffect = new System.Windows.Media.Effects.BlurEffect();
        public MainWindow()
        {
            InitializeComponent();
            blurEffect.Radius = 5;
            MainGrid.Effect = blurEffect;
        }
        void IwasteMyFreeTime(object sender, RoutedEventArgs e)
        {
            if (temp1 == 1)
            {
                temp1 = 0;
                PasswordFromBox.Text = "";
            }
        }

        void UploadOnServer(object sender, RoutedEventArgs e)
        {
            Working();
        }
        void BasicInformation(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PasswordFromBox.Text.Length >= 5 && IPAdressOfServer.Text.Length >= 4)
                {
                    password = PasswordFromBox.Text;
                    ProtectorGrid.IsEnabled = false;
                    StarterPage.IsEnabled = false;
                    ProtectorGrid.Visibility = Visibility.Hidden;
                    StarterPage.Visibility = Visibility.Hidden;
                    blurEffect.Radius = 0;
                }
                else
                {
                    MessageBox.Show("Убедитесь в правильности введенных данных");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Working()
        {
            try
            {
                string ip = IPAdressOfServer.Text;
                if (Box.Text != "")
                {
                    if (temp == 0)
                    {
                        Client.Download(password + Box.Text, ip);
                        Block.Text = "Впишите описание файла";
                        Box.Text = "";
                        temp = 1;
                    }
                    else
                    {
                        if (temp == 1)
                        {
                            Client.Download(password + Box.Text, ip);
                            Block.Text = "Залейте картинку на хост и вставте прямую ссылку на нее";
                            Box.Text = "";
                            temp = 2;
                        }
                        else
                        {
                            if (temp == 2)
                            {
                                Client.Download(password + Box.Text, ip);
                                Block.Text = "Залейте приложение на хост и вставте прямую ссылку на него (если файлов несколько, то в один zip архив)";
                                Box.Text = "";
                                temp = 3;
                            }
                            else
                            {
                                if (temp == 3)
                                {
                                    Client.Download(password + Box.Text, ip);
                                    Block.Text = "Впишите название файла";
                                    Box.Text = "";
                                    temp = 0;
                                }
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Произошла ошибка " + ex.ToString());
                temp = 3;
            }
        }

    }
}
