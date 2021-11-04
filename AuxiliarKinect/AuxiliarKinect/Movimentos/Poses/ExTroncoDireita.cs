using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Poses
{
    public class ExTroncoDireita : Pose
    {
        public ExTroncoDireita()
        {
            this.Nome = "ExTroncoDireita";
            this.QuadroIdentificacao = 30;
        }

        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {
            
            Joint hipEsquerdo = esqueletoUsuario.Joints[JointType.HipLeft];
            Joint maoDireita = esqueletoUsuario.Joints[JointType.HandRight];
            Joint cotoveloDireito = esqueletoUsuario.Joints[JointType.ElbowRight];
            Joint maoEsquerda = esqueletoUsuario.Joints[JointType.HandLeft];
            Joint cotoveloEsquerdo = esqueletoUsuario.Joints[JointType.ElbowLeft];
            Joint cabeca = esqueletoUsuario.Joints[JointType.Head];
            double margemErro = 0.20;



            bool cotoveloEsquerdoDistanciaCorreta = Util.CompararComMargemErro(margemErro, cotoveloEsquerdo.Position.X, maoEsquerda.Position.X);
            bool cotoveloDireitoAlturaCorreta = Util.CompararComMargemErro(margemErro, cotoveloDireito.Position.Y, cabeca.Position.Y);
            bool maoEsquerdaNoQuadril = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.Y, hipEsquerdo.Position.Y);
            bool maoDireitaDistanciaCorreta = Util.CompararComMargemErro(margemErro, maoDireita.Position.Z, cabeca.Position.Z);
            bool maoDireitaAlturaCorreta = maoDireita.Position.Y > cabeca.Position.Y;
            bool maoDireitaAposCotovelo = maoDireita.Position.X > cotoveloEsquerdo.Position.X;


            return
                   cotoveloEsquerdoDistanciaCorreta &&
                   maoDireitaAlturaCorreta &&
                   maoDireitaDistanciaCorreta &&
                   maoDireitaAposCotovelo &&
                   maoEsquerdaNoQuadril &&
                   cotoveloDireitoAlturaCorreta;
        }



    }
}
