namespace DemoCocurrencia
{
    public partial class FrmConcurrencia : Form
    {
        private CancellationTokenSource _cts;
        public FrmConcurrencia()
        {
            InitializeComponent();
        }

        private void BtnSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("Iniciando Proceso Secuencial...");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                ActualizarResultado($" Actividad - paso {i + 1}");
            }
            ActualizarResultado("�Fin del  Proceso Secuencial.");
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");
        }

        private void BtnIniciarHilo_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Thread hilo1 = new Thread(() =>
            {
                try
                {
                    ActualizarResultado($"Iniciar nuevo threado {Thread.CurrentThread.ManagedThreadId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(2000);
                        ActualizarResultado($"Actividad en hilo {Thread.CurrentThread.ManagedThreadId} - paso{i + 1}");
                    }

                    ActualizarResultado($"Thread {Thread.CurrentThread.ManagedThreadId}  terminado.");


                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Hilo cancelado.");
                }
            });
            hilo1.Start();

        }
        private async void BtnIniciarTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(() =>
         {
             try
             {
                 ActualizarResultado($"Iniciando Task {Task.CurrentId}...");
                 for (int i = 0; i < 5; i++)
                 {
                     token.ThrowIfCancellationRequested();

                     Thread.Sleep(2000);
                     ActualizarResultado($"Actividad  en Tarea {Task.CurrentId} - paso{i + 1}");
                 }
                 ActualizarResultado($"Task {Task.CurrentId} completada .");
             }
             catch (OperationCanceledException)
             {

                 ActualizarResultado("Tarea Cancelada");
             }

         });



        }

        private void BtnCancelarhilo_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        private void FrmConcurrencia_Load(object sender, EventArgs e)
        {

        }
    }
}
