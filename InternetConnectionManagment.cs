using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Rider
{
    public class InternetConnectionManagment
    {
        private readonly PictureBox icon;
        private bool isConnected = false;
        private readonly CancellationTokenSource cts;
        private Task blinkingTask;

        public InternetConnectionManagment(PictureBox icon)
        {
            this.icon = icon ?? throw new ArgumentNullException(nameof(icon));
            cts = new CancellationTokenSource();

            blinkingTask = Task.Run(() => IconBlinkCallback(cts.Token));
        }

        public void CheckConnection()
        {
            Debug.WriteLine("Checking connection...");
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                isConnected = true;
                Debug.WriteLine("Connected to the internet.");
            }
            else
            {
                isConnected = false;
                Debug.WriteLine("Not connected to the internet.");
            }
        }

        private async Task IconBlinkCallback(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    if (icon.IsHandleCreated && !icon.IsDisposed)
                    {
                        icon.Invoke(() =>
                        {
                            if (!isConnected)
                            {
                                icon.Visible = !icon.Visible;
                            }
                            else
                            {
                                icon.Visible = false;
                            }
                        });
                    }

                    await Task.Delay(500, token); // Obsługa anulowania w Task.Delay
                }
                catch (OperationCanceledException)
                {
                    Debug.WriteLine("Blinking task canceled.");
                    break;
                }
                catch (InvalidOperationException) { };
            }
        }

        public void Close()
        {
            Debug.WriteLine("Closing InternetConnectionManagment...");
            cts.Cancel(); // Sygnalizuj zakończenie zadania
            blinkingTask.Wait(); // Poczekaj na zakończenie zadania
            cts.Dispose(); // Zwolnij zasoby tokena
        }
    }
}
