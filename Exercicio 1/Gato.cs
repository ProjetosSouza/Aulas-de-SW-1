﻿namespace exercicio1;
class Gato:Animal
{
        public override string Fala()
    {
        return base.Fala() + "miau miau";
    }
}