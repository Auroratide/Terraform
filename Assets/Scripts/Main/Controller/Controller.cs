using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {

    [RequireComponent (typeof(CanvasSystem))]
    abstract public class Controller : MonoBehaviour {

        protected CanvasSystem canvas;

        public virtual void Awake() {
            this.canvas = GetComponent<CanvasSystem>();
        }

    }
}