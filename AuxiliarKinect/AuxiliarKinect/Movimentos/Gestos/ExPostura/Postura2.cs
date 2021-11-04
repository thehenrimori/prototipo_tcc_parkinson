using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Gestos.ExPostura
{
    public class Postura2 : Pose
    {
        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {
            Joint maoDireita = esqueletoUsuario.Joints[JointType.HandRight];
            Joint shoulderDireito = esqueletoUsuario.Joints[JointType.ShoulderRight];
            Joint maoEsquerda = esqueletoUsuario.Joints[JointType.HandLeft];
            Joint shoulderEsquerda = esqueletoUsuario.Joints[JointType.ShoulderLeft];
            double margemErro = 0.20;


            bool maoDireitaAposOmbro = Util.CompararComMargemErro(margemErro, maoDireita.Position.X, shoulderDireito.Position.X);
            bool maoDireitaAcimaOmbro = Util.CompararComMargemErro(margemErro, maoDireita.Position.Y, shoulderDireito.Position.Y);
            bool maoEsquerdaAposOmbro = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.Y, shoulderEsquerda.Position.Y);
            bool maoEsquerdaAcimaOmbro = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.X, shoulderEsquerda.Position.X);

            return maoDireitaAposOmbro && maoDireitaAcimaOmbro && maoEsquerdaAposOmbro && maoEsquerdaAcimaOmbro;
        }
    }
}
