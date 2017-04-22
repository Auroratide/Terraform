using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {

    public class ElementsUIController : Controller {

        [SerializeField] private Config config;

        public void AddElement(string element) {
            Debug.Log("Adding " + element);
            canvas.HideElementsUI();
            canvas.UnfadePlanet();
            canvas.UnfadeQuadrantsUI();
            config.quadrantsUIController.SetElement(ElementFactory.Create(element));
        }

        [System.Serializable] public class Config {
            public QuadrantsUIController quadrantsUIController;
        }

    }
}