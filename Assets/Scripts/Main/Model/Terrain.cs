using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {
    public class Terrain {

        private Gradient<float> temperature;
        private Gradient<float> hydration;
        private Gradient<float> atmosphere;

        public Terrain() {
            this.temperature = new Gradient<float>();
        }

                                            //    [0, 7]
        public void Apply(IElement element, int aroundAngle) {
            temperature = Add(temperature, element.Temperature().RotateClockwise(aroundAngle));
        }

        public string ToString() {
            return temperature.ToString();
        }

        public static Gradient<float> Add(Gradient<float> lhs, Gradient<float> rhs) {
            Gradient<float> sum = new Gradient<float>();
            for(int i = 0; i < Gradient<float>.SIZE; ++i) {
                sum.Set(i, lhs.Get(i) + rhs.Get(i));
            }

            return sum;
        }

    }
}