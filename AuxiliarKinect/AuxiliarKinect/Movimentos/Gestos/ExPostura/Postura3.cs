using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Gestos.ExPostura
{
    public class Postura3 : Pose
    {
        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {
            
            Joint maoDireita = esqueletoUsuario.Joints[JointType.HandRight];
            Joint maoEsquerda = esqueletoUsuario.Joints[JointType.HandLeft];
            Joint cabeca = esqueletoUsuario.Joints[JointType.Head];
            Joint cotoveloDireito = esqueletoUsuario.Joints[JointType.ElbowRight];
            Joint cotoveloEsquerdo = esqueletoUsuario.Joints[JointType.ElbowLeft];
            double margemErro = 0.20;

            bool maoDireitaIgualCotovelo = Util.CompararComMargemErro(margemErro, maoDireita.Position.X, cotoveloDireito.Position.X);
            bool maoEsquerdaIgualCotovelo = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.X, cotoveloEsquerdo.Position.X);
            bool maoDireitaIgualEsquerda  = Util.CompararComMargemErro(margemErro, maoDireita.Position.Y, maoEsquerda.Position.Y);
            bool maoDireitaAntesCabeca = maoDireita.Position.X > cabeca.Position.X;
            bool maoDireitaAcimaCabeca = maoDireita.Position.Y > cabeca.Position.Y;
            bool maoEsquerdaaAntesCabeca = maoEsquerda.Position.X < cabeca.Position.X;
            bool maoEsquerdaAcimaCabeca = maoEsquerda.Position.Y > cabeca.Position.Y;

            return maoDireitaAntesCabeca && maoDireitaAcimaCabeca && maoEsquerdaaAntesCabeca && maoEsquerdaAcimaCabeca && maoDireitaIgualEsquerda &&
                maoEsquerdaIgualCotovelo && maoDireitaIgualCotovelo;
        }
    }
}
