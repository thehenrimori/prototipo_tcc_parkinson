using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Poses
{
    public class ExMarcha : Pose
    {
        public ExMarcha()
        {
            this.Nome = "ExMarcha";
            this.QuadroIdentificacao = 60;
        }

        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {
            
            Joint maoDireita = esqueletoUsuario.Joints[JointType.HandRight];
            Joint joelhoDireito = esqueletoUsuario.Joints[JointType.KneeRight];
            Joint maoEsquerda = esqueletoUsuario.Joints[JointType.HandLeft];
            Joint joelhoEsquerdo = esqueletoUsuario.Joints[JointType.KneeLeft];
            Joint cabeca = esqueletoUsuario.Joints[JointType.Head];
            double margemErro = 0.15;



            bool joelhoDireitoDistanciaCorreta = Util.CompararComMargemErro(margemErro, joelhoDireito.Position.X, maoDireita.Position.X);
            bool joelhoDireitoAlturaCorreta = Util.CompararComMargemErro(margemErro, joelhoDireito.Position.Y, maoDireita.Position.Y);
            bool joelhoEsquerdoDistanciaCorreta = Util.CompararComMargemErro(margemErro, joelhoEsquerdo.Position.X, maoEsquerda.Position.X);
            bool joelhoEsquerdoAlturaCorreta = Util.CompararComMargemErro(margemErro, joelhoEsquerdo.Position.Y, maoEsquerda.Position.Y);

            bool maoEsquerdaDistanciaCorreta = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.X, cabeca.Position.X);
            bool maoDireitaDistanciaCorreta = Util.CompararComMargemErro(margemErro, maoDireita.Position.X, cabeca.Position.X);
        


            return
                   joelhoDireitoDistanciaCorreta &&
                   joelhoDireitoAlturaCorreta &&
                   maoEsquerdaDistanciaCorreta &&
                   joelhoEsquerdoDistanciaCorreta &&
                   maoDireitaDistanciaCorreta &&
                   joelhoEsquerdoAlturaCorreta;
        }

    }
}
