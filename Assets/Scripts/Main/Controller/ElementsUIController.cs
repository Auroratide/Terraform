using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {

    public class ElementsUIController : Controller {

        public void AddElement(string element) {
            Debug.Log("Adding " + element);
            canvas.HideElementsUI();
            canvas.UnfadePlanet();
        }

    }
}