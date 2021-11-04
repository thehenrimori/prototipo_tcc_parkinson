using AuxiliarKinect.FuncoesBasicas;
using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Poses
{
    public class ExTronco : Pose
    {
        public ExTronco()
        {
            this.Nome = "ExTronco";
            this.QuadroIdentificacao = 30;
        }

        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {
            Joint hipDireito = esqueletoUsuario.Joints[JointType.HipRight];
            Joint maoDireita = esqueletoUsuario.Joints[JointType.HandRight];
            Joint cotoveloDireito = esqueletoUsuario.Joints[JointType.ElbowRight];
            Joint maoEsquerda = esqueletoUsuario.Joints[JointType.HandLeft];
            Joint cotoveloEsquerdo = esqueletoUsuario.Joints[JointType.ElbowLeft];
            Joint cabeca = esqueletoUsuario.Joints[JointType.Head];
            double margemErro = 0.20;

           

            bool cotoveloDireitoDistanciaCorreta = Util.CompararComMargemErro(margemErro, cotoveloDireito.Position.X, maoDireita.Position.X);
            bool cotoveloEsquerdoAlturaCorreta = Util.CompararComMargemErro(margemErro, cotoveloEsquerdo.Position.Y, cabeca.Position.Y);
            bool maoDireitaNoQuadril = Util.CompararComMargemErro(margemErro, maoDireita.Position.Y, hipDireito.Position.Y);
            bool maoEsquerdaDistanciaCorreta = Util.CompararComMargemErro(margemErro, maoEsquerda.Position.Z, cabeca.Position.Z);
            bool maoEsquerdaAlturaCorreta = maoEsquerda.Position.Y > cabeca.Position.Y;
            bool maoEsquerdaAposCotovelo = maoEsquerda.Position.X > cotoveloEsquerdo.Position.X;
            

            return
                   cotoveloDireitoDistanciaCorreta &&
                   maoEsquerdaAlturaCorreta && 
                   maoEsquerdaDistanciaCorreta &&
                   maoEsquerdaAposCotovelo &&
                   maoDireitaNoQuadril &&
                   cotoveloEsquerdoAlturaCorreta;
        }



    }
}
