using System;

namespace Auroratide.Terraform {
    public class AppliedElement {
        public IElement element;
        public int angle; // [0, 7]

        public AppliedElement(IElement element, int angle) {
            this.element = element;
            this.angle = angle;
        }
    }
}

