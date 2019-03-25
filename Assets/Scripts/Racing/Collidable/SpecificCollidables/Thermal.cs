using System.Collections;
using UnityEngine;

namespace Racing.Collidables {
	public class Thermal : Continuous {
		public override void applySpecificEffect(Glider glider) {
			boost(glider);
		}

		public void boost(Glider glider) {
			Rigidbody rb = glider.GetComponent<Rigidbody>();
			rb.velocity = rb.velocity + new Vector3(0, 1 * Time.deltaTime, 0);
		}
	}
}