﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCocurrencia
{
    public partial class FrmBloqueos : Form
    {
        private int Contador = 0;
        private object Bloqueo = new();
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);
        public FrmBloqueos()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                Task.Run(() =>
                {
                    semaforo.Wait();

                    lock (Bloqueo)
                    {
                        Contador++;
                        Thread.Sleep(1000);

                        this.Invoke((MethodInvoker)delegate
                        {
                            LblContador.Text = Contador.ToString();
                        });
                        Monitor.Pulse(Bloqueo);
                    }
                    //semaforo.Release();
                });

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                {

                    Task.Run(() =>
                    {
                        lock (Bloqueo)
                        {
                            while (Contador <= 0)
                            {
                                ActualizarResultado("Esperando ....");
                                Monitor.Wait(Bloqueo);
                            }

                            if (Contador > 0)
                            {
                                Contador--;
                                Thread.Sleep(1000);

                                this.Invoke((MethodInvoker)delegate
                                {
                                    LblContador.Text = Contador.ToString();
                                });
                            }

                            ActualizarResultado("Pedido...");

                        }


                    });
                }
            }

        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

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

        private void FrmBloqueos_Load(object sender, EventArgs e)
        {

        }
    }
}