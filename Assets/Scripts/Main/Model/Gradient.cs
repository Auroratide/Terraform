using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {
    public class Gradient<T> {

        public const int SIZE = 8;

        private T[] values;

        public Gradient() {
            this.values = new T[SIZE];
        }

        public T Get(int n) {
            return values[index(n)];
        }

        public void Set(int n, T value) {
            values[index(n)] = value;
        }

        public Gradient<T> RotateClockwise(int angle) {
            Gradient<T> gradient = new Gradient<T>();
            for(int i = 0; i < SIZE; ++i) 
                gradient.values[index(i)] = this.values[index(i - angle)];
            return gradient;
        }

        private int index(int n) {
            return (n % SIZE + SIZE) % SIZE;
        }

        public string ToString() {
            string s = "";
            for(int i = 0; i < SIZE; ++i)
                s += values[i].ToString() + ", ";

            return s;
        }

    }
}