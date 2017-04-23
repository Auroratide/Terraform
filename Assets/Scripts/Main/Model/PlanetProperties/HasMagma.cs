using System;
using UnityEngine;
using UnityEngine.UI;

namespace Auroratide.Terraform {
    public class HasMagma : IPlanetProperty {

        private int octant;

        public HasMagma(int octant) {
            this.octant = octant;
        }

        public void Render(Image image) {
            image.sprite = Resources.LoadAll<Sprite>("magma_sheet_1")[octant];
        }

    }
}

