using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliarKinect.Movimentos.Gestos.ExPostura
{
    public class ExPosturaErradaEsquerda : Gesto
    {
        public ExPosturaErradaEsquerda()
        {
            InicializaQuadrosChave();

            Nome = "ExPosturaErrada";
            ContadorQuadros = 0;
            QuadroChaveAtual = QuadrosChave.First;
        }

        private void InicializaQuadrosChave()
        {
            QuadrosChave = new LinkedList<GestoQuadroChave>();
            QuadrosChave.AddFirst(new GestoQuadroChave(new Postura1(), 0, 0));
            QuadrosChave.AddLast(new GestoQuadroChave(new PosturaErrada1(), 1, 25));
            QuadrosChave.AddLast(new GestoQuadroChave(new PosturaErrada2(), 1, 25));
            QuadrosChave.AddLast(new GestoQuadroChave(new PosturaErrada2(), 50, 70));

        }

        protected override bool PosicaoValida(Skeleton esqueletoUsuario)
        {
            EstadoRastreamento estado = QuadroChaveAtual.Value.PoseChave.Rastrear(esqueletoUsuario);
            return estado == EstadoRastreamento.Identificado;
        }
    }
}