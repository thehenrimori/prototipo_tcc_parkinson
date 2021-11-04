using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect.Toolkit.Controls;
using EsqueletoUsuario.Auxiliar;
using AuxiliarKinect.Movimentos.Poses;
using AuxiliarKinect.Movimentos;
using AuxiliarKinect.Movimentos.Gestos;
using AuxiliarKinect.Movimentos.Gestos.ExPostura;

namespace EsqueletoUsuario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contador = 0;
        int contador2 = 0;
        int contador3 = 0;
        int quantidade_movimento_tronco = 0;
        int quantidade_movimento_postura = 0;
        int quantidade_movimento_marcha = 0;
        KinectSensor kinect;
        List<IRastreador> rastreadores;

        public MainWindow()
        {
            InitializeComponent();
            InicializarSeletor();
            InicializarRastreadores();
        }

        private void InicializarSeletor()
        {
            InicializadorKinect inicializador = new InicializadorKinect();
            inicializador.MetodoInicializadorKinect = InicializarKinect;
            sensorChooserUi.KinectSensorChooser = inicializador.SeletorKinect;
        }

        private void InicializarKinect(KinectSensor kinectSensor)
        {
            kinect = kinectSensor;
            slider.Value = kinect.ElevationAngle;

            kinect.DepthStream.Enable();
            kinect.SkeletonStream.Enable();
            kinect.ColorStream.Enable();
            kinect.AllFramesReady += kinect_AllFramesReady;
        }

        private void InicializarRastreadores()
        {
            rastreadores = new List<IRastreador>();

            Rastreador<ExTronco> rastreadorExTronco = new Rastreador<ExTronco>();
            rastreadorExTronco.MovimentoIdentificado += ExTroncoIdentificado;
            rastreadorExTronco.MovimentoEmProgresso += ExTroncoEmProgresso;

            Rastreador<ExTroncoDireita> rastreadorExTroncoDireita = new Rastreador<ExTroncoDireita>();
            rastreadorExTroncoDireita.MovimentoIdentificado += ExTroncoDireitaIdentificado;
            rastreadorExTroncoDireita.MovimentoEmProgresso += ExTroncoDireitaEmProgresso;

            Rastreador<ExMarcha> rastreadorExMarcha = new Rastreador<ExMarcha>();
            rastreadorExMarcha.MovimentoIdentificado += ExMarchaIdentificada;
            rastreadorExMarcha.MovimentoEmProgresso += ExMarchaEmProgresso;

            Rastreador<ExPostura> rastreadorExPostura = new Rastreador<ExPostura>();
            rastreadorExPostura.MovimentoIdentificado += ExPosturaIndentificada;

            Rastreador<ExPosturaErradaEsquerda> rastreadorExPosturaErradaEsquerda = new Rastreador<ExPosturaErradaEsquerda>();
            rastreadorExPosturaErradaEsquerda.MovimentoIdentificado += ExPosturaErradaEsquerdaIndentificada;

            Rastreador<ExPosturaErradaDireita> rastreadorExPosturaErradaDireita = new Rastreador<ExPosturaErradaDireita>();
            rastreadorExPosturaErradaDireita.MovimentoIdentificado += ExPosturaErradaDireitaIndentificada;

            rastreadores.Add(rastreadorExTronco);
            rastreadores.Add(rastreadorExTroncoDireita);
            rastreadores.Add(rastreadorExMarcha);
            rastreadores.Add(rastreadorExPostura);
            rastreadores.Add(rastreadorExPosturaErradaEsquerda);
            rastreadores.Add(rastreadorExPosturaErradaDireita);
        }


        private void ExPosturaIndentificada(object sender, EventArgs e)
        {
            
            contador2++;
            if (contador2 <= 1)
            {
                quantidade_movimento_postura +=  1;
                MessageBox.Show("EXERCÍCIO FEITO CORRETAMENTE " + quantidade_movimento_postura + " VEZES, RESPIRE FUNDO E" +
                    " VOLTE A POSIÇÃO INICIAL");

            }
            contador2 -= 1;
        }


        private void ExPosturaErradaEsquerdaIndentificada(object sender, EventArgs e)
        {
            contador2++;
            if (contador2 <= 1)
            {
                MessageBox.Show("EXERCÍCIO FEITO DE FORMA INCORRETA, ARRUME A POSIÇÃO DOS SEU BRAÇO ESQUERDO E TENTE NOVAMENTE, LEIA AS INSTRUÇÕES");
            }
            contador2 -= 1;

        }

        private void ExPosturaErradaDireitaIndentificada(object sender, EventArgs e)
        {
            contador2++;
            
            if (contador2 <= 1)
            {
                MessageBox.Show("EXERCÍCIO FEITO DE FORMA INCORRETA, ARRUME A POSIÇÃO DOS SEU BRAÇO DIREITO E TENTE NOVAMENTE, LEIA AS INSTRUÇÕES");
            }
            contador2 -= 1;

        }


        private void ExMarchaEmProgresso(object sender, EventArgs e)
        {
            ExMarcha pose = sender as ExMarcha;

            Rectangle retangulo = new Rectangle();
            retangulo.Width = canvasKinect.ActualWidth;
            retangulo.Height = 20;
            retangulo.Fill = Brushes.Black;

            Rectangle poseRetangulo = new Rectangle();
            poseRetangulo.Width = canvasKinect.ActualWidth * pose.PercentualProgresso / 100;
            poseRetangulo.Height = 20;
            poseRetangulo.Fill = Brushes.BlueViolet;

            canvasKinect.Children.Add(retangulo);
            canvasKinect.Children.Add(poseRetangulo);
        }

        private void ExTroncoEmProgresso(object sender, EventArgs e)
        {
            ExTronco pose = sender as ExTronco;

            Rectangle retangulo = new Rectangle();
            retangulo.Width = canvasKinect.ActualWidth;
            retangulo.Height = 20;
            retangulo.Fill = Brushes.Black;

            Rectangle poseRetangulo = new Rectangle();
            poseRetangulo.Width = canvasKinect.ActualWidth * pose.PercentualProgresso / 100;
            poseRetangulo.Height = 20;
            poseRetangulo.Fill = Brushes.BlueViolet;

            canvasKinect.Children.Add(retangulo);
            canvasKinect.Children.Add(poseRetangulo);
        }

        private void ExTroncoDireitaEmProgresso(object sender, EventArgs e)
        {
            ExTroncoDireita pose = sender as ExTroncoDireita;

            Rectangle retangulo = new Rectangle();
            retangulo.Width = canvasKinect.ActualWidth;
            retangulo.Height = 20;
            retangulo.Fill = Brushes.Black;

            Rectangle poseRetangulo = new Rectangle();
            poseRetangulo.Width = canvasKinect.ActualWidth * pose.PercentualProgresso / 100;
            poseRetangulo.Height = 20;
            poseRetangulo.Fill = Brushes.BlueViolet;

            canvasKinect.Children.Add(retangulo);
            canvasKinect.Children.Add(poseRetangulo);
        }
        private void ExMarchaIdentificada(object sender, EventArgs e)
        {
            
            contador3++;
            
            if (contador3 <= 1)
            {
                quantidade_movimento_marcha += 1;
                MessageBox.Show("EXERCÍCIO FEITO CORRETAMENTE " + quantidade_movimento_marcha + " VEZES, DESLIZE LENTAMENTE AS MÃOS ATÉ CHEGAR NOS PÉS E" +
                    " EM SEGUIDA ESTIQUE AS PERNAS PARA VOLTAR A POSIÇÃO INICIAL");

            }
            contador3 -= 1;
            
        }

        private void ExTroncoIdentificado(object sender, EventArgs e)
        {
            contador++;
            
            if (contador <= 1)
            {
                quantidade_movimento_tronco += 1;
                MessageBox.Show("EXERCÍCIO FEITO CORRETAMENTE " + quantidade_movimento_tronco + " VEZES, REALIZE CINCO RESPIRAÇÕES PROFUNDAS," +
                " VOLTE A POSIÇÃO INICIAL E REALIZE O EXERCÍCIO PARA O LADO DIREITO!");
              
            }
            contador-= 1;
        }

        private void ExTroncoDireitaIdentificado(object sender, EventArgs e)
        {
            contador++;
            
            if (contador <= 1)
            {
                quantidade_movimento_tronco += 1;
                MessageBox.Show("EXERCÍCIO FEITO CORRETAMENTE " + quantidade_movimento_tronco + " VEZES, REALIZE CINCO RESPIRAÇÕES PROFUNDAS," +
                " VOLTE A POSIÇÃO INICIAL E REALIZE O EXERCÍCIO PARA A ESQUERDA CASO NÃO TENHA FEITO!");
                

            }
            contador -= 1;
        }

        private void kinect_AllFramesReady(object sender, AllFramesReadyEventArgs e)
        {
            byte[] imagem = ObterImagemSensorRGB(e.OpenColorImageFrame());

            if (imagem != null)
                canvasKinect.Background = new ImageBrush(BitmapSource.Create(kinect.ColorStream.FrameWidth, kinect.ColorStream.FrameHeight,
                                    96, 96, PixelFormats.Bgr32, null, imagem,
                                    kinect.ColorStream.FrameWidth * kinect.ColorStream.FrameBytesPerPixel));

            canvasKinect.Children.Clear();

            FuncoesEsqueletoUsuario(e.OpenSkeletonFrame());

        }

        private void FuncoesEsqueletoUsuario(SkeletonFrame quadro)
        {
            if (quadro == null) return;

            using (quadro)
            {
                Skeleton esqueletoUsuario = quadro.ObterEsqueletoUsuario();
                foreach (IRastreador rastreador in rastreadores)
                    rastreador.Rastrear(esqueletoUsuario);

                if (chkEx4.IsChecked.HasValue && chkEx4.IsChecked.Value)
                    quadro.DesenharEsqueletoUsuario(kinect, canvasKinect);
            }
        }

        private byte[] ObterImagemSensorRGB(ColorImageFrame quadro)
        {
            if (quadro == null) return null;

            using (quadro)
            {
                byte[] bytesImagem = new byte[quadro.PixelDataLength];
                quadro.CopyPixelDataTo(bytesImagem);

                return bytesImagem;
            }
        }

        private void ReconhecerDistancia(DepthImageFrame quadro, byte[] bytesImagem, int distanciaMaxima)
        {
            if (quadro == null || bytesImagem == null) return;

            using (quadro)
            {
                DepthImagePixel[] imagemProfundidade = new DepthImagePixel[quadro.PixelDataLength];
                quadro.CopyDepthImagePixelDataTo(imagemProfundidade);

                DepthImagePoint[] pontosImagemProfundidade = new DepthImagePoint[640 * 480];
                kinect.CoordinateMapper.MapColorFrameToDepthFrame(kinect.ColorStream.Format, kinect.DepthStream.Format, imagemProfundidade, pontosImagemProfundidade);

                for (int i = 0; i < pontosImagemProfundidade.Length; i++)
                {
                    var point = pontosImagemProfundidade[i];
                    if (point.Depth < distanciaMaxima && KinectSensor.IsKnownPoint(point))
                    {
                        var pixelDataIndex = i * 4;

                        byte maiorValorCor = Math.Max(bytesImagem[pixelDataIndex], Math.Max(bytesImagem[pixelDataIndex + 1], bytesImagem[pixelDataIndex + 2]));

                        bytesImagem[pixelDataIndex] = maiorValorCor;
                        bytesImagem[pixelDataIndex + 1] = maiorValorCor;
                        bytesImagem[pixelDataIndex + 2] = maiorValorCor;
                    }
                }
            }
        }



        private void slider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            kinect.ElevationAngle = Convert.ToInt32(slider.Value);
        }

        private void chkEsqueleto_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void chkEsqueletoM_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frm_Instrucao frm = new Frm_Instrucao();
            frm.Show();
        }

        private void chkEx2_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
