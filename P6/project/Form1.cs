using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace project
{
    public partial class Hilos : Form
    {
        public Hilos()
        {
            InitializeComponent();
        }

        private int cont = 0, tpCont = 0;

        private Thread HiloA;
        private ManualResetEvent PararHiloA;
        private ManualResetEvent HiloParadoA;
        private Thread HiloB;
        private ManualResetEvent PararHiloB;
        private ManualResetEvent HiloParadoB;

        private delegate void SetValueDelegate(int prValue);
        private delegate void SetEnableDelegate(bool Enabled);

        private void SetEnable_bt_Iniciar(bool enable)
        {
            if (bt_Iniciar.InvokeRequired)
            {
                SetEnableDelegate delegado = SetEnable_bt_Iniciar;
                bt_Iniciar.Invoke(delegado, new object[] { enable });
            }
            else
                bt_Iniciar.Enabled = enable;
        }

        private void SetEnable_numericUpDown(bool enable)
        {
            if (numericUpDown.InvokeRequired)
            {
                SetEnableDelegate delegado = SetEnable_numericUpDown;
                numericUpDown.Invoke(delegado, new object[] { enable });
            }
            else
                numericUpDown.Enabled = enable;
        }

        private void SetValue_progressBar(int cont)
        {
            if (progressBar.InvokeRequired)
            {
                SetValueDelegate delegado = SetValue_progressBar;
                progressBar.Invoke(delegado, new object[] { cont });
            }
            else
                progressBar.Value = cont;
        }

        private void ArchivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_MostrarOcultar_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = !pictureBox.Visible;
            bt_MostrarOcultar.Text = pictureBox.Visible ? "Ocultar Imagen" : "Mostrar Imagen";
        }

        private void bt_Iniciar_Click(object sender, EventArgs e)
        {
            bt_Iniciar.Enabled = false;
            numericUpDown.Enabled = false;
            progressBar.Value = 0;
            cont = 0; tpCont = 0;
            //Creamos los controladores  para PararHiloA e HiloParadoA
            PararHiloA = new ManualResetEvent(false);
            HiloParadoA = new ManualResetEvent(false);
            PararHiloB = new ManualResetEvent(false);
            HiloParadoB = new ManualResetEvent(false);
            ThreadStart delegado = new ThreadStart(RellenarBarraHiloA);
            HiloA = new Thread(delegado);
            HiloA.Start();
            delegado = RellenarBarraHiloB;
            HiloB = new Thread(delegado);
            HiloB.Start();
        }

        private void RellenarBarra()
        {
            cont += 1;
            tpCont = (int)(cont / numericUpDown.Value * 100);
            if (tpCont > progressBar.Value)
            {
                SetValue_progressBar(tpCont);
                Console.WriteLine(tpCont.ToString());
            }
        }

        private void RellenarBarraHiloA()
        {
            while (cont < numericUpDown.Value)
            {
                lock (progressBar) { RellenarBarra(); }
                if (PararHiloA.WaitOne(0, false))
                {
                    HiloParadoA.Set();
                    return;
                }
            }
            SetEnable_bt_Iniciar(true);
            SetEnable_numericUpDown(true);
        }

        private void RellenarBarraHiloB()
        {
            while (cont < numericUpDown.Value)
            {
                lock (progressBar) { RellenarBarra(); }
                if (PararHiloB.WaitOne(0, false))
                {
                    HiloParadoB.Set();
                    return;
                }
            }
            SetEnable_bt_Iniciar(true);
            SetEnable_numericUpDown(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PararHilo_A();
            PararHilo_B();
            SetEnable_bt_Iniciar(true);
            SetEnable_numericUpDown(true);
        }

        private bool PararHilo_A()
        {
            if (HiloA != null && HiloA.IsAlive)
            {
                PararHiloA.Set();
                while (HiloA.IsAlive)
                {
                    WaitHandle.WaitAll((new ManualResetEvent[] { HiloParadoA }), 100, false);
                    Application.DoEvents();
                }
                HiloA = null;
                MessageBox.Show("Hilo A parado", "Hilo Parado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }

        private bool PararHilo_B()
        {
            if (HiloB != null && HiloB.IsAlive)
            {
                PararHiloB.Set();
                while (HiloB.IsAlive)
                {
                    WaitHandle.WaitAll((new ManualResetEvent[] { HiloParadoB }), 100, false);
                    Application.DoEvents();
                }
                HiloB = null;
                MessageBox.Show("Hilo B parado", "Hilo Parado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();
            ayuda.ShowDialog();
        }

        private void ArchivoDetener_Click(object sender, EventArgs e)
        {
            PararHilo_A();
            PararHilo_B();
            SetEnable_bt_Iniciar(true);
            SetEnable_numericUpDown(true);
        }
        /*
         ////////////////////////////////////P5//////////////////////////////////////////////////////////
private void ImagenAñadirTexto_Click(object sender, EventArgs e)
{using (Graphics gfx = Graphics.FormImage(this.PictureBox.Image)){
 gfx.DrawString("Programación Visual", new Font("Arial", 20)), Brushes.Blue, 0f
 PictureBox.Refresh();
}

private void ArchivoAbrir_Click(object sender, EventArgs e)
{OpenFileDialog dlg = new OpenFileDialog();
 dlg.Title = "Selecione un archivo de imagen a abrir";
 dlg.InitialDirectory = Directory.GetCurrentDirectory();
 dlg.Filter = 
 dlg.FilterIndex = 3;
 dlg.CheckFileExist = true;

 if (dlg.ShowDialog() != DialogResult.OK) return;
 AbrirArchivo(dlg.FileName);
}

private void AbrirArchivo(string file)
{byte[] contenidoArchivo = File.ReadAllBytes(file);
 /////
 MemoryStream flujo = new MemoryStream(contenidoArchivo)
 
}

private void ActualizarMenús(){
  this.ArchivoCerrar.Enabled = this.HijoActiva != null;
  this.VentanaCascada.Enabled = this.HijaActiva != null;
  this.VentanaMosaicoHorizontal.Enable = this.HijaActiva != null;
  this.VentanaMosaicoVertical.Enable = this.HijaActiva != null;

private void verToolStripMenuItem_DropDownOpened(object sender, EventArgs e){
  VerMostrarBarraDeEstado.Checked = statusStrip1.Visible;
  this.VerMostrarBarraDeHerramientas.Checked = toolStrip1.Visible;}

private void VerMostrarBarraDeEstado_Click(object sender, EventArgs e){
  statusStrip1.Visible = !VerMostrarBarraDeEstado.Checked;

private void VerMostrarBarraDeHerramientas_Click(object sender, EventArgs e){
  toolStrip1.Visible = !this.VerMostrarBarraDeHerramientas.Checked;

private void añadirTextoToolStripMenuItem_Click(object sender, EventAtgs e){
  using (Graphics gfx = Graphics.ForImage(this.PictureBox.Image)) {
    gfx.DrawString("Programación Visual", new Font("Arial", 20), Brushes.Blue, 0f, 0f);

Liberar los recursos no administrados de gfx.
Se invoca al método Dispose de Graphics.

private void VisorImágenes_MdiChildActivate(object sender, EventArgs e)
{
   ActualizarMenús();
   ToolStripManager.RevertMerge(this.barraHerramientas);
   VentanaHija ventanaHijaActiva = this.ActiveMdiChild as VentanaHija;
   if (ventanaHijaActiva != null)
   { ToolStripManager.Merge(ventanaHijaActiva.barraHerramientas, this.barraHerramientas);
     ventanaHijaActiva.ActualizarMenuAjustar();}
}
    
////////////////////////////////////P6//////////////////////////////////////////////////////////
private void PararHiloA()
{
   if (m_HiloA != null && m_HiloA.IsAlive)
   {
	//Activamos el evento para decirle que el hilo pare
	m_PararHiloA.Set();
	//Esperar a que el hilo haya terminado
	while(m_HiloA.IsAlive)
	{
	   m_ParadoHiloA.WaitOne(200,false);   //evitar una espera activa
	   Application.DoEvents();	       //procesar eventos pendientes
	}
   }
}

private void menuArchivoDetener_Click(object sender, EventArgs e)
{
  PararHiloA();
  PararHiloB();
  m_PararHiloA.Reset();
  m_ParadoHiloA.Reset();
  m_PararHiloB.Reset();
  m_ParadoHiloB.Reset();
  MessageBox.Show("Hilos Parados");
  ActualizarBotonIniciar();
  ActualizarCtVelocidad();
}

private void ActualizarBotonIniciar()
{
  if (bt_Iniciar.InvokeRequired)
  {
    MethodInvoker delegado = new MethodInvoker(ActualizarBotonIniciar);
    bt_Iniciar.BeginInvoker(delegado);
  }
  else
    bt_Inicar.Enabled = true;
}

private void bt_Mostrar_Click(object sender, EventArgs e)
{
  pb_Imagen.Visible = !pb_Imagen.Visible;
  if(pb_Imagen.Visible)
    bt_Mostrar.Text = "Ocultar Imagen";
  else
    bt_Mostrar.Text = "Mostrar Imagen";
}

private void ActualizarB()
{
  while(m_indice <= bp_Progreso.Maximum){
     if(this.m_PararHiloB.WaitOne(0, false)){
        m_ParadoHiloB.Set();
        break;)
     lock(bp_Progreso){
        Progresar();}}
}

/////////////////////////////////////////////////////////////////////////////////////////////////
>contenedor MDI
  prop. ref a matriz de form MDI hijos-MdiChildren
  evento se genera cuando se activa una ventana hija MDI-MdiChildActivate
  prop deter. si el form es un contenedor MDI-IsMdiContainer
  prop ref a la ventana hija MDI activa-ActiveMdiChild

>como un hilo puede conocer el estado de un controlador de espera
 Invocando al método WaitOne, WaitAny, WaitAll

>relación
  Devuelve un obj Image desde un fichero-FromFile
  Rotar una imagen-RotateFlip
  Clase Graphics-Superficie de dibujo
  Save/FromImage/RotateFlip-método de Image
  Clase Image-Trabajar con mapas de bits
  Guardar un obj Image en un fichero-Save

>relación
  Thread-Hilo //declarar el hilo
  Mutex/Semaphore/Monitor-Sincronizar hilos
  ThreadStart-Referencia al método que ejecuta el hilo

>ralación
  Controlador del evento DoWork-Método que ejecuta el hilo
  RunWorkerAsync-Inicia la ejecución del hilo
  ReportProgress-Genera el evento ProgressChanged
  RunWorkerCompleted-Evento generado cuando el hilo finaliza
  BackgroundWorker-Hilo asíncrono

>app con una interfaz gráfica de usuario (IGU)
  El hilo principal de la aplicación gestiona los eventos procedentes de la IGU
  Los hilos secundarios se encargan de realizar otras tareas ajenas a la gestión de la IGU
  Hay un hilo principal y cero o más hilo secundarios.

>para una ventana MDI
  ManiMenuStrip-tiene que hacer referencia a la barra de menus
  AllowMerge-tiene que valer true
  ShowInTaskbar-no es necesaria para que pueda ejecutarse la aplicación
  MdiWindowListItem-de su barra de menús tiene que hacer referencia a un menú Ventana
  IsMDIContainer-tiene que valer true
  MDIIsContainer-no existe

>el controlador sig tiene como finalidad fusionar las barras de herr. padre e hija
cada vez que se activa una ventana hija de la clase FormHijo
private void FormPadre_MdiChildActivate(object sender, EventArgs e)
{ToolStripManager.RevertMerge(thislbarraHerramientasPadre);
 // FormHijo ventanaHijaActiva = this.ActivateMdiChild as FormHijo;
 if (ventanaHijaActiva != null) ToolStripManager.Merge(ventajaHijaActiva.barraHerramientasHija, this.barraHerramientas);
}
  
>{
   private Thread hiloSecundario;
   public Form1() { InitializeComponent(); }
   private voidTareaSecundaria() {
     int hecho = 0, tpHecho = 0;
     while (hecho < numCargaUCP.Value){hecho += 1; tpHecho = (int)(hecho/numCargaUCP.Value*100);
        if(tpHecho > bpProgreso.Value) bpProgreso.Value = tpHecho;}
   }
   private void btCalcular_Click(object sender, EventArgs e)
   {ThreadStart delegadoPS = new ThreadStart(TareaSecundaria);
    hiloSecundario = new Thread(delegadoPS);
    hiloSecundario.Start();}}

   resp: El código tiene un problema en la línea 16

>relación
  DrawString-método de Graphics
  DrawImage-método de Graphics
  Dibujar texto-DrawString
  Clase Graphics-superficie de dibujo
  Clase Image-trabajar con mapas de bits
  ColorMatrix-objeto que define una transformación de color
  Dibujar todo o parte de un Image-DrawImage
  Transformación de color-ColorMatrix

>completar método que crea una ventana hija (formMDI)
private void NuevaHija(string titulo){
   VentanaHija hija = new VentanaHija(titulo);
   hija.MdiParent = this;
   hija.AutoScroll = true;
   hija.Show();}
         */
    }
}
