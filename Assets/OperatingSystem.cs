using UnityEngine;
using System.Collections;

namespace Doors94
{
	[AddComponentMenu("Doors94/MainSystems/OperatingSystem")]
	public class OperatingSystem : MonoBehaviour
	{
		internal static OperatingSystem _Instance;

		void Start()
		{
			_Instance = this;
		}

		void Update()
		{

		}
	}
}
