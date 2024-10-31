using Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
                mensaje.Dispose(); // Cerramos el anterior mensaje que está en "Hide".
                BackupCompleto();
                mensaje = new MsgPersonalizado("'Backup Completo' realizado con éxito!", "Backup Exitoso", "Informacion", null);
                mensaje.ShowDialog();
            }   
            else
            {
                mensaje.Dispose();
            }
        }

        private void BBackupPersonalizado_Click(object sender, EventArgs e)
        {
            if (CBGestionCompra.Checked || CBGestionProducto.Checked || CBGestionProveedor.Checked || CBGestionUsuario.Checked || CBGestionVenta.Checked || CBGestionCliente.Checked)
            {
                if (CBGestionCompra.Checked && CBGestionProducto.Checked && CBGestionProveedor.Checked && CBGestionUsuario.Checked && CBGestionVenta.Checked && CBGestionCliente.Checked)
                {
                    this.BBackupCompleto_Click(sender, e);
                }
                else
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea realizar un 'Backup Personalizado'?", "Backup Personalizado", "Interrogacion", null);
                    DialogResult result = mensaje.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        mensaje.Dispose();
                        BackupPersonalizado(CBGestionCompra.Checked, CBGestionProducto.Checked, CBGestionProveedor.Checked, CBGestionUsuario.Checked, CBGestionVenta.Checked, CBGestionCliente.Checked);
                        mensaje = new MsgPersonalizado("'Backup Personalizado' realizado con éxito!", "Backup Personalizado", "Informacion", null);
                        mensaje.ShowDialog();
                    }
                    else
                    {
                        mensaje.Dispose();
                    }
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Seleccione una opción para Backup Personalizado por favor", "Error", "Error",null);
                mensaje.ShowDialog();
            }
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= Backups_Load;
            PContInfBackups.Paint -= PContInfBackups_Paint;
            BBackupCompleto.Click -= BBackupCompleto_Click;
            BBackupPersonalizado.Click -= BBackupPersonalizado_Click;

            // Liberar los recursos
            base.Dispose();
        }
        private void BackupCompleto()
        {
            ClaseBackups.BackupCompleto.ExporteCompletoACSV();
        }
        private void BackupPersonalizado(bool BCompra, bool BProducto, bool BProveedor, bool BUsuario, bool BVenta, bool BCliente)
        {
            //Backup Personalizado Gestion Compra
            if (BCompra == true)
            {
                BackupCompras.ExportarComprasACSV();
            }
            //Backup Personalizado Gestion Producto
            if (BProducto == true)
            {
                BackupProductos.ExportarProductosACSV();
            }
            //Backup Personalizado Gestion Proveedor
            if (BProveedor == true)
            {
                BackupProveedores.ExportarProveedoresACSV();
            }
            //Backup Personalizado Gestion Usuario
            if (BUsuario == true)
            {
                BackupUsuarios.ExportarUsuariosACSV();
            }
            //Backup Personalizado Gestion Venta
            if (BVenta == true)
            {
                BackupVentas.ExportarVentasACSV();
            }
            //Backup Personalizado Gestion Cliente
            if (BCliente == true)
            {
                BackupClientes.ExportarClientesACSV();
            }
        }
    }
}
