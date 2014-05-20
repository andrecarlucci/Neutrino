﻿using System;

namespace Neutrino.Core {
    public class Occurrence : IEquatable<Occurrence> {

        public DateTime DateTime { get; set; }
        public decimal? Value { get; set; }

        public bool Equals(Occurrence other) {
            return other.DateTime == DateTime && other.Value == Value;
        }
    }
}