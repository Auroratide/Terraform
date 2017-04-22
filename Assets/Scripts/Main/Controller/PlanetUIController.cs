using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {

    [RequireComponent (typeof(CanvasSystem))]
    public class PlanetUIController : MonoBehaviour {

        private CanvasSystem canvas;

        public void Awake() {
            this.canvas = GetComponent<CanvasSystem>();
        }

        public void AddElements() {
            Debug.Log("Add Elements Button Clicked");
            canvas.RevealElementsUI();
        }

    }
}