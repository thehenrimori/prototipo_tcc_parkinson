using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Gestos.ExPostura
{
    public class PosturaErrada1 : Pose
    {
        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {
            Joint maoDireita = esqueletoUsuario.Joints[JointType.HandRight];
            Joint shoulderDireito = esqueletoUsuario.Joints[JointType.ShoulderRight];
            Joint maoEsquerda = esqueletoUsuario.Joints[JointType.HandLeft];
            Joint shoulderEsquerda = esqueletoUsuario.Joints[JointType.ShoulderLeft];
            double margemErro = 0.10;


            bool maoDireitaAcimaEsquerda = maoDireita.Position.Y > maoEsquerda.Position.Y;
            bool maoDireitaAlturaOmbro = Util.CompararComMargemErro(margemErro, maoDireita.Position.Y, shoulderDireito.Position.Y);
            bool maoEsquerdaEmbaixoOmbro = maoEsquerda.Position.Y < shoulderEsquerda.Position.Y;
            bool maoDireitaNoOmbro = Util.CompararComMargemErro(margemErro, maoDireita.Position.X, shoulderDireito.Position.X);

            return maoDireitaAcimaEsquerda && maoDireitaAlturaOmbro && maoEsquerdaEmbaixoOmbro && maoDireitaNoOmbro;
        }
    }
}
