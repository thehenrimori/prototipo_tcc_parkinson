   M S B A M L   `   `   `  ����   EsqueletoUsuario!    EsqueletoUsuario.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     h dMicrosoft.Kinect.Toolkit.Controls, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [Microsoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e352k(http://schemas.microsoft.com/kinect/2013     � Title$  
MainWindow��$	��550��$	��800��.���  � ColumnDefinitions �� $��* ��� $��25 � � RowDefinitions �� $��50 ��� $
��240* ��� $��50 �.+��� -   $��canvasKinect��$��1���� $��2�� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ chkEx2��$��Exercicio Marcha��$
��Left=�$��
10,10,0,10q��� -   $ chkEx1��$��Exercício para o tronco��$
��Left=�$��
10,10,0,10q��� -   $ chkEx3��$��Exercicio Postura��$
��Left=�$��10,10,50,10q��� -    ��Name$ btn_Instrucao��$)��#INSTRUÇÕES DOS 
      EXERCÍCIOS��$	��212��$��Segoe UI Symbol)�$��14(����	#FF569B47 J� OpacityMask �	#FF0D6431
���   �$��Italic$�$
��Bold"�$��Right=�$��0,0,0,10q�4  .Microsoft.Kinect.Toolkit.KinectSensorChooserUI  -   $��sensorChooserUi��$��Center=�$	��Top=�$��390,0,337,0q��� -   $��slider��$��20�� �� Orientation$ Vertical=� � Minimum$	 -27Q�	 � Maximum$	 27Q�
 � SmallChange$
 1Q� � Value$ 0Q�$��1��$��1��$��3,0,2,0q�����  �� ElementName$ imagemCamera�� �� Path$ ActualHeight�