using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {

    public class PlanetUIController : Controller {

        public void AddElements() {
            Debug.Log("Add Elements Button Clicked");
            canvas.RevealElementsUI();
        }

    }
}