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

        private void PContRestaurar_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 20;
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
            PContRestaurar.SendToBack();
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
            ClaseBackups.BackupCompleto.HacerBackup();
        }
        private void BackupPersonalizado(bool BCompra, bool BProducto, bool BProveedor, bool BUsuario, bool BVenta, bool BCliente)
        {
            //Backup Personalizado Gestion Compra
            if (BCompra == true)
            {
                BackupCompras.ExportarComprasACSV(null);
            }
            //Backup Personalizado Gestion Producto
            if (BProducto == true)
            {
                BackupProductos.ExportarProductosACSV(null);
            }
            //Backup Personalizado Gestion Proveedor
            if (BProveedor == true)
            {
                BackupProveedores.ExportarProveedoresACSV(null);
            }
            //Backup Personalizado Gestion Usuario
            if (BUsuario == true)
            {
                BackupUsuarios.ExportarUsuariosACSV(null);
            }
            //Backup Personalizado Gestion Venta
            if (BVenta == true)
            {
                BackupVentas.ExportarVentasACSV(null);
            }
            //Backup Personalizado Gestion Cliente
            if (BCliente == true)
            {
                BackupClientes.ExportarClientesACSV(null);
            }
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            CerrarOAbrirPanelRestaurar();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            CerrarOAbrirPanelRestaurar();
        }

        private void CerrarOAbrirPanelRestaurar()
        {
            if (!iWasClick)
            {
                PContRestaurar.Visible = true;
                PContRestaurar.BringToFront();
                iWasClick = true;
            }
            else
            {
                PContRestaurar.Visible = false;
                PContRestaurar.SendToBack();
                iWasClick = false;
            }
        }

        private void BRestaurarBk_Click(object sender, EventArgs e)
        {
            if (TBDireccionBak.Texts != string.Empty && nombreArchivo != string.Empty)
            {
                if (nombreArchivo.Contains("BackupCompleto"))
                {
                    RestauracionCompleta.HacerRestauracion(TBDireccionBak.Texts);
                }
                else
                {
                    RestauracionParcial(nombreArchivo);
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Por favor seleccione un CSV para restaurar", "Error", "Error", null);
                mensaje.ShowDialog();
            }
        }

        private void RestauracionParcial(string nombreArchivo)
        {
            if (nombreArchivo.Contains("Clientes"))
            {
                RestauracionClientes.RestaurarClientesDesdeCSV(TBDireccionBak.Texts);
            }
            if (nombreArchivo.Contains("Compras"))
            {
                //Aún no implementado
            }
            if (nombreArchivo.Contains("Productos"))
            {
                //Aún no implementado
            }
            if (nombreArchivo.Contains("Proveedores"))
            {
                RestauracionProveedores.RestaurarProveedoresDesdeCSV(TBDireccionBak.Texts);
            }
            if (nombreArchivo.Contains("Usuarios"))
            {
                //Aún no implementado
            }
            if (nombreArchivo.Contains("Ventas"))
            {
                //Aún no implementado
            }
        }

        private void BCSVSearch_Click(object sender, EventArgs e)
        {
            string rutaCarpetaBackupsClientes = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados"));

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = rutaCarpetaBackupsClientes;
            openFileDialog.Filter = "Archivos de Backup (*.bak)|*.bak";
            openFileDialog.Title = "Seleccione un archivo de backup CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                TBDireccionBak.Texts = sourceFilePath;

                nombreArchivo = Path.GetFileNameWithoutExtension(sourceFilePath);
            }
        }
    }
}
