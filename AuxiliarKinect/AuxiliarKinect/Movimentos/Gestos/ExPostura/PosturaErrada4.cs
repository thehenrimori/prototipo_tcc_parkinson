using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Gestos.ExPostura
{
    public class PosturaErrada4 : Pose
    {
        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {

            Joint maoDireita = esqueletoUsuario.Joints[JointType.HandRight];
            Joint maoEsquerda = esqueletoUsuario.Joints[JointType.HandLeft];
            Joint cabeca = esqueletoUsuario.Joints[JointType.Head];
            Joint cotoveloDireito = esqueletoUsuario.Joints[JointType.ElbowRight];
            Joint cotoveloEsquerdo = esqueletoUsuario.Joints[JointType.ElbowLeft];
            double margemErro = 0.10;

            bool maoEsquerdaIgualCotovelo = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.X, cotoveloEsquerdo.Position.X);
            bool maoEsquerdaAcimaDireita = maoEsquerda.Position.Y > maoDireita.Position.Y;
            bool maoEsquerdaAcimaCabeca = maoEsquerda.Position.Y > cabeca.Position.Y;
            bool maoDireitaNaCabeca = Util.CompararComMargemErro(margemErro, maoDireita.Position.Y, cabeca.Position.Y);
            bool maoDireitaAntesCabeca = maoDireita.Position.X > cabeca.Position.X;
            bool maoEsquerdaaAntesCabeca = maoEsquerda.Position.X < cabeca.Position.X;

            return maoEsquerdaIgualCotovelo && maoEsquerdaAcimaDireita && maoEsquerdaAcimaCabeca && maoDireitaNaCabeca && maoDireitaAntesCabeca && maoEsquerdaaAntesCabeca;
        }
    }
}