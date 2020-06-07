﻿using System;

namespace Aula_10__Polimorfismo
{
    public class Mario : Player
    {
	//Coloque override e o mesmo nome do método na classe pai nos métodos que você quer sobrescrever.

        override public void Correr() {
            Console.WriteLine("Correndo um pouco mais rápido...");
        }

        override public void Pular() {
            base.Pular();
            Console.WriteLine("O Mário pula normalmente.");
        }
    }
}