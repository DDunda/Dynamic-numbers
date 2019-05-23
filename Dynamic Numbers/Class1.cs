using System;
using System.Collections.Generic;

namespace Dynamic_Numbers {
	public sealed class DInt {
		public bool negative = false;
		public int size { get { return this.parts.Count; } }
		public List<ulong> parts = new List<ulong>();
		public DInt() { }
		public DInt(ulong number, bool negative = false) {
			this.parts.Add(number);
			this.negative = negative;
		}
		public DInt(ulong[] numbers, bool negative = false) {
			this.parts = new List<ulong>(numbers);
			this.negative = negative;
		}
		public override string ToString() {
			return base.ToString();
		}
		public static DInt operator +(DInt a, DInt b) {
			int maxIndex = a.parts.Count > b.parts.Count ? a.parts.Count : b.parts.Count;
			int minIndex = a.parts.Count < b.parts.Count ? a.parts.Count : b.parts.Count;
			bool carry = false;
			List<ulong> n = new List<ulong>(maxIndex);
			uint i = 0;
			while (i < minIndex) {

			}
			return new DInt(n.ToArray());
		}

		public static DInt operator -(DInt a) {
			a.negative = !a.negative;
			return a;
		}

		public static DInt operator -(DInt a, long b) {
			a.Validate();
			if (b < 0)
				return a + (-b);
			long tmpNum = a.parts[0];
			if (tmpNum - b > tmpNum) {

			}
		}

		public static DInt operator +(DInt a, long b) {
			if (b == 0) return a;
			if (a == 0) return new DInt(b);
			if (a.negative && b < 0)
				if (b < 0) return a - (-b);
			ulong tmpNum = a.parts[0];
			if (tmpNum + b > tmpNum) {

			}
		}

		public void Validate() {
			for (int i = this.parts.Count - 1; i >= 0; i--) {
				if (this.parts[i] != 0) return;
				this.parts.RemoveAt(i);
			}
		}

		public static bool operator ==(DInt a, long b) {
			a.Validate();
			if
		}

		public ulong this[int index] {
			get { return this.parts[index]; }
			set { this.parts[index] = value; }
		}
	}
}