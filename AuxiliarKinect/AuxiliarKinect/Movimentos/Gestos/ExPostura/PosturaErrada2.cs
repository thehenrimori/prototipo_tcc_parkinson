using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Gestos.ExPostura
{
    public class PosturaErrada2 : Pose
    {
        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {

            Joint maoDireita = esqueletoUsuario.Joints[JointType.HandRight];
            Joint maoEsquerda = esqueletoUsuario.Joints[JointType.HandLeft];
            Joint cabeca = esqueletoUsuario.Joints[JointType.Head];
            Joint cotoveloDireito = esqueletoUsuario.Joints[JointType.ElbowRight];
            Joint cotoveloEsquerdo = esqueletoUsuario.Joints[JointType.ElbowLeft];
            double margemErro = 0.10;

            bool maoDireitaIgualCotovelo = Util.CompararComMargemErro(margemErro, maoDireita.Position.X, cotoveloDireito.Position.X);          
            bool maoDireitaAcimaEsquerda = maoDireita.Position.Y > maoEsquerda.Position.Y;            
            bool maoDireitaAcimaCabeca = maoDireita.Position.Y > cabeca.Position.Y;
            bool maoEsquerdaNaCabeca = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.Y, cabeca.Position.Y);
            bool maoDireitaAntesCabeca = maoDireita.Position.X > cabeca.Position.X;
            bool maoEsquerdaaAntesCabeca = maoEsquerda.Position.X < cabeca.Position.X;

            return maoDireitaIgualCotovelo && maoDireitaAcimaEsquerda && maoDireitaAcimaCabeca && maoEsquerdaNaCabeca && maoDireitaAntesCabeca && maoEsquerdaaAntesCabeca;
        }
    }
}