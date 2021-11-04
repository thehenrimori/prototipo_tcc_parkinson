using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Gestos.ExPostura
{
    public class PosturaErrada3 : Pose
    {
        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {
            Joint maoDireita = esqueletoUsuario.Joints[JointType.HandRight];
            Joint shoulderDireito = esqueletoUsuario.Joints[JointType.ShoulderRight];
            Joint maoEsquerda = esqueletoUsuario.Joints[JointType.HandLeft];
            Joint shoulderEsquerda = esqueletoUsuario.Joints[JointType.ShoulderLeft];
            double margemErro = 0.10;


            bool maoEsquerdaAcimaDireita = maoEsquerda.Position.Y > maoDireita.Position.Y;
            bool maoEsquerdaAlturaOmbro = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.Y, shoulderDireito.Position.Y);
            bool maoDireitaEmbaixoOmbro = maoDireita.Position.Y < shoulderDireito.Position.Y;
            bool maoEsquerdaNoOmbro = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.X, shoulderEsquerda.Position.X);

            return maoEsquerdaAcimaDireita && maoEsquerdaAlturaOmbro && maoDireitaEmbaixoOmbro && maoEsquerdaNoOmbro;
        }
    }
}
