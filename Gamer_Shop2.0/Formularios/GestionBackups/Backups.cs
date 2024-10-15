using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionBackups
{
    public partial class Backups : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Backups()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(Backups_Load);
            PContInfBackups.Paint += new PaintEventHandler(PContInfBackups_Paint);
        }

        private void PContInfBackups_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 60;
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
                mensaje.Close(); // Cerramos el anterior mensaje que está en "Hide".
                mensaje = new MsgPersonalizado("'Backup Completo' realizado con éxito!", "Backup Exitoso", "Informacion", null);
                mensaje.ShowDialog();
            }   
            else
            {
                mensaje.Close();
            }
        }

        private void BBackupPersonalizado_Click(object sender, EventArgs e)
        {
            if (CBGestionCompra.Checked || CBGestionProducto.Checked || CBGestionProveedor.Checked || CBGestionUsuario.Checked || CBGestionVenta.Checked)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea realizar un 'Backup Personalizado'?", "Backup Personalizado", "Interrogacion", null);
                DialogResult result = mensaje.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    mensaje.Close();
                    mensaje = new MsgPersonalizado("'Backup Personalizado' realizado con éxito!", "Backup Personalizado", "Informacion", null);
                    mensaje.ShowDialog();
                }
                else
                {
                    mensaje.Close();
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Seleccione una opción para Backup Personalizado por favor", "Error", "Error",null);
                mensaje.ShowDialog();
            }
        }
    }
}
