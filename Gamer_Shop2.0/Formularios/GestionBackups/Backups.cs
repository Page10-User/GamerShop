using Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups;
using Gamer_Shop2._0.Formularios.GestionBackups.ClaseRestauraciones;
using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionBackups
{
    public partial class Backups : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        private bool iWasClick;
        private string nombreArchivo = "";

        public Backups()
        {
            InitializeComponent();

            cargarBackupsGuardados();

            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void cargarBackupsGuardados(){
            FLPSaveBackups.Controls.Clear();
            string rutaCarpetaBackups = @"C:\Backups";
            
            // Verificar si hay backups guardados
            if (Directory.Exists(rutaCarpetaBackups))
            {
                string[] archivosBak = Directory.GetFiles(rutaCarpetaBackups, "*.bak");
                if (archivosBak.Length > 0)
                {
                    LNoBackups.Visible = false;
                    FLPSaveBackups.Visible = true;

                    foreach (var archivo in archivosBak)
                    {
                        botonRestaurarBackup botonRes = new botonRestaurarBackup();

                        FileInfo Archivo = new FileInfo(archivo);

                        botonRes.Ruta = archivo.ToString();
                        botonRes.NombreBackup = Path.GetFileNameWithoutExtension(Archivo.Name);
                        botonRes.FechaBackup = Archivo.CreationTime.ToString("dd/MM/yyyy HH:mm:ss");

                        FLPSaveBackups.Controls.Add(botonRes);
                    }
                }
            }
        }

        private void PContInfBackups_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 5;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                path.CloseFigure();


                panel.Region = new Region(path);


                using (Pen pen = new Pen(Color.LightGreen, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void Backups_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            iWasClick = false;
        }

        private GraphicsPath CreateRoundedPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Agregar los arcos para las esquinas redondeadas
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(this.ClientSize.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
            path.AddArc(new Rectangle(this.ClientSize.Width - borderRadius, this.ClientSize.Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, this.ClientSize.Height - borderRadius, borderRadius, borderRadius), 90, 90);

            path.CloseFigure();

            return path;
        }

        private Region CreateRoundedRegion()
        {
            GraphicsPath path = CreateRoundedPath();
            return new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // dibujar el borde redondeado
            GraphicsPath path = CreateRoundedPath();
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.LightGreen, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BBackupCompleto_Click(object sender, EventArgs e)
        {
            MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea realizar un 'Backup Completo'?", "Backup Completo", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();
            if (result == DialogResult.Yes)
            {
                mensaje.Dispose(); // Cerramos el anterior mensaje que está en "Hide".
                BackupCompleto();
                cargarBackupsGuardados();
            }   
            else
            {
                mensaje.Dispose();
            }
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= Backups_Load;
            PContInfBackups.Paint -= PContInfBackups_Paint;
            BBackupCompleto.Click -= BBackupCompleto_Click;

            // Liberar los recursos
            base.Dispose();
        }
        private void BackupCompleto()
        {
            ClaseBackups.BackupCompleto.HacerBackup();
        }
    }
}
