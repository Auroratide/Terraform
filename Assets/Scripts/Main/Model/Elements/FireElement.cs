using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {
   
    public class FireElement : IElement {

        public Gradient<float> Temperature() {
            Gradient<float> gradient = new Gradient<float>();
            gradient.Set(-1, 5);
            gradient.Set(0, 10);
            gradient.Set(1, 5);

            return gradient;
        }

    }

}