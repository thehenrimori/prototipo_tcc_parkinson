using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Gestos.ExPostura
{
    public class Postura1 : Pose
    {
        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {
            Joint maoDireita = esqueletoUsuario.Joints[JointType.HandRight];
            Joint hipDireito = esqueletoUsuario.Joints[JointType.HipRight];
            Joint maoEsquerda = esqueletoUsuario.Joints[JointType.HandLeft];
            Joint hipEsquerdo = esqueletoUsuario.Joints[JointType.HipLeft];
            double margemErro = 0.20;

            bool maoDireitaAntesQuadril = Util.CompararComMargemErro(margemErro, maoDireita.Position.X, hipDireito.Position.X);
            bool maoDireitaSobreQuadril = Util.CompararComMargemErro(margemErro, maoDireita.Position.Y, hipDireito.Position.Y);
            bool maoesquerdaAntesQuadril = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.X, hipEsquerdo.Position.X);
            bool maoEsquerdaSobreQuadril = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.Y, hipEsquerdo.Position.Y);

            return maoDireitaAntesQuadril && maoDireitaSobreQuadril && maoesquerdaAntesQuadril && maoEsquerdaSobreQuadril;
        }
    }
}
